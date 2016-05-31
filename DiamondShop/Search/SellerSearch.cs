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
using DiamondDS.DS;

namespace DiamondShop
{
    public partial class SellerSearch : FormList
    {
        public string fullName = "";
        
        public SellerSearch()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007",true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            gridSeller.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Seller", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSeller.DataSource = ds.Tables[0];
                gridSeller.Refresh();
            }
            else
            {
                gridSeller.DataSource = null;
                gridSeller.Refresh();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchSeller(txtSearch.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSeller.DataSource = ds.Tables[0];
                gridSeller.Refresh();
            }
            else
            {
                gridSeller.DataSource = null;
                gridSeller.Refresh();
            }
        }

        private void gridSeller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(gridSeller.SelectedRows[0].Cells["ID"].Value.ToString());
            fullName = gridSeller.SelectedRows[0].Cells["FullName1"].Value.ToString();

            this.Close();
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
    }
}
