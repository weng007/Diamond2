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
using DiamondShop.DiamondService;

namespace DiamondShop
{
    public partial class BuyBookSetting : FormInfo
    {
        dsBuyBookSetting tds = new dsBuyBookSetting();
        dsBuyBookSettingDetail tds2 = new dsBuyBookSettingDetail();
        bool isAuthorize = false;
        DataSet ds2 = new DataSet();

        public BuyBookSetting()
        {
            InitializeComponent();
            Initial();
            BinderData();


        }
        public BuyBookSetting(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            dtBuyDate.Select();
            SetFieldService.SetRequireField(txtSeller);
        }

        private void BinderData()
        {
            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtBuyPrice, "BuyPrice");
            binder.BindControl(txtSalePrice, "SalePrice");
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookSetting", id);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BuyBookSettingDetail", id);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BBSetting.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BBSetting[0]);

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }

            if (tds2.BBSettingDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds2.BBSettingDetail[0]);
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookSetting.BBSettingRow row = null;

            if (tds.BBSetting.Rows.Count > 0)
            {
                row = tds.BBSetting[0];
            }
            else
            {
                row = tds.BBSetting.NewBBSettingRow();
                tds.BBSetting.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookSetting", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookSetting", tds);
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("BuyBookSetting", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
            }
            else
            {
                RequirePassword frm = new RequirePassword("2");
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    base.EditData();
                }
            }
        }

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookSettingDetail frm = new BuyBookSettingDetail(id,0);
            frm.ShowDialog();

            LoadData();
        }

        private void gridSetting_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(gridSetting.SelectedRows.Count > 0)
            {
                BuyBookSettingDetail frm = new BuyBookSettingDetail(id, 1);
                frm.ShowDialog();

                LoadData();
            }
        }
    }
}
