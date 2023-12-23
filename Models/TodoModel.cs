using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoAPP.Models
{
    public class TodoModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("task")]
        public string Task { get; set; }
    }
}