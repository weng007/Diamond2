using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;

namespace DiamondShop
{  
    public partial class CustomerSearch : FormList
    {
        public string customerName = "";
        public CustomerSearch()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            gridCustomer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Customer", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridCustomer.DataSource = ds.Tables[0];
                gridCustomer.Refresh();
            }
            else
            {
                gridCustomer.DataSource = null;
                gridCustomer.Refresh();
            }
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

        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridCustomer.Rows.Count > 0)
            {
                id = Convert.ToInt16(gridCustomer.SelectedRows[0].Cells["ID"].Value.ToString());
                customerName = gridCustomer.SelectedRows[0].Cells["FullName"].Value.ToString();
            }

            this.Close();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchCustomer(txtSearch.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridCustomer.DataSource = ds.Tables[0];
                gridCustomer.Refresh();
            }
            else
            {
                gridCustomer.DataSource = null;
                gridCustomer.Refresh();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
    }
}
