using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondShop.DiamondService;
using DiamondDS.DS;

namespace DiamondShop
{
    public partial class GemstoneCer : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsGemstoneCer tds = new dsGemstoneCer();

        public GemstoneCer()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtSetting, "Setting");
            binder.BindControl(txtShop, "Shop");
            binder.BindControl(txtStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtIdentification, "Identification");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(txtLab, "Lab");
            binder.BindControl(txtOrigin, "Origin");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtShape, "Shape");

        }
        public GemstoneCer(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtSetting, "Setting");
            binder.BindControl(txtShop, "Shop");
            binder.BindControl(txtStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtIdentification, "Identification");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(txtLab, "Lab");
            binder.BindControl(txtOrigin, "Origin");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtShape, "Shape");

            this.id = id;
            LoadData();
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("GemstoneCer", id);
            tds.Clear();
            tds.Merge(ds);


            if (tds.GemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.GemstoneCer[0]);
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsGemstoneCer.GemstoneCerRow row = null;

            if (tds.GemstoneCer.Rows.Count > 0)
            {
                row = tds.GemstoneCer[0];
            }
            else
            {
                row = tds.GemstoneCer.NewGemstoneCerRow();
                tds.GemstoneCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("GemstoneCer", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("GemstoneCer", tds);
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
                chkFlag = ser.DoDeleteData("GemstoneCer", id);
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

        protected override void Initial()
        {
            //cmbCompanyCer.DataSource = (GM.GetMasterTableDetail("C020")).Tables[0];
            //cmbCompanyCer.ValueMember = "ID";
            //cmbCompanyCer.DisplayMember = "Detail";
            //cmbCompanyCer.Refresh();

            //cmbShapeAndCut.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //cmbShapeAndCut.ValueMember = "ID";
            //cmbShapeAndCut.DisplayMember = "Detail";
            //cmbShapeAndCut.Refresh();

            //cmbClarity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            //cmbClarity.ValueMember = "ID";
            //cmbClarity.DisplayMember = "Detail";
            //cmbClarity.Refresh();

            //cmbColorGrade.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            //cmbColorGrade.ValueMember = "ID";
            //cmbColorGrade.DisplayMember = "Detail";
            //cmbColorGrade.Refresh();

            //cmbCutGrade.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            //cmbCutGrade.ValueMember = "ID";
            //cmbCutGrade.DisplayMember = "Detail";
            //cmbCutGrade.Refresh();

            //cmbPolish.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            //cmbPolish.ValueMember = "ID";
            //cmbPolish.DisplayMember = "Detail";
            //cmbPolish.Refresh();

            //cmbSymmetry.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            //cmbSymmetry.ValueMember = "ID";
            //cmbSymmetry.DisplayMember = "Detail";
            //cmbSymmetry.Refresh();

            //cmbFluores.DataSource = (GM.GetMasterTableDetail("C018")).Tables[0];
            //cmbFluores.ValueMember = "ID";
            //cmbFluores.DisplayMember = "Detail";
            //cmbFluores.Refresh();

            dtReportDate.Select();

            //SetFieldService.SetRequireField(txtCode, txtW, txtL, txtD, txtCarat);
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
