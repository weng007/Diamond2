using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService2;

namespace DiamondShop.FormMaster
{
    public partial class FormList : Form
    {
        public DataSet ds = new DataSet();
        public int id = 0;
        public bool chkFlag = false;
        public Service1 ser;
        public Service3 ser2;

        public FormList()
        {
            InitializeComponent();
            ser = GM.GetService();
            ser2 = GM.GetService2();
        }

        protected virtual void Initial()
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        protected virtual void DoLoadData()
        {
 
        }
        protected virtual bool DoDeleteData()
        {
            return true;
        }
    }
}
