using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemis
{
    public partial class ModelsControl : UserControl
    {
        public ModelsControl()
        {
            InitializeComponent();
            panel25.Visible = false;
            panel25.Enabled = false;
            panel1.Visible = false;
            panel1.Enabled = false;
            panel3.Visible = false;
            panel3.Enabled = false;
            panel5.Enabled = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel7.Enabled = false;
            panel9.Visible = false;
            panel9.Enabled = false;
            panel13.Visible = false;
            panel13.Enabled = false;
            panel11.Visible = false;
            panel11.Enabled = false;
        }

        private void shadowLabel4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel25.Visible = true;
            panel25.Enabled = true;
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button12.BackColor = clr1;
            panel25.Visible = false;
            panel25.Enabled = false;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel26.BackColor = clr1; // preview panel for button 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button1.BackColor = clr1;
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel2.BackColor = clr1; // preview panel for button 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Enabled = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button2.BackColor = clr1;
            panel3.Visible = false;
            panel3.Enabled = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel4.BackColor = clr1; // preview panel for button 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.Enabled = true;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button3.BackColor = clr1;
            panel5.Visible = false;
            panel5.Enabled = false;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox3.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel6.BackColor = clr1; // preview panel for button
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel7.Enabled = true;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox4.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button5.BackColor = clr1;
            panel7.Visible = false;
            panel7.Enabled = false;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel8.BackColor = clr1; // preview panel for button
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel9.Enabled = true;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox5.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button4.BackColor = clr1;
            panel9.Visible = false;
            panel9.Enabled = false;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox5.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel10.BackColor = clr1; // preview panel for button
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel11.Enabled = true;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox6.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button6.BackColor = clr1;
            panel11.Visible = false;
            panel11.Enabled = false;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox6.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel12.BackColor = clr1; // preview panel for button
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
            panel13.Enabled = true;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button7.BackColor = clr1;
            panel13.Visible = false;
            panel13.Enabled = false;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox6.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel14.BackColor = clr1; // preview panel for button
        }
    }
}
