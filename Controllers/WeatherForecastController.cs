using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApis.DBContexts;
using MoviesApis.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MySqlDbContext _dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MySqlDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        //// PUT: api/TodoItems/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Watch(WatchVideoForm form)
        //{
        //    // See if the video is already exist in the watching list
        //    var watchEntry = _dbContext.WatchLists.Where(item => item.UserId == form.UserId && item.VideoId == form.VideoId).SingleOrDefault();
        //    if(watchEntry != null)
        //    {
        //        // Remove the video from the watching list it's crossed 90% of the duration
        //        var percentage = (form.Seek / watchEntry.Video.Duration) *100;
        //        if (percentage > 90 && watchEntry.Video.Type == Models.VideoType.Movie){
        //            _dbContext.WatchLists.Remove(watchEntry);
        //        }
        //    }
        //}

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
