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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://totalcsgo.com/skin-ids");
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {

        }
    }
}
