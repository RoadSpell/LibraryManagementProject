using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;

namespace LibraryManagementProject
{
    internal class Author
    {
        [BsonId]
        internal Guid Id { get; }

        private string FullName { get; set; }
        private List<Guid> WrittenBooks { get; set; }

    }
}
