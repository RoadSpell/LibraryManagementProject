using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace LibraryManagementProject
{
    internal class Language
    {
        [BsonId]
        public ObjectId Id { get; }

        public string FullName { get; set; }
        public List<ObjectId> BooksInLanguage { get; set; }

        public ObjectId GetLanguageObjectIdByName(string name)
        {
            if (name == this.FullName)
            {
                return this.Id;
            }

            return ObjectId.Parse("-1");
        }
    }
}