using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemis.Controls
{
    public partial class visualsmisc : UserControl
    {
        public visualsmisc()
        {
            InitializeComponent();
            panel25.Visible = false;
            panel25.Enabled = false;
            panel1.Enabled = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel25.Visible = true;
            panel25.Enabled = true;
            skeetGroupBox2.Enabled = false; skeetGroupBox2.Visible = false;
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button1.BackColor = clr1;
            panel25.Visible = false;
            panel25.Enabled = false;
            skeetGroupBox2.Enabled = true; skeetGroupBox2.Visible = true;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel26.BackColor = clr1; // preview panel for button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            skeetGroupBox2.Enabled = false; skeetGroupBox2.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button2.BackColor = clr1;
            panel1.Visible = false;
            panel1.Enabled = false;
            skeetGroupBox2.Enabled = true; skeetGroupBox2.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel2.BackColor = clr1; // preview panel for button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            panel3.Visible = true;
            skeetGroupBox2.Enabled = false; skeetGroupBox2.Visible = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox2.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button3.BackColor = clr1;
            panel3.Visible = false;
            panel3.Enabled = false;
            skeetGroupBox2.Enabled = true; skeetGroupBox2.Visible = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox2.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel4.BackColor = clr1; // preview panel for button
        }
    }
}
