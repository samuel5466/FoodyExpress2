namespace FoodyExpress2
{
    partial class MainForm
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.lnkChangepassword = new System.Windows.Forms.LinkLabel();
            this.lnkEditProfile = new System.Windows.Forms.LinkLabel();
            this.tabManageDrivers = new System.Windows.Forms.TabPage();
            this.tabManageMenu = new System.Windows.Forms.TabPage();
            this.tabViewOrders = new System.Windows.Forms.TabPage();
            this.tabAssignedOrders = new System.Windows.Forms.TabPage();
            this.tabDeliveryHistory = new System.Windows.Forms.TabPage();
            this.tabBrowseMenu = new System.Windows.Forms.TabPage();
            this.tabMyOrders = new System.Windows.Forms.TabPage();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Green;
            this.lbltitle.Location = new System.Drawing.Point(258, 78);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(424, 45);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Welcome to Foody Express";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(401, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(401, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(401, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(297, 192);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(302, 249);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabProfile);
            this.tabControlMain.Controls.Add(this.tabManageDrivers);
            this.tabControlMain.Controls.Add(this.tabManageMenu);
            this.tabControlMain.Controls.Add(this.tabViewOrders);
            this.tabControlMain.Controls.Add(this.tabAssignedOrders);
            this.tabControlMain.Controls.Add(this.tabDeliveryHistory);
            this.tabControlMain.Controls.Add(this.tabBrowseMenu);
            this.tabControlMain.Controls.Add(this.tabMyOrders);
            this.tabControlMain.Controls.Add(this.tabCart);
            this.tabControlMain.Location = new System.Drawing.Point(2, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(948, 481);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.Visible = false;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lnkChangepassword);
            this.tabProfile.Controls.Add(this.lnkEditProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 29);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(940, 448);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // lnkChangepassword
            // 
            this.lnkChangepassword.AutoSize = true;
            this.lnkChangepassword.Location = new System.Drawing.Point(655, 28);
            this.lnkChangepassword.Name = "lnkChangepassword";
            this.lnkChangepassword.Size = new System.Drawing.Size(137, 20);
            this.lnkChangepassword.TabIndex = 2;
            this.lnkChangepassword.TabStop = true;
            this.lnkChangepassword.Text = "Change password";
            this.lnkChangepassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangepassword_LinkClicked);
            // 
            // lnkEditProfile
            // 
            this.lnkEditProfile.AutoSize = true;
            this.lnkEditProfile.Location = new System.Drawing.Point(17, 22);
            this.lnkEditProfile.Name = "lnkEditProfile";
            this.lnkEditProfile.Size = new System.Drawing.Size(85, 20);
            this.lnkEditProfile.TabIndex = 1;
            this.lnkEditProfile.TabStop = true;
            this.lnkEditProfile.Text = "Edit Profile";
            this.lnkEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditProfile_LinkClicked);
            // 
            // tabManageDrivers
            // 
            this.tabManageDrivers.Location = new System.Drawing.Point(4, 29);
            this.tabManageDrivers.Name = "tabManageDrivers";
            this.tabManageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageDrivers.Size = new System.Drawing.Size(940, 448);
            this.tabManageDrivers.TabIndex = 1;
            this.tabManageDrivers.Text = "Manage Drivers";
            this.tabManageDrivers.UseVisualStyleBackColor = true;
            // 
            // tabManageMenu
            // 
            this.tabManageMenu.Location = new System.Drawing.Point(4, 29);
            this.tabManageMenu.Name = "tabManageMenu";
            this.tabManageMenu.Size = new System.Drawing.Size(940, 448);
            this.tabManageMenu.TabIndex = 2;
            this.tabManageMenu.Text = "Manage menu";
            this.tabManageMenu.UseVisualStyleBackColor = true;
            // 
            // tabViewOrders
            // 
            this.tabViewOrders.Location = new System.Drawing.Point(4, 29);
            this.tabViewOrders.Name = "tabViewOrders";
            this.tabViewOrders.Size = new System.Drawing.Size(940, 448);
            this.tabViewOrders.TabIndex = 3;
            this.tabViewOrders.Text = "Veiw order";
            this.tabViewOrders.UseVisualStyleBackColor = true;
            // 
            // tabAssignedOrders
            // 
            this.tabAssignedOrders.Location = new System.Drawing.Point(4, 29);
            this.tabAssignedOrders.Name = "tabAssignedOrders";
            this.tabAssignedOrders.Size = new System.Drawing.Size(940, 448);
            this.tabAssignedOrders.TabIndex = 4;
            this.tabAssignedOrders.Text = "Assigned order";
            this.tabAssignedOrders.UseVisualStyleBackColor = true;
            // 
            // tabDeliveryHistory
            // 
            this.tabDeliveryHistory.Location = new System.Drawing.Point(4, 29);
            this.tabDeliveryHistory.Name = "tabDeliveryHistory";
            this.tabDeliveryHistory.Size = new System.Drawing.Size(940, 448);
            this.tabDeliveryHistory.TabIndex = 5;
            this.tabDeliveryHistory.Text = "Delivery history";
            this.tabDeliveryHistory.UseVisualStyleBackColor = true;
            // 
            // tabBrowseMenu
            // 
            this.tabBrowseMenu.Location = new System.Drawing.Point(4, 29);
            this.tabBrowseMenu.Name = "tabBrowseMenu";
            this.tabBrowseMenu.Size = new System.Drawing.Size(940, 448);
            this.tabBrowseMenu.TabIndex = 6;
            this.tabBrowseMenu.Text = "Browse menu";
            this.tabBrowseMenu.UseVisualStyleBackColor = true;
            // 
            // tabMyOrders
            // 
            this.tabMyOrders.Location = new System.Drawing.Point(4, 29);
            this.tabMyOrders.Name = "tabMyOrders";
            this.tabMyOrders.Size = new System.Drawing.Size(940, 448);
            this.tabMyOrders.TabIndex = 7;
            this.tabMyOrders.Text = "My orders";
            this.tabMyOrders.UseVisualStyleBackColor = true;
            // 
            // tabCart
            // 
            this.tabCart.Location = new System.Drawing.Point(4, 29);
            this.tabCart.Name = "tabCart";
            this.tabCart.Size = new System.Drawing.Size(940, 448);
            this.tabCart.TabIndex = 8;
            this.tabCart.Text = "Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(868, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 53);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.lblPassword);
            this.LoginPanel.Controls.Add(this.lblUsername);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.txtUsername);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.lbltitle);
            this.LoginPanel.Location = new System.Drawing.Point(834, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(114, 481);
            this.LoginPanel.TabIndex = 3;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 479);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tabControlMain.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabManageDrivers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabManageMenu;
        private System.Windows.Forms.TabPage tabViewOrders;
        private System.Windows.Forms.TabPage tabAssignedOrders;
        private System.Windows.Forms.TabPage tabDeliveryHistory;
        private System.Windows.Forms.TabPage tabBrowseMenu;
        private System.Windows.Forms.TabPage tabMyOrders;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.LinkLabel lnkEditProfile;
        private System.Windows.Forms.LinkLabel lnkChangepassword;
        private System.Windows.Forms.Panel LoginPanel;
    }
}

