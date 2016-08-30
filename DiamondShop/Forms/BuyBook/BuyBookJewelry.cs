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
    public partial class BuyBookJewelry : FormInfo
    {
        dsBuyBookJewelry tds = new dsBuyBookJewelry();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        bool isAuthorize = false;

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
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(dtPayDate, "PayDate");
            binder.BindControl(cmbBuyer, "Buyer");
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
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(dtPayDate, "PayDate");
            binder.BindControl(cmbBuyer, "Buyer");

            btnDiamond.Enabled = true;
            btnGemstone.Enabled = true;

            this.id = id;
            LoadData();

            txtCost1_Leave(null, null);

            SetControlEnable(false);
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuyer.DataSource = ds.Tables[0];
            cmbBuyer.ValueMember = "ID";
            cmbBuyer.DisplayMember = "DisplayName";
            cmbBuyer.Refresh();

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

            SetFieldService.SetRequireField(txtSeller, txtWeight, txtMinPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookJewelry", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookJewelry.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookJewelry[0]);            
                
                if (tds.BuyBookJewelry[0].Image1 != null)
                {
                    image1 = tds.BuyBookJewelry[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (tds.BuyBookJewelry[0].Image2 != null)
                {
                    image2 = tds.BuyBookJewelry[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }
                if (tds.BuyBookJewelry[0]["IsPaid"].ToString() == "0")
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
                EnableEdit = true;
                EnableDelete = false;
            }
            SetFormatNumber();
            base.LoadData();
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);

                base.EditData();
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
                    SetControlEnable(true);

                    base.EditData();
                }
            }
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
            row.IsPaid = rdoYes.Checked ? "1" : "0";
            row.Image1 = image1;
            row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("JWR");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookJewelry", tds,0);
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
            if (txtMinPrice.Text == "" || GM.ConvertStringToDouble(txtMinPrice) == 0)
            {
                message += "Please input Min Price > 0.\n";
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
            BBJewelryDiamondDetail frm = new BBJewelryDiamondDetail(id);
            frm.ShowDialog();
        }

        private void btnGemstone_Click(object sender, EventArgs e)
        {
            BBJewelryGemstoneDetail frm = new BBJewelryGemstoneDetail(id);
            frm.ShowDialog();
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

        private void txtCost1_Leave(object sender, EventArgs e)
        {
            txtCost1.Text = GM.ConvertDoubleToString(txtCost1,0);
            txtCost2.Text = GM.ConvertDoubleToString(txtCost2,0);
            txtCost3.Text = GM.ConvertDoubleToString(txtCost3,0);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice,0);
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
        }
        private void SetFormatNumber()
        {
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
            //txtSize.Text = GM.ConvertDoubleToString(txtSize);
        }

        private void txtCost1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtCode.Enabled = status;
            txtCost1.Enabled = status;
            txtCost2.Enabled = status;
            txtCost3.Enabled = status;
            cmbShop.Enabled = status;
            cmbType.Enabled = status;
            cmbMaterial.Enabled = status;
            txtWeight.Enabled = status;
            txtSize.Enabled = status;
            txtMinPrice.Enabled = status;
            txtSeller.Enabled = status;
            txtNote.Enabled = status;
            txtRemark.Enabled = status;
            btnImage1.Enabled = status;
            btnImage2.Enabled = status;
            btnDiamond.Enabled = status;
            btnGemstone.Enabled = status;
            cmbBuyer.Enabled = status;
        }
    }
}
