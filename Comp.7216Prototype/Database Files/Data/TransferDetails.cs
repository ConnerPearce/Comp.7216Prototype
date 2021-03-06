﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files.Data
{
    public class TransferDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        public string TransferType { get; set; }
        public string TransferAmount { get; set; }
        public bool Payed { get; set; }
        public string PayeeID { get; set; }
    }
}
