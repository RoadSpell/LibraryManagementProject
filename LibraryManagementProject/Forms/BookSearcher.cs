using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementProject.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;
using MongoDB.Libmongocrypt;

namespace LibraryManagementProject
{
    public partial class BookSearcher : Form
    {
        public MainMenu mainForm;

        private List<string> authorList = new List<string>();
        private List<string> editorList = new List<string>();

        private List<Author> gigaChadAuthors = new List<Author>();
        private List<Editor> gigaChadEditors = new List<Editor>();

        private List<Guid> authorsGuids = new List<Guid>();
        private List<Guid> editorGuids = new List<Guid>();

        public BookSearcher()
        {
            InitializeComponent();
        }

        private void ResetBttn_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtbx in this.Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }

        private void SearchBttn_Click(object sender, EventArgs e)   //Get the records by splitting the textboxes, load from the database, then get their Guids (Don't mind the variable names)
        {
            authorList = AuthorsTxtBx.Text.Trim().Split(',').ToList();
            editorList = EditorsTxtBx.Text.Trim().Split(',').ToList();

            foreach (var a in authorList)
            {
                gigaChadAuthors.Add(OperationManager.LoadRecordByName<Author>("Books",a));
            }

            foreach (var editor in editorList)
            {
                gigaChadEditors.Add(OperationManager.LoadRecordByName<Editor>("Books", editor));
            }

            foreach (var a in gigaChadAuthors)
            {
                authorsGuids.Add(a.Id);
            }

            foreach (var editor in gigaChadEditors)
            {
                editorGuids.Add(editor.Id);
            }


            /*OperationManager.LoadRecordsBySearch("Books", TitleTxtBx.Text.Trim(), gigaChadAuthors,
                EditionTxtBx.Text.Split(',').ToList(), ISBNTxtBx.Text.Trim(),
                BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), PublisherTxtBx.Text.Trim(),
                Int32.Parse(PageCountTxtBx.Text.Trim()), LanguageTxtBx.Text.Trim(), Int32.Parse(InStockTxtBx.Text.Trim()));*/   //To be fixed
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();

            //MainMenu main = new MainMenu();
            mainForm.Show();
        }

        private void showAllBorrowedBttn_Click(object sender, EventArgs e)
        {
            AllBorrowedBooks allBorrowed = new AllBorrowedBooks();
            allBorrowed.ShowDialog();
        }
    }
}
