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
        Service1 ser = GM.GetService();
        dsBuyBookGemstone tds = new dsBuyBookGemstone();

        public BuyBookGemstone()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");
        }
        public BuyBookGemstone(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtTotalThaiBaht, "TotalThaiBaht");
            binder.BindControl(txtMarketPrice, "MarketPrice");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();
        }
        protected override void Initial()
        {
            cmbShape.DataSource = (GM.GetMasterTableDetail("C020")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbIdentification.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbIdentification.ValueMember = "ID";
            cmbIdentification.DisplayMember = "Detail";
            cmbIdentification.Refresh();

            cmbOrigin.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            cmbOrigin.ValueMember = "ID";
            cmbOrigin.DisplayMember = "Detail";
            cmbOrigin.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            dtBuyDate.Select();

            //SetFieldService.SetRequireField(txtCode, txtMeasure1, txtMeasure2, txtMeasure3, txtCarat);
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

                if (tds.BuyBookGemstone[0]["PayByUSD"].ToString() == "0")
                {
                    chkPayByUSD.Checked = true;
                }

                EnableDelete = true;
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

            try
            {
                if (id == 0)
                {
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
    }
}
