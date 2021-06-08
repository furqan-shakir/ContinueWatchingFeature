using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Models
{
    public class Video
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public float Duration { get; set; }

        public int SeasonId { get; set; }

        public VideoType Type { get; set; }

        public string StoragePath { get; set; }
        public Season Season { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
    public enum VideoType
    {
        Movie = 1,
        Series
    }
}
