﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeetFramework
{
    public class SkeetButton : Control
    {
        public Color ColorTop { get; set; } = Color.FromArgb(23, 23, 23);
        public Color ColorBottom { get; set; } = Color.FromArgb(25, 25, 25);
        private bool active = false;
        private StringFormat strFormat = new StringFormat();
        public Pen FakeWhite { get; set; } = new Pen(Color.FromArgb(169, 160, 203));
        
        public SkeetButton()
        {
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            this.Paint += SkeetButton_Paint;
            Font = new Font("Verdana", 7);
        }

        private void SkeetButton_Paint(object sender, PaintEventArgs e)
        {
            Rectangle ree = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle ree2 = new Rectangle(1, 1, Width - 3, Height - 3);
            LinearGradientBrush gradient = new LinearGradientBrush(ree, this.ColorBottom, this.ColorTop, 90.0f);
            e.Graphics.FillRectangle(gradient, ree);
            e.Graphics.DrawRectangle(Pens.Black, ree);
            e.Graphics.DrawRectangle(FakeWhite, ree2);
            e.Graphics.DrawString(Text, Font, (active) ? Brushes.White : Brushes.White, ree, strFormat);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            active = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
