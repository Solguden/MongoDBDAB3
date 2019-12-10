using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PostId { get; set; }
        public string text { get; set; }
        public string PollId { get; set; }
        public DateTime PostDate { get; set; }
        public List<Comment> Comments { get; set;  }
        public string UserId { get; set; }
        public string CircleId { get; set; }

    }
}
