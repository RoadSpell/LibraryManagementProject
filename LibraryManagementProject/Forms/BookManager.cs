using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementProject.Forms
{
    public partial class BookManager : Form
    {
        internal MainMenu mainForm;

        private List<string> authorListString = new List<string>();
        private List<string> editorListString = new List<string>();

        private List<Author> authorListObjects = new List<Author>();
        private List<Editor> editorListObjects = new List<Editor>();

        private List<ObjectId> authorsObjectIds = new List<ObjectId>();
        private List<ObjectId> editorObjectIds = new List<ObjectId>();

        internal IMongoCollection<Book> books;

        public BookManager()
        {
            InitializeComponent();
        }

        private void bookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            TitleTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            AuthorsTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            EditorsTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            ISBNTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            PublishYearTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            EditionTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            PublisherTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            PageCountTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            LanguageTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            InStockTxtBx.Text = bookGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void ResetBttn_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtbx in this.Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            authorListString = AuthorsTxtBx.Text.Trim().Split(',').ToList();
            editorListString = EditorsTxtBx.Text.Trim().Split(',').ToList();

            foreach (var a in authorListString)
            {
                authorListObjects.Add(OperationManager.LoadRecordByName<Author>("Books", a));
            }

            foreach (var editor in editorListString)
            {
                editorListObjects.Add(OperationManager.LoadRecordByName<Editor>("Books", editor));
            }

            foreach (var a in authorListObjects)
            {
                authorsObjectIds.Add(a.Id);
            }

            foreach (var editor in editorListObjects)
            {
                editorObjectIds.Add(editor.Id);
            }

            Book newBook = new Book(TitleTxtBx.Text.Trim(), authorsObjectIds, editorObjectIds, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), ObjectId.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
                ObjectId.Parse(LanguageTxtBx.Text.Trim()), Int32.Parse(InStockTxtBx.Text.Trim()));

            OperationManager.UpsertRecord("Books", ObjectId.Empty, newBook);
            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(TitleTxtBx.Text.Trim(), authorsObjectIds, editorObjectIds, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), ObjectId.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
                ObjectId.Parse(LanguageTxtBx.Text.Trim()), Int32.Parse(InStockTxtBx.Text.Trim()));

            //OperationManager.UpdateRecord<Book>("Books", TitleTxtBx.Text.Trim(), authorsObjectIds, editorObjectIds, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), ObjectId.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
            //LanguageTxtBx.Text.Trim(), Int32.Parse(InStockTxtBx.Text.Trim()));

            OperationManager.UpsertRecord("Books", ObjectId.Parse(idTxtBx.Text.Trim()), newBook);

            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            OperationManager.DeleteRecord<Book>("Books", ObjectId.Parse(idTxtBx.Text.Trim()));
            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void borrowBttn_Click(object sender, EventArgs e)
        {
            if (idTxtBx.Text.Trim() != "" && idTxtBx.Text != null)
            {
                UserSelf user = UserSelf.Instance;
                user.BorrowBook<Book>(idTxtBx.Text.Trim());
            }
        }
    }
}