namespace LibraryManagementProject.Forms
{
    partial class AllBorrowedBooks
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
            this.allBorrowedGridView = new System.Windows.Forms.DataGridView();
            this.BackBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allBorrowedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allBorrowedGridView
            // 
            this.allBorrowedGridView.AllowUserToAddRows = false;
            this.allBorrowedGridView.AllowUserToDeleteRows = false;
            this.allBorrowedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBorrowedGridView.Location = new System.Drawing.Point(13, 13);
            this.allBorrowedGridView.Name = "allBorrowedGridView";
            this.allBorrowedGridView.ReadOnly = true;
            this.allBorrowedGridView.RowTemplate.Height = 28;
            this.allBorrowedGridView.Size = new System.Drawing.Size(1441, 841);
            this.allBorrowedGridView.TabIndex = 0;
            // 
            // BackBttn
            // 
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBttn.Location = new System.Drawing.Point(13, 870);
            this.BackBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(192, 74);
            this.BackBttn.TabIndex = 25;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = true;
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // AllBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 958);
            this.Controls.Add(this.BackBttn);
            this.Controls.Add(this.allBorrowedGridView);
            this.Name = "AllBorrowedBooks";
            this.Text = "AllBorrowedBooks";
            ((System.ComponentModel.ISupportInitialize)(this.allBorrowedGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allBorrowedGridView;
        private System.Windows.Forms.Button BackBttn;
    }
}