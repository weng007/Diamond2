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
    public partial class DiamondCer : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsDiamondCer tds = new dsDiamondCer();

        public DiamondCer()
        {
            InitializeComponent();
            Initial();

            BinderData();


        }
        public DiamondCer(int id)
        {
            InitializeComponent();
            Initial();

            BinderData();

            this.id = id;
            LoadData();
        }

        private void BinderData()
        {
            binder.BindControl(txtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtShape, "ShapeName");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtColor, "ColorName");
            binder.BindControl(txtCut, "CutName");
            binder.BindControl(txtClearity, "ClearityName");
            binder.BindControl(txtPolish, "PolishName");
            binder.BindControl(txtSymmetry, "SymmetryName");
            binder.BindControl(txtFluorescent, "FluorescentName");
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(txtRap, "Rap");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtSetting, "SettingName");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtNote1, "Note1");
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("DiamondCer", id);
            tds.Clear();
            tds.Merge(ds);


            if (tds.DiamondCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.DiamondCer[0]);
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsDiamondCer.DiamondCerRow row = null;

            if (tds.DiamondCer.Rows.Count > 0)
            {
                row = tds.DiamondCer[0];
            }
            else
            {
                row = tds.DiamondCer.NewDiamondCerRow();
                tds.DiamondCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("DiamondCer", tds);

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
                chkFlag = ser.DoDeleteData("DiamondCer", id);
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
            //if(txtW.Text == "" || txtL.Text == "" || txtD.Text == ""
            //&& GM.ConvertStringToDouble(txtW) == 0 || GM.ConvertStringToDouble(txtL) == 0 || GM.ConvertStringToDouble(txtD) == 0)
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

            txtNote.Select();

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
