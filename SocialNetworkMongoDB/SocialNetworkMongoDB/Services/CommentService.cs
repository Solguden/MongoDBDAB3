using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetworkMongoDB.Models;

namespace SocialNetworkMongoDB.Services
{
    public class CommentService
    {
        private readonly IMongoCollection<Comment> _comments;

        public List<Comment> ListComments()
        {
            return _comments.Find(comment => true).ToList();
        }

        public Comment GetCommentFromId(string id)
        {
            return _comments.Find(comment => comment.CommentId == id).FirstOrDefault();
        }

        public Comment NewComment(Comment comment)
        {
            _comments.InsertOne(comment);
            return comment;
        }
    }
}
