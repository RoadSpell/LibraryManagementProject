using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;

namespace LibraryManagementProject
{
     public class Reader
    {
        [BsonId]
        internal Guid Id { get; set; }

        internal string FullName { get; set; }
        internal Dictionary<Guid, BsonDateTime> BorrowedBooks { get; set; } //Book id

        public Reader()
        {
            Id = Guid.Empty;
            FullName = "UNKNOWN";
            BorrowedBooks = null;
        }

        public Reader(string fullname, Dictionary<Guid, BsonDateTime> books)
        {
            Id = Guid.Empty;
            this.FullName = fullname;
            this.BorrowedBooks = books;
        }

    }
}
