using MongoDB.Driver;
using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public List<User> GetListAllUsers()
        {
            return _users.Find(user => true).ToList();
        }

        public User GetUser(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public User CreateUser(User user)
        {
            _users.InsertOne(user);
            return user;
        }

    }
}
