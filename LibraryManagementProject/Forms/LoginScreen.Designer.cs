namespace LibraryManagementProject
{
    partial class LoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.UserIDTxtBox = new System.Windows.Forms.TextBox();
            this.LogInBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please log in to use the features of the library management system";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDLbl.Location = new System.Drawing.Point(147, 179);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(26, 18);
            this.IDLbl.TabIndex = 1;
            this.IDLbl.Text = "ID:";
            // 
            // UserIDTxtBox
            // 
            this.UserIDTxtBox.Location = new System.Drawing.Point(179, 177);
            this.UserIDTxtBox.Name = "UserIDTxtBox";
            this.UserIDTxtBox.Size = new System.Drawing.Size(472, 20);
            this.UserIDTxtBox.TabIndex = 2;
            // 
            // LogInBttn
            // 
            this.LogInBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogInBttn.Location = new System.Drawing.Point(673, 384);
            this.LogInBttn.Name = "LogInBttn";
            this.LogInBttn.Size = new System.Drawing.Size(115, 54);
            this.LogInBttn.TabIndex = 3;
            this.LogInBttn.Text = "Log In";
            this.LogInBttn.UseVisualStyleBackColor = true;
            this.LogInBttn.Click += new System.EventHandler(this.LogInBttn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogInBttn);
            this.Controls.Add(this.UserIDTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox UserIDTxtBox;
        private System.Windows.Forms.Button LogInBttn;
    }
}