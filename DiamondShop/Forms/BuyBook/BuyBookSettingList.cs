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
            cmbSettingType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbSettingType.ValueMember = "ID";
            cmbSettingType.DisplayMember = "Detail";
            cmbSettingType.Refresh();

            //txtSearch.Select();

            gridSetting.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookSetting", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables[0];
                gridSetting.Refresh();
            }
            else
            {
                gridSetting.DataSource = null;
                gridSetting.Refresh();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookSetting frm = new BuyBookSetting();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookSettingDetail(Convert.ToInt16(cmbSettingType.SelectedValue.ToString()), Convert.ToDateTime(dtSBuyDate.Text),Convert.ToDateTime(dtEBuyDate.Text));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables[0];
                gridSetting.Refresh();
            }
            else { gridSetting.DataSource = null; gridSetting.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        protected override bool DoDeleteData()
        {
            //Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            //winMessage.ShowDialog();
            //chkFlag = winMessage.result;

            //if (chkFlag)
            //{
            //    if (gridSetting.RowCount > 0 && gridSetting.SelectedRows.Count > 0)
            //    {
            //        id = (int)gridSetting.SelectedRows[0].Cells["ID"].Value;
            //        chkFlag = ser.DoDeleteData("BuyBookSettingDetail", id);
            //    }
            //}
            return chkFlag;
        }

        private void gridSetting_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridSetting.RowCount > 0 && gridSetting.SelectedRows.Count > 0)
            {
                id = (int)gridSetting.SelectedRows[0].Cells["ID"].Value;
                BuyBookSetting frm = new BuyBookSetting(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
