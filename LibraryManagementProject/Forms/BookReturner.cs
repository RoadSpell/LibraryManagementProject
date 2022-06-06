using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementProject.Forms
{
    public partial class BookReturner : Form
    {

        private Guid bookToReturnId;

        internal MainMenu mainForm;
        public BookReturner()
        {
            InitializeComponent();

        }

        private void myBooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookToReturnId = Guid.Parse(myBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
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
