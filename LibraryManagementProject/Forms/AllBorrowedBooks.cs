using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

namespace LibraryManagementProject.Forms
{
    public partial class AllBorrowedBooks : Form
    {
        private List<Reader> allReaders = OperationManager.LoadAllRecords<Reader>("Readers");
        private Dictionary<Reader, List<Guid>> workAround;
        private Dictionary<Reader, List<Book>> result;
        List<Book> collectionList;
        public AllBorrowedBooks()
        {
            InitializeComponent();
            ShowBorrowedInDetail();
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBorrowedInDetail()
        {

            //Get Books for each Guid in Borrowed books in each reader
            foreach (var _reader in allReaders)
            {
                if (_reader.BorrowedBooks != null && _reader.BorrowedBooks.Count > 0)
                {
                    workAround.Add(_reader, _reader.BorrowedBooks.Keys.ToList());
                }
            }

            foreach (var keyPair in workAround)
            {
                for (int i = 0; i < workAround.Values.Count; i++)
                {
                    var guidValue = keyPair.Value.ElementAt(i);
                    var collection = OperationManager.LoadRecordById<Book>("Books", guidValue);
                    
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
