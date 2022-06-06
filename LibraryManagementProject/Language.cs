using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManagementProject
{
    internal class Language
    {
        [BsonId]
        internal Guid Id { get; }

        private string FullName { get; set; }
        private List<Guid> BooksInLanguage { get; set; }

        private Guid GetLanguageGuidByName(string name)
        {
            if (name == this.FullName)
            {
                return this.Id;
            }

            return Guid.Parse("-1");
        }
    }
}
