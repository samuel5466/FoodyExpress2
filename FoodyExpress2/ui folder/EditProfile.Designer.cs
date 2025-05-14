namespace FoodyExpress2
{
    partial class EditProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEditprofile = new System.Windows.Forms.Label();
            this.lblnewUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.newFirstname = new System.Windows.Forms.Label();
            this.newLastname = new System.Windows.Forms.Label();
            this.newDob = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblEditprofile
            // 
            this.lblEditprofile.AutoSize = true;
            this.lblEditprofile.Location = new System.Drawing.Point(120, 47);
            this.lblEditprofile.Name = "lblEditprofile";
            this.lblEditprofile.Size = new System.Drawing.Size(86, 20);
            this.lblEditprofile.TabIndex = 0;
            this.lblEditprofile.Text = "Edit-Profile";
            // 
            // lblnewUsername
            // 
            this.lblnewUsername.AutoSize = true;
            this.lblnewUsername.Location = new System.Drawing.Point(10, 89);
            this.lblnewUsername.Name = "lblnewUsername";
            this.lblnewUsername.Size = new System.Drawing.Size(83, 20);
            this.lblnewUsername.TabIndex = 1;
            this.lblnewUsername.Text = "Username";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(249, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // newFirstname
            // 
            this.newFirstname.AutoSize = true;
            this.newFirstname.Location = new System.Drawing.Point(13, 140);
            this.newFirstname.Name = "newFirstname";
            this.newFirstname.Size = new System.Drawing.Size(80, 20);
            this.newFirstname.TabIndex = 4;
            this.newFirstname.Text = "Firstname";
            // 
            // newLastname
            // 
            this.newLastname.AutoSize = true;
            this.newLastname.Location = new System.Drawing.Point(13, 194);
            this.newLastname.Name = "newLastname";
            this.newLastname.Size = new System.Drawing.Size(80, 20);
            this.newLastname.TabIndex = 5;
            this.newLastname.Text = "Lastname";
            // 
            // newDob
            // 
            this.newDob.AutoSize = true;
            this.newDob.Location = new System.Drawing.Point(54, 243);
            this.newDob.Name = "newDob";
            this.newDob.Size = new System.Drawing.Size(39, 20);
            this.newDob.TabIndex = 6;
            this.newDob.Text = "Dob";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(108, 83);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(141, 26);
            this.txtusername.TabIndex = 7;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(108, 188);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(141, 26);
            this.txtlastname.TabIndex = 8;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(108, 134);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(141, 26);
            this.txtfirstname.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(34, 26);
            this.textBox4.TabIndex = 10;
            // 
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(148, 237);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(176, 26);
            this.dtpdob.TabIndex = 11;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.newDob);
            this.Controls.Add(this.newLastname);
            this.Controls.Add(this.newFirstname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblnewUsername);
            this.Controls.Add(this.lblEditprofile);
            this.Name = "EditProfile";
            this.Size = new System.Drawing.Size(341, 387);
            //this.Load += new System.EventHandler(this.EditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditprofile;
        private System.Windows.Forms.Label lblnewUsername;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label newFirstname;
        private System.Windows.Forms.Label newLastname;
        private System.Windows.Forms.Label newDob;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dtpdob;
    }
}
