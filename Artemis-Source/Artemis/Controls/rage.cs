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
    public partial class rage : UserControl
    {
        public rage()
        {
            InitializeComponent();
            rageantiaim1.Hide();
            rageWeapons1.Hide();
            button6.ForeColor = Color.FromArgb(115,112,151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
            // panel1.Visible = false;
            panel1.Size = new Size(62, 2);
            panel1.Location = new Point(36, 40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rageantiaim1.Hide();
            rageWeapons1.Hide(); 
            rageaimbot1.Show();
            panel1.Size = new Size(62, 2);
            panel1.Location = new Point(36, 40);
            button5.ForeColor = Color.FromArgb(211, 204, 245);
            button6.ForeColor = Color.FromArgb(115, 112, 151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rageaimbot1.Hide();
            rageWeapons1.Hide();
            rageantiaim1.Show();
            panel1.Size = new Size(73, 2);
            panel1.Location = new Point(161, 40);
            button6.ForeColor = Color.FromArgb(211, 204, 245);
            button5.ForeColor = Color.FromArgb(115, 112, 151);
            button7.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rageWeapons1.Show();
            rageaimbot1.Hide();
            rageantiaim1.Hide();
            panel1.Size = new Size(76, 2);
            panel1.Location = new Point(290, 40);
            button7.ForeColor = Color.FromArgb(211, 204, 245);
            button6.ForeColor = Color.FromArgb(115, 112, 151);
            button5.ForeColor = Color.FromArgb(115, 112, 151);
        }

        private void rage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
