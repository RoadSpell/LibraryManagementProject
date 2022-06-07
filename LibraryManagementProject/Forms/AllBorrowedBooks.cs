using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementProject.Forms
{
    public partial class AllBorrowedBooks : Form
    {
        private List<Reader> allReaders = OperationManager.LoadAllRecords<Reader>("Readers");
        private Dictionary<Reader, List<string>> workAround;
        private Dictionary<Reader, List<Book>> result;
        private List<Book> collectionList;

        public AllBorrowedBooks()
        {
            InitializeComponent();
            ShowBorrowedInDetail();
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBorrowedInDetail() //DOESN'T WORK
        {
            //Get Books for each ObjectId in Borrowed books in each reader
            foreach (var _reader in allReaders)
            {
                if (_reader.BorrowedBooks != null && _reader.BorrowedBooks.Count > 0)
                {
                    workAround.Add(_reader, _reader.BorrowedBooks.Keys.ToList());
                }
            }

            foreach (var keyPair in workAround)
            {
                for (int i = 0; i < workAround.Count; i++)
                {
                    var ObjectIdValue = keyPair.Value.ElementAt(i);
                    var collection = OperationManager.LoadRecordById<Book>("Books", ObjectId.Parse(ObjectIdValue));

                    collectionList.Add(collection);
                }
                result.Add(keyPair.Key, collectionList);
                collectionList.Clear();
            }

            //readersWithBooks.GroupBy(reader => reader.BorrowedBooks.Keys);
            allBorrowedGridView.DataSource = result;
        }
    }
}