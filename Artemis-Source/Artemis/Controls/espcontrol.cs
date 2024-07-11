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
    public partial class espcontrol : UserControl
    {
        public espcontrol()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel1.Enabled = false;
            panel3.Visible = false;
            panel3.Enabled = false;
            panel5.Visible = false;
            panel5.Enabled = false;
            panel7.Visible = false;
            panel7.Enabled = false;
            panel9.Visible = false;
            panel9.Enabled = false;
            panel11.Visible = false;
            panel11.Enabled = false;
            panel13.Visible = false;
            panel13.Enabled = false;
            panel15.Visible = false;
            panel15.Enabled = false;
            panel17.Visible = false;
            panel17.Enabled = false;
            panel19.Visible = false;
            panel19.Enabled = false;
            panel21.Visible = false;
            panel21.Enabled = false;
            panel23.Visible = false;
            panel23.Enabled = false;
            panel25.Visible = false;
            panel25.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void espcontrol_Load(object sender, EventArgs e)
        {

        }

        private void shadowLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel2.BackColor = clr1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button1.BackColor = clr1;
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void skeetToggle9_CheckedChanged(object sender)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Enabled = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e) // button 2
        {
            Bitmap pixeldata = (Bitmap)pictureBox2.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel4.BackColor = clr1; // preview panel for button 2
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox2.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button2.BackColor = clr1;
            panel3.Visible = false;
            panel3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) // button 3
        {
            panel5.Visible = true;
            panel5.Enabled = true;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox3.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button3.BackColor = clr1;
            panel5.Visible = false;
            panel5.Enabled = false;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox3.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel6.BackColor = clr1; // preview panel for button 3
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox4.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button4.BackColor = clr1;
            panel7.Visible = false;
            panel7.Enabled = false;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox4.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel8.BackColor = clr1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel7.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel9.Enabled = true;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox5.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button5.BackColor = clr1;
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

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_MouseDown_1(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox5.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button5.BackColor = clr1;
            panel9.Visible = false;
            panel9.Enabled = false;
        }

        private void pictureBox5_MouseMove_1(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox5.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel10.BackColor = clr1; // preview panel for button 
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
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel14.BackColor = clr1; // preview panel for button 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel15.Enabled = true;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox8.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button8.BackColor = clr1;
            panel15.Visible = false;
            panel15.Enabled = false;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel16.BackColor = clr1; // preview panel for button 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel17.Visible = true;
            panel17.Enabled = true;
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox9.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button9.BackColor = clr1;
            panel17.Visible = false;
            panel17.Enabled = false;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel18.BackColor = clr1; // preview panel for button 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;
            panel19.Enabled = true;
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox10.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button10.BackColor = clr1;
            panel19.Visible = false;
            panel19.Enabled = false;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel20.BackColor = clr1; // preview panel for button 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel21.Visible = true;
            panel21.Enabled = true;
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox11.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button11.BackColor = clr1;
            panel21.Visible = false;
            panel21.Enabled = false;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel22.BackColor = clr1; // preview panel for button 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel23.Visible = true;
            panel23.Enabled = true;
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox11.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button12.BackColor = clr1;
            panel23.Visible = false;
            panel23.Enabled = false;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox7.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel24.BackColor = clr1; // preview panel for button 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel25.Visible = true;
            panel25.Enabled = true;
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox13.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            button13.BackColor = clr1;
            panel25.Visible = false;
            panel25.Enabled = false;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox3.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel26.BackColor = clr1; // preview panel for button 
        }
    }
}