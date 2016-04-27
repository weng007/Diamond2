using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiamondShop.Popup
{
    public partial class Popup : Form
    {
        public bool result = false;
        public Popup()
        {
            InitializeComponent();
        }

        public Popup(string mes)
        {
            InitializeComponent();

            lblMain.Text = mes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
