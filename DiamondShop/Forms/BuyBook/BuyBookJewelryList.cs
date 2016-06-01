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
    public partial class BuyBookJewelryList : FormList
    {
        
        public BuyBookJewelryList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {

            txtCode.Select();

            gridJewelry.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookJewelry", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables[0];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }

            //btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookJewelry frm = new BuyBookJewelry();
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookJewelry(txtPrefix.Text + "-" + txtCode.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables[0];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }
        }

        private void gridJewelry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridJewelry.RowCount > 0 && gridJewelry.SelectedRows.Count > 0)
            {
                id = (int)gridJewelry.SelectedRows[0].Cells["ID"].Value;
                BuyBookJewelry frm = new BuyBookJewelry(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
