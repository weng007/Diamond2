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
using DiamondShop.DiamondService1;
using DiamondDS.DS;

namespace DiamondShop
{
    public partial class Inventory : FormInfo
    {
        dsInventory tds = new dsInventory();
        Service2 ser1;
        bool isAuthorize = false;
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        string prefixCode = "";
        double minPremium = 0;
        
        public Inventory()
        {
            InitializeComponent();
            Initial();
            isAuthorize = true;

            BinderData();
            //txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);
        }

        public Inventory(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();

            this.id = id;
            LoadData();
            SetControlEnable(false);
            
            isEdit = false;
        }

        public Inventory(string prefixCode, string code)
        {
            InitializeComponent();
            Initial();
            BinderData();

            this.prefixCode = prefixCode;
            txtOrderCode.Text = code;

            //Set ตามที่เลือกเข้ามา
            SetJewelryType();

            cmbShop.SelectedValue = ApplicationInfo.Shop.ToString();
        }

        public Inventory(string prefix)
        {
            InitializeComponent();
            Initial();
            BinderData();        

            prefixCode = prefix;

            //Set ตามที่เลือกเข้ามา
            SetJewelryType();

            cmbShop.SelectedValue = ApplicationInfo.Shop.ToString();
        }

        private void SetJewelryType()
        {
            if (prefixCode == "DR")
            {
                cmbJewelryType.SelectedValue = 74;
            }
            else if(prefixCode == "DER")
            {
                cmbJewelryType.SelectedValue = 76;
            }
            else if (prefixCode == "GR")
            {
                cmbJewelryType.SelectedValue = 75;
            }
            else if (prefixCode == "GER")
            {
                cmbJewelryType.SelectedValue = 78;
            }
            else if (prefixCode == "WR")
            {
                cmbJewelryType.SelectedValue = 85;
            }
            else if (prefixCode == "IC")
            {
                cmbJewelryType.SelectedValue = 86;
            }
            else if (prefixCode == "NL")
            {
                cmbJewelryType.SelectedValue = 83;
            }
            else if (prefixCode == "BL")
            {
                cmbJewelryType.SelectedValue = 82;
            }
            else if (prefixCode == "CL")
            {
                cmbJewelryType.SelectedValue = 84;
            }
            else if (prefixCode == "BR")
            {
                cmbJewelryType.SelectedValue = 81;
            }
            else if (prefixCode == "PD")
            {
                cmbJewelryType.SelectedValue = 80;
            }
            else if (prefixCode == "SJ")
            {
                cmbJewelryType.SelectedValue = 207;
            }
            else if (prefixCode == "MTO")
            {
                cmbJewelryType.SelectedValue = 79;
            }
        }

        private void BinderData()
        {
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtCode2, "Code2");
            binder.BindControl(txtOrderCode, "OrderNo");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbJewelryType, "JewelryType");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(cmbMaterial1, "Material1");
            binder.BindControl(cmbMaterial2, "Material2");
            binder.BindControl(txtMaterialWeight1, "MaterialWeight1");
            binder.BindControl(txtMaterialWeight2, "MaterialWeight2");
            binder.BindControl(txtPricePerGram1, "PricePerGram1");
            binder.BindControl(txtPricePerGram2, "PricePerGram2");
            binder.BindControl(txtMaterialCost1, "MaterialCost1");
            binder.BindControl(txtMaterialCost2, "MaterialCost2");
            binder.BindControl(txtMaterialNetCost, "MaterialNetCost");
            binder.BindControl(txtLaborCost, "LaborCost");
            binder.BindControl(txtCost1, "Cost1");
            binder.BindControl(txtCost2, "Cost2");
            binder.BindControl(txtCost3, "Cost3");
            binder.BindControl(txtCostBody, "CostBody");
            binder.BindControl(txtCostNonCer, "CostNonCer");
            binder.BindControl(txtCostCer, "CostCer");
            binder.BindControl(txtRedCost, "RedCost");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(txtRedCost1, "MinPremium");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(txtUpdateBy, "EditByName");
            binder.BindControl(txtTechnician, "Technicial");
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(dtImportDate, "CreateDate");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtPricePerGram11, "PricePerGram11");
            binder.BindControl(txtPricePerGram22, "PricePerGram22");
        }

        protected override void Initial()
        {
            cmbMaterial1.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial1.ValueMember = "ID";
            cmbMaterial1.DisplayMember = "Detail";
            cmbMaterial1.Refresh();

            cmbMaterial2.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial2.ValueMember = "ID";
            cmbMaterial2.DisplayMember = "Detail";
            cmbMaterial2.Refresh();

            cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbJewelryType.ValueMember = "ID";
            cmbJewelryType.DisplayMember = "Detail";
            cmbJewelryType.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbShop.Select();

            SetFieldService.SetRequireField(txtPricePerGram2,txtPricePerGram22,txtMinPrice, txtPriceTag);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Inventory", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Inventory.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Inventory[0]);
                minPremium = tds.Inventory[0].MinPremium;

                if (tds.Inventory[0].MoreMaterial == "0")
                { chkMoreMaterial.Checked = false; }
                else { chkMoreMaterial.Checked = true; }

                SetPrice();

                if(tds.Inventory[0].Image1 !=  null)
                {
                    image1 = tds.Inventory[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (tds.Inventory[0].Image2 != null)
                {
                    image2 = tds.Inventory[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }

                if (!isAuthorize)
                {
                    EnableSave = false;
                    EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                    EnableDelete = false;
                }
            }
            SetFormatNumber();
            base.LoadData();

            cmbShop.SelectedValueChanged += cmbShop_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsInventory.InventoryRow row = null;

            if (tds.Inventory.Rows.Count > 0)
            {
                row = tds.Inventory[0];
            }
            else
            {
                row = tds.Inventory.NewInventoryRow();
                tds.Inventory.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            row.CreateBy = ApplicationInfo.UserID;
            row.MoreMaterial = chkMoreMaterial.Checked?"1":"0";
            row.Image1 = image1;
            row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber(prefixCode);
                    SetCreateBy(row);               
                    chkFlag = ser.DoInsertData("Inventory", tds,0);

                    if(chkFlag)
                    {
                        ser1 = GM.GetService1();
                        id = ser1.DoSearchInventoryByCode(row.Code);

                        SetControlEnable(true);
                        isAuthorize = true;
                    }
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Inventory", tds);
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //ไม่ให้ปิดหน้าจอหลัง Save
            isClosed = false;
            LoadData();

            return chkFlag;
        }

        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("Inventory", id);

                if (!chkFlag)
                {
                    Popup.Popup pop = new Popup.Popup("Jewelry ไม่อยู่ในสถานะลบได้");
                    pop.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            isEdit = true;
            return chkFlag;
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                if (cmbStatus.SelectedValue.ToString() == "73")
                {
                    EnableDelete = true;
                }
                SetControlEnable(true);
                base.EditData();
            }
            else
            {
                RequirePassword frm = new RequirePassword(Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    if (cmbStatus.SelectedValue.ToString() == "73")
                    {
                        EnableDelete = true;
                    }
                    SetControlEnable(true);
                    base.EditData();
                }
            }
        }
        protected override bool ValidateData()
        {
            message = "";

            if (chkMoreMaterial.Checked)
            {
                if (txtPricePerGram2.Text == "" || txtPricePerGram2.Text == "0" || txtPricePerGram22.Text == "" || txtPricePerGram22.Text == "0")
                {
                    message += "Please input Price2 Per Gram > 0.\n";
                }
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

        private void btnImage2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
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

        private void txtNetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkMoreMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMoreMaterial.Checked)
            {
                panel3.Enabled = true;
            }
            else
            {
                panel3.Enabled = false;

                txtPricePerGram2.Text = "0";
                txtPricePerGram22.Text = "0";
            }
        }

        private void txtMaterialWeight1_TextChanged(object sender, EventArgs e)
        {
            txtMaterialCost1.Text = (GM.ConvertStringToDouble(txtMaterialWeight1) * GM.ConvertStringToDouble(txtPricePerGram1)).ToString();
            //txtMaterialCost11.Text = (GM.ConvertStringToDouble(txtMaterialWeight1) * GM.ConvertStringToDouble(txtPricePerGram11)).ToString();
            txtMaterialCost1_Leave(null, null);

            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody) + GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();
            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost, 0);

            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);

            //txtMaterialCost11.Text = GM.ConvertDoubleToString(txtMaterialCost11,0);
            isEdit = true;
        }

        private void txtMaterialWeight2_TextChanged(object sender, EventArgs e)
        {
            txtMaterialCost2.Text = (GM.ConvertStringToDouble(txtMaterialWeight2) * GM.ConvertStringToDouble(txtPricePerGram2)).ToString();
            txtMaterialCost22.Text = (GM.ConvertStringToDouble(txtMaterialWeight2) * GM.ConvertStringToDouble(txtPricePerGram22)).ToString();

            txtMaterialCost2.Text = GM.ConvertDoubleToString(txtMaterialCost2,0);
            txtMaterialCost22.Text = GM.ConvertDoubleToString(txtMaterialCost22,0);

            isEdit = true;
        }

        private void txtPricePerGram11_TextChanged(object sender, EventArgs e)
        {
            txtMaterialCost11.Text = (GM.ConvertStringToDouble(txtMaterialWeight1) * GM.ConvertStringToDouble(txtPricePerGram11)).ToString();
            txtMaterialCost11.Text = GM.ConvertDoubleToString(txtMaterialCost11,0);

            isEdit = true;
        }

        private void txtPricePerGram22_TextChanged(object sender, EventArgs e)
        {
            txtMaterialCost22.Text = (GM.ConvertStringToDouble(txtMaterialWeight2) * GM.ConvertStringToDouble(txtPricePerGram22)).ToString();
            txtMaterialCost22.Text = GM.ConvertDoubleToString(txtMaterialCost22,0);

            isEdit = true;
        }

        private void txtMaterialCost1_TextChanged(object sender, EventArgs e)
        {
            txtMaterialNetCost.Text = (GM.ConvertStringToDouble(txtMaterialCost1) + GM.ConvertStringToDouble(txtMaterialCost2)).ToString();
            txtMaterialNetCost.Text = GM.ConvertDoubleToString(txtMaterialNetCost,0);
            txtMaterialNetCost_Leave(null, null);

            isEdit = true;
        }

        private void txtMaterialCost11_TextChanged(object sender, EventArgs e)
        {
            txtMaterialNetCost1.Text = (GM.ConvertStringToDouble(txtMaterialCost11) + GM.ConvertStringToDouble(txtMaterialCost22)).ToString();
            txtMaterialNetCost1.Text = GM.ConvertDoubleToString(txtMaterialNetCost1,0);

            isEdit = true;
        }

        private void txtLaborCost_TextChanged(object sender, EventArgs e)
        {
            txtCost3_TextChanged(sender, e);
            txtLaborCost1.Text = (GM.ConvertStringToDouble(txtLaborCost) * 2).ToString();

            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody) + GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();
            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost, 0);
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);
 
            isEdit = true;
        }

        private void txtCost1_TextChanged(object sender, EventArgs e)
        {
            txtCost3_TextChanged(sender, e);
            txtCost11.Text = (GM.ConvertStringToDouble(txtCost1) * 2).ToString();

            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody) + GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();

            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost, 0);
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);
 
            isEdit = true;
        }

        private void txtCost2_TextChanged(object sender, EventArgs e)
        {
            txtCost3_TextChanged(sender, e);
            txtCost22.Text = (GM.ConvertStringToDouble(txtCost2) * 2).ToString();

            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody) + GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();

            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost, 0);
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);

            isEdit = true;
        }

        private void txtCost3_TextChanged(object sender, EventArgs e)
        {
            //txtCost33.Text = (GM.ConvertStringToDouble(txtCost3) * 2).ToString();
            txtCostBody.Text = (GM.ConvertStringToDouble(txtMaterialNetCost) + GM.ConvertStringToDouble(txtLaborCost) + GM.ConvertStringToDouble(txtCost1) +
                GM.ConvertStringToDouble(txtCost2) + GM.ConvertStringToDouble(txtCost3)).ToString();

            txtCostBody.Text = GM.ConvertDoubleToString(txtCostBody,0);

            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody) + GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();
            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost, 0);
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost, 0);

            isEdit = true;
        }

        private void txtMaterialNetCost_TextChanged(object sender, EventArgs e)
        {
            txtCostBody.Text = (GM.ConvertStringToDouble(txtMaterialNetCost) + GM.ConvertStringToDouble(txtLaborCost) + GM.ConvertStringToDouble(txtCost1) +
                GM.ConvertStringToDouble(txtCost2) + GM.ConvertStringToDouble(txtCost3)).ToString();
            //txtPricePerGram1_Leave(sender, e);

            txtCostBody.Text = GM.ConvertDoubleToString(txtCostBody, 0);

            isEdit = true;
        }

        private void txtMaterialNetCost1_TextChanged(object sender, EventArgs e)
        {
            txtCostBody1.Text = (GM.ConvertStringToDouble(txtMaterialNetCost1) + GM.ConvertStringToDouble(txtLaborCost1) + GM.ConvertStringToDouble(txtCost11) +
                GM.ConvertStringToDouble(txtCost22) + GM.ConvertStringToDouble(txtCost33)).ToString();
            txtPricePerGram1_Leave(sender, e);

            txtCostBody1.Text = GM.ConvertDoubleToString(txtCostBody1, 0);
            isEdit = true;
        }

        private void txtCostNonCer_TextChanged(object sender, EventArgs e)
        {
            txtRedCost.Text = (GM.ConvertStringToDouble(txtCostBody)+ GM.ConvertStringToDouble(txtCostNonCer) + GM.ConvertStringToDouble(txtCostCer)).ToString();         

            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost,0);

            isEdit = true;
        }

        private void txtPricePerGram1_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            double cost = GM.ConvertStringToDouble(txt);
            cost = Math.Ceiling(cost / 100) * 100;
            txt.Text = cost.ToString();

            txt.Text = GM.ConvertDoubleToString(txt, 0);
        }

        private void txtMaterialWeight1_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Text = GM.ConvertDoubleToString(txt);
        }

        private void SetFormatNumber()
        {
            //txtMaterialCost1.Text = GM.ConvertDoubleToString(txtMaterialCost1, 0);
            txtMaterialCost1.Text = GM.ConvertDoubleToString(txtMaterialCost1, 0);
            txtMaterialCost2.Text = GM.ConvertDoubleToString(txtMaterialCost2, 0);

            txtPricePerGram1.Text= GM.ConvertDoubleToString(txtPricePerGram1, 0);
            txtPricePerGram11.Text = GM.ConvertDoubleToString(txtPricePerGram11, 0);
            txtPricePerGram2.Text = GM.ConvertDoubleToString(txtPricePerGram2, 0);
            txtPricePerGram22.Text = GM.ConvertDoubleToString(txtPricePerGram22, 0);

            txtMaterialCost11.Text = GM.ConvertDoubleToString(txtMaterialCost11, 0);
            txtMaterialCost22.Text = GM.ConvertDoubleToString(txtMaterialCost22, 0);

            txtMaterialNetCost.Text = GM.ConvertDoubleToString(txtMaterialNetCost, 0);
            txtMaterialNetCost1.Text = GM.ConvertDoubleToString(txtMaterialNetCost1, 0);

            txtLaborCost.Text = GM.ConvertDoubleToString(txtLaborCost, 0);
            txtCost1.Text = GM.ConvertDoubleToString(txtCost1, 0);
            txtCost2.Text = GM.ConvertDoubleToString(txtCost2, 0);
            txtCost3.Text = GM.ConvertDoubleToString(txtCost3, 0);

            txtCostBody.Text = GM.ConvertDoubleToString(txtCostBody, 0);
            txtCostBody1.Text = GM.ConvertDoubleToString(txtCostBody1, 0);

            txtCostNonCer.Text = GM.ConvertDoubleToString(txtCostNonCer, 0);
            txtCostNonCer1.Text = GM.ConvertDoubleToString(txtCostNonCer1, 0);

            txtCostCer.Text = GM.ConvertDoubleToString(txtCostCer, 0);
            txtCostCer1.Text = GM.ConvertDoubleToString(txtCostCer1, 0);

            txtRedCost.Text = GM.ConvertDoubleToString(txtRedCost,0);

            txtRedCost1.Text = minPremium.ToString();
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost1,0);

            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice,0);
            txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag,0);
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                SaveData();
            }
            InvDiamondDetail frm = new InvDiamondDetail(id);
            frm.ShowDialog();

            txtPricePerGram1_Leave(txtCostCer, null);
            txtPricePerGram1_Leave(txtCostNonCer, null);

            LoadData();          
        }

        private void btnGemstone_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                SaveData();
            }
            InvGemstoneDetail frm = new InvGemstoneDetail(id);
            frm.ShowDialog();

            LoadData();
            txtPricePerGram1_Leave(txtCostCer, null);
            txtPricePerGram1_Leave(txtCostNonCer, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Report.ReportViewer report = new Report.ReportViewer(id);
            //report.ShowDialog();
        }

        private void SetPrice()
        {
            ser1 = GM.GetService1();
            ds = ser1.GetPriceDaimondAndGemstone(id);

            if (ds.Tables[0].Rows.Count > 0)
            {            
                txtCostNonCer.Text = Convert.ToString(Convert.ToDouble(ds.Tables[0].Rows[0]["Cost"]) + Convert.ToDouble(ds.Tables[0].Rows[1]["Cost"]));
                //txtCostNonCer1.Text = Convert.ToString(Convert.ToDouble(ds.Tables[0].Rows[0]["Price"]) + Convert.ToDouble(ds.Tables[0].Rows[1]["Price"]));
                txtCostCer.Text = Convert.ToString(Convert.ToDouble(ds.Tables[0].Rows[2]["Cost"]) + Convert.ToDouble(ds.Tables[0].Rows[3]["Cost"]));
                //txtCostCer1.Text = Convert.ToString(Convert.ToDouble(ds.Tables[0].Rows[2]["Price"]) + Convert.ToDouble(ds.Tables[0].Rows[3]["Price"]));

                double cost = GM.ConvertStringToDouble(txtCostNonCer);
                cost = Math.Ceiling(cost / 100) * 100;
                txtCostNonCer.Text = cost.ToString();
                txtCostNonCer.Text = GM.ConvertDoubleToString(txtCostNonCer, 0);

                cost = GM.ConvertStringToDouble(txtCostCer);
                cost = Math.Ceiling(cost / 100) * 100;
                txtCostCer.Text = cost.ToString();
                txtCostCer.Text = GM.ConvertDoubleToString(txtCostCer, 0);
            }
        }

        private void cmbShop_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtUpdateDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void txtRedCost1_Leave(object sender, EventArgs e)
        {
            txtRedCost1.Text = GM.ConvertDoubleToString(txtRedCost1, 0);
        }

        //ใช้เฉพาะ txtPricePerGram1
        private void txtPricePerGram_Leave(object sender, EventArgs e)
        {
            txtPricePerGram1.Text = GM.ConvertDoubleToString(txtPricePerGram1, 0);
        }

        private void txtCostCer_BindingContextChanged(object sender, EventArgs e)
        {
            txtPricePerGram1_Leave(sender, e);
        }

        private void txtMaterialNetCost_Leave(object sender, EventArgs e)
        {
            double cost = GM.ConvertStringToDouble(txtMaterialNetCost);
            cost = Math.Ceiling(cost / 100) * 100;
            txtMaterialNetCost.Text = cost.ToString();

            txtMaterialNetCost.Text = GM.ConvertDoubleToString(txtMaterialNetCost, 0);
        }

        private void txtMaterialCost1_Leave(object sender, EventArgs e)
        {
            double cost = GM.ConvertStringToDouble(txtMaterialCost1);
            cost = Math.Ceiling(cost / 100) * 100;
            txtMaterialCost1.Text = cost.ToString();

            txtMaterialCost1.Text = GM.ConvertDoubleToString(txtMaterialCost1, 0);
        }

        private void SetControlEnable(bool status)
        {
            dtUpdateDate.Enabled = status;
            txtCode2.Enabled = status;
            cmbShop.Enabled = status;
            txtSize.Enabled = status;
            dtImportDate.Enabled = status;
            cmbMaterial2.Enabled = status;
            txtPricePerGram1.Enabled = status;
            txtMaterialWeight2.Enabled = status;
            txtPricePerGram2.Enabled = status;
            txtPricePerGram22.Enabled = status;
            txtMaterialCost2.Enabled = status;
            txtMaterialCost22.Enabled = status;
            cmbMaterial1.Enabled = status;
            txtMaterialWeight1.Enabled = status;
            txtPricePerGram11.Enabled = status;
            txtLaborCost.Enabled = status;
            txtCost1.Enabled = status;
            txtCost2.Enabled = status;
            txtCost3.Enabled = status;
            txtTechnician.Enabled = status;
            txtMinPrice.Enabled = status;
            txtPriceTag.Enabled = status;
            btnDiamond.Enabled = status;
            btnGemstone.Enabled = status;
            txtRedCost1.Enabled = status;
            btnImage1.Enabled = status;
            btnImage2.Enabled = status;
            txtRemark.Enabled = status;
            chkMoreMaterial.Enabled = status;
        }
    }
}
