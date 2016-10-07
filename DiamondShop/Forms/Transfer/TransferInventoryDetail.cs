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
using DiamondDS;

namespace DiamondShop
{
    public partial class TransferInventoryDetail : FormList
    {
        int shop;
        public int refID1 = 0;
        public TransferInventoryDetail()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuybookType.DataSource = ds.Tables[0];
            cmbBuybookType.ValueMember = "ID";
            cmbBuybookType.DisplayMember = "DisplayName";
            cmbBuybookType.Refresh();

            gridTransferInventory.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            
            shop = ApplicationInfo.Shop;
            ds = ser2.DoSearchTransferInventory(shop, "", 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }

            //btnSearch_Click(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TransferInfo frm = new TransferInfo();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransferBuyBook(shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbBuybookType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        protected override bool DoDeleteData()
        {
            return chkFlag;
        }

        private void gridSetting_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            refID1 = (int)gridTransferInventory.SelectedRows[0].Cells["ID"].Value;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
