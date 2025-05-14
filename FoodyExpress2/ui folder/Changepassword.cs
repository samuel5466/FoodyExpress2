using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodyExpress2
{
    public partial class Changepassword: UserControl
    {
        private bool isDragging = false;
        private Point mouseStartPos;
        public Changepassword()
        {
            InitializeComponent();
            this.MouseDown += EditProfile_MouseDown;
            this.MouseMove += EditProfile_MouseMove;
            this.MouseUp += EditProfile_MouseUp;
        }

        private void EditProfile_MouseDown(object sender, MouseEventArgs e)
        {
            // If the user clicks on the UserControl, mark that dragging started
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseStartPos = e.Location; // Store the starting position of the mouse
            }
        }
        private void EditProfile_MouseMove(object sender, MouseEventArgs e)
        {
            // If the user is dragging, move the control
            if (isDragging)
            {
                // Calculate the distance the mouse has moved
                var deltaX = e.X - mouseStartPos.X;
                var deltaY = e.Y - mouseStartPos.Y;

                // Set the new position of the UserControl
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }
        private void EditProfile_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when the user releases the mouse button
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lblChangepassword_Click(object sender, EventArgs e)
        {

        }
    }
}
