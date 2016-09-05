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
    public partial class Payment : FormInfo
    {
        dsBuyBookPayment tds = new dsBuyBookPayment();
        bool isAuthorize = false;
        Decimal TotalPrice;

        public Payment()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

            binder.BindControl(dtPayDate, "PayDate");
            binder.BindControl(txtUSDRate, "USDRete");

        }
        public Payment(int id,Decimal TotalPrice)
        {
            InitializeComponent();
            Initial();
            this.TotalPrice = TotalPrice;
            binder.BindControl(dtPayDate, "PayDate");
            binder.BindControl(txtUSDRate, "USDRete");

            this.id = id;
            LoadData();
            SetControlEnable(false);
        }

        protected override void Initial()
        {

            dtPayDate.Select();

            //SetFieldService.SetRequireField(txtSeller, txtPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookPayment", id, 0);
            tds.Clear();
            tds.Merge(ds);

            txtPrice.Text = Convert.ToString(TotalPrice);

            if (tds.BuyBookPayment.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookPayment[0]);
                
                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();
            SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookPayment.BuyBookPaymentRow row = null;

            if (tds.BuyBookPayment.Rows.Count > 0)
            {
                row = tds.BuyBookPayment[0];
            }
            else
            {
                row = tds.BuyBookPayment.NewBuyBookPaymentRow();
                tds.BuyBookPayment.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.IsPaid = rdoYes.Checked ? "1" : "0";
            try
            {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookPayment", tds);

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        //protected override bool DeleteData()
        //{
        //    try
        //    {
        //        chkFlag = ser.DoDeleteData("BuyBookETC", id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return chkFlag;
        //}

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
            dtPayDate.Enabled = status;
            txtPrice.Enabled = status;
        }
    }
}
