using MongoDB.Driver;
using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Services
{
    public class PostService
    {
        private readonly IMongoCollection<Post> _posts;

        public List<Post> GetListofPosts()
        {
            return _posts.Find(post => true).ToList();
        }

        public Post GetPostById(string id)
        {
            return _posts.Find(post => post.Id == id).FirstOrDefault();
        }

        public Post CreatePost(Post post)
        {
            _posts.InsertOne(post);
            return post;
        }
    }
}
