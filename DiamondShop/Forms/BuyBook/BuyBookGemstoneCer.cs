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
    public partial class BuyBookGemstoneCer : FormInfo
    {
        Service1 ser = GM.GetService();
        dsBuyBookGemstoneCer tds = new dsBuyBookGemstoneCer();

        public BuyBookGemstoneCer()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbSetting, "Setting");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtTotalBaht, "TotalThaiBaht");
            binder.BindControl(txtNote, "Note");
        }
        public BuyBookGemstoneCer(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbSetting, "Setting");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtTotalBaht, "TotalThaiBaht");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbSetting.DataSource = (GM.GetMasterTableDetail("C005")).Tables[0];
            cmbSetting.ValueMember = "ID";
            cmbSetting.DisplayMember = "Detail";
            cmbSetting.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbIdentification.DataSource = (GM.GetMasterTableDetail("C016")).Tables[0];
            cmbIdentification.ValueMember = "ID";
            cmbIdentification.DisplayMember = "Detail";
            cmbIdentification.Refresh();

            cmbLab.DataSource = (GM.GetMasterTableDetail("C026")).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

            cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            cmbOrigin.ValueMember = "ID";
            cmbOrigin.DisplayMember = "Detail";
            cmbOrigin.Refresh();

            dtBuyDate.Select();

            //SetFieldService.SetRequireField(txtCode, txtW, txtL, txtD, txtCarat);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstoneCer", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookGemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookGemstoneCer[0]);


                if (tds.BuyBookGemstoneCer[0]["IsPaid"].ToString() == "0")
                {
                    rdoYes.Checked = false;
                    rdoNo.Checked = true;
                }
                else
                {
                    rdoYes.Checked = true;
                    rdoNo.Checked = false;
                }

                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookGemstoneCer.BuyBookGemstoneCerRow row = null;

            if (tds.BuyBookGemstoneCer.Rows.Count > 0)
            {
                row = tds.BuyBookGemstoneCer[0];
            }
            else
            {
                row = tds.BuyBookGemstoneCer.NewBuyBookGemstoneCerRow();
                tds.BuyBookGemstoneCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookGemstoneCer", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookGemstoneCer", tds);
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
                //chkFlag = ser.DoDeleteData("BuyBookGemstoneCer", id);
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
            if(txtW.Text == "" || txtL.Text == "" || txtD.Text == ""
            && GM.ConvertStringToDouble(txtW) == 0 || GM.ConvertStringToDouble(txtL) == 0 || GM.ConvertStringToDouble(txtD) == 0)
            {
                message += "Please input Measurement > 0.\n";
            }
            //if (txtCarat.Text == "" || GM.ConvertStringToDouble(txtCarat) == 0)
            //{
            //    message += "Please input Carat Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

    }
}
