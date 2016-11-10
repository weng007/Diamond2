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
using DiamondShop.DiamondService1;


namespace DiamondShop
{
    public partial class BuyBookGemstoneCer : FormInfo
    {
        Service2 ser1;
        dsBuyBookGemstoneCer tds = new dsBuyBookGemstoneCer();
        bool isAuthorize = false;
        MemoryStream ms1;
        byte[] image1;
        MemoryStream ms;
        byte[] file;
        string fileExtension ="";
        string FilePath;

        public BuyBookGemstoneCer()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(lnkSetting, "Setting");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbComment, "Comment");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(linkFile, "FileName");
            binder.BindControl(txtCode2, "Code2");

            dtDueDate.Value = dtBuyDate.Value.AddDays(30);
        }
        public BuyBookGemstoneCer(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(lnkSetting, "Setting");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbIdentification, "Identification");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(cmbLab, "Lab");
            binder.BindControl(cmbOrigin, "Origin");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
            binder.BindControl(txtPriceCarat, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbComment, "Comment");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(linkFile, "FileName");
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

            cmbColor.DataSource = (GM.GetMasterTableDetail("C009")).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();

            cmbCut.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            cmbCut.ValueMember = "ID";
            cmbCut.DisplayMember = "Detail";
            cmbCut.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            dtBuyDate.Select();
            cmbShop.SelectedValue = ApplicationInfo.Shop;

            SetFieldService.SetRequireField(txtWeight, txtUSDRate);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstoneCer", id,0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookGemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookGemstoneCer[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BuyBookGemstoneCer[0]["PayDate"]);

                if (tds.BuyBookGemstoneCer[0]["PayByUSD"].ToString() =="0")
                {
                    chkPayByUSD.Checked = false;
                }
                else
                {
                    chkPayByUSD.Checked = true;
                }

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

                if (tds.BuyBookGemstoneCer[0].Image1 != null)
                {
                    image1 = tds.BuyBookGemstoneCer[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = false;
            }
            SetFormatNumber();
            base.LoadData();

            cmbShape.SelectedValueChanged += cmbShape_SelectedValueChanged;
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
            row.Image1 = image1;
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
                    row.Code = GM.GetRunningNumber("GC");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookGemstoneCer", tds,0);
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
                if (cmbStatus.SelectedIndex == 0)
                {
                    chkFlag = ser.DoDeleteData("BuyBookGemstoneCer", id);
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

            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input  Weight > 0.\n";
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

        private void btnImage1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image1 = new byte[fs.Length];
                fs.Read(image1, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void cmbIdentification_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GemstoneType = "";

            if (cmbIdentification.SelectedValue.ToString() == "95")
            {
                cmbComment.Enabled = true;
                GemstoneType = "C029";
            }
            else
            {
                cmbComment.Enabled = true;
                GemstoneType = "C028";
            }

            cmbComment.DataSource = (GM.GetMasterTableDetail(GemstoneType)).Tables[0];
            cmbComment.ValueMember = "ID";
            cmbComment.DisplayMember = "Detail";
            cmbComment.Refresh();
        }
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #region Calculate Money
        private void chkPayByUSD_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPayByUSD.Checked)
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
            if(chkPayByUSD.Checked)
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

        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ser1 = GM.GetService1();
            file = ser1.GetCertificate(id, 1);
            if (file != null || id > 0)
            {
                System.IO.FileStream wFile;
                if (!Directory.Exists(GM.Path))
                {
                    Directory.CreateDirectory("C:\\Project");
                }
                wFile = new FileStream("C:\\Project\\" + linkFile.Text, FileMode.Create);
                wFile.Write(file, 0, file.Length);
                wFile.Flush();
                wFile.Close();

                System.Diagnostics.Process.Start(@"C:\\Project\\" + linkFile.Text);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
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
                    linkFile.Text = openFileDialog2.SafeFileName;
                }
            }
        }
        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtCode.Enabled = status;
            cmbShape.Enabled = status;
            cmbCut.Enabled = status;
            txtWeight.Enabled = status;
            txtReportNumber.Enabled = status;
            cmbIdentification.Enabled = status;
            cmbColor.Enabled = status;
            cmbLab.Enabled = status;
            cmbOrigin.Enabled = status;
            cmbComment.Enabled = status;
            dtReportDate.Enabled = status;
            cmbShop.Enabled = status;
            rdoYes.Enabled = status;
            rdoNo.Enabled = status;
            dtDueDate.Enabled = status;
            txtUSDRate.Enabled = status;
            txtTotalBaht.Enabled = status;
            txtNote.Enabled = status;
            chkPayByUSD.Enabled = status;
            txtPriceCaratUSD.Enabled = status;
            btnUpload.Enabled = status;
            btnFileDel.Enabled = status;
            btnChooseDate.Enabled = status;
            btnImage1.Enabled = status;
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
            if (openFileDialog3.ShowDialog() == DialogResult.OK && openFileDialog3.CheckFileExists)
            {
                using (var stream = new FileStream(openFileDialog3.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                if (file.Length > 0)
                {
                    FilePath = openFileDialog3.FileName;
                }
            }
            BuyBookGemstoneCerExcel frm = new BuyBookGemstoneCerExcel(id, FilePath);
            frm.ShowDialog();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbShape_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
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
            ser1.DeleteDataReference(id, 3);

            linkFile.Text = "No File Attached";
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
    