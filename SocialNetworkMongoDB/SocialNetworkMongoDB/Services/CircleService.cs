using MongoDB.Driver;
using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Services
{
    public class CircleService
    {
        private IMongoCollection<Circle> _circles;

        public Circle getCircle(string id)
        {
            return _circles.Find(circle => circle.Id == id).FirstOrDefault();
        }


    }
}
