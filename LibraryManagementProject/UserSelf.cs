using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public sealed class UserSelf : Reader
    {
        //private static Reader mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);
        public new static ObjectId Id;

        public new static string FullName;
        public new static IDictionary<string, BsonDateTime> BorrowedBooks;

        private UserSelf()
        {
        }

        private static readonly UserSelf instance = null;

        public static UserSelf Instance
        {
            get
            {
                if (instance == null)
                {
                    return new UserSelf();
                }
                return instance;
            }
        }

        public void BorrowBook<T>(string id) //Book ID
        {
            var book = OperationManager.LoadRecordById<Book>("Books", ObjectId.Parse(id));
            if (book.InStock > 0)
            {
                book.InStock -= 1;
                BorrowedBooks.Add(id, BsonDateTime.Create(DateTime.Now));  //Add the borrowed book to User Self, not sure if it is required
                OperationManager.UpsertRecord("Readers", Id, this);
                //mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);    //Refresh myself
            }
            else
            {
                MessageBox.Show("That book is not in stock!", "Not In Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReturnBook<T>(string id) //Book ID
        {
            if (BorrowedBooks.ContainsKey(id))
            {
                var book = OperationManager.LoadRecordById<Book>("Books", ObjectId.Parse(id));
                book.InStock += 1;
                OperationManager.UpsertRecord("Books", book.Id, book);

                BorrowedBooks.Remove(id);
                OperationManager.UpsertRecord("Readers", Id, this);
                //mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);    //Refresh myself
                //OperationManager.DeleteRecord<BorrowedBooks>(); //To be fixed
            }
        }

        public void ConvertReaderToUserSelf(Reader _reader)
        {
            if (BorrowedBooks != null)
            {
                BorrowedBooks = _reader.BorrowedBooks;
            }

            FullName = _reader.FullName;
            Id = _reader.Id;
        }
    }
}