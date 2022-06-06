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
using MongoDB.Driver;

namespace LibraryManagementProject.Forms
{
    public partial class BookManager : Form
    {

        internal MainMenu mainForm;

        private List<string> authorListString = new List<string>();
        private List<string> editorListString = new List<string>();

        private List<Author> authorListObjects = new List<Author>();
        private List<Editor> editorListObjects = new List<Editor>();

        private List<Guid> authorsGuids = new List<Guid>();
        private List<Guid> editorGuids = new List<Guid>();

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
                authorsGuids.Add(a.Id);
            }

            foreach (var editor in editorListObjects)
            {
                editorGuids.Add(editor.Id);
            }


            Book newBook = new Book(TitleTxtBx.Text.Trim(), authorsGuids, editorGuids, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), Guid.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
                Guid.Parse(LanguageTxtBx.Text.Trim()), Int32.Parse(InStockTxtBx.Text.Trim()));

            OperationManager.UpsertRecord("Books", Guid.Empty, newBook);
            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(TitleTxtBx.Text.Trim(), authorsGuids, editorGuids, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), Guid.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
                Guid.Parse(LanguageTxtBx.Text.Trim()), Int32.Parse(InStockTxtBx.Text.Trim()));

            //OperationManager.UpdateRecord<Book>("Books", TitleTxtBx.Text.Trim(), authorsGuids, editorGuids, ISBNTxtBx.Text.Trim(), BsonDateTime.Create(PublishYearTxtBx.Text.Trim()), EditionTxtBx.Text.Trim(), Guid.Parse(PublisherTxtBx.Text.Trim()), Int32.Parse(PageCountTxtBx.Text.Trim()),
            //LanguageTxtBx.Text.Trim(), Int32.Parse(InStockTxtBx.Text.Trim()));

            OperationManager.UpsertRecord("Books", Guid.Parse(idTxtBx.Text.Trim()), newBook);

            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            OperationManager.DeleteRecord<Book>("Books", Guid.Parse(idTxtBx.Text.Trim()));
            OperationManager.RefreshBooksOnGrid(bookGrid, idTxtBx, TitleTxtBx, AuthorsTxtBx, EditorsTxtBx, ISBNTxtBx, PublishYearTxtBx, EditionTxtBx, PublisherTxtBx, PageCountTxtBx, LanguageTxtBx, InStockTxtBx);
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
