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
        [HttpPost]
        public ActionResult<WatchingList> Create(WatchingList item)
        {
            // See if the video is already exist in the watching list
            var watchingItem = _movieService.GetByUserAndMoviePin(item.UserId, item.VideoId);
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
                        var totalEposidesNumber = _dbContext.Seasons.Where(s => s.SeriesId == watchingItem.SeriesId).Sum(s => s.EposidesNumber);
                        var seriesWatchedItemsNumber = _movieService.CountWatchedSeriesItems(watchingItem.SeriesId);
                        if(totalEposidesNumber == seriesWatchedItemsNumber)
                        {
                            _movieService.RemoveSeries(watchingItem.SeriesId);
                        }
                        else // Otherwise, just update the seek position
                        {
                            _movieService.Update(watchingItem.Id, item);
                        }
                        break;
                    default:
                       
                     break;

                }
            }
            else // add the record to the watching list
            {
                _movieService.Create(item);
            }
            //WatchingList item = new WatchingList();
            //Video video = new Video();
            //video.Id = form.VideoId;
            //video.Duration = form.Duration;

            //item.VideoId = form.VideoId;
            //item.SeasonId = form.SeasonId;
            //item.SeekPosition = form.Seek;
            //item.UserId = form.UserId;
            //item.SeriesId = form.SeriesId;
            //item.Duration = form.Duration;
            //item.Video = video;
            //item.CreationDateTime = System.DateTime.UtcNow;
            //_movieService.Create(item);

            return CreatedAtRoute("GetMovie", new { id = item.Id.ToString() }, item);
        }

    }
}
