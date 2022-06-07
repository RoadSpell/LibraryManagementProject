using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace LibraryManagementProject
{
    internal class Publisher
    {
        [BsonId]
        public ObjectId Id { get; }

        public string FullName { get; set; }

        public List<ObjectId> PublishedBooks { get; set; }
    }
}