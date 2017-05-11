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
        public int ReceiveDocID = 0;
        public string ReceiveDocNo = "";

        public BuyBookDiamond()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

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
            binder.BindControl(chkPayByUSD, "PayByUSD");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode2, "Code2");
            binder.BindControl(txtReceiveNo, "ReceiveDocNo");

            dtDueDate.Value = dtBuyDate.Value.AddDays(30);

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
            binder.BindControl(chkPayByUSD, "PayByUSD");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode2, "Code2");
            binder.BindControl(txtReceiveNo, "ReceiveDocNo");

            this.id = id;
            LoadData();
            SetControlEnable(false);

            isEdit = false;

        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;

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

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbColor.DataSource = (GM.GetMasterTableDetail("C017")).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();

            cmbClearity.DataSource = (GM.GetMasterTableDetail("C032")).Tables[0];
            cmbClearity.ValueMember = "ID";
            cmbClearity.DisplayMember = "Detail";
            cmbClearity.Refresh();

            cmbShop.SelectedValue = ApplicationInfo.Shop;

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtWeight, txtSeller,txtUSDRate);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookDiamond", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BBDiamondStock", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BuyBookDiamond.Rows.Count > 0)
            {
                grid1.Enabled = true;
                binder.BindValueToControl(tds.BuyBookDiamond[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BuyBookDiamond[0]["PayDate"]);

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

                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                
                EnableDelete = false;
            }
            SetFormatNumber();
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
                    row.Code = GM.GetRunningNumber("NDC");
                    SetCreateBy(row);
                    
                    
                    chkFlag = ser.DoInsertData("BuyBookDiamond", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookDiamond", tds);
                }

                //Delete Save Stock
                if (tds2.BBDiamondStock.Rows.Count > 0)
                {
                    chkFlag = ser.DoInsertData("BBDiamondStock", tds2,0);
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

            isEdit = true;
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
            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input Weight > 0.\n";
            }
            if (txtUSDRate.Text == "" || GM.ConvertStringToDouble(txtUSDRate) == 0)
            {
                message += "Please input USDRate > 0.\n";
            }
            if (rdoPayment1.Checked == true && txtPayDate.Text == "")
            {
                message += "Please input Paydate";
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
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
            txtAmount.Text = GM.ConvertDoubleToString(txtAmount, 0);
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
            txtSSize.Text = GM.ConvertDoubleToString(txtSSize);
            txtESize.Text = GM.ConvertDoubleToString(txtESize);
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
        }


        #region Calculate Money
        private void chkPayByUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtPriceCaratUSD.Enabled = true;
                txtPriceCarat.Enabled = false;
                txtPriceCarat.Text = "0";
                txtUSDRate_Leave(null, null);
            }
            else
            {
                txtPriceCaratUSD.Enabled = false;
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
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            }
        }

        private void txtTotalBaht_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);

            isEdit = true;
        }
        #endregion Calculate Money

        private void txtMarketPrice_Leave(object sender, EventArgs e)
        {
            txtMarketPrice.Text = GM.ConvertDoubleToString(txtMarketPrice, 0);
        }
        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtCode.Enabled = status;
            cmbShape.Enabled = status;
            txtSSize.Enabled = status;
            txtESize.Enabled = status;
            txtAmount.Enabled = status;
            txtWeight.Enabled = status;
            cmbColor.Enabled = status;
            cmbClearity.Enabled = status;
            rdoPayment1.Enabled = status;
            rdoPayment2.Enabled = status;
            dtDueDate.Enabled = status;
            txtPriceCaratUSD.Enabled = status;
            txtPriceCarat.Enabled = status;
            txtUSDRate.Enabled = status;
            txtMarketPrice.Enabled = status;
            txtNote.Enabled = status;
            grid1.Enabled = status;
            chkPayByUSD.Enabled = status;
            txtPriceCaratUSD.Enabled = status;
            txtPayDate.Enabled = status;
            cmbBuyer.Enabled = status;
            txtCode2.Enabled = status;
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbShop_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoPayment1_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
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

        private void btnBrowseReceiveNo_Click(object sender, EventArgs e)
        {
            ReceiveDocumentList frm = new ReceiveDocumentList(1);
            frm.ShowDialog();
            ReceiveDocID = frm.ReceiveDocID;
            txtReceiveNo.Text = frm.ReceiveDocNo;
        }
    }
}
