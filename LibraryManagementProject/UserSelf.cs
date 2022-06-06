using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public sealed class UserSelf : Reader 
    {
        internal new static Guid Id = mySelf.Id;    //What if someone else sets your id to someone else's
        private static Reader mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);
        internal new static string FullName = mySelf.FullName;
        internal new static Dictionary<Guid, BsonDateTime> BorrowedBooks = mySelf.BorrowedBooks;
            

        

        private UserSelf()
        {
            
        }

        private static UserSelf instance = null;

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

        public void BorrowBook<T>(Guid id) //Book ID
        {
            var book = OperationManager.LoadRecordById<Book>("Books", id);
            if (book.InStock > 0)
            {
                book.InStock -= 1;
                BorrowedBooks.Add(book.Id, BsonDateTime.Create(DateTime.Now));  //Add the borrowed book to User Self, not sure if it is required
                OperationManager.UpsertRecord("Readers", Id, this);
                mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);    //Refresh myself

            }
            else
            {
                MessageBox.Show("That book is not in stock!", "Not In Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReturnBook<T>(Guid id) //Book ID
        {
            if (BorrowedBooks.ContainsKey(id))
            {
                var book = OperationManager.LoadRecordById<Book>("Books", id);
                book.InStock += 1;
                OperationManager.UpsertRecord("Books", book.Id, book);


                BorrowedBooks.Remove(book.Id);
                OperationManager.UpsertRecord("Readers", Id, mySelf);
                mySelf = OperationManager.LoadRecordById<Reader>("Readers", Id);    //Refresh myself
                //OperationManager.DeleteRecord<BorrowedBooks>(); //To be fixed
            }

        }

        public void ConvertReaderToUserSelf(Reader _reader)
        {
            BorrowedBooks = _reader.BorrowedBooks;
            FullName = _reader.FullName;
            Id = _reader.Id;
        }
    }
}
