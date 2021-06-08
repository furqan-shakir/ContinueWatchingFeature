using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Season> Seasons { get; } = new List<Season>();
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
