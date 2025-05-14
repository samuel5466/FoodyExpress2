namespace FoodyExpress2
{
    partial class Changepassword
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
            this.btnChangepassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOldpassword = new System.Windows.Forms.Label();
            this.lblnewPassword = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.lblChangepassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangepassword
            // 
            this.btnChangepassword.BackColor = System.Drawing.Color.SandyBrown;
            this.btnChangepassword.FlatAppearance.BorderSize = 0;
            this.btnChangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangepassword.Location = new System.Drawing.Point(155, 243);
            this.btnChangepassword.Name = "btnChangepassword";
            this.btnChangepassword.Size = new System.Drawing.Size(85, 53);
            this.btnChangepassword.TabIndex = 1;
            this.btnChangepassword.Text = "Change";
            this.btnChangepassword.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 26);
            this.textBox2.TabIndex = 3;
            // 
            // lblOldpassword
            // 
            this.lblOldpassword.AutoSize = true;
            this.lblOldpassword.Location = new System.Drawing.Point(39, 106);
            this.lblOldpassword.Name = "lblOldpassword";
            this.lblOldpassword.Size = new System.Drawing.Size(101, 20);
            this.lblOldpassword.TabIndex = 4;
            this.lblOldpassword.Text = "Oldpassword";
            // 
            // lblnewPassword
            // 
            this.lblnewPassword.AutoSize = true;
            this.lblnewPassword.Location = new System.Drawing.Point(32, 178);
            this.lblnewPassword.Name = "lblnewPassword";
            this.lblnewPassword.Size = new System.Drawing.Size(108, 20);
            this.lblnewPassword.TabIndex = 5;
            this.lblnewPassword.Text = "Newpassword";
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(354, 13);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 43);
            this.btnClose2.TabIndex = 6;
            this.btnClose2.Text = "❌";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // lblChangepassword
            // 
            this.lblChangepassword.AutoSize = true;
            this.lblChangepassword.Location = new System.Drawing.Point(136, 36);
            this.lblChangepassword.Name = "lblChangepassword";
            this.lblChangepassword.Size = new System.Drawing.Size(137, 20);
            this.lblChangepassword.TabIndex = 7;
            this.lblChangepassword.Text = "Change password";
            this.lblChangepassword.Click += new System.EventHandler(this.lblChangepassword_Click);
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.lblChangepassword);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.lblnewPassword);
            this.Controls.Add(this.lblOldpassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChangepassword);
            this.Name = "Changepassword";
            this.Size = new System.Drawing.Size(445, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangepassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOldpassword;
        private System.Windows.Forms.Label lblnewPassword;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label lblChangepassword;
    }
}
