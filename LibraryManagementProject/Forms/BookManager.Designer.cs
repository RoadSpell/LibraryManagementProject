namespace LibraryManagementProject.Forms
{
    partial class BookManager
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
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.InStockTxtBx = new System.Windows.Forms.TextBox();
            this.LanguageTxtBx = new System.Windows.Forms.TextBox();
            this.PageCountTxtBx = new System.Windows.Forms.TextBox();
            this.PublisherTxtBx = new System.Windows.Forms.TextBox();
            this.EditionTxtBx = new System.Windows.Forms.TextBox();
            this.PublishYearTxtBx = new System.Windows.Forms.TextBox();
            this.ISBNTxtBx = new System.Windows.Forms.TextBox();
            this.EditorsTxtBx = new System.Windows.Forms.TextBox();
            this.AuthorsTxtBx = new System.Windows.Forms.TextBox();
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.InStockLbl = new System.Windows.Forms.Label();
            this.LanguageLbl = new System.Windows.Forms.Label();
            this.PageCountLbl = new System.Windows.Forms.Label();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.EditionLbl = new System.Windows.Forms.Label();
            this.PublishYearLbl = new System.Windows.Forms.Label();
            this.ISBNLbl = new System.Windows.Forms.Label();
            this.EditorInfoLbl = new System.Windows.Forms.Label();
            this.EditorsLbl = new System.Windows.Forms.Label();
            this.AuthorsInfoLbl = new System.Windows.Forms.Label();
            this.AuthorsLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ResetBttn = new System.Windows.Forms.Button();
            this.AddBttn = new System.Windows.Forms.Button();
            this.BackBttn = new System.Windows.Forms.Button();
            this.updateBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTxtBx = new System.Windows.Forms.TextBox();
            this.borrowBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookGrid
            // 
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Location = new System.Drawing.Point(13, 14);
            this.bookGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.Size = new System.Drawing.Size(1164, 1025);
            this.bookGrid.TabIndex = 0;
            this.bookGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookGrid_CellContentClick);
            // 
            // InStockTxtBx
            // 
            this.InStockTxtBx.Location = new System.Drawing.Point(1425, 860);
            this.InStockTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InStockTxtBx.Name = "InStockTxtBx";
            this.InStockTxtBx.Size = new System.Drawing.Size(751, 26);
            this.InStockTxtBx.TabIndex = 67;
            // 
            // LanguageTxtBx
            // 
            this.LanguageTxtBx.Location = new System.Drawing.Point(1425, 772);
            this.LanguageTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguageTxtBx.Name = "LanguageTxtBx";
            this.LanguageTxtBx.Size = new System.Drawing.Size(751, 26);
            this.LanguageTxtBx.TabIndex = 66;
            // 
            // PageCountTxtBx
            // 
            this.PageCountTxtBx.Location = new System.Drawing.Point(1425, 675);
            this.PageCountTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageCountTxtBx.Name = "PageCountTxtBx";
            this.PageCountTxtBx.Size = new System.Drawing.Size(751, 26);
            this.PageCountTxtBx.TabIndex = 65;
            // 
            // PublisherTxtBx
            // 
            this.PublisherTxtBx.Location = new System.Drawing.Point(1425, 580);
            this.PublisherTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PublisherTxtBx.Name = "PublisherTxtBx";
            this.PublisherTxtBx.Size = new System.Drawing.Size(751, 26);
            this.PublisherTxtBx.TabIndex = 64;
            // 
            // EditionTxtBx
            // 
            this.EditionTxtBx.Location = new System.Drawing.Point(1425, 483);
            this.EditionTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditionTxtBx.Name = "EditionTxtBx";
            this.EditionTxtBx.Size = new System.Drawing.Size(751, 26);
            this.EditionTxtBx.TabIndex = 63;
            // 
            // PublishYearTxtBx
            // 
            this.PublishYearTxtBx.Location = new System.Drawing.Point(1425, 405);
            this.PublishYearTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PublishYearTxtBx.Name = "PublishYearTxtBx";
            this.PublishYearTxtBx.Size = new System.Drawing.Size(751, 26);
            this.PublishYearTxtBx.TabIndex = 62;
            // 
            // ISBNTxtBx
            // 
            this.ISBNTxtBx.Location = new System.Drawing.Point(1425, 320);
            this.ISBNTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ISBNTxtBx.Name = "ISBNTxtBx";
            this.ISBNTxtBx.Size = new System.Drawing.Size(751, 26);
            this.ISBNTxtBx.TabIndex = 61;
            // 
            // EditorsTxtBx
            // 
            this.EditorsTxtBx.Location = new System.Drawing.Point(1425, 229);
            this.EditorsTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditorsTxtBx.Name = "EditorsTxtBx";
            this.EditorsTxtBx.Size = new System.Drawing.Size(751, 26);
            this.EditorsTxtBx.TabIndex = 60;
            // 
            // AuthorsTxtBx
            // 
            this.AuthorsTxtBx.Location = new System.Drawing.Point(1425, 148);
            this.AuthorsTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorsTxtBx.Name = "AuthorsTxtBx";
            this.AuthorsTxtBx.Size = new System.Drawing.Size(751, 26);
            this.AuthorsTxtBx.TabIndex = 59;
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Location = new System.Drawing.Point(1425, 75);
            this.TitleTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.Size = new System.Drawing.Size(751, 26);
            this.TitleTxtBx.TabIndex = 58;
            // 
            // InStockLbl
            // 
            this.InStockLbl.AutoSize = true;
            this.InStockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InStockLbl.Location = new System.Drawing.Point(1254, 863);
            this.InStockLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InStockLbl.Name = "InStockLbl";
            this.InStockLbl.Size = new System.Drawing.Size(66, 18);
            this.InStockLbl.TabIndex = 57;
            this.InStockLbl.Text = "In Stock:";
            // 
            // LanguageLbl
            // 
            this.LanguageLbl.AutoSize = true;
            this.LanguageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LanguageLbl.Location = new System.Drawing.Point(1254, 771);
            this.LanguageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LanguageLbl.Name = "LanguageLbl";
            this.LanguageLbl.Size = new System.Drawing.Size(76, 18);
            this.LanguageLbl.TabIndex = 56;
            this.LanguageLbl.Text = "Language:";
            // 
            // PageCountLbl
            // 
            this.PageCountLbl.AutoSize = true;
            this.PageCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PageCountLbl.Location = new System.Drawing.Point(1254, 674);
            this.PageCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageCountLbl.Name = "PageCountLbl";
            this.PageCountLbl.Size = new System.Drawing.Size(90, 18);
            this.PageCountLbl.TabIndex = 55;
            this.PageCountLbl.Text = "Page Count:";
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublisherLbl.Location = new System.Drawing.Point(1254, 578);
            this.PublisherLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(73, 18);
            this.PublisherLbl.TabIndex = 54;
            this.PublisherLbl.Text = "Publisher:";
            // 
            // EditionLbl
            // 
            this.EditionLbl.AutoSize = true;
            this.EditionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditionLbl.Location = new System.Drawing.Point(1254, 486);
            this.EditionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditionLbl.Name = "EditionLbl";
            this.EditionLbl.Size = new System.Drawing.Size(57, 18);
            this.EditionLbl.TabIndex = 53;
            this.EditionLbl.Text = "Edition:";
            // 
            // PublishYearLbl
            // 
            this.PublishYearLbl.AutoSize = true;
            this.PublishYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PublishYearLbl.Location = new System.Drawing.Point(1254, 403);
            this.PublishYearLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PublishYearLbl.Name = "PublishYearLbl";
            this.PublishYearLbl.Size = new System.Drawing.Size(94, 18);
            this.PublishYearLbl.TabIndex = 52;
            this.PublishYearLbl.Text = "Publish Year:";
            // 
            // ISBNLbl
            // 
            this.ISBNLbl.AutoSize = true;
            this.ISBNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ISBNLbl.Location = new System.Drawing.Point(1254, 323);
            this.ISBNLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBNLbl.Name = "ISBNLbl";
            this.ISBNLbl.Size = new System.Drawing.Size(46, 18);
            this.ISBNLbl.TabIndex = 51;
            this.ISBNLbl.Text = "ISBN:";
            // 
            // EditorInfoLbl
            // 
            this.EditorInfoLbl.AutoSize = true;
            this.EditorInfoLbl.Location = new System.Drawing.Point(1258, 265);
            this.EditorInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditorInfoLbl.Name = "EditorInfoLbl";
            this.EditorInfoLbl.Size = new System.Drawing.Size(232, 20);
            this.EditorInfoLbl.TabIndex = 50;
            this.EditorInfoLbl.Text = "Seperate editors with a comma.";
            // 
            // EditorsLbl
            // 
            this.EditorsLbl.AutoSize = true;
            this.EditorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditorsLbl.Location = new System.Drawing.Point(1254, 237);
            this.EditorsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditorsLbl.Name = "EditorsLbl";
            this.EditorsLbl.Size = new System.Drawing.Size(59, 18);
            this.EditorsLbl.TabIndex = 49;
            this.EditorsLbl.Text = "Editors:";
            // 
            // AuthorsInfoLbl
            // 
            this.AuthorsInfoLbl.AutoSize = true;
            this.AuthorsInfoLbl.Location = new System.Drawing.Point(1258, 180);
            this.AuthorsInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorsInfoLbl.Name = "AuthorsInfoLbl";
            this.AuthorsInfoLbl.Size = new System.Drawing.Size(238, 20);
            this.AuthorsInfoLbl.TabIndex = 48;
            this.AuthorsInfoLbl.Text = "Seperate authors with a comma.";
            // 
            // AuthorsLbl
            // 
            this.AuthorsLbl.AutoSize = true;
            this.AuthorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AuthorsLbl.Location = new System.Drawing.Point(1254, 146);
            this.AuthorsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorsLbl.Name = "AuthorsLbl";
            this.AuthorsLbl.Size = new System.Drawing.Size(63, 18);
            this.AuthorsLbl.TabIndex = 47;
            this.AuthorsLbl.Text = "Authors:";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(1254, 74);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(39, 18);
            this.TitleLbl.TabIndex = 46;
            this.TitleLbl.Text = "Title:";
            // 
            // ResetBttn
            // 
            this.ResetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetBttn.Location = new System.Drawing.Point(1781, 932);
            this.ResetBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetBttn.Name = "ResetBttn";
            this.ResetBttn.Size = new System.Drawing.Size(192, 74);
            this.ResetBttn.TabIndex = 70;
            this.ResetBttn.Text = "Reset";
            this.ResetBttn.UseVisualStyleBackColor = true;
            this.ResetBttn.Click += new System.EventHandler(this.ResetBttn_Click);
            // 
            // AddBttn
            // 
            this.AddBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBttn.Location = new System.Drawing.Point(2029, 1112);
            this.AddBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(192, 74);
            this.AddBttn.TabIndex = 69;
            this.AddBttn.Text = "Add";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // BackBttn
            // 
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBttn.Location = new System.Drawing.Point(13, 1112);
            this.BackBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(192, 74);
            this.BackBttn.TabIndex = 68;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = true;
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // updateBttn
            // 
            this.updateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBttn.Location = new System.Drawing.Point(1781, 1112);
            this.updateBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBttn.Name = "updateBttn";
            this.updateBttn.Size = new System.Drawing.Size(192, 74);
            this.updateBttn.TabIndex = 72;
            this.updateBttn.Text = "Update";
            this.updateBttn.UseVisualStyleBackColor = true;
            this.updateBttn.Click += new System.EventHandler(this.updateBttn_Click);
            // 
            // deleteBttn
            // 
            this.deleteBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBttn.Location = new System.Drawing.Point(1522, 1112);
            this.deleteBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(192, 74);
            this.deleteBttn.TabIndex = 73;
            this.deleteBttn.Text = "Delete";
            this.deleteBttn.UseVisualStyleBackColor = true;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLbl.Location = new System.Drawing.Point(1254, 14);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(26, 18);
            this.idLbl.TabIndex = 74;
            this.idLbl.Text = "ID:";
            // 
            // idTxtBx
            // 
            this.idTxtBx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idTxtBx.Location = new System.Drawing.Point(1425, 10);
            this.idTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTxtBx.Name = "idTxtBx";
            this.idTxtBx.Size = new System.Drawing.Size(751, 26);
            this.idTxtBx.TabIndex = 75;
            // 
            // borrowBttn
            // 
            this.borrowBttn.BackColor = System.Drawing.Color.LemonChiffon;
            this.borrowBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borrowBttn.Location = new System.Drawing.Point(2029, 932);
            this.borrowBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borrowBttn.Name = "borrowBttn";
            this.borrowBttn.Size = new System.Drawing.Size(192, 74);
            this.borrowBttn.TabIndex = 76;
            this.borrowBttn.Text = "Borrow";
            this.borrowBttn.UseVisualStyleBackColor = false;
            this.borrowBttn.Click += new System.EventHandler(this.borrowBttn_Click);
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2234, 1200);
            this.Controls.Add(this.borrowBttn);
            this.Controls.Add(this.idTxtBx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.deleteBttn);
            this.Controls.Add(this.updateBttn);
            this.Controls.Add(this.ResetBttn);
            this.Controls.Add(this.AddBttn);
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
            this.Controls.Add(this.bookGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookManager";
            this.Text = "UpdateBooks";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.TextBox InStockTxtBx;
        private System.Windows.Forms.TextBox LanguageTxtBx;
        private System.Windows.Forms.TextBox PageCountTxtBx;
        private System.Windows.Forms.TextBox PublisherTxtBx;
        private System.Windows.Forms.TextBox EditionTxtBx;
        private System.Windows.Forms.TextBox PublishYearTxtBx;
        private System.Windows.Forms.TextBox ISBNTxtBx;
        private System.Windows.Forms.TextBox EditorsTxtBx;
        private System.Windows.Forms.TextBox AuthorsTxtBx;
        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.Label InStockLbl;
        private System.Windows.Forms.Label LanguageLbl;
        private System.Windows.Forms.Label PageCountLbl;
        private System.Windows.Forms.Label PublisherLbl;
        private System.Windows.Forms.Label EditionLbl;
        private System.Windows.Forms.Label PublishYearLbl;
        private System.Windows.Forms.Label ISBNLbl;
        private System.Windows.Forms.Label EditorInfoLbl;
        private System.Windows.Forms.Label EditorsLbl;
        private System.Windows.Forms.Label AuthorsInfoLbl;
        private System.Windows.Forms.Label AuthorsLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ResetBttn;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button BackBttn;
        private System.Windows.Forms.Button updateBttn;
        private System.Windows.Forms.Button deleteBttn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTxtBx;
        private System.Windows.Forms.Button borrowBttn;
    }
}