using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManagementProject
{
    internal class Publisher
    {
        [BsonId]
        internal Guid Id { get; }
        
        private string FullName { get; set; }

        private List<Guid> PublishedBooks { get; set; }
    }
}
