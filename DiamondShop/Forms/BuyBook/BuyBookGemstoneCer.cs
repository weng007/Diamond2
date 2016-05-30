﻿using System;
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
    public partial class BuyBookGemstoneCer : FormInfo
    {
        dsBuyBookGemstoneCer tds = new dsBuyBookGemstoneCer();
        bool isAuthorize = false;
        MemoryStream ms1;
        byte[] image1;
        MemoryStream ms;
        byte[] file;

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
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbComment, "Comment");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbColor, "Color");
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
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbComment, "Comment");
            binder.BindControl(cmbCut, "Cut");
            binder.BindControl(cmbColor, "Color");

            this.id = id;
            LoadData();

        }

        protected override void Initial()
        {
            cmbSetting.DataSource = (GM.GetMasterTableDetail("C015",false)).Tables[0];
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

            SetFieldService.SetRequireField(txtWeight);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstoneCer", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookGemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookGemstoneCer[0]);

                if (tds.BuyBookGemstoneCer[0]["Certificate"].ToString() != "")
                {
                    file = (byte[])tds.BuyBookGemstoneCer[0]["Certificate"];
                    linkFile.Text = "Certificate";
                }


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
                EnableEdit = true;
                EnableDelete = false;
            }
            SetFormatNumber();
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
            row.Image1 = image1;
            row.IsPaid = rdoYes.Checked ? "1" : "0";

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
                chkFlag = ser.DoDeleteData("BuyBookGemstoneCer", id);
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

            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input  Weight > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void btnImage1_Click(object sender, EventArgs e)
        {
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

        private void chkPayByUSD_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPayByUSD.Checked)
            {
                txtPriceCaratUSD.Enabled = true;
                txtUSDRate.Enabled = true;

                txtPriceCarat.Enabled = false;
                txtPriceCarat.Text = "0";
                txtUSDRate_Leave(null, null);
            }
            else
            {
                txtPriceCaratUSD.Enabled = false;
                txtUSDRate.Enabled = false;
                txtUSDRate.Text = "0";
                txtTotalBaht.Text = "0";

                txtPriceCarat.Enabled = true;                       
            }       
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if(chkPayByUSD.Checked)
            {
                txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCaratUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            }
            else
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
            }
            
        }

        private void txtPriceCarat_Leave(object sender, EventArgs e)
        {
            if (!chkPayByUSD.Checked)
            {
                txtTotalBaht.Text = (GM.ConvertStringToDouble(txtPriceCarat) * GM.ConvertStringToDouble(txtWeight)).ToString();
            }
        }

        private void txtPriceCaratUSD_Leave(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (GM.ConvertStringToDouble(txtWeight) * GM.ConvertStringToDouble(txtPriceCaratUSD)).ToString();
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
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
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void SetFormatNumber()
        {
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCarat.Text = GM.ConvertDoubleToString(txtPriceCarat, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (file != null && file.Length > 0)
            {
                System.IO.FileStream wFile;
                if (!Directory.Exists(GM.Path))
                {
                    Directory.CreateDirectory("C:\\Project");
                }
                wFile = new FileStream("C:\\Project\\Certificate.pdf", FileMode.Create);
                wFile.Write(file, 0, file.Length);
                wFile.Flush();
                wFile.Close();

                System.Diagnostics.Process.Start(@"C:\\Project\\Certificate.pdf");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists)
            {
                using (var stream = new FileStream(openFileDialog1.InitialDirectory + openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                if (file.Length > 0)
                {
                    linkFile.Text = "Certificate";
                }
            }
        }
    }
}
