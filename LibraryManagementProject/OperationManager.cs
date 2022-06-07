using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    internal static class OperationManager
    {
        private static IMongoDatabase db;
        private static IMongoCollection<Book> bookCollection;
        private static string databaseName = "library";

        //connection string: mongodb://localhost:27017/

        public static void MongoCRUD()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            db = client.GetDatabase(databaseName);
        }

        public static void InsertRecord<T>(string table, T record)       //Only needed if Upsert Record is faulty
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public static List<T> LoadAllRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(Builders<T>.Filter.Empty).ToList();
        }

        public static T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public static T LoadRecordByName<T>(string table, string name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("FullName", name);

            return collection.Find(filter).FirstOrDefault();
        }

        public static List<T> LoadRecordsBySearch<T>(string table, string title, List<ObjectId> authors, List<ObjectId> editors,
            string ISBN, BsonDateTime publishYear, string edition, ObjectId publisher, int pageCount, ObjectId language,
            int inStock)
        {
            var collection = db.GetCollection<T>(table);
            var titleFilter = Builders<T>.Filter.Eq("Title", title);
            var authorFilter = Builders<T>.Filter.AnyEq("Authors", authors);
            var editorFilter = Builders<T>.Filter.AnyEq("Editors", editors);
            var isbnFilter = Builders<T>.Filter.Eq("ISBN", ISBN);
            var publishYearFilter = Builders<T>.Filter.Eq("PublishYear", publishYear);
            var editionFilter = Builders<T>.Filter.Eq("Edition", edition);
            var publisherFilter = Builders<T>.Filter.Eq("Publisher", publisher);
            var pageCountFilter = Builders<T>.Filter.Eq("PageCount", pageCount);
            var languageFilter = Builders<T>.Filter.Eq("Language", language);
            var inStockFilter = Builders<T>.Filter.Eq("InStock", inStock);
            var combinedFilters = Builders<T>.Filter.And(titleFilter, authorFilter, editorFilter, isbnFilter,
                publishYearFilter, editionFilter, publisherFilter, pageCountFilter, languageFilter, inStockFilter);

            return collection.Find(combinedFilters).ToList();
        }

        public static void UpsertRecord<T>(string table, ObjectId? id, T record)        //Insert if not exists; update if exists, needs more testing
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions { IsUpsert = true }
            );
        }

        public static void UpdateRecord<T>(string table, string title, List<ObjectId> authors, List<ObjectId> editors,
            string ISBN, BsonDateTime publishYear, string edition, ObjectId publisher, int pageCount, string language,
            int inStock)
        {
            //var updateDef = Builders<T>.Update.Set()
            if (table == "Books")
            {
                var updateDef = Builders<Book>.Update.Set("Title", title).Set("Authors", authors)
                    .Set("Editors", editors).Set("ISBN", ISBN).Set("PublishYear", publishYear).Set("Edition", edition)
                    .Set("Publisher", publisher).Set("PageCount", pageCount).Set("Language", language)
                    .Set("InStock", inStock);

                var titleFilter = Builders<T>.Filter.Eq("Title", title);
                var authorFilter = Builders<T>.Filter.AnyEq("Authors", authors);
                var editorFilter = Builders<T>.Filter.AnyEq("Editors", editors);
                var isbnFilter = Builders<T>.Filter.Eq("ISBN", ISBN);
                var publishYearFilter = Builders<T>.Filter.Eq("PublishYear", publishYear);
                var editionFilter = Builders<T>.Filter.Eq("Edition", edition);
                var publisherFilter = Builders<T>.Filter.Eq("Publisher", publisher);
                var pageCountFilter = Builders<T>.Filter.Eq("PageCount", pageCount);
                var languageFilter = Builders<T>.Filter.Eq("Language", language);
                var inStockFilter = Builders<T>.Filter.Eq("InStock", inStock);
                var combinedFilters = Builders<T>.Filter.And(titleFilter, authorFilter, editorFilter, isbnFilter,
                    publishYearFilter, editionFilter, publisherFilter, pageCountFilter, languageFilter, inStockFilter);

                //bookCollection.UpdateOne(combinedFilters, updateDef);
            }

            /*else if (table == "Authors")
            {
            }
            else if (table == "Editors")
            {
            }*/
        }

        public static void DeleteRecord<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        public static T LoadPairRecord<T>(string table, ObjectId id, string keyName, T valueName)
        {
            var collection = db.GetCollection<T>(table);

            var idFilter = Builders<T>.Filter.Eq("Id", id);
            var customValueFilter = Builders<T>.Filter.Eq(keyName, valueName);
            var combinedFilters = Builders<T>.Filter.And(idFilter, customValueFilter);

            return collection.Find(combinedFilters).First();
        }

        public static List<T> LoadAllPairRecords<T>(string table, ObjectId id, string keyName, T valueName)
        {
            var collection = db.GetCollection<T>(table);

            var idFilter = Builders<T>.Filter.Eq("Id", id);
            var customValueFilter = Builders<T>.Filter.Eq(keyName, valueName);
            var combinedFilters = Builders<T>.Filter.And(idFilter, customValueFilter);

            return collection.Find(combinedFilters).ToList();
        }

        public static void DeletePairRecord<T>(string table, ObjectId id, string keyName, T valueName)
        {
            var collection = db.GetCollection<T>(table);

            var idFilter = Builders<T>.Filter.Eq("Id", id);
            var customValueFilter = Builders<T>.Filter.Eq(keyName, valueName);
            var combinedFilters = Builders<T>.Filter.And(idFilter, customValueFilter);

            collection.DeleteOne(combinedFilters);
        }

        public static void RefreshBooksOnGrid(DataGridView view)
        {
            bookCollection = db.GetCollection<Book>("Books");
            List<Book> bookList = bookCollection.AsQueryable().ToList<Book>();
            view.DataSource = bookList;
        }

        public static void RefreshBooksOnGrid(DataGridView view, TextBox Id, TextBox title, TextBox authors, TextBox editors, TextBox isbn,
            TextBox publishYear, TextBox edition, TextBox publisher, TextBox pageCount, TextBox language, TextBox inStock)
        {
            bookCollection = db.GetCollection<Book>("Books");
            List<Book> bookList = bookCollection.AsQueryable().ToList<Book>();
            view.DataSource = bookList;

            Id.Text = view.Rows[0].Cells[0].Value.ToString();
            title.Text = view.Rows[0].Cells[1].Value.ToString();
            authors.Text = view.Rows[0].Cells[2].Value.ToString();
            editors.Text = view.Rows[0].Cells[3].Value.ToString();
            isbn.Text = view.Rows[0].Cells[4].Value.ToString();
            publishYear.Text = view.Rows[0].Cells[5].Value.ToString();
            edition.Text = view.Rows[0].Cells[6].Value.ToString();
            publisher.Text = view.Rows[0].Cells[7].Value.ToString();
            pageCount.Text = view.Rows[0].Cells[8].Value.ToString();
            language.Text = view.Rows[0].Cells[9].Value.ToString();
            inStock.Text = view.Rows[0].Cells[10].Value.ToString();
        }

        public static void CreateFilizYilmaz()
        {
            Reader filiz = new Reader("Filiz Yılmaz", new Dictionary<string, BsonDateTime>());
            filiz.BorrowedBooks.Add("629e169064867bfbc52fb1d1", BsonDateTime.Create(DateTime.Now));

            UpsertRecord("Readers", filiz.Id, filiz);
        }
    }
}