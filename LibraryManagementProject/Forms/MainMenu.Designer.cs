namespace LibraryManagementProject
{
    partial class MainMenu
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
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.ManageBooksBttn = new System.Windows.Forms.Button();
            this.SearchBooksBttn = new System.Windows.Forms.Button();
            this.LogInLbl = new System.Windows.Forms.Label();
            this.LogInBttnMainMenu = new System.Windows.Forms.Button();
            this.returnBooksBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeLbl.Location = new System.Drawing.Point(255, 62);
            this.WelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(441, 25);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome to the Library Management System";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageBooksBttn
            // 
            this.ManageBooksBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ManageBooksBttn.Location = new System.Drawing.Point(130, 150);
            this.ManageBooksBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManageBooksBttn.Name = "ManageBooksBttn";
            this.ManageBooksBttn.Size = new System.Drawing.Size(249, 126);
            this.ManageBooksBttn.TabIndex = 1;
            this.ManageBooksBttn.Text = "Manage Books";
            this.ManageBooksBttn.UseVisualStyleBackColor = true;
            this.ManageBooksBttn.Click += new System.EventHandler(this.ManageBooksBttn_Click);
            // 
            // SearchBooksBttn
            // 
            this.SearchBooksBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBooksBttn.Location = new System.Drawing.Point(130, 538);
            this.SearchBooksBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBooksBttn.Name = "SearchBooksBttn";
            this.SearchBooksBttn.Size = new System.Drawing.Size(249, 126);
            this.SearchBooksBttn.TabIndex = 2;
            this.SearchBooksBttn.Text = "Search Books";
            this.SearchBooksBttn.UseVisualStyleBackColor = true;
            this.SearchBooksBttn.Click += new System.EventHandler(this.SearchBooksBttn_Click);
            // 
            // LogInLbl
            // 
            this.LogInLbl.AutoSize = true;
            this.LogInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogInLbl.Location = new System.Drawing.Point(754, 252);
            this.LogInLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogInLbl.Name = "LogInLbl";
            this.LogInLbl.Size = new System.Drawing.Size(251, 24);
            this.LogInLbl.TabIndex = 3;
            this.LogInLbl.Text = "Log In text here, Placeholder";
            // 
            // LogInBttnMainMenu
            // 
            this.LogInBttnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogInBttnMainMenu.Location = new System.Drawing.Point(808, 438);
            this.LogInBttnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogInBttnMainMenu.Name = "LogInBttnMainMenu";
            this.LogInBttnMainMenu.Size = new System.Drawing.Size(249, 126);
            this.LogInBttnMainMenu.TabIndex = 4;
            this.LogInBttnMainMenu.Text = "Log In";
            this.LogInBttnMainMenu.UseVisualStyleBackColor = true;
            this.LogInBttnMainMenu.Click += new System.EventHandler(this.LogInBttnMainMenu_Click);
            // 
            // returnBooksBttn
            // 
            this.returnBooksBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnBooksBttn.Location = new System.Drawing.Point(130, 345);
            this.returnBooksBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBooksBttn.Name = "returnBooksBttn";
            this.returnBooksBttn.Size = new System.Drawing.Size(249, 126);
            this.returnBooksBttn.TabIndex = 5;
            this.returnBooksBttn.Text = "Return Books";
            this.returnBooksBttn.UseVisualStyleBackColor = true;
            this.returnBooksBttn.Click += new System.EventHandler(this.returnBooksBttn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 713);
            this.Controls.Add(this.returnBooksBttn);
            this.Controls.Add(this.LogInBttnMainMenu);
            this.Controls.Add(this.LogInLbl);
            this.Controls.Add(this.SearchBooksBttn);
            this.Controls.Add(this.ManageBooksBttn);
            this.Controls.Add(this.WelcomeLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Button ManageBooksBttn;
        private System.Windows.Forms.Button SearchBooksBttn;
        private System.Windows.Forms.Button LogInBttnMainMenu;
        private System.Windows.Forms.Label LogInLbl;
        private System.Windows.Forms.Button returnBooksBttn;
    }
}

