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
    public partial class SearchBuyBookSettingList : FormList
    {
        
        public SearchBuyBookSettingList()
        {
            InitializeComponent();
            Initial();
            dtSBuyDate.Value = dtSBuyDate.Value.AddDays(-90);
            DoLoadData();
            
        }

        protected override void Initial()
        {
            gridSetting.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookSetting", -1, 0);

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

            btnSearch_Click(null, null);
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

            ds = ser2.DoSearchBuyBookSetting(txtSeller.Text, dtSBuyDate.Value, dtEBuyDate.Value);

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
            return chkFlag;
        }

        private void gridSetting_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridSetting.RowCount > 0 && gridSetting.SelectedRows.Count > 0)
            {
                id = (int)gridSetting.SelectedRows[0].Cells["ID"].Value;
                BuyBookSetting frm = new BuyBookSetting(id);
                frm.ShowDialog();

                if (frm.isEdit)
                {
                    DoLoadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
