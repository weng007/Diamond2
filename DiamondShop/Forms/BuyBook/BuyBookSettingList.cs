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
    public partial class BuyBookSettingList : FormList
    {
        
        public BuyBookSettingList()
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

            //txtSearch.Select();

            gridSetting.AutoGenerateColumns = false;
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchProduct(txtSearch.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()),
            //       Convert.ToInt16(cmbStatus.SelectedValue.ToString()), Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables["Product"];
                gridSetting.Refresh();
            }
            else { gridSetting.DataSource = null; gridSetting.Refresh(); }
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Product", -1);

            if (ds.Tables["Product"].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables["Product"];
                gridSetting.Refresh();
            }
            else { gridSetting.DataSource = null; gridSetting.Refresh(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookSetting frm = new BuyBookSetting();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
    }
}
