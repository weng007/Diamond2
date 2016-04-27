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
    public partial class BuyBookGoldList : FormList
    {
        
        public BuyBookGoldList()
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

            //txtPercentGold.Select();

            //gridProduct.AutoGenerateColumns = false;
        }

        private void DoSearchData()
        {
            //ser2 = GM.GetService2();

            //ds = ser2.DoSearchProduct(txtPercentGold.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()),
            //       Convert.ToInt16(cmbStatus.SelectedValue.ToString()), Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    gridProduct.DataSource = ds.Tables["Product"];
            //    gridProduct.Refresh();
            //}
            //else { gridProduct.DataSource = null; gridProduct.Refresh(); }
        }

        protected override void DoLoadData()
        {
            //ds = ser.DoSelectData("Product", -1);

            //if (ds.Tables["Product"].Rows.Count > 0)
            //{
            //    gridProduct.DataSource = ds.Tables["Product"];
            //    gridProduct.Refresh();
            //}
            //else { gridProduct.DataSource = null; gridProduct.Refresh(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookGold frm = new BuyBookGold();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridGold_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGold.RowCount > 0 && gridGold.SelectedRows.Count > 0)
            {
                id = (int)gridGold.SelectedRows[0].Cells["ID"].Value;
                //BuyBookGold frm = new BuyBookGold(id);
                //frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
