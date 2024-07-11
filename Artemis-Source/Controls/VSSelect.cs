using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemis_Loader
{
    public partial class VSSelect : UserControl
    {
        public VSSelect()
        {
            InitializeComponent();
            button2.Visible = button3.Visible = false;
            button2.Enabled = button3.Enabled = false;
        }

        private void VSSelect_Load(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button1.ForeColor = Color.FromArgb(195, 23, 87);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(195, 23, 87);
            button3.ForeColor = Color.FromArgb(211, 204, 245);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(211, 204, 245);
            button3.ForeColor = Color.FromArgb(195, 23, 87);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(195, 23, 87);
            button1.ForeColor = Color.FromArgb(211, 204, 245);
            button2.Visible = button2.Enabled = true;
            button3.Visible = button3.Enabled = false;
        }
    }
}
