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
    public partial class BuyBookJewelry : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsBuyBookJewelry tds = new dsBuyBookJewelry();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;

        public BuyBookJewelry()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbType, "JewelryType");
            binder.BindControl(CmbStatus, "Status");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCost1, "CostBaht");
            binder.BindControl(txtCost2, "CostUSD");
            binder.BindControl(txtCost3, "CostYen");
            binder.BindControl(txtNote, "NoteForRate");
            binder.BindControl(btnImage1, "Image1");
            binder.BindControl(btnImage2, "Image2");
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(txtMinPrice, "MinPrice");
        }
        public BuyBookJewelry(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbType, "JewelryType");
            binder.BindControl(CmbStatus, "Status");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCost1, "CostBaht");
            binder.BindControl(txtCost2, "CostUSD");
            binder.BindControl(txtCost3, "CostYen");
            binder.BindControl(txtNote, "NoteForRate");
            binder.BindControl(btnImage1, "Image1");
            binder.BindControl(btnImage2, "Image2");
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(txtMinPrice, "MinPrice");

            this.id = id;
            LoadData();

            txtCost1_Leave(null, null);
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbType.ValueMember = "ID";
            cmbType.DisplayMember = "Detail";
            cmbType.Refresh();

            CmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            CmbStatus.ValueMember = "ID";
            CmbStatus.DisplayMember = "Detail";
            CmbStatus.Refresh();

            cmbMaterial.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial.ValueMember = "ID";
            cmbMaterial.DisplayMember = "Detail";
            cmbMaterial.Refresh();

            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller, txtWeight);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookJewelry", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookJewelry.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookJewelry[0]);
                image1 = tds.BuyBookJewelry[0].Image1;
                image2 = tds.BuyBookJewelry[0].Image2;
                if (image1 != null)
                {
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (image2 != null)
                {
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookJewelry.BuyBookJewelryRow row = null;

            if (tds.BuyBookJewelry.Rows.Count > 0)
            {
                row = tds.BuyBookJewelry[0];
            }
            else
            {
                row = tds.BuyBookJewelry.NewBuyBookJewelryRow();
                tds.BuyBookJewelry.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.Image1 = image1;
            row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("JWR");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookJewelry", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookJewelry", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookJewelry", id);
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
                message += "Please input Weight > 0.\n";
            }
            if (txtSeller.Text == "")
            {
                message += "Please input Seller.\n";
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

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            BBJewelryDiamondDetail frm = new BBJewelryDiamondDetail();
            frm.ShowDialog();
        }

        private void btnGemstone_Click(object sender, EventArgs e)
        {
            BBJewelryGemstoneDetail frm = new BBJewelryGemstoneDetail();
            frm.ShowDialog();
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

        private void btnImage2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image2 = new byte[fs.Length];
                fs.Read(image2, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void txtCost1_Leave(object sender, EventArgs e)
        {
            txtCost1.Text = GM.ConvertDoubleToString(txtCost1,0);
            txtCost2.Text = GM.ConvertDoubleToString(txtCost2,0);
            txtCost3.Text = GM.ConvertDoubleToString(txtCost3,0);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice,0);
        }
        
        private void txtCost1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
