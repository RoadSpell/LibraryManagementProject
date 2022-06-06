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
        private List<Reader> readersWithBooks;
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
            foreach (var _reader in allReaders)
            {
                if (_reader.BorrowedBooks != null && _reader.BorrowedBooks.Count > 0)
                {
                    readersWithBooks.Add(_reader);
                }
            }

            readersWithBooks.GroupBy(reader => reader.BorrowedBooks.Keys);
            allBorrowedGridView.DataSource = readersWithBooks;
        }
    }
}
