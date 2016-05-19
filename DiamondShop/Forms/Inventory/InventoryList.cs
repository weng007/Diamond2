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
    public partial class InventoryList : FormList
    {
        public InventoryList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public InventoryList(string prefix)
        {
            InitializeComponent();
            Initial();

            txtPrefix.Text = prefix;
            DoLoadData();
        }

        protected override void Initial()
        {
            
            txtCode.Select();

            gridInventory.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchInventoryByType(txtPrefix.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridInventory.DataSource = ds.Tables[0];
                gridInventory.Refresh();
            }
            else { gridInventory.DataSource = null; gridInventory.Refresh(); }
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchInventory(txtPrefix.Text+"-"+txtCode.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridInventory.DataSource = ds.Tables[0];
                gridInventory.Refresh();
            }
            else { gridInventory.DataSource = null; gridInventory.Refresh(); }
        }

        
        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (gridInventory.RowCount > 0 && gridInventory.SelectedRows.Count > 0)
                {
                    id = (int)gridInventory.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Inventory", id);
                }
            }

            return chkFlag;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory(txtPrefix.Text);
            frm.ShowDialog();
            DoLoadData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void gridInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridInventory.RowCount > 0 && gridInventory.SelectedRows.Count > 0)
            {
                id = (int)gridInventory.SelectedRows[0].Cells["ID"].Value;
                Inventory frm = new Inventory(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
