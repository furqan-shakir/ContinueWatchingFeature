using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApis.Helpers
{
    // The preceding MoviesDatabaseSettings class is used to store the appsettings.json file's
    // MoviesDatabaseSettings property values.
    // The JSON and C# property names are named identically to ease the mapping process.
    public class MoviesDatabaseSettings : IMoviesDatabaseSettings
    {
        public string MoviesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMoviesDatabaseSettings
    {
        string MoviesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
