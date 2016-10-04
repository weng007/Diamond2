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
    public partial class BuyBookGold : FormInfo
    {
        dsBuyBookGold tds = new dsBuyBookGold();
        bool isAuthorize = false;

        public BuyBookGold()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtBuyPrice, "BuyPrice");
            binder.BindControl(txtSellPrice, "SellPrice");
            binder.BindControl(txtAmount1, "Amount1");
            binder.BindControl(txtAmount2, "Amount2");
            binder.BindControl(txtPrice1, "Price1");
            binder.BindControl(txtPrice2, "Price2");
            binder.BindControl(txtTotal1, "Total1");
            binder.BindControl(txtTotal2, "Total2");
            binder.BindControl(txtPricePerGram, "PricePerGram");
            binder.BindControl(txtPriceGram1, "PriceGram1");
            binder.BindControl(txtPriceGram2, "PriceGram2");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode, "Code");

            cmbShop.SelectedValue = ApplicationInfo.Shop;
        }
        public BuyBookGold(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtBuyPrice, "BuyPrice");
            binder.BindControl(txtSellPrice, "SellPrice");
            binder.BindControl(txtAmount1, "Amount1");
            binder.BindControl(txtAmount2, "Amount2");
            binder.BindControl(txtPrice1, "Price1");
            binder.BindControl(txtPrice2, "Price2");
            binder.BindControl(txtTotal1, "Total1");
            binder.BindControl(txtTotal2, "Total2");
            binder.BindControl(txtPricePerGram, "PricePerGram");
            binder.BindControl(txtPriceGram1, "PriceGram1");
            binder.BindControl(txtPriceGram2, "PriceGram2");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode, "Code");

            this.id = id;
            LoadData();
            SetFormatNumber();
            SetControlEnable(false);

            isEdit = false;
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuyer.DataSource = ds.Tables[0];
            cmbBuyer.ValueMember = "ID";
            cmbBuyer.DisplayMember = "DisplayName";
            cmbBuyer.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbBuyer.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGold", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookGold.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookGold[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BuyBookGold[0]["PayDate"]);

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = false;
            }
            if (tds.BuyBookGold[0]["IsPaid"].ToString() == "0")
            {
                rdoYes.Checked = false;
                rdoNo.Checked = true;
            }
            else
            {
                rdoYes.Checked = true;
                rdoNo.Checked = false;
            }

            base.LoadData();

            cmbBuyer.SelectedValueChanged += cmbBuyer_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsBuyBookGold.BuyBookGoldRow row = null;

            if (tds.BuyBookGold.Rows.Count > 0)
            {
                row = tds.BuyBookGold[0];
            }
            else
            {
                row = tds.BuyBookGold.NewBuyBookGoldRow();
                tds.BuyBookGold.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.IsPaid = rdoYes.Checked ? "1" : "0";
            if (txtPayDate.Text == "")
            {
                row.PayDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.PayDate = Convert.ToDateTime(txtPayDate.Text.ToString());
            }
            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("GOL");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookGold", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookGold", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookGold", id);
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
                RequirePassword frm = new RequirePassword(ApplicationInfo.Shop);
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
            if (rdoYes.Checked == true && txtPayDate.Text == "")
            {
                message += "Please input Paydate";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtAmount1_Leave(object sender, EventArgs e)
        {
            txtTotal1.Text = (GM.ConvertStringToDouble(txtAmount1) * GM.ConvertStringToDouble(txtPrice1)).ToString();

            txtAmount1.Text = GM.ConvertDoubleToString(txtAmount1);
            txtTotal1.Text = GM.ConvertDoubleToString(txtTotal1);
        }

        private void txtPrice1_Leave(object sender, EventArgs e)
        {
            txtTotal1.Text = (GM.ConvertStringToDouble(txtAmount1) * GM.ConvertStringToDouble(txtPrice1)).ToString();

            txtPrice1.Text = GM.ConvertDoubleToString(txtPrice1, 0);
            txtTotal1.Text = GM.ConvertDoubleToString(txtTotal1);
        }
        private void txtAmount2_Leave(object sender, EventArgs e)
        {
            txtTotal2.Text = (GM.ConvertStringToDouble(txtAmount2) * GM.ConvertStringToDouble(txtPrice2)).ToString();

            txtAmount2.Text = GM.ConvertDoubleToString(txtAmount2);
            txtTotal2.Text = GM.ConvertDoubleToString(txtTotal2);
        }
        private void txtPrice2_Leave(object sender, EventArgs e)
        {
            txtTotal2.Text = (GM.ConvertStringToDouble(txtAmount2) * GM.ConvertStringToDouble(txtPrice2)).ToString();

            txtPrice2.Text = GM.ConvertDoubleToString(txtPrice2, 0);
            txtTotal2.Text = GM.ConvertDoubleToString(txtTotal2);
        }
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
            txtSellPrice.Text = GM.ConvertDoubleToString(txtSellPrice, 0);
            txtAmount1.Text = GM.ConvertDoubleToString(txtAmount1);
            txtPrice1.Text = GM.ConvertDoubleToString(txtPrice1, 0);
            txtTotal1.Text = GM.ConvertDoubleToString(txtTotal1, 0);
            txtPricePerGram.Text = GM.ConvertDoubleToString(txtPricePerGram,0);
            txtPriceGram1.Text = GM.ConvertDoubleToString(txtPriceGram1,0);

            txtAmount2.Text = GM.ConvertDoubleToString(txtAmount2);
            txtPrice2.Text = GM.ConvertDoubleToString(txtPrice2, 0);
            txtTotal2.Text = GM.ConvertDoubleToString(txtTotal2, 0);
            txtPriceGram2.Text = GM.ConvertDoubleToString(txtPriceGram2, 0);
        }

        private void txtBuyPrice_Leave(object sender, EventArgs e)
        {
            txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
        }

        private void txtSellPrice_Leave(object sender, EventArgs e)
        {
            txtSellPrice.Text = GM.ConvertDoubleToString(txtSellPrice, 0);
        }

        private void txtPricePerGram_Leave(object sender, EventArgs e)
        {
            txtPricePerGram.Text = GM.ConvertDoubleToString(txtPricePerGram, 0);
        }

        private void txtPriceGram1_Leave(object sender, EventArgs e)
        {
            txtPriceGram1.Text = GM.ConvertDoubleToString(txtPriceGram1, 0);
        }
        private void txtPriceGram2_Leave(object sender, EventArgs e)
        {
            txtPriceGram2.Text = GM.ConvertDoubleToString(txtPriceGram2, 0);
        }

        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtBuyPrice.Enabled = status;
            txtSellPrice.Enabled = status;
            txtAmount1.Enabled = status;
            txtPrice1.Enabled = status;
            txtPricePerGram.Enabled = status;
            txtPriceGram1.Enabled = status;
            txtAmount2.Enabled = status;
            txtPrice2.Enabled = status;
            txtPriceGram2.Enabled = status;
            txtSeller.Enabled = status;
            cmbBuyer.Enabled = status;
        }

        private void txtSeller_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbBuyer_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtPayDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
            isEdit = true;
        }
    }
}
