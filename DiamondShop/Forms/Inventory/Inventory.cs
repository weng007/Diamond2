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
    public partial class Inventory : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsProduct tds = new dsProduct();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        
        public Inventory()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
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
            binder.BindControl(txtCost4, "Cost4");
            binder.BindControl(txtCostDiamondCer, "CostDiamondCer");
            //binder.BindControl(txtCostGemstoneCer, "CostGemstoneCer");
            binder.BindControl(txtRedCost, "RedCost");
            binder.BindControl(txtMinBeforePremium, "MinBeforePremium");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(txtMinPrice, "Remark");

            txtUpdateBy.Text = ApplicationInfo.UserName;
        }

        public Inventory(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
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
            binder.BindControl(txtCost4, "Cost4");
            binder.BindControl(txtCostDiamondCer, "CostDiamondCer");
            //binder.BindControl(txtCostGemstoneCer, "CostGemstoneCer");
            binder.BindControl(txtRedCost, "RedCost");
            binder.BindControl(txtMinBeforePremium, "MinBeforePremium");
            binder.BindControl(txtMinPrice, "MinPrice");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(txtMinPrice, "Remark");

            this.id = id;
            LoadData();
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

            //gridDiamond
            //DataGridViewComboBoxColumn colShape;
            //colShape = (DataGridViewComboBoxColumn)gridDiamond.Columns["Shape"];
            //colShape.ValueMember = "ID";
            //colShape.DisplayMember = "Detail";
            //colShape.Name = "Shape";
            //colShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //colShape.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0]["Detail"];
            ////colShape.DefaultCellStyle.DataSourceNullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0];

            //DataGridViewComboBoxColumn colColorGrade;
            //colColorGrade = (DataGridViewComboBoxColumn)gridDiamond.Columns["ColorGrade"];
            //colColorGrade.ValueMember = "ID";
            //colColorGrade.DisplayMember = "Detail";
            //colColorGrade.Name = "ColorGrade";
            //colColorGrade.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            //colColorGrade.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C025")).Tables[0].Rows[0]["Detail"];

            //DataGridViewComboBoxColumn colClarity;
            //colClarity = (DataGridViewComboBoxColumn)gridDiamond.Columns["Clarity"];
            //colClarity.ValueMember = "ID";
            //colClarity.DisplayMember = "Detail";
            //colClarity.Name = "Clarity";
            //colClarity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            //colClarity.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C002")).Tables[0].Rows[0]["Detail"];

            txtMaterialWeight1.Text = GM.ConvertDoubleToString(txtMaterialWeight1);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice);
            //txtOpenPrice.Text = GM.ConvertDoubleToString(txtOpenPrice);

            //gridDiamond.AutoGenerateColumns = false;
            //gridGemstone.AutoGenerateColumns = false;

            txtCode.Select();

            //SetFieldService.SetRequireField(txtCode, txtNetWeight, txtSize, txtMaterialWeight1, txtMinPrice, txtOpenPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Product", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Product.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Product[0]);

                //Image
                image1 = tds.Product[0].Image1;
                image2 = tds.Product[0].Image2;
                if(image1 !=  null)
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

                //gridDiamond.DataSource = tds.DiamondDetail;
                //gridGemstone.DataSource = tds.GemstoneDetail;

                //gridDiamond.Refresh();
                //gridGemstone.Refresh();
            }

            txtMaterialWeight1.Text = GM.ConvertDoubleToString(txtMaterialWeight1);
            txtMinPrice.Text = GM.ConvertDoubleToString(txtMinPrice);
            //txtOpenPrice.Text = GM.ConvertDoubleToString(txtOpenPrice);

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsProduct.ProductRow row = null;

            if (tds.Product.Rows.Count > 0)
            {
                row = tds.Product[0];
            }
            else
            {
                row = tds.Product.NewProductRow();
                tds.Product.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.UserID = ApplicationInfo.UserID;
            row.Image1 = image1;
            row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);               
                    chkFlag = ser.DoInsertData("Product", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Product", tds);
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
                chkFlag = ser.DoDeleteData("Product", id);
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

            //if (txtCode.Text == "")
            //{
            //    message += "Please input Code.\n";
            //}
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
            //if (gridDiamond.SelectedRows.Count > 0)
            //{
            //    DeleteData(0, (int)gridDiamond.SelectedRows[0].Cells["ID"].Value);
            //    LoadData();
            //}
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
