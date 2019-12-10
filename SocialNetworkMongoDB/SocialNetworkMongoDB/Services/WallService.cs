using MongoDB.Driver;
using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Services
{
    public class WallService
    {
        private readonly IMongoCollection<Wall> _walls;

        public List<Wall> ListWalls()
        {
            return _walls.Find(wall => true).ToList();
        }

        public Wall GetWallFromUserId(string id)
        {
            return _walls.Find(wall => wall.UserId == id).FirstOrDefault();
        }
    }
}
