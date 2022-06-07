using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace LibraryManagementProject
{
    internal class Author
    {
        [BsonId]
        public ObjectId Id { get; }

        public string FullName { get; set; }
        public List<ObjectId> WrittenBooks { get; set; }
    }
}