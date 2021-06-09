using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApis.DBContexts;
using MoviesApis.Services;
using MoviesApis.Models;
using MoviesApis.Models.Forms;
using System.Linq;

namespace MoviesApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;
        private readonly MySqlDbContext _dbContext;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger, MovieService movieService, MySqlDbContext dbContext)
        {
            _logger = logger;
            _movieService = movieService;
            _dbContext = dbContext;
        }
        [HttpPut]
        public ActionResult<WatchingList> Create(int movieId, WatchingList item)
        {
            // See if the video is already exist in the watching list
            var watchingItem = _movieService.GetByUserAndMoviePin(item.User.Id, item.Video.Id);
            if (watchingItem != null)
            {
                var percentage = (item.SeekPosition / watchingItem.Video.Duration) * 100;
                switch (watchingItem.Video.Type)
                {
                    case Models.VideoType.Movie:
                        // Remove the video from the watching list it's crossed 90% of the duration
                        if (percentage > 90 )
                        {
                            _movieService.Remove(watchingItem);
                        }
                        else // Otherwise, just update the seek position
                        {
                            _movieService.Update(watchingItem.Id, item);
                        }
                     break;
                    case Models.VideoType.Series:
                        // Remove the series if all the eposides for all the seasons have been watched.
                        var totalEposidesNumber = _dbContext.Seasons.Where(s => s.SeriesId == watchingItem.Series.Id).Sum(s => s.EposidesNumber);
                        var seriesWatchedItemsNumber = _movieService.CountWatchedSeriesItems(watchingItem.Series.Id);
                        if(totalEposidesNumber == seriesWatchedItemsNumber)
                        {
                            _movieService.RemoveSeries(watchingItem.Series.Id);
                        }
                        else // Otherwise, just update the seek position
                        {
                            item.Id = watchingItem.Id;
                            _movieService.Update(item.Id, item);
                        }
                        break;
                    default:
                       
                     break;

                }
            }
            else // add the record to the watching list if it's not completed already!
            {
                var video = _dbContext.Videos.Where(v => v.Id == item.Video.Id).SingleOrDefault();
                var percentage = (item.SeekPosition / video.Duration) * 100;
                if (percentage <= 90)
                {
                    _movieService.Create(item);
                }
            }
            return NoContent();
        }

    }
}
