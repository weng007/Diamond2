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

            this.id = id;
            LoadData();
        }
        protected override void Initial()
        {
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

            cmbShop.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();


            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller, txtWeight);
        }


        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstone", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookGemstone.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookGemstone[0]);


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
                message += "Please input  Weight > 0.\n";
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

        private void txtPriceCaratUSD_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
        }

        private void txtUSDRate_TextChanged(object sender, EventArgs e)
        {
            if (chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            }
        }

        private void txtPriceCarat_TextChanged(object sender, EventArgs e)
        {
            if (!chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
            }
        }

        private void txtTotalBaht_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht);
        }
    }
}
