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
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           // Bitmap pixelData = (Bitmap)pictureBox1.Image;
           // Color clr1 = pixelData.GetPixel(e.X, e.Y);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
            panel1.BackColor = clr1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr1 = pixeldata.GetPixel(e.X, e.Y);
        }
    }
}
