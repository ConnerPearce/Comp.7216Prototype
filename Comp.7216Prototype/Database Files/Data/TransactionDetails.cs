using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files.Data
{
    public class TransactionDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public DateTime DateCreated { get; set; }
        public string ItemPurchased { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentType { get; set; }
        public string CustomerID { get; set; }
    }
}
