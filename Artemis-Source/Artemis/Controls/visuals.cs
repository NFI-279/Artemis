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
    public partial class visuals : UserControl
    {
        public visuals()
        {
            InitializeComponent();
            modelsControl1.Hide();
            visualsmisc1.Hide();
            button6.ForeColor = Color.FromArgb(115, 112, 151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
            // panel1.Visible = false;
            panel1.Size = new Size(28, 2);
            panel1.Location = new Point(54, 40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(28, 2);
            panel1.Location = new Point(54, 40);
            modelsControl1.Hide();
            espcontrol1.Show();
            visualsmisc1.Hide();
            button5.ForeColor = Color.FromArgb(211, 204, 245);
            button6.ForeColor = Color.FromArgb(115, 112, 151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modelsControl1.Show();
            panel1.Size = new Size(64, 2);
            panel1.Location = new Point(166, 40);
            espcontrol1.Hide();
            visualsmisc1.Hide();
            button6.ForeColor = Color.FromArgb(211, 204, 245);
            button5.ForeColor = Color.FromArgb(115, 112, 151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(37, 2);
            panel1.Location = new Point(310, 40);
            visualsmisc1.Show();
            modelsControl1.Hide();
            espcontrol1.Hide();
            button7.ForeColor = Color.FromArgb(211, 204, 245);
            button6.ForeColor = Color.FromArgb(115, 112, 151);
            button5.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
