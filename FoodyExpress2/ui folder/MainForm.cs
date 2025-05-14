using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FoodyExpress2.DB;
using static FoodyExpress2.DB.DBConnection;



namespace FoodyExpress2
{
    
    public partial class MainForm : Form
    {

        private EditProfile editProfileControl;
        private Changepassword changePasswordControl;
       //private RegistrationControl registrationControl;
       


        public MainForm()
        {
            InitializeComponent();
            LoginPanel.BringToFront();
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlMain.Visible = false;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;

            // Also hide any labels used for login
            lblUsername.Visible = true; // E.g., "Username:"
            lblPassword.Visible = true; // E.g., "Password:"

            this.ActiveControl = txtUsername; // 👈 This makes Enter work right away

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                string userRole = UserRepository.GetUserRole(username, password);

                if (userRole != null)
                {
                    MessageBox.Show($"Welcome, {username} ({userRole})", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginPanel.SendToBack();
                    tabControlMain.Visible = true;
                    tabControlMain.BringToFront();
                    btnLogout.BringToFront();
                    tabControlMain.SelectedIndex = 0;
                    tabControlMain.TabPages.Clear();

                    this.Text = $"{char.ToUpper(username[0]) + username.Substring(1)} Page";
                    tabControlMain.TabPages.Add(tabProfile);

                    if (userRole == "admin")
                    {
                        tabControlMain.TabPages.Add(tabManageDrivers);
                        tabControlMain.TabPages.Add(tabManageMenu);
                        tabControlMain.TabPages.Add(tabViewOrders);
                    }
                    else if (userRole == "driver")
                    {
                        tabControlMain.TabPages.Add(tabAssignedOrders);
                        tabControlMain.TabPages.Add(tabDeliveryHistory);
                    }
                    else if (userRole == "customer")
                    {
                        tabControlMain.TabPages.Add(tabBrowseMenu);
                        tabControlMain.TabPages.Add(tabMyOrders);
                        tabControlMain.TabPages.Add(tabCart);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hide the TabControl
            tabControlMain.Visible = false;
            tabControlMain.Controls.Clear();
            // Show login controls again
            LoginPanel.Visible = true;
            LoginPanel.BringToFront();
            // Reset input fields
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();

            // Reset title
            this.Text = "Login Page";

            // Hide any visible user controls in the profile tab
            if (editProfileControl != null)
                editProfileControl.Visible = false;

            if (changePasswordControl != null)
                changePasswordControl.Visible = false;

            // You can also reset the selected tab if needed
            tabControlMain.SelectedIndex = 0;

            // Keep the tabs as they are or clear and just re-add profile
            tabControlMain.TabPages.Clear();
            tabControlMain.TabPages.Add(tabProfile);
        }



        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // If both fields are empty, focus on username
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Focus();
                }
                // If username filled but password empty, focus on password
                else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Focus();
                }
                // If both filled, simulate login button click
                else
                {
                    btnLogin.PerformClick();
                }

                // Prevent the default Enter key beep
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void lnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (changePasswordControl != null && changePasswordControl.Visible)
                changePasswordControl.Visible = false;

            // Show or create EditProfile
            if (editProfileControl == null)
            {
                editProfileControl = new EditProfile();
                editProfileControl.Location = new Point(20, 50);
                tabProfile.Controls.Add(editProfileControl);
            }

            editProfileControl.Visible = true;
        }

        private void lnkChangepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (editProfileControl != null && editProfileControl.Visible)
                editProfileControl.Visible = false;

            // Show or create ChangePassword
            if (changePasswordControl == null)
            {
                changePasswordControl = new Changepassword();
                changePasswordControl.Location = new Point(20, 50);
                tabProfile.Controls.Add(changePasswordControl);
            }

            changePasswordControl.Visible = true;
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
