using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MoviesApis.Models
{
    public class WatchingList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public float SeekPosition { get; set; }
        public float Duration { get; set; }
        public int SeasonId { get; set; }
        public int SeriesId { get; set; }
        public Video Video { get; set; }
        public Series Series { get; set; }
        public Season Season { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }

    }
}
