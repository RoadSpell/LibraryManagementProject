using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class LoginScreen : Form
    {
        public static bool hasLoggedIn = false;
        public MainMenu mainForm;

        public LoginScreen(MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            //OperationManager.MongoCRUD();
        }

        private void LogInBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Reader _reader =
                    OperationManager.LoadRecordById<Reader>("Readers", ObjectId.Parse(UserIDTxtBox.Text.Trim()));

                UserSelf user = UserSelf.Instance;
                user.ConvertReaderToUserSelf(_reader);
                hasLoggedIn = true;

                this.Close();
                mainForm.MainMenuHasLoggedIn();
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Connection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Log In Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                MessageBox.Show("Invalid ID!", "Log In Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}