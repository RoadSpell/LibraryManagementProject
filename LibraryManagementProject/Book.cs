using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;

namespace LibraryManagementProject
{
    internal class Book
    {
        [BsonId]
        internal Guid Id { get; }

        private string Title { get; set; }
        private List<Guid> Authors { get; set; } //TBC
        private List<Guid> Editors { get; set; } //TBC
        private string ISBN { get; set; }
        private BsonDateTime PublishYear { get; set; }
        private string Edition { get; set; }
        private Guid Publisher { get; set; } //TBC
        private int PageCount { get; set; }
        private Guid Language { get; set; }
        public int InStock { get; set; }


        public Book()
        {
            Id = Guid.Empty;
            Authors = new List<Guid>();
            Editors = new List<Guid>();
            Publisher = Guid.Empty;
            ISBN = "";
            PublishYear = BsonDateTime.Create(DateTime.Now);
            Edition = "";
            Publisher = Guid.Empty;
            PageCount = -1;
            Language = Guid.Empty;
            InStock = -1;
        }

        public Book(string _title, List<Guid> _authors, List<Guid> _editors, string _isbn, BsonDateTime _publishYear, string _edition, Guid _publisher, int _pageCount, Guid _language, int _inStock)
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


        private Guid GetBookGuidByTitle(string title)
        {
            if (title == this.Title)
            {
                return (Guid)Id;
            }

            return Guid.Parse("-1");
        }
    }
}
