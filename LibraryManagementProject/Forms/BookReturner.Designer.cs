namespace LibraryManagementProject.Forms
{
    partial class BookReturner
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
            this.myBooksGrid = new System.Windows.Forms.DataGridView();
            this.returnBookBttn = new System.Windows.Forms.Button();
            this.BackBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myBooksGrid
            // 
            this.myBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myBooksGrid.Location = new System.Drawing.Point(12, 12);
            this.myBooksGrid.Name = "myBooksGrid";
            this.myBooksGrid.RowTemplate.Height = 28;
            this.myBooksGrid.Size = new System.Drawing.Size(604, 554);
            this.myBooksGrid.TabIndex = 0;
            this.myBooksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myBooksGrid_CellContentClick);
            // 
            // returnBookBttn
            // 
            this.returnBookBttn.BackColor = System.Drawing.Color.LemonChiffon;
            this.returnBookBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnBookBttn.Location = new System.Drawing.Point(972, 800);
            this.returnBookBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBookBttn.Name = "returnBookBttn";
            this.returnBookBttn.Size = new System.Drawing.Size(192, 74);
            this.returnBookBttn.TabIndex = 77;
            this.returnBookBttn.Text = "Return Book";
            this.returnBookBttn.UseVisualStyleBackColor = false;
            this.returnBookBttn.Click += new System.EventHandler(this.returnBookBttn_Click);
            // 
            // BackBttn
            // 
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBttn.Location = new System.Drawing.Point(13, 800);
            this.BackBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(192, 74);
            this.BackBttn.TabIndex = 78;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = true;
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // BookReturner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 888);
            this.Controls.Add(this.BackBttn);
            this.Controls.Add(this.returnBookBttn);
            this.Controls.Add(this.myBooksGrid);
            this.Name = "BookReturner";
            this.Text = "BookReturner";
            ((System.ComponentModel.ISupportInitialize)(this.myBooksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myBooksGrid;
        private System.Windows.Forms.Button returnBookBttn;
        private System.Windows.Forms.Button BackBttn;
    }
}