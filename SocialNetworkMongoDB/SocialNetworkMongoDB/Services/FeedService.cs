using MongoDB.Driver;
using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Services
{
    public class FeedService
    {
        private readonly IMongoCollection<Feed> _feeds;


        public Feed GetFeed(string id)
        {
            return _feeds.Find(feed => feed.Id == id).FirstOrDefault();
        }

        public Feed GetFeedFromUserId(string id)
        {
            return _feeds.Find(feed => feed.UserId == id).FirstOrDefault();
        }
    }
}
