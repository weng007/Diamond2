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
    public partial class SearchTransferInventory : FormList
    { 
        public int refID1 = 0;
        public string tmpCode = "";
        public string idSelected = "";

        public SearchTransferInventory()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbJewelryType.ValueMember = "ID";
            cmbJewelryType.DisplayMember = "Detail";
            cmbJewelryType.Refresh();

            gridTransferInventory.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            
            ds = ser2.DoSearchTransferInventory(ApplicationInfo.Shop, "", Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }

        private void CheckSelected()
        {
            string comma = ",";
            idSelected = "";

            for (int i = 0; i < gridTransferInventory.Rows.Count; i++)
            {
                if (gridTransferInventory.Rows[i].Cells["Select"].Value != null)
                {
                    if (gridTransferInventory.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        idSelected += gridTransferInventory.Rows[i].Cells["Code"].Value.ToString() + comma;
                         
                    }
                }
            }

            if (idSelected.Length > 0)
            {
                idSelected = idSelected.Remove(idSelected.Length - 1, 1);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridTransferInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridTransferInventory.SelectedCells[0].Value == null || gridTransferInventory.SelectedCells[0].Value.ToString() == "False")
                {
                    gridTransferInventory.SelectedCells[0].Value = true;
                    id = (int)gridTransferInventory.SelectedRows[0].Cells["ID"].Value;
                }
                else
                {
                    gridTransferInventory.SelectedCells[0].Value = false;
                }
            }
        }
    }
}
