using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Models.Forms
{
    public class WatchVideoForm
    {
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public float Seek { get; set; }
        public float Duration { get; set; }
        public int SeasonId { get; set; }
        public int SeriesId { get; set; }
        public VideoType Type { get; set; }


    }
}
