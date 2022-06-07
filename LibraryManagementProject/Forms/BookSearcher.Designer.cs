namespace LibraryManagementProject
{
    partial class BookSearcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLbl = new System.Windows.Forms.Label();
            this.AuthorsLbl = new System.Windows.Forms.Label();
            this.AuthorsInfoLbl = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.EditorsLbl = new System.Windows.Forms.Label();
            this.EditorInfoLbl = new System.Windows.Forms.Label();
            this.ISBNLbl = new System.Windows.Forms.Label();
            this.PublishYearLbl = new System.Windows.Forms.Label();
            this.EditionLbl = new System.Windows.Forms.Label();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.PageCountLbl = new System.Windows.Forms.Label();
            this.LanguageLbl = new System.Windows.Forms.Label();
            this.InStockLbl = new System.Windows.Forms.Label();
            this.SearchBttn = new System.Windows.Forms.Button();
            this.ResetBttn = new System.Windows.Forms.Button();
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.AuthorsTxtBx = new System.Windows.Forms.TextBox();
            this.EditorsTxtBx = new System.Windows.Forms.TextBox();
            this.ISBNTxtBx = new System.Windows.Forms.TextBox();
            this.PublishYearTxtBx = new System.Windows.Forms.TextBox();
            this.EditionTxtBx = new System.Windows.Forms.TextBox();
            this.PublisherTxtBx = new System.Windows.Forms.TextBox();
            this.PageCountTxtBx = new System.Windows.Forms.TextBox();
            this.LanguageTxtBx = new System.Windows.Forms.TextBox();
            this.InStockTxtBx = new System.Windows.Forms.TextBox();
            this.BackBttn = new System.Windows.Forms.Button();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.showAllBorrowedBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(725, 56);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(39, 18);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Title:";
            // 
            // AuthorsLbl
            // 
            this.AuthorsLbl.AutoSize = true;
            this.AuthorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AuthorsLbl.Location = new System.Drawing.Point(725, 103);
            this.AuthorsLbl.Name = "AuthorsLbl";
            this.AuthorsLbl.Size = new System.Drawing.Size(63, 18);
            this.AuthorsLbl.TabIndex = 1;
            this.AuthorsLbl.Text = "Authors:";
            // 
            // AuthorsInfoLbl
            // 
            this.AuthorsInfoLbl.AutoSize = true;
            this.AuthorsInfoLbl.Location = new System.Drawing.Point(728, 125);
            this.AuthorsInfoLbl.Name = "AuthorsInfoLbl";
            this.AuthorsInfoLbl.Size = new System.Drawing.Size(159, 13);
            this.AuthorsInfoLbl.TabIndex = 2;
            this.AuthorsInfoLbl.Text = "Seperate authors with a comma.";
            // 
            // EditorsLbl
            // 
            this.EditorsLbl.AutoSize = true;
            this.EditorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditorsLbl.Location = new System.Drawing.Point(725, 162);
            this.EditorsLbl.Name = "EditorsLbl";
            this.EditorsLbl.Size = new System.Drawing.Size(59, 18);
            this.EditorsLbl.TabIndex = 3;
            this.EditorsLbl.Text = "Editors:";
            // 
            // EditorInfoLbl
            // 
            this.EditorInfoLbl.AutoSize = true;
            this.EditorInfoLbl.Location = new System.Drawing.Point(728, 180);
            this.EditorInfoLbl.Name = "EditorInfoLbl";
            this.EditorInfoLbl.Size = new System.Drawing.Size(155, 13);
            this.EditorInfoLbl.TabIndex = 4;
            this.EditorInfoLbl.Text = "Seperate editors with a comma.";
            // 
            // ISBNLbl
            // 
            this.ISBNLbl.AutoSize = true;
            this.ISBNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ISBNLbl.Location = new System.Drawing.Point(725, 218);
            this.ISBNLbl.Name = "ISBNLbl";
            this.ISBNLbl.Size = new System.Drawing.Size(46, 18);
            this.ISBNLbl.TabIndex = 5;
            this.ISBNLbl.Text = "ISBN:";
            // 
            // PublishYearLbl
            // 
            this.PublishYearLbl.AutoSize = true;
            this.PublishYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublishYearLbl.Location = new System.Drawing.Point(725, 270);
            this.PublishYearLbl.Name = "PublishYearLbl";
            this.PublishYearLbl.Size = new System.Drawing.Size(94, 18);
            this.PublishYearLbl.TabIndex = 6;
            this.PublishYearLbl.Text = "Publish Year:";
            // 
            // EditionLbl
            // 
            this.EditionLbl.AutoSize = true;
            this.EditionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditionLbl.Location = new System.Drawing.Point(725, 324);
            this.EditionLbl.Name = "EditionLbl";
            this.EditionLbl.Size = new System.Drawing.Size(57, 18);
            this.EditionLbl.TabIndex = 7;
            this.EditionLbl.Text = "Edition:";
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublisherLbl.Location = new System.Drawing.Point(725, 384);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(73, 18);
            this.PublisherLbl.TabIndex = 8;
            this.PublisherLbl.Text = "Publisher:";
            // 
            // PageCountLbl
            // 
            this.PageCountLbl.AutoSize = true;
            this.PageCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PageCountLbl.Location = new System.Drawing.Point(725, 446);
            this.PageCountLbl.Name = "PageCountLbl";
            this.PageCountLbl.Size = new System.Drawing.Size(90, 18);
            this.PageCountLbl.TabIndex = 9;
            this.PageCountLbl.Text = "Page Count:";
            // 
            // LanguageLbl
            // 
            this.LanguageLbl.AutoSize = true;
            this.LanguageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LanguageLbl.Location = new System.Drawing.Point(725, 509);
            this.LanguageLbl.Name = "LanguageLbl";
            this.LanguageLbl.Size = new System.Drawing.Size(76, 18);
            this.LanguageLbl.TabIndex = 10;
            this.LanguageLbl.Text = "Language:";
            // 
            // InStockLbl
            // 
            this.InStockLbl.AutoSize = true;
            this.InStockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InStockLbl.Location = new System.Drawing.Point(725, 569);
            this.InStockLbl.Name = "InStockLbl";
            this.InStockLbl.Size = new System.Drawing.Size(66, 18);
            this.InStockLbl.TabIndex = 11;
            this.InStockLbl.Text = "In Stock:";
            // 
            // SearchBttn
            // 
            this.SearchBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBttn.Location = new System.Drawing.Point(1203, 662);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(128, 48);
            this.SearchBttn.TabIndex = 12;
            this.SearchBttn.Text = "Search";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // ResetBttn
            // 
            this.ResetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetBttn.Location = new System.Drawing.Point(1021, 662);
            this.ResetBttn.Name = "ResetBttn";
            this.ResetBttn.Size = new System.Drawing.Size(128, 48);
            this.ResetBttn.TabIndex = 13;
            this.ResetBttn.Text = "Reset";
            this.ResetBttn.UseVisualStyleBackColor = true;
            this.ResetBttn.Click += new System.EventHandler(this.ResetBttn_Click);
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Location = new System.Drawing.Point(839, 57);
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.Size = new System.Drawing.Size(502, 20);
            this.TitleTxtBx.TabIndex = 14;
            // 
            // AuthorsTxtBx
            // 
            this.AuthorsTxtBx.Location = new System.Drawing.Point(839, 104);
            this.AuthorsTxtBx.Name = "AuthorsTxtBx";
            this.AuthorsTxtBx.Size = new System.Drawing.Size(502, 20);
            this.AuthorsTxtBx.TabIndex = 15;
            // 
            // EditorsTxtBx
            // 
            this.EditorsTxtBx.Location = new System.Drawing.Point(839, 157);
            this.EditorsTxtBx.Name = "EditorsTxtBx";
            this.EditorsTxtBx.Size = new System.Drawing.Size(502, 20);
            this.EditorsTxtBx.TabIndex = 16;
            // 
            // ISBNTxtBx
            // 
            this.ISBNTxtBx.Location = new System.Drawing.Point(839, 216);
            this.ISBNTxtBx.Name = "ISBNTxtBx";
            this.ISBNTxtBx.Size = new System.Drawing.Size(502, 20);
            this.ISBNTxtBx.TabIndex = 17;
            // 
            // PublishYearTxtBx
            // 
            this.PublishYearTxtBx.Location = new System.Drawing.Point(839, 271);
            this.PublishYearTxtBx.Name = "PublishYearTxtBx";
            this.PublishYearTxtBx.Size = new System.Drawing.Size(502, 20);
            this.PublishYearTxtBx.TabIndex = 18;
            // 
            // EditionTxtBx
            // 
            this.EditionTxtBx.Location = new System.Drawing.Point(839, 322);
            this.EditionTxtBx.Name = "EditionTxtBx";
            this.EditionTxtBx.Size = new System.Drawing.Size(502, 20);
            this.EditionTxtBx.TabIndex = 19;
            // 
            // PublisherTxtBx
            // 
            this.PublisherTxtBx.Location = new System.Drawing.Point(839, 385);
            this.PublisherTxtBx.Name = "PublisherTxtBx";
            this.PublisherTxtBx.Size = new System.Drawing.Size(502, 20);
            this.PublisherTxtBx.TabIndex = 20;
            // 
            // PageCountTxtBx
            // 
            this.PageCountTxtBx.Location = new System.Drawing.Point(839, 447);
            this.PageCountTxtBx.Name = "PageCountTxtBx";
            this.PageCountTxtBx.Size = new System.Drawing.Size(502, 20);
            this.PageCountTxtBx.TabIndex = 21;
            // 
            // LanguageTxtBx
            // 
            this.LanguageTxtBx.Location = new System.Drawing.Point(839, 510);
            this.LanguageTxtBx.Name = "LanguageTxtBx";
            this.LanguageTxtBx.Size = new System.Drawing.Size(502, 20);
            this.LanguageTxtBx.TabIndex = 22;
            // 
            // InStockTxtBx
            // 
            this.InStockTxtBx.Location = new System.Drawing.Point(839, 567);
            this.InStockTxtBx.Name = "InStockTxtBx";
            this.InStockTxtBx.Size = new System.Drawing.Size(502, 20);
            this.InStockTxtBx.TabIndex = 23;
            // 
            // BackBttn
            // 
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBttn.Location = new System.Drawing.Point(12, 662);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(128, 48);
            this.BackBttn.TabIndex = 24;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = true;
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // searchGridView
            // 
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(12, 8);
            this.searchGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowTemplate.Height = 28;
            this.searchGridView.Size = new System.Drawing.Size(633, 576);
            this.searchGridView.TabIndex = 25;
            // 
            // showAllBorrowedBttn
            // 
            this.showAllBorrowedBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showAllBorrowedBttn.Location = new System.Drawing.Point(839, 662);
            this.showAllBorrowedBttn.Name = "showAllBorrowedBttn";
            this.showAllBorrowedBttn.Size = new System.Drawing.Size(128, 48);
            this.showAllBorrowedBttn.TabIndex = 26;
            this.showAllBorrowedBttn.Text = "Show All Borrowed Books";
            this.showAllBorrowedBttn.UseVisualStyleBackColor = true;
            this.showAllBorrowedBttn.Click += new System.EventHandler(this.showAllBorrowedBttn_Click);
            // 
            // BookSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 722);
            this.Controls.Add(this.showAllBorrowedBttn);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.BackBttn);
            this.Controls.Add(this.InStockTxtBx);
            this.Controls.Add(this.LanguageTxtBx);
            this.Controls.Add(this.PageCountTxtBx);
            this.Controls.Add(this.PublisherTxtBx);
            this.Controls.Add(this.EditionTxtBx);
            this.Controls.Add(this.PublishYearTxtBx);
            this.Controls.Add(this.ISBNTxtBx);
            this.Controls.Add(this.EditorsTxtBx);
            this.Controls.Add(this.AuthorsTxtBx);
            this.Controls.Add(this.TitleTxtBx);
            this.Controls.Add(this.ResetBttn);
            this.Controls.Add(this.SearchBttn);
            this.Controls.Add(this.InStockLbl);
            this.Controls.Add(this.LanguageLbl);
            this.Controls.Add(this.PageCountLbl);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.EditionLbl);
            this.Controls.Add(this.PublishYearLbl);
            this.Controls.Add(this.ISBNLbl);
            this.Controls.Add(this.EditorInfoLbl);
            this.Controls.Add(this.EditorsLbl);
            this.Controls.Add(this.AuthorsInfoLbl);
            this.Controls.Add(this.AuthorsLbl);
            this.Controls.Add(this.TitleLbl);
            this.Name = "BookSearcher";
            this.Text = "SearchBooks";
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label AuthorsLbl;
        private System.Windows.Forms.Label AuthorsInfoLbl;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label EditorsLbl;
        private System.Windows.Forms.Label EditorInfoLbl;
        private System.Windows.Forms.Label ISBNLbl;
        private System.Windows.Forms.Label PublishYearLbl;
        private System.Windows.Forms.Label EditionLbl;
        private System.Windows.Forms.Label PublisherLbl;
        private System.Windows.Forms.Label PageCountLbl;
        private System.Windows.Forms.Label LanguageLbl;
        private System.Windows.Forms.Label InStockLbl;
        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Button ResetBttn;
        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.TextBox AuthorsTxtBx;
        private System.Windows.Forms.TextBox EditorsTxtBx;
        private System.Windows.Forms.TextBox ISBNTxtBx;
        private System.Windows.Forms.TextBox PublishYearTxtBx;
        private System.Windows.Forms.TextBox EditionTxtBx;
        private System.Windows.Forms.TextBox PublisherTxtBx;
        private System.Windows.Forms.TextBox PageCountTxtBx;
        private System.Windows.Forms.TextBox LanguageTxtBx;
        private System.Windows.Forms.TextBox InStockTxtBx;
        private System.Windows.Forms.Button BackBttn;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button showAllBorrowedBttn;
    }
}