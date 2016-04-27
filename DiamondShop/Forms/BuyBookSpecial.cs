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
using DiamondShop.DiamondService;
using DiamondDS.DS;

namespace DiamondShop
{
    public partial class BuyBookSpecial : FormInfo
    {
        Service1 ser = GM.GetService();
        dsBuyBookSpecial tds = new dsBuyBookSpecial();

        public BuyBookSpecial()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtTotalPrice, "TotalPrice");
            binder.BindControl(txtComment, "Comment");

            txtTotalPrice.Text = GM.ConvertDoubleToString(txtTotalPrice);
        }
        public BuyBookSpecial(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtTotalPrice, "TotalPrice");
            binder.BindControl(txtComment, "Comment");

            this.id = id;
            LoadData();

            txtTotalPrice.Text = GM.ConvertDoubleToString(txtTotalPrice);
        }

        protected override void Initial()
        {
            SetFieldService.SetRequireField(txtTotalPrice);

            dtBuyDate.Select();
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookSpecial", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookSpecial.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookSpecial[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookSpecial.BuyBookSpecialRow row = null;

            if (tds.BuyBookSpecial.Rows.Count > 0)
            {
                row = tds.BuyBookSpecial[0];
            }
            else
            {
                row = tds.BuyBookSpecial.NewBuyBookSpecialRow();
                tds.BuyBookSpecial.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookSpecial", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookSpecial", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookSpecial", id);
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

            if (txtTotalPrice.Text == "" || GM.ConvertStringToDouble(txtTotalPrice) == 0)
            {
                message = "Please input Total Price > 0.\n";
            }
            //if (txtPrice.Text == "")
            //{
            //    message = "Please input Price/CT. $.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalPrice_Leave(object sender, EventArgs e)
        {
            txtTotalPrice.Text = GM.ConvertDoubleToString(txtTotalPrice);
        }
    }
}
