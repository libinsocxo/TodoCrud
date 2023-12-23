using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TodoAPP.App_Start
{
    public class DBContext
    {
      MongoClient client;

      public IMongoDatabase database;

      public DBContext()
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }

    }

   
}