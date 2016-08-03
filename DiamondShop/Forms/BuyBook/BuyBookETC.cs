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
    public partial class BuyBookETC : FormInfo
    {
        dsBuyBookETC tds = new dsBuyBookETC();
        bool isAuthorize = false;

        public BuyBookETC()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtPrice, "Price");

        }
        public BuyBookETC(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtPrice, "Price");

            this.id = id;
            LoadData();
            SetControlEnable(false);
        }

        protected override void Initial()
        {

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller, txtPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookETC", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookETC.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookETC[0]);

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookETC.BuyBookETCRow row = null;

            if (tds.BuyBookETC.Rows.Count > 0)
            {
                row = tds.BuyBookETC[0];
            }
            else
            {
                row = tds.BuyBookETC.NewBuyBookETCRow();
                tds.BuyBookETC.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookETC", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookETC", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookETC", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
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
                    SetControlEnable(true);
                    base.EditData();
                }
            }
        }

        protected override bool ValidateData()
        {
            message = "";

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }
            if (txtPrice.Text == "" || GM.ConvertStringToDouble(txtPrice) == 0)
            {
                message += "Please input Price > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice,0);
        }
        private void SetFormatNumber()
        {
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice,0);
        }

        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtDetail.Enabled = status;
            txtPrice.Enabled = status;
        }
    }
}
