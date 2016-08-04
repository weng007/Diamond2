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
    public partial class BuyBookGemstone : FormInfo
    {
        DataSet ds2 = new DataSet();
        dsBuyBookGemstone tds = new dsBuyBookGemstone();
        bool isAuthorize = false;

        public BuyBookGemstone()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(chkPayByUSD, "PayByUSD");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(dtPayDate, "PayDate");

            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
        }
        public BuyBookGemstone(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(chkPayByUSD, "PayByUSD");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(dtPayDate, "PayDate");

            this.id = id;
            LoadData();
            SetControlEnable(false);
        }
        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbIdentification.DataSource = (GM.GetMasterTableDetail("C016")).Tables[0];
            cmbIdentification.ValueMember = "ID";
            cmbIdentification.DisplayMember = "Detail";
            cmbIdentification.Refresh();

            cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            cmbOrigin.ValueMember = "ID";
            cmbOrigin.DisplayMember = "Detail";
            cmbOrigin.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();


            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller, txtWeight);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstone", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BBGemstoneStock", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BuyBookGemstone.Rows.Count > 0)
            {
                grid1.Enabled = true;
                binder.BindValueToControl(tds.BuyBookGemstone[0]);

                if (tds.BuyBookGemstone[0]["PayByUSD"].ToString() == "0")
                {
                    chkPayByUSD.Checked = false;
                }
                else
                {
                    chkPayByUSD.Checked = true;
                }
                if (tds.BuyBookGemstone[0]["IsPaid"].ToString() == "0")
                {
                    rdoYes.Checked = false;
                    rdoNo.Checked = true;
                }
                else
                {
                    rdoYes.Checked = true;
                    rdoNo.Checked = false;
                }

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookGemstone.BuyBookGemstoneRow row = null;

            if (tds.BuyBookGemstone.Rows.Count > 0)
            {
                row = tds.BuyBookGemstone[0];
            }
            else
            {
                row = tds.BuyBookGemstone.NewBuyBookGemstoneRow();
                tds.BuyBookGemstone.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.IsPaid = rdoYes.Checked ? "1" : "0";

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("NGC");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookGemstone", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookGemstone", tds);
                }

                //Delete Save Stock
                if (tds2.BBGemstoneStock.Rows.Count > 0)
                {
                    chkFlag = ser.DoInsertData("BBGemstoneStock", tds2);
                }

                tds.AcceptChanges();
                tds2.AcceptChanges();
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
                chkFlag = ser.DoDeleteData("BuyBookGemstone", id);
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
            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input  Weight > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }
        private void grid1_Validated(object sender, EventArgs e)
        {
            if (grid1.Rows.Count > 0)
            {
                tds2.AcceptChanges();
                for (int i = 0; i < grid1.Rows.Count; i++)
                {
                    if (grid1.Rows[i].Cells[0].Value != null)
                    {
                        if (grid1.Rows[i].Cells["ActionDate"].Value != null)
                        { tds2.Tables[0].Rows[i]["ActionDate"] = grid1.Rows[i].Cells["ActionDate"].Value; }
                        if (grid1.Rows[i].Cells["Amount"].Value != null)
                        { tds2.Tables[0].Rows[i]["Amount"] = grid1.Rows[i].Cells["Amount"].Value; }
                        tds2.Tables[0].Rows[i]["RefID"] = id;
                    }
                }

                tds2.AcceptChanges();
            }
        }
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void SetFormatNumber()
        {
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
            //txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
        }
        private void txtMarketPrice_Leave(object sender, EventArgs e)
        {
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
        }

        #region Calculate Money
        private void chkPayByUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtPriceCaratUSD.Enabled = true;
                txtUSDRate.Enabled = true;

                txtPriceCarat.Enabled = false;
                txtPriceCarat.Text = "0";
                txtUSDRate_Leave(null, null);
            }
            else
            {
                txtPriceCaratUSD.Enabled = false;
                txtUSDRate.Enabled = false;
                txtUSDRate.Text = "0";

                txtPriceCarat_Leave(null, null);
                txtPriceCarat.Enabled = true;
            }
        }


        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
                txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            }
            else
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
            }

        }

        private void txtPriceCarat_Leave(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
        }

        private void txtPriceCaratUSD_Leave(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD,0);
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
        }

        private void txtTotalBaht_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }
        #endregion Calculate Money

        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtCode.Enabled = status;
            cmbShop.Enabled = status;
            cmbShape.Enabled = status;
            txtSize.Enabled = status;
            txtAmount.Enabled = status;
            txtWeight.Enabled = status;
            cmbOrigin.Enabled = status;
            cmbShop.Enabled = status;
            rdoYes.Enabled = status;
            rdoNo.Enabled = status;
            dtDueDate.Enabled = status;
            txtPriceCaratUSD.Enabled = status;
            txtPriceCarat.Enabled = status;
            txtUSDRate.Enabled = status;
            txtMarketPrice.Enabled = status;
            txtNote.Enabled = status;
            grid1.Enabled = status;
            chkPayByUSD.Enabled = status;
            cmbIdentification.Enabled = status;
            dtPayDate.Enabled = status;
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
        }
    }
}
