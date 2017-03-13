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
    public partial class Catalog : FormInfo
    {
        dsCatalog tds = new dsCatalog();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        
        public Catalog()
        {
            InitializeComponent();
            Initial();

            BinderData();
        }

        public Catalog(int id)
        {
            InitializeComponent();
            Initial();

            BinderData();
            this.id = id;
            LoadData();

            isEdit = false;
        }

        private void BinderData()
        {
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(txtJewelryType, "JewelryTypeName");
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtMaterial1, "Material1Name");
            binder.BindControl(txtMaterial2, "Material2Name");
            binder.BindControl(txtMaterialWeight1, "MaterialWeight1");
            binder.BindControl(txtMaterialWeight2, "MaterialWeight2");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(txtMinBeforePremium, "MinPremium");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(txtInvRemark, "RemarkInv");
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(txtSellDate, "SellDate");
            binder.BindControl(dtImportDate, "CreateDate");
            binder.BindControl(txtUpdateBy, "EditByName");
        }

        protected override void Initial()
        {
            txtRemark.Select();

            //SetFieldService.SetRequireField(txtCode, txtNetWeight, txtSize, txtMaterialWeight1, txtMinPrice, txtOpenPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Catalog", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Catalog.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Catalog[0]);

                if (tds.Catalog[0].Image1 !=  null)
                {
                    image1 = tds.Catalog[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (tds.Catalog[0].Image2 != null)
                {
                    image2 = tds.Catalog[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }              
            }

            SetFormatNumber();

            base.LoadData();

        }

        private void SetFormatNumber()
        {
            txtMaterialWeight1.Text = GM.ConvertDoubleToString(txtMaterialWeight1);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice);
            txtMinBeforePremium.Text = GM.ConvertDoubleToString(txtMinBeforePremium);
            txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag);
        }


        protected override bool SaveData()
        {
            dsCatalog.CatalogRow row = null;

            if (tds.Catalog.Rows.Count > 0)
            {
                row = tds.Catalog[0];
            }
            else
            {
                row = tds.Catalog.NewCatalogRow();
                tds.Catalog.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Catalog", tds);

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
                //chkFlag = ser.DoDeleteData("Product", id);
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

            if (txtRemark.Text == "")
            {
                message += "Please input Remark.\n";
            }
            //if (txtNetWeight.Text == "" || GM.ConvertStringToDouble(txtNetWeight) == 0)
            //{
            //    message += "Please input Net Weight > 0.\n";
            //}

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

        private void txtCost_Leave(object sender, EventArgs e)
        {
            txtMaterialWeight1.Text = GM.ConvertDoubleToString(txtMaterialWeight1);
        }

        private void txtMinPrice_Leave(object sender, EventArgs e)
        {
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice);
        }

        private void txtNetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            DiamondDetailCatalog frm = new DiamondDetailCatalog(Convert.ToInt32(tds.Tables[0].Rows[0]["RefID"].ToString()));
            frm.ShowDialog();
        }

        private void txtUpdateBy_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtImportDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnGemstone_Click(object sender, EventArgs e)
        {
            GemstoneDetailCatalog frm = new GemstoneDetailCatalog(Convert.ToInt32(tds.Tables[0].Rows[0]["RefID"].ToString()));
            frm.ShowDialog();
        }
    }
}
