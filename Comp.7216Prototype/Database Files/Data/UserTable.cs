using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files.Data
{
    public class UserTable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public double AccountCredit { get; set; }
        public double PartialCredit { get; set; }
        public double RemainingCredit { get; set; }
        public double Data { get; set; }
        public int Texts { get; set; }
        public int Minutes { get; set; }

    }
}
