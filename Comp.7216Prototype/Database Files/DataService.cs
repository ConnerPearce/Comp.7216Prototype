using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files
{
    public class DataService
    {
        private IMongoDatabase db;

        public DataService()
        {
            var client = new MongoClient("mongodb+srv://admin:admin@prototype-iuehj.mongodb.net/");
            db = client.GetDatabase("prototypedatabase");
        }


    }
}
