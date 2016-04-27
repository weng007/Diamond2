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

            gridJewelry.AutoGenerateColumns = false;
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchProduct(txtCode.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()),
            //       Convert.ToInt16(cmbStatus.SelectedValue.ToString()), Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables["Product"];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Product", -1);

            if (ds.Tables["Product"].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables["Product"];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }
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
    }
}
