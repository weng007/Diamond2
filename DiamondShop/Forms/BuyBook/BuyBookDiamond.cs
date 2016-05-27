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
    public partial class BuyBookDiamond : FormInfo
    {
        dsBuyBookDiamond tds = new dsBuyBookDiamond();
        
        DataSet ds2 = new DataSet();
        bool isAuthorize = false;

        public BuyBookDiamond()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(txtSSize, "SSize");
            binder.BindControl(txtESize, "ESize");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            //binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");

        }
        public BuyBookDiamond(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(txtSSize, "SSize");
            binder.BindControl(txtESize, "ESize");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            //binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();

            SetFormatNumber();
        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbColor.DataSource = (GM.GetMasterTableDetail("C017")).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();

            cmbClearity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            cmbClearity.ValueMember = "ID";
            cmbClearity.DisplayMember = "Detail";
            cmbClearity.Refresh();

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtWeight, txtSeller);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookDiamond", id);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BBDiamondStock", id);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BuyBookDiamond.Rows.Count > 0)
            {
                grid1.Enabled = true;
                binder.BindValueToControl(tds.BuyBookDiamond[0]);

                if (tds.BuyBookDiamond[0]["PayByUSD"].ToString() == "0")
                {
                    chkPayByUSD.Checked = false;
                }
                else
                {
                    chkPayByUSD.Checked = true;
                }
                if (tds.BuyBookDiamond[0]["IsPaid"].ToString() == "0")
                {
                    rdoPayment1.Checked = false;
                    rdoPayment2.Checked = true;
                }
                else
                {
                    rdoPayment1.Checked = true;
                    rdoPayment2.Checked = false;
                }

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookDiamond.BuyBookDiamondRow row = null;

            if (tds.BuyBookDiamond.Rows.Count > 0)
            {
                row = tds.BuyBookDiamond[0];
            }
            else
            {
                row = tds.BuyBookDiamond.NewBuyBookDiamondRow();
                tds.BuyBookDiamond.Rows.Add(row);
            }

            binder.BindValueToDataRow(row);
            row.IsPaid = rdoPayment1.Checked ? "1" : "0";

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("NDC");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookDiamond", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookDiamond", tds);
                }

                //Delete Save Stock
                if (tds2.BBDiamondStock.Rows.Count > 0)
                {
                    chkFlag = ser.DoInsertData("BBDiamondStock", tds2);
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
                chkFlag = ser.DoDeleteData("BuyBookDiamond", id);
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
        protected override bool ValidateData()
        {
            message = "";

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }
            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input Weight > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void chkPayByUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtPriceCaratUSD.Enabled = true;
                txtUSDRate.Enabled = true;

                txtPriceCarat.Enabled = false;
                txtPriceCarat.Text = "0";
                txtUSDRate_TextChanged(null, null);
            }
            else
            {
                txtPriceCaratUSD.Enabled = false;
                txtUSDRate.Enabled = false;
                txtUSDRate.Text = "0";

                txtPriceCarat.Enabled = true;

            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
        }

        private void txtUSDRate_TextChanged(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            }
            else
            {
                txtTotalBaht.Text = "0";
            }
        }
        private void txtTotalBaht_TextChanged(object sender, EventArgs e)
        {
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate, 0);
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SetFormatNumber()
        {
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate, 0);
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
        }

        private void txtMarketPrice_Leave(object sender, EventArgs e)
        {
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
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

        private void txtPriceCarat_Leave(object sender, EventArgs e)
        {
            if (!chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
                txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            }
            
        }

        private void txtPriceCaratUSD_Leave(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();

            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
        }
    }
}
