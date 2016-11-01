using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;
using System.Data.OleDb;
using System.Data.SqlClient;
using DiamondShop.DiamondService1;


namespace DiamondShop
{
    public partial class BuyBookDiamondCer : FormInfo
    {
        Service2 ser1;
        dsBuyBookDiamondCer tds = new dsBuyBookDiamondCer();
        bool isAuthorize = false;
        string FilePath;
        MemoryStream ms;
        byte[] file;

        public BuyBookDiamondCer()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

            cmbCut.SelectedIndex = 1;
            cmbPolish.SelectedIndex = 1;
            cmbSymmetry.SelectedIndex = 1;

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
            binder.BindControl(lnkSetting, "Setting");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(linkFile, "FileName");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtCode2, "Code2");

            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
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
            binder.BindControl(lnkSetting, "Setting");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(linkFile, "FileName");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtCode2, "Code2");

            this.id = id;
            btnImportExcel.Visible = false;
            SetControlEnable(false);
            LoadData();

            isEdit = false;
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuyer.DataSource = ds.Tables[0];
            cmbBuyer.ValueMember = "ID";
            cmbBuyer.DisplayMember = "DisplayName";
            cmbBuyer.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbBuyer.Refresh();

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

            cmbLab.DataSource = (GM.GetMasterTableDetail("C020")).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

            cmbShop.SelectedValue = ApplicationInfo.Shop;

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtWeight, txtPrice, txtRap, txtUSDRate);
        }

        protected override void LoadData()
        {
              ds = ser.DoSelectData("BuyBookDiamondCer", id, 0);
              tds.Clear();
              tds.Merge(ds);

              if (tds.BuyBookDiamondCer.Rows.Count > 0)
              {
                binder.BindValueToControl(tds.BuyBookDiamondCer[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BuyBookDiamondCer[0]["PayDate"]);

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

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = false;
              }

              SetFormatNumber();
              base.LoadData();

            cmbColorType.SelectedValueChanged += cmbColorType_SelectedValueChanged;
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
            row.FileName = linkFile.Text;
            if (txtPayDate.Text == "")
            {
                row.PayDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.PayDate = Convert.ToDateTime(txtPayDate.Text.ToString());
            }

            //แนบ Certificate
            if (file != null && file.Length > 0)
            {
                row.Certificate = file;
            }

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("DC");
                    //พึ่งซื้อยังไม่ได้ขายให้ลูกค้า
                    row.SoldTo = 0;

                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookDiamondCer", tds,0);
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
                if (cmbStatus.SelectedIndex == 0)
                {
                    chkFlag = ser.DoDeleteData("BuyBookDiamondCer", id);
                }
                else
                {
                    Popup.Popup pop = new Popup.Popup("Diamond Cer ไม่อยู่ในสถานะลบได้");
                    pop.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override void EditData()
        {
            if(isAuthorize)
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
            if (txtUSDRate.Text == "" || GM.ConvertStringToDouble(txtUSDRate) == 0)
            {
                message += "Please input USDRate > 0.\n";
            }
            if (rdoYes.Checked == true && txtPayDate.Text == "")
            {
                message += "Please input Paydate";
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists)
            {      
                using (var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                if(file.Length > 0)
                {
                    linkFile.Text = openFileDialog1.SafeFileName;
                }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
                * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        } 

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
                * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }

        private void txtRap_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
                * GM.ConvertStringToDouble(txtWeight)).ToString();
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);

            isEdit = true;
        }

        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);          
        }
        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ser1 = GM.GetService1();
            file = ser1.GetCertificate(id, 0);
            if(file != null || id > 0)
            {
                System.IO.FileStream wFile;
                if (!Directory.Exists(GM.Path))
                {
                    Directory.CreateDirectory("C:\\Project");
                }
                wFile = new FileStream("C:\\Project\\"+linkFile.Text, FileMode.Create);
                wFile.Write(file, 0, file.Length);
                wFile.Flush();
                wFile.Close();

                System.Diagnostics.Process.Start(@"C:\\Project\\"+linkFile.Text);             
            }
        }
        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtCode.Enabled = status;
            txtPrice.Enabled = status;
            cmbColorType.Enabled = status;
            cmbCut.Enabled = status;
            cmbPolish.Enabled = status;
            cmbSymmetry.Enabled = status;
            cmbFluorescent.Enabled = status;
            cmbLab.Enabled = status;
            txtReportNumber.Enabled = status;
            txtWeight.Enabled = status;
            cmbShape.Enabled = status;
            cmbColor.Enabled = status;
            cmbClearity.Enabled = status;
            txtPrice.Enabled = status;
            txtRap.Enabled = status;
            btnUpload.Enabled = status;
            btnFileDel.Enabled = status;
            rdoIns1.Enabled = status;
            rdoIns2.Enabled = status;
            rdoYes.Enabled = status;
            rdoNo.Enabled = status;
            dtDueDate.Enabled = status;
            txtUSDRate.Enabled = status;
            txtTotalBaht.Enabled = status;
            txtNote.Enabled = status;
            txtPayDate.Enabled = status;
            btnChooseDate.Enabled = status;
            cmbBuyer.Enabled = status;
            txtCode2.Enabled = status;
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
            isEdit = true;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK && openFileDialog2.CheckFileExists)
            {
                using (var stream = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                if (file.Length > 0)
                {
                    FilePath = openFileDialog2.FileName;
                }
            }
            BuyBookDiamonCerExcel frm = new BuyBookDiamonCerExcel(id,FilePath);
            frm.ShowDialog();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbColorType_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoIns1_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
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

        private void btnFileDel_Click(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.DeleteDataReference(id,2);
        }

        private void lnkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int tmpId = 0;
            ser1 = GM.GetService1();
            tmpId = ser1.DoSearchInventoryByCode(lnkSetting.Text);

            Inventory frm = new Inventory(tmpId);
            frm.ShowDialog();
        }
    }
}
