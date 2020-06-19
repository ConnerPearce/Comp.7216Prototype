using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files.Data
{
    class PaymentDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public int CardCvv { get; set; }
        public int CardDetails { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CustomerID { get; set; }
    }
}
