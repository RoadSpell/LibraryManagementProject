using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;

namespace LibraryManagementProject
{
    public partial class LoginScreen : Form
    {

        public static bool hasLoggedIn = false;

        public LoginScreen()
        {
            InitializeComponent();
            OperationManager.MongoCRUD();
        }

        private void LogInBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Reader _reader =
                    OperationManager.LoadRecordById<Reader>("Readers", Guid.Parse(UserIDTxtBox.Text.Trim()));

                UserSelf user = UserSelf.Instance;
                user.ConvertReaderToUserSelf(_reader);
                hasLoggedIn = true;

                this.Close();
                MainMenu main = (MainMenu)MainMenu.ActiveForm;
                main.MainMenuHasLoggedIn();
            }
            catch (FormatException exception)
            {
                //Console.WriteLine(exception);
                MessageBox.Show("Could not connect to the database!", "Connection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //throw;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID!", "Log In Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }
    }
}
