using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementProject.Forms;

namespace LibraryManagementProject
{
    public partial class MainMenu : Form
    {


        public MainMenu()
        {
            InitializeComponent();
            LogInLbl.Text = "You are currently not logged in.";
            OperationManager.CreateMertYilmaz();
            try
            {
                OperationManager.MongoCRUD();
            }
            catch (Exception e)
            {
                MessageBox.Show("Please check your internet connection!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }

        public void MainMenuHasLoggedIn()
        {
            LogInLbl.Text = "You are logged in.";
            LogInBttnMainMenu.Enabled = false;
        }

        private void SearchBooksBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookSearcher search = new BookSearcher();
            search.mainForm = this;
            search.Show();
        }

        /*private void BorrowBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowBooks borrow = new BorrowBooks();
            borrow.Show();
        }*/

        private void LogInBttnMainMenu_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }

        private void ManageBooksBttn_Click(object sender, EventArgs e)
        {
            if (LoginScreen.hasLoggedIn)
            {
                this.Hide();
                BookManager manage = new BookManager();
                manage.mainForm = this;
                manage.Show();
            }
            else
            {
                MessageBox.Show("Please log in!", "Not Logged In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void returnBooksBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookReturner returner = new BookReturner();
            returner.mainForm = this;
            returner.Show();
        }
    }
}
