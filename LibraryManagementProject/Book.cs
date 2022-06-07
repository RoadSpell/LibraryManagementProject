using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace LibraryManagementProject
{
    internal class Book
    {
        [BsonId]
        public ObjectId Id { get; }

        public string Title { get; set; }
        public List<ObjectId> Authors { get; set; } //TBC
        public List<ObjectId> Editors { get; set; } //TBC
        public string ISBN { get; set; }
        public BsonDateTime PublishYear { get; set; }
        public string Edition { get; set; }
        public ObjectId Publisher { get; set; } //TBC
        private int PageCount { get; set; }
        public ObjectId Language { get; set; }
        public int InStock { get; set; }

        public Book()
        {
            Id = ObjectId.Empty;
            Authors = new List<ObjectId>();
            Editors = new List<ObjectId>();
            Publisher = ObjectId.Empty;
            ISBN = "";
            PublishYear = BsonDateTime.Create(DateTime.Now);
            Edition = "";
            Publisher = ObjectId.Empty;
            PageCount = -1;
            Language = ObjectId.Empty;
            InStock = -1;
        }

        public Book(string _title, List<ObjectId> _authors, List<ObjectId> _editors, string _isbn, BsonDateTime _publishYear, string _edition, ObjectId _publisher, int _pageCount, ObjectId _language, int _inStock)
        {
            Title = _title;
            Authors = _authors;
            Editors = _editors;
            Publisher = _publisher;
            ISBN = _isbn;
            PublishYear = _publishYear;
            Edition = _edition;
            Publisher = _publisher;
            PageCount = _pageCount;
            Language = _language;
            InStock = _inStock;
        }

        private ObjectId GetBookObjectIdByTitle(string title)
        {
            if (title == this.Title)
            {
                return (ObjectId)Id;
            }

            return ObjectId.Parse("-1");
        }
    }
}