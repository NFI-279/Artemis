
namespace Artemis_Loader
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.outlineLabel1 = new SkeetFramework.outlineLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shadowLabel3 = new SkeetFramework.shadowLabel();
            this.shadowLabel1 = new SkeetFramework.shadowLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.shadowLabel2 = new SkeetFramework.shadowLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skeetButton1 = new SkeetFramework.SkeetButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.outlineLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 96);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // outlineLabel1
            // 
            this.outlineLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineLabel1.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.outlineLabel1.Location = new System.Drawing.Point(139, 42);
            this.outlineLabel1.Name = "outlineLabel1";
            this.outlineLabel1.OutlineForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.outlineLabel1.OutlineWidth = 5F;
            this.outlineLabel1.Size = new System.Drawing.Size(122, 38);
            this.outlineLabel1.TabIndex = 15;
            this.outlineLabel1.Text = "ARTEMIS";
            this.outlineLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 3);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(54)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.shadowLabel3);
            this.panel2.Controls.Add(this.shadowLabel1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.shadowLabel2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.skeetButton1);
            this.panel2.Location = new System.Drawing.Point(16, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 305);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // shadowLabel3
            // 
            this.shadowLabel3.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel3.EnableShadow = false;
            this.shadowLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel3.Font = new System.Drawing.Font("Josefin Sans Medium", 10F, System.Drawing.FontStyle.Bold);
            this.shadowLabel3.ForeColor = System.Drawing.Color.White;
            this.shadowLabel3.Location = new System.Drawing.Point(125, 254);
            this.shadowLabel3.Name = "shadowLabel3";
            this.shadowLabel3.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel3.ShadowOffset = 1;
            this.shadowLabel3.Size = new System.Drawing.Size(136, 22);
            this.shadowLabel3.TabIndex = 9;
            this.shadowLabel3.Text = "Incorrect credentials";
            this.shadowLabel3.Visible = false;
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.AutoSize = true;
            this.shadowLabel1.EnableShadow = true;
            this.shadowLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel1.Font = new System.Drawing.Font("Josefin Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.White;
            this.shadowLabel1.Location = new System.Drawing.Point(98, 67);
            this.shadowLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.shadowLabel1.ShadowOffset = 3;
            this.shadowLabel1.Size = new System.Drawing.Size(69, 20);
            this.shadowLabel1.TabIndex = 8;
            this.shadowLabel1.Text = "Username";
            this.shadowLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Josefin Sans Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(89, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(212, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shadowLabel2
            // 
            this.shadowLabel2.AutoSize = true;
            this.shadowLabel2.EnableShadow = true;
            this.shadowLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel2.Font = new System.Drawing.Font("Josefin Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel2.ForeColor = System.Drawing.Color.White;
            this.shadowLabel2.Location = new System.Drawing.Point(98, 137);
            this.shadowLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.shadowLabel2.Name = "shadowLabel2";
            this.shadowLabel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.shadowLabel2.ShadowOffset = 3;
            this.shadowLabel2.Size = new System.Drawing.Size(64, 20);
            this.shadowLabel2.TabIndex = 6;
            this.shadowLabel2.Text = "Password";
            this.shadowLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Josefin Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(89, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // skeetButton1
            // 
            this.skeetButton1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.skeetButton1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.skeetButton1.Font = new System.Drawing.Font("Josefin Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.skeetButton1.Location = new System.Drawing.Point(129, 214);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(124, 23);
            this.skeetButton1.TabIndex = 2;
            this.skeetButton1.Text = "Login";
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(424, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Loader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artemis Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loader_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Loader_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Loader_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SkeetFramework.outlineLabel outlineLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private SkeetFramework.SkeetButton skeetButton1;
        private System.Windows.Forms.TextBox textBox2;
        private SkeetFramework.shadowLabel shadowLabel2;
        private SkeetFramework.shadowLabel shadowLabel1;
        private SkeetFramework.shadowLabel shadowLabel3;
        private System.Windows.Forms.Timer timer1;
    }
}

