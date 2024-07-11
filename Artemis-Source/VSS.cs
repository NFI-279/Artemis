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
using System.Diagnostics;
using System.IO;

namespace Artemis_Loader
{
    public partial class VSS : Form
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
        public void CenterLabel(Label label, Panel parent)
        {
            int x = (parent.Size.Width - label.Size.Width) / 2;
            label.Location = new Point(x, label.Location.Y);
        }
        public VSS(string value)
        {
            InitializeComponent();
            CenterLabel(outlineLabel1, panel1);
            timer1.Interval = 2000;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();
            label2.Text = "";
            label3.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button1.ForeColor = Color.FromArgb(195, 23, 87);
            button4.ForeColor = Color.FromArgb(211, 204, 245);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
            button3.ForeColor = Color.FromArgb(211, 204, 245);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(195, 23, 87);
            button1.ForeColor = Color.FromArgb(211, 204, 245);
            button2.Visible = button2.Enabled = true; button2.ForeColor = Color.FromArgb(211, 204, 245);
            button3.Visible = button3.Enabled = false; button3.ForeColor = Color.FromArgb(211, 204, 245);
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

        private void outlineLabel1_Click(object sender, EventArgs e)
        {

        }

        private void VSS_Load(object sender, EventArgs e)
        {
        }
        public int totalseconds = 300;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(totalseconds==300)
                label2.Text = "5 minutes";
            if (totalseconds == 240)
                label2.Text = "4 minutes";
            else if(totalseconds == 180)
                label2.Text = "3 minutes";
            else if(totalseconds == 120)
                label2.Text = "2 minutes";
            else if(totalseconds == 60)
                label2.Text = "1 minute";
            if (totalseconds == 0)
                this.Close();
            totalseconds--;
        }

        private void VSS_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void VSS_MouseMove(object sender, MouseEventArgs e)
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {
            // Initially, the project had a local DB which was used to check the database for when the user tries to log in, currently removed due to not being secure or a proper online hosted db
            // string trace1 = @"C:\Users\lehom\source\repos\Artemis\bin\Debug\Artemis.exe"; Process process = new Process(); process.StartInfo.FileName = trace1; process.Start(); this.Close();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.2;
            else
            {
                // Assuming Artemis.exe is in the same directory as Artemis-Loader.exe
                string artemisExePath = Path.Combine(Application.StartupPath, "Artemis.exe");

                if (File.Exists(artemisExePath))
                {
                    Process.Start(artemisExePath);
                }
                else
                {
                    MessageBox.Show("Artemis.exe not found. Please ensure it is built and located in the correct directory.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        private void VSS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            e.Handled = true;
        }
    }
}
