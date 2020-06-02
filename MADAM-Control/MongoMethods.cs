using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using MADAM_Control.Classes;
using System.Xml.Serialization;
using System.IO;

namespace MADAM_Control
{
    class MongoMethods
    {
        public void GetAll()
        {
            MongoClient client = getClient();
            var database =  client.GetDatabase("MADAM");
        }

        public void connect()
        {
            MongoClient client = getClient();
            var dbList = client.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

        public MongoClient getClient()
        {
            try
            {
                Settings settings;
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                XmlSerializer mySerializer = new XmlSerializer(typeof(Settings));
                FileStream myFileStream = new FileStream(savePath + "\\MADAMControl\\Settings.XML", FileMode.Open);

                settings = (Settings)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
                var dbip = settings.dbip;
                var client = new MongoClient("mongodb://" + dbip + ":27017");
                var database = client.GetDatabase("madam");
                return client;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
