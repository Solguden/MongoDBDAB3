using SocialNetworkMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB
{
    public class Seeding
    {
        public void SeedData(MongoCRUD db)
        {

            //Data seeding

            #region Users
           


            User user1 = new User
            {
                Name = "Jobs Jobsemand",
                Age = 26,
                
                Gender = "Male"
            };
            db.InsertRecord("User", user1);

            User user2 = new User
            {
                Name = "Henrik Dabsemand",
                Age = 99,

                Gender = "Male"
            };
            db.InsertRecord("User", user2);

            User user3 = new User
            {
                Name = "Muubs Muubsemand",
                Age = 23,

                Gender = "Male"
            };
            db.InsertRecord("User", user3);

            User user4 = new User
            {
                Name = "Flops Flopsemand",
                Age = 25,

                Gender = "Male"
            };
            db.InsertRecord("User", user4);

            User user5 = new User
            {
                Name = "Jeps Jepsemand",
                Age = 23,
              
                Gender = "Male"
            };
            db.InsertRecord("User", user5);

            User user6 = new User
            {
                Name = "Hvem Hvemsemand",
                Age = 69,
               
                Gender = "Male"
            };
            db.InsertRecord("User", user6);
            #endregion

            #region Circles

            Circle circle1 = new Circle
            {
                CircleName = "League Lovers",

                Users = new List<string>
                {
                    user1.Id,
                    user3.Id,
                    user5.Id
                }

            };
            db.InsertRecord("Cirlce", circle1);

            Circle circle2 = new Circle
            {
                CircleName = "CS:GO GODS",

                Users = new List<string>
                {
                    user1.Id,
                    user2.Id,
                    user4.Id
                }

            };
            db.InsertRecord("Cirlce", circle2);

            Circle circle3 = new Circle
            {
                CircleName = "For os der hader videospil",

                Users = new List<string>
                {
                    user6.Id 
                }

            };
            db.InsertRecord("Cirlce", circle3);

            //Adding circle to users lists
            user1.Circles = new List<String>
            {
                circle1.Id,
                circle2.Id
            };

            user3.Circles = new List<String>
            {
                circle1.Id
            };

            user5.Circles = new List<String>
            {
                circle1.Id
            };

            user2.Circles = new List<String>
            {
                circle2.Id
            };

            user4.Circles = new List<String>
            {
                circle2.Id
            };

            user6.Circles = new List<String>
            {
                circle3.Id
            };

            #endregion

            #region Feed
            Feed feed1 = new Feed
            {
                UserId = user1.Id,
            };
            db.InsertRecord("Feed", feed1);

            Feed feed2 = new Feed
            {
                UserId = user2.Id,
            };
            db.InsertRecord("Feed", feed2);

            Feed feed3 = new Feed
            {
                UserId = user3.Id,
            };
            db.InsertRecord("Feed", feed3);

            Feed feed4 = new Feed
            {
                UserId = user4.Id,
            };
            db.InsertRecord("Feed", feed4);

            Feed feed5 = new Feed
            {
                UserId = user5.Id,
            };
            db.InsertRecord("Feed", feed5);

            Feed feed6 = new Feed
            {
                UserId = user6.Id,
            };
            db.InsertRecord("Feed", feed6);


            #endregion


            #region Posts
            Poll poll1 = new Poll
            {
                Question = "Hvilket spil er bedst League eller CS?",
                Answer1 = "League",
                Answer2 = "CS",
                Answer3 = "Det ved jeg ikke"
            };
            db.InsertRecord("Poll", poll1);
            Poll poll2 = new Poll
            {
                Question = "Hvilket spil er bedst League eller CS?",
                Answer1 = "League",
                Answer2 = "CS",
                Answer3 = "Det ved jeg ikke"
            };
            db.InsertRecord("Poll", poll2);

            Post post1 = new Post
            {
                PostDate = new DateTime(2019,12,01),
                UserId = user1.Id,
                CircleId = circle1.Id,
                PollId = poll1.Id
            };
            db.InsertRecord("Post", post1);

            Post post11 = new Post
            {
                PostDate = new DateTime(2019, 12, 01),
                UserId = user1.Id,
                CircleId = circle2.Id,
                PollId = poll2.Id
            };
            db.InsertRecord("Post", post11);

            Post post6 = new Post
            {
                PostDate = new DateTime(2019, 12, 06),
                text = "Forever alone :(",
                UserId = user6.Id,
                CircleId = circle3.Id
            };

            Post post2 = new Post
            {
                PostDate = new DateTime(2019, 12, 02),
                UserId = user3.Id,
                CircleId = circle1.Id,
                text = "League er nice"
            };
            db.InsertRecord("Post", post2);

            Post post3 = new Post
            {
                PostDate = new DateTime(2019, 12, 03),
                UserId = user2.Id,
                CircleId = circle2.Id,
                text = "CS er nice"
            };
            db.InsertRecord("Post", post3);

            #endregion

            #region Wall
            Wall wall1 = new Wall
            {
                UserId = user1.Id,
                Posts = new List<Post>
                {
                    post1, post11
                }
            };

            Wall wall2 = new Wall
            {
                UserId = user2.Id,
                Posts = new List<Post>
                {
                    post2, post11
                }
            };

            Wall wall3 = new Wall
            {
                UserId = user3.Id,
                Posts = new List<Post>
                {
                    post1, post11
                }
            };
            #endregion

            #region Comments
            Comment comment1 = new Comment
            {
                CommentDate = new DateTime(2019, 12, 03),
                PostId = post2.PostId,
                UserId = user4.Id,
                CommentText = "Leage er mega nice"
            };
            db.InsertRecord("Comment", comment1);
            Comment comment2 = new Comment
            {
                CommentDate = new DateTime(2019, 12, 04),
                PostId = post2.PostId,
                UserId = user1.Id,
                CommentText = "Elsker League"
            };
            db.InsertRecord("Comment", comment2);

            Comment comment3 = new Comment
            {
                CommentDate = new DateTime(2019, 12, 03),
                PostId = post3.PostId,
                UserId = user4.Id,
                CommentText = "Cs er mega nice"
            };
            db.InsertRecord("Comment", comment3);
            Comment comment4 = new Comment
            {
                CommentDate = new DateTime(2019, 12, 04),
                PostId = post3.PostId,
                UserId = user1.Id,
                CommentText = "Elsker Cs"
            };
            db.InsertRecord("Comment", comment4);

            #endregion
        }
    }
}
