using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeriesId { get; set; }
        public List<Video> Episodes { get; } = new List<Video>();
        public Series Series { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
