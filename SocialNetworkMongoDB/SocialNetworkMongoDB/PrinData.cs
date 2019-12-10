using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkMongoDB.Models
{
    class PrinData 
    {
        private readonly MongoCRUD _db;

        //public void PrintPostById(int id)
        //{
        //    //var recs = db.LoadRecords<Post>("Post");


        //}

        public PrinData(MongoCRUD db)
        {
            _db = db;
        }

        public void getUserName(string userId)
        {
            var rec = _db.LoadRecordById<User>("User", new string(userId));

            Console.WriteLine(rec.Name);
        }

        public void getFeed(string userId)
        {
            //var rec = _db.LoadRecordById<Feed>("Feed",new string("userId"));

            //var name = _db.LoadRecordById<User>("User", new string(rec.UserId));

            //string name1 = name.Name;

            //Console.WriteLine(name1);

            var rec = _db.LoadRecordById<Feed>("Feed",new string("userId"));

        }
    }
}
