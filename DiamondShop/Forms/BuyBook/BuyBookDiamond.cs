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
        //Service1 ser = GM.GetService();
        dsBuyBookDiamond tds = new dsBuyBookDiamond();

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
            binder.BindControl(chkPayUSD, "PayByUSD");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
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
            binder.BindControl(chkPayUSD, "PayByUSD");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
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

            //SetFieldService.SetRequireField(txtCode, txtMeasure1, txtMeasure2, txtMeasure3, txtCarat);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookDiamond", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookDiamond.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookDiamond[0]);


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

                if (tds.BuyBookDiamond[0]["PayByUSD"].ToString() == "0")
                {
                    chkPayUSD.Checked = true;
                }

                EnableDelete = true;
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

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookDiamond", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookDiamond", tds);
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
                //chkFlag = ser.DoDeleteData("DiamondCer", id);
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

            if (txtCode.Text == "")
            {
                message = "Please input GIA Number.\n";
            }
            //if(txtMeasure1.Text == "" || txtMeasure2.Text == "" || txtMeasure3.Text == ""
            //&& GM.ConvertStringToDouble(txtMeasure1) == 0 || GM.ConvertStringToDouble(txtMeasure2) == 0 || GM.ConvertStringToDouble(txtMeasure3) == 0)
            //{
            //    message += "Please input Measurement > 0.\n";
            //}
            //if (txtCarat.Text == "" || GM.ConvertStringToDouble(txtCarat) == 0)
            //{
            //    message += "Please input Carat Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        
        private void cmbColorGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "C017";

            //if (cmbColorGrade.SelectedIndex == 0)
            //{
            //    color = "C001";
            //}

            //cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            //cmbColor.ValueMember = "ID";
            //cmbColor.DisplayMember = "Detail";
            //cmbColor.Refresh();
        }

        private void txtCarat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbShapeAndCut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbShapeAndCut.SelectedIndex == 0)
            //{
            //    lbl1.Text = "-";
            //}
            //else
            //{
            //    lbl1.Text = "x";
            //}
        }
    }
}
