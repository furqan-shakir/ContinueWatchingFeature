using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public List<WatchingList> WatchHistory { get; } = new List<WatchingList>();
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
