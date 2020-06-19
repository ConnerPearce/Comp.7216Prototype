using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files.Data
{
    public class RecordManagement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string CustomerID { get; set; }
        public string PaymentID { get; set; }
        public string TransferID { get; set; }
        public string TransactionID { get; set; }

        
    }

    
}
