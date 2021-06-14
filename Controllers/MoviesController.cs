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
        public ActionResult<WatchingList> WatchVideo(int movieId, WatchingList item)
        {
            // validations first 
            //....

            // Workflow
            // See if the video is already exist in the watching list
            var watchingItem = _movieService.GetByUserAndMoviePin(item.User.Id, item.Video.Id);
            switch (item.Video.Type)
            {
                case Models.VideoType.Movie:
                    var percentage = (item.SeekPosition / item.Video.Duration) * 100;
                    if (watchingItem != null)
                    {
                        // Remove the video from the watching list it's crossed 90% of the duration
                        if (percentage > 90)
                        {
                            _movieService.Remove(watchingItem);
                        }
                        else // Otherwise, just update the seek position
                        {
                            watchingItem.SeekPosition = item.SeekPosition;
                            _movieService.Update(watchingItem.Id, watchingItem);
                        }
                    }
                    else // add the record to the watching list if it's not completed already! the movie will not be registered in the continue watching list if the end-user completed it.
                    {
                        if (percentage <= 90)
                        {
                            _movieService.Create(item);
                        }
                    }
                    break;
                case Models.VideoType.Series:
                    
                    if (watchingItem != null) // just update the seek position
                    {
                        watchingItem.SeekPosition = item.SeekPosition;
                        _movieService.Update(item.Id, item);
                    } else
                    {
                        watchingItem = _movieService.Create(item);
                    }
                    // Remove the series if all the eposides for all the seasons have been watched.
                    var totalEposidesNumber = _dbContext.Seasons.Where(s => s.SeriesId == watchingItem.Series.Id).Sum(s => s.EposidesNumber);
                    var seriesWatchedItemsNumber = _movieService.CountWatchedSeriesItems(watchingItem.Series.Id);
                    if (totalEposidesNumber == seriesWatchedItemsNumber)
                    {
                        _movieService.RemoveSeries(watchingItem.Series.Id);
                    }
                    break;
                default: break;
            }
            return NoContent();
        }

    }
}
