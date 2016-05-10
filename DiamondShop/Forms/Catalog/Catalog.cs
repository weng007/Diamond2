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
        //Service1 ser = GM.GetService();
        dsCatalog tds = new dsCatalog();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        
        public Catalog()
        {
            InitializeComponent();
            Initial();

            BinderData();

            txtUpdateBy.Text = ApplicationInfo.UserName;
        }

        public Catalog(int id)
        {
            InitializeComponent();
            Initial();

            BinderData();
            txtUpdateBy.Text = ApplicationInfo.UserName;
            this.id = id;
            LoadData();
        }

        private void BinderData()
        {
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(txtJewelryType, "JewelryTypeName");
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtMaterial1, "Material1");
            binder.BindControl(txtMaterial2, "Material2");
            binder.BindControl(txtMaterialWeight1, "MaterialWeight1");
            binder.BindControl(txtMaterialWeight2, "MaterialWeight2");
            binder.BindControl(txtMinBeforePremium, "MinBeforePremium");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(txtInvRemark, "InvRemark");
            binder.BindControl(txtRemark, "Remark");
            binder.BindControl(dtImportDate, "CreateDate");
            binder.BindControl(txtUpdateBy, "EditByName");
        }

        protected override void Initial()
        {

            txtCode.Select();

            //SetFieldService.SetRequireField(txtCode, txtNetWeight, txtSize, txtMaterialWeight1, txtMinPrice, txtOpenPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Catalog", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Catalog.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Catalog[0]);
                
                if(image1 !=  null)
                {
                    image1 = tds.Catalog[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (image2 != null)
                {
                    image2 = tds.Catalog[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }              

                EnableDelete = true;

            }

            txtMaterialWeight1.Text = GM.ConvertDoubleToString(txtMaterialWeight1);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice);
            //txtOpenPrice.Text = GM.ConvertDoubleToString(txtOpenPrice);

            base.LoadData();
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
            //if (txtSize.Text == "" || GM.ConvertStringToDouble(txtSize) == 0)
            //{
            //    message += "Please input Size > 0.\n";
            //}
            //if (txtMaterialWeight1.Text == "" || GM.ConvertStringToDouble(txtMaterialWeight1) == 0)
            //{
            //    message += "Please input Cost > 0.\n";
            //}
            //if (txtMinPrice.Text == "" || GM.ConvertStringToDouble(txtMinPrice) == 0)
            //{
            //    message += "Please input Min Price > 0.\n";
            //}
            //if (txtOpenPrice.Text == "" || GM.ConvertStringToDouble(txtOpenPrice) == 0)
            //{
            //    message += "Please input Open Price >0.\n";
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

        //private void gridDiamond_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string color = "";

        //    if (e.ColumnIndex == 3)
        //    {
        //        if (gridDiamond.Rows[e.RowIndex].Cells["ColorGrade"].RowIndex == 0)
        //        {
        //            color = "C001";
        //        }
        //        else
        //        {
        //            color = "C017";
        //        }

        //        DataGridViewComboBoxColumn colColor;
        //        colColor = (DataGridViewComboBoxColumn)gridDiamond.Columns["Color"];
        //        colColor.ValueMember = "ID";
        //        colColor.DisplayMember = "Detail";
        //        colColor.Name = "Color";
        //        colColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
        //        colColor.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail(color)).Tables[0].Rows[e.RowIndex]["Detail"];
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DiamondDetail frm = new DiamondDetail();

            //if (tds.Product.Rows.Count > 0)
            //{
            //    frm.productID = Convert.ToInt16(tds.Product[0]["ID"].ToString());
            //    frm.ShowDialog();

            //    LoadData();
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (gridDiamond.RowCount > 0 && gridDiamond.SelectedRows.Count > 0)
            //{
            //    int id1 = 0;
            //    id1 = (int)gridDiamond.SelectedRows[0].Cells["ID"].Value;
            //    DiamondDetail frm = new DiamondDetail(id1);
            //    frm.productID = Convert.ToInt16(tds.Product[0]["ID"].ToString());
            //    frm.ShowDialog();
            //}

            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
   
        }

        private void DeleteData(int gridNum, int sid)
        {
            if(gridNum == 0)
            try
            {
                ser.DoDeleteData("DiamondDetail", sid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            else if (gridNum == 1)
            try
            {
                ser.DoDeleteData("GemstoneDetail", sid);
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void txtOpenPrice_Leave(object sender, EventArgs e)
        {
            //txtOpenPrice.Text = GM.ConvertDoubleToString(txtOpenPrice);
        }
    }
}
