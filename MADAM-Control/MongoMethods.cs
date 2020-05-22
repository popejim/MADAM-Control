using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;

namespace MADAM_Control
{
    class MongoMethods
    {

        MongoClient dbClient = new MongoClient("string here");


        public void GetAll()
        {
            var database =  dbClient.GetDatabase("MADAM");
        }

        public void connect()
        {
            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
    }
}
