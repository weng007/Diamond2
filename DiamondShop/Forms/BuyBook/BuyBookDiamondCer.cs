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
    public partial class BuyBookDiamondCer : FormInfo
    {
        dsBuyBookDiamondCer tds = new dsBuyBookDiamondCer();

        public BuyBookDiamondCer()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbColorType, "ColorType");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbPolish, "Polish");
            binder.BindControl(cmbSymmetry, "Symmetry");
            binder.BindControl(cmbFluorescent, "Fluorescent");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtSoldToName, "SoldToName");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(txtRap, "Rap");
            binder.BindControl(txtTotal, "Total$");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbSetting, "Setting");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtNote, "Note");
        }
        public BuyBookDiamondCer(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbColorType, "ColorType");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbPolish, "Polish");
            binder.BindControl(cmbSymmetry, "Symmetry");
            binder.BindControl(cmbFluorescent, "Fluorescent");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtSoldToName, "SoldToName");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(txtRap, "Rap");
            binder.BindControl(txtTotal, "Total$");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbSetting, "Setting");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbColorType.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            cmbColorType.ValueMember = "ID";
            cmbColorType.DisplayMember = "Detail";
            cmbColorType.Refresh();

            cmbCut.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            cmbCut.ValueMember = "ID";
            cmbCut.DisplayMember = "Detail";
            cmbCut.Refresh();

            cmbPolish.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            cmbPolish.ValueMember = "ID";
            cmbPolish.DisplayMember = "Detail";
            cmbPolish.Refresh();

            cmbSymmetry.DataSource = (GM.GetMasterTableDetail("C003")).Tables[0];
            cmbSymmetry.ValueMember = "ID";
            cmbSymmetry.DisplayMember = "Detail";
            cmbSymmetry.Refresh();

            cmbFluorescent.DataSource = (GM.GetMasterTableDetail("C018")).Tables[0];
            cmbFluorescent.ValueMember = "ID";
            cmbFluorescent.DisplayMember = "Detail";
            cmbFluorescent.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbClearity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            cmbClearity.ValueMember = "ID";
            cmbClearity.DisplayMember = "Detail";
            cmbClearity.Refresh();    

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbSetting.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbSetting.ValueMember = "ID";
            cmbSetting.DisplayMember = "Detail";
            cmbSetting.Refresh();

            cmbLab.DataSource = (GM.GetMasterTableDetail("C020")).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtWeight, txtPrice, txtRap);
        }

        protected override void LoadData()
        {
              ds = ser.DoSelectData("BuyBookDiamondCer", id);
              tds.Clear();
              tds.Merge(ds);

              if (tds.BuyBookDiamondCer.Rows.Count > 0)
              {
                binder.BindValueToControl(tds.BuyBookDiamondCer[0]);

                if (tds.BuyBookDiamondCer[0]["IsInscription"].ToString() == "0")
                {
                    rdoIns1.Checked = false;
                    rdoIns2.Checked = true;                  
                }
                else
                {
                    rdoIns1.Checked = true;
                    rdoIns2.Checked = false;
                }

                if (tds.BuyBookDiamondCer[0]["IsPaid"].ToString() == "0")
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
            dsBuyBookDiamondCer.BuyBookDiamondCerRow row = null;

            if (tds.BuyBookDiamondCer.Rows.Count > 0)
            {
                row = tds.BuyBookDiamondCer[0];
            }
            else
            {
                row = tds.BuyBookDiamondCer.NewBuyBookDiamondCerRow();
                tds.BuyBookDiamondCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.IsInscription = rdoIns1.Checked ?"1":"0";
            row.IsPaid = rdoYes.Checked ? "1" : "0";

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("DC");
                    //พึ่งซื้อยังไม่ได้ขายให้ลูกค้า
                    row.SoldTo = 0;

                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookDiamondCer", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookDiamondCer", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookDiamondCer", id);
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

            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message = "Please Input Weight > 0.\n";
            }

            if (txtPrice.Text == "" || GM.ConvertStringToDouble(txtPrice) == 0)
            {   
                message += "Please Input Price > 0.\n";
            }

            if (txtRap.Text == "" || GM.ConvertStringToDouble(txtRap) == 0)
            {
                message += "Please Input Rap > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar!='-'))
            {
                e.Handled = true;
            }
        }

        private void cmbColorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            if (cmbColorType.SelectedIndex == 0)
            {
                color = "C001";
            }
            else
            {
                color = "C017";
            }

            cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShape.SelectedIndex != 0)
            {
                cmbCut.SelectedIndex = 0;
                cmbCut.Enabled = false;
            }
            else
            {
                cmbCut.Enabled = true;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht);
        }

        private void txtUSDRate_TextChanged(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht);
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice))
                * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text= GM.ConvertDoubleToString(txtTotal);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice);
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice))
                * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }

        private void txtRap_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice))
                            * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }
    }
}
