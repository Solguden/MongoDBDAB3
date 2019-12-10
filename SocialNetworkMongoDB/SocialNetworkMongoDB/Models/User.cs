using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public List<string> Friends = new List<string>();
        public List<string> Circles = new List<string>();
        public List<string> Blocked = new List<string>();
    }
}
