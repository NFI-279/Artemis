using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Artemis_Loader
{
    public partial class Loader : Form
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
        public void CenterTB(TextBox textbox, Panel parent) // by width
        {
            int x = (parent.Size.Width - textbox.Size.Width) / 2;
           // int y = (parent.Size.Height - textbox.Size.Height) / 2;
            textbox.Location = new Point(x, textBox1.Location.Y);
        }
        public void CenterBT(Button button, Panel parent)
        {
            int x = (parent.Size.Width - button.Size.Width) / 2;
             int y = (parent.Size.Height - button.Size.Height) / 2;
            button.Location = new Point(x,y);
        }
        public Loader()
        {
            InitializeComponent();
            CenterLabel(outlineLabel1, panel1);
            textBox1.Anchor = AnchorStyles.None;
            CenterTB(textBox1, panel2);
            shadowLabel2.Width = shadowLabel1.Width = 64;
            shadowLabel1.Height = shadowLabel2.Height = 20;

            shadowLabel1.Location = new Point(textBox1.Location.X-5 , textBox1.Location.Y - 25);
            textBox2.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 60);
            shadowLabel2.Location = new Point(textBox2.Location.X - 3, textBox2.Location.Y - 25);
            int x = (panel2.Size.Width - skeetButton1.Size.Width)/ 2;
            skeetButton1.Location = new Point(x, textBox2.Location.Y + 80);//+50
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Loader_Load(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {
            /* This was previously connected to a local DB, whihc was removed.
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Db\BazaDate.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "Select * from Table Where username = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    timer1.Start();
                    //this.Hide(); shadowLabel3.Visible = false; VSS x = new VSS(textBox1.Text); x.Show();
                }
                else
                {
                    shadowLabel3.Location = new Point(skeetButton1.Location.X, skeetButton1.Location.Y - 35);
                    shadowLabel3.Visible = true;
                }
            */
            if(true)
            {
                timer1.Start();
                //this.Hide(); shadowLabel3.Visible = false; VSS x = new VSS(textBox1.Text); x.Show();
            }
        }

        private void Loader_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Loader_MouseMove(object sender, MouseEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.2;
            else
            {
                timer1.Stop();
                this.Hide();
                shadowLabel3.Visible = false;
                VSS x = new VSS(textBox1.Text);
                x.Show();
            }
        }
       
       
        private void Loader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            e.Handled = true;
        }

        private void Loader_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
