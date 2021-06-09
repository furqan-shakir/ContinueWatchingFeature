using MoviesApis.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using MoviesApis.Helpers;

namespace MoviesApis.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<WatchingList> _watchingList;

        public MovieService(IMoviesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _watchingList = database.GetCollection<WatchingList>(settings.MoviesCollectionName);
        }

        public List<WatchingList> Get() =>
            _watchingList.Find(record => true).ToList();

        public WatchingList Get(string id) =>
            _watchingList.Find<WatchingList>(record => record.Id == id).FirstOrDefault();

        public WatchingList GetByUserAndMoviePin(int userId, int videoId) =>
           _watchingList.Find<WatchingList>(record => record.User.Id == userId && record.Video.Id == videoId).FirstOrDefault();

        public int CountWatchedSeriesItems(int seriesId) =>
          (int)_watchingList.Find<WatchingList>(record => record.Series.Id == seriesId).CountDocuments();

        public void RemoveSeries(int seriesId) =>
        _watchingList.DeleteMany<WatchingList>(record => record.Series.Id == seriesId);

        public WatchingList Create(WatchingList record)
        {
            _watchingList.InsertOne(record);
            return record;
        }

        public void Update(string id, WatchingList recordIn) =>
            _watchingList.ReplaceOne(record => record.Id == id, recordIn);

        public void Remove(WatchingList recordIn) =>
            _watchingList.DeleteOne(record => record.Id == recordIn.Id);

        public void Remove(string id) =>
            _watchingList.DeleteOne(record => record.Id == id);
    }
}
