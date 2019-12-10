using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Models
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
    }
}
