using System;
using System.Windows.Forms;

namespace LibraryManagementProject.Forms
{
    public partial class BookReturner : Form
    {
        private string bookToReturnId;

        internal MainMenu mainForm;

        public BookReturner()
        {
            InitializeComponent();
        }

        private void myBooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookToReturnId = myBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void returnBookBttn_Click(object sender, EventArgs e)
        {
            UserSelf user = UserSelf.Instance;
            user.ReturnBook<Book>(bookToReturnId);

            OperationManager.RefreshBooksOnGrid(myBooksGrid);
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}