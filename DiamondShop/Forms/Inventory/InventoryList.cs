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

        protected override void Initial()
        {
            //cmbShop.DataSource = (GM.GetMasterTableDetail("C007",true)).Tables[0];
            //cmbShop.ValueMember = "ID";
            //cmbShop.DisplayMember = "Detail";
            //cmbShop.Refresh();

            //cmbStatus.DataSource = (GM.GetMasterTableDetail("C023",true)).Tables[0];
            //cmbStatus.ValueMember = "ID";
            //cmbStatus.DisplayMember = "Detail";
            //cmbStatus.Refresh();

            //cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015",true)).Tables[0];
            //cmbJewelryType.ValueMember = "ID";
            //cmbJewelryType.DisplayMember = "Detail";
            //cmbJewelryType.Refresh();

            txtCode.Select();

            gridInventory.AutoGenerateColumns = false;
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchProduct(txtCode.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()),
            //       Convert.ToInt16(cmbStatus.SelectedValue.ToString()), Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridInventory.DataSource = ds.Tables["Product"];
                gridInventory.Refresh();
            }
            else { gridInventory.DataSource = null; gridInventory.Refresh(); }
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Product", -1);

            if (ds.Tables["Product"].Rows.Count > 0)
            {
                gridInventory.DataSource = ds.Tables["Product"];
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
                    chkFlag = ser.DoDeleteData("Product", id);
                }
            }

            return chkFlag;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            frm.ShowDialog();
            DoLoadData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void gridInventory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridInventory.RowCount > 0 && gridInventory.SelectedRows.Count > 0)
            {
                //id = (int)gridInventory.SelectedRows[0].Cells["ID"].Value;
                //Product frm = new Product(id);
                //frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
