using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace LibraryManagementProject
{
    public class Reader
    {
        [BsonId]
        internal ObjectId Id { get; set; }

        public string FullName { get; set; }
        public IDictionary<string, BsonDateTime> BorrowedBooks { get; set; } //Book id

        public Reader()
        {
            Id = ObjectId.GenerateNewId();
            FullName = "UNKNOWN";
            BorrowedBooks = null;
        }

        public Reader(string fullname, IDictionary<string, BsonDateTime> books)
        {
            Id = ObjectId.GenerateNewId();
            this.FullName = fullname;
            this.BorrowedBooks = books;
        }
    }
}