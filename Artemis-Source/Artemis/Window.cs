using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemis
{
    public partial class Window : Form
    {
        private Point lastpoint;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public Window()
        {
            InitializeComponent();
            visuals1.Hide();
            miscControl1.Hide();
            inventoryControl1.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            rage1.Location = miscControl1.Location;
            inventoryControl1.Location = miscControl1.Location;
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        { 
        }
        private void Window_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {}
        private void button2_Click(object sender, EventArgs e)
        {}
        private void button3_Click(object sender, EventArgs e)
        {}
        private void button4_Click(object sender, EventArgs e)
        {}
        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button1.ForeColor = Color.FromArgb(211, 204, 245);
            //   panel2.Size = new Size(79, 1);
            // panel2.Location = new Point(143, 67); // 16 def b1
            visuals1.Hide();
            miscControl1.Hide();
            inventoryControl1.Hide();
            rage1.Show();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
           // panel2.Size = new Size(118, 1);
           // panel2.Location = new Point(228, 67);
            rage1.Hide();
            miscControl1.Hide();
            inventoryControl1.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(211, 204, 245);
           // panel2.Size = new Size(118, 1);
           // panel2.Location = new Point(405, 63);
            rage1.Hide();
            inventoryControl1.Hide();
            miscControl1.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(211, 204, 245);
           // panel2.Size = new Size(148, 1);
           // panel2.Location = new Point(524, 63);
            rage1.Hide();
            miscControl1.Hide();
            inventoryControl1.Show();
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
           // panel2.Size = new Size(118, 1);
          //  panel2.Location = new Point(281, 63);
            rage1.Hide();
            visuals1.Hide();
            miscControl1.Hide();
            inventoryControl1.Hide();
        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            //misc
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(211, 204, 245);
           // panel2.Size = new Size(118, 1);
           // panel2.Location = new Point(405, 63);
            rage1.Hide();
            visuals1.Hide();
            inventoryControl1.Hide();
            miscControl1.Show();
        }
        private void button4_Click_2(object sender, EventArgs e)
        {
            //inventory
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(211, 204, 245);
            // panel2.Size = new Size(148, 1);
            // panel2.Location = new Point(524, 63);
            visuals1.Hide();
            rage1.Hide();
            miscControl1.Hide();
            inventoryControl1.Show();
        }
        private void button2_Click_3(object sender, EventArgs e)
        {
            //visuals
            visuals1.Show();
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button3.ForeColor = Color.FromArgb(99, 95, 135);
            button4.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
            //panel2.Size = new Size(118, 1);
           // panel2.Location = new Point(281, 63);
            rage1.Hide();
            miscControl1.Hide();
            inventoryControl1.Hide();
        }
        private void miscControl1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
