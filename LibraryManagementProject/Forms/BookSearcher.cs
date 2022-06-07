using LibraryManagementProject.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class BookSearcher : Form
    {
        public MainMenu mainForm;

        private List<string> authorList = new List<string>();
        private List<string> editorList = new List<string>();

        private List<Author> gigaChadAuthors = new List<Author>();
        private List<Editor> gigaChadEditors = new List<Editor>();

        private List<ObjectId> authorsObjectIds;
        private List<ObjectId> editorObjectIds;

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

        private void SearchBttn_Click(object sender, EventArgs e)   //Get the records by splitting the textboxes, load from the database, then get their ObjectIds (Don't mind the variable names)
        {
            authorList = AuthorsTxtBx.Text.Trim().Split(',').ToList();
            editorList = EditorsTxtBx.Text.Trim().Split(',').ToList();

            var title = TitleTxtBx.Text.Trim();
            var isbn = ISBNTxtBx.Text.Trim();

            var dateBool = DateTime.TryParse(PublishYearTxtBx.Text.Trim(), out var date);
            var dateBson = BsonDateTime.Create(date);

            var edition = EditionTxtBx.Text.Trim();


            var publisher = OperationManager.LoadRecordByName<Publisher>("Publishers", PublisherTxtBx.Text.Trim());
            var publisherId = publisher.Id;

            var pageCount = Int32.Parse(PageCountTxtBx.Text.Trim());


            var language = OperationManager.LoadRecordByName<Language>("Languages", LanguageTxtBx.Text.Trim());
            var languageId= language.Id;

            var inStock = Int32.Parse(InStockTxtBx.Text.Trim());


            foreach (var a in authorList)
            {
                gigaChadAuthors.Add(OperationManager.LoadRecordByName<Author>("Books", a));
            }

            foreach (var editor in editorList)
            {
                gigaChadEditors.Add(OperationManager.LoadRecordByName<Editor>("Books", editor));
            }

            foreach (var a in gigaChadAuthors)
            {
                if (a != null)
                    authorsObjectIds.Add(a.Id);
            }

            foreach (var editor in gigaChadEditors)
            {
                if (editor != null)
                    editorObjectIds.Add(editor.Id);
            }

            searchGridView.DataSource = OperationManager.LoadRecordsBySearch<Book>("Books", title, authorsObjectIds, editorObjectIds, isbn, dateBson, edition, publisherId, pageCount, languageId, inStock);  //To be fixed
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