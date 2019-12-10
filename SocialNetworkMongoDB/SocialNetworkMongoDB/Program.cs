using SocialNetworkMongoDB.Models;
using System;

namespace SocialNetworkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("SocialNetworkMongoDB");
            Seeding seed = new Seeding();
            seed.SeedData(db);
            PrinData print = new PrinData(db);
            
            print.getUserName("5ded6c141520b80b80ea793c");

                                                                        

            //string value = "0";

            //while (true)
            //{
            //    switch (value)
            //    {
            //        case "0":
            //            Console.WriteLine("Log in as: ");
            //            Console.WriteLine("1. Jeppe");
            //            Console.WriteLine("2. Jacob");
            //            Console.WriteLine("3. Andreas");
            //            value = Console.ReadLine();
            //            break;
            //        case "1":
            //            Console.WriteLine("Logged in as Jeppe.");
            //            value = "0";
            //            break;
            //        case "2":
            //            Console.WriteLine("Logged in as Jacob.");
            //            value = "0";
            //            break;
            //        case "3":
            //            Console.WriteLine("Logged in as Andreas.");
            //            value = "0";
            //            break;
            //        case "4":
            //            Console.WriteLine("See post: ");

            //            break;
            //        default:
            //            break;
            //    }

            //}




        }
    }
}
