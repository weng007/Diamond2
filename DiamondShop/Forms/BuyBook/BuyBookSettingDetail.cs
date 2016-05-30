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
    public partial class BuyBookSettingDetail : FormInfo
    {
        dsBuyBookSettingDetail tds = new dsBuyBookSettingDetail();
        MemoryStream ms1;
        int mode = 0;
        byte[] image1;

        public BuyBookSettingDetail()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbSettingType, "SettingType");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtLaborCost, "LaborCost");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtPricePerGram, "PricePerGram");
            binder.BindControl(txtPricePerUnit, "PricePerUnit");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");
        }
        public BuyBookSettingDetail(int id, int mode)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbSettingType, "SettingType");
            binder.BindControl(txtAmount, "Amount");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtLaborCost, "LaborCost");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtPricePerGram, "PricePerGram");
            binder.BindControl(txtPricePerUnit, "PricePerUnit");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtTotalUSD, "TotalUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtTotalBaht, "TotalBaht");


            this.id = id;
            this.mode = mode;

            if (mode == 1)
            {
                LoadData();
            }
            
        }
        protected override void Initial()
        {
            cmbSettingType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbSettingType.ValueMember = "ID";
            cmbSettingType.DisplayMember = "Detail";
            cmbSettingType.Refresh();

            cmbMaterial.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial.ValueMember = "ID";
            cmbMaterial.DisplayMember = "Detail";
            cmbMaterial.Refresh();

            cmbSettingType.Select();

            SetFieldService.SetRequireField(txtAmount,txtWeight, txtTotalUSD, txtUSDRate);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookSettingDetail", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BBSettingDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BBSettingDetail[0]);          

                if (tds.BBSettingDetail[0].Image1 != null)
                {
                    image1 = tds.BBSettingDetail[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                EnableDelete = true;
            }

            SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookSettingDetail.BBSettingDetailRow row = null;

            if (tds.BBSettingDetail.Rows.Count > 0)
            {
                row = tds.BBSettingDetail[0];
            }
            else
            {
                row = tds.BBSettingDetail.NewBBSettingDetailRow();
                tds.BBSettingDetail.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.Image1 = image1;

            try
            {
                if (mode == 0)
                {
                    row.RefID = id;

                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookSettingDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookSettingDetail", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookSettingDetail", id);
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

            if (txtAmount.Text == "" || GM.ConvertStringToDouble(txtAmount) == 0)
            {
                message = "Please input Amount > 0.\n";
            }
            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input Weight > 0.\n";
            }
            if (txtTotalUSD.Text == "" || GM.ConvertStringToDouble(txtTotalUSD) == 0)
            {
                message += "Please input Total USD > 0.\n";
            }
            if (txtUSDRate.Text == "" || GM.ConvertStringToDouble(txtUSDRate) == 0)
            {
                message += "Please input USD Rate > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            txtAmount.Text = GM.ConvertDoubleToString(txtAmount, 0);
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
        }

        private void txtLaborCost_Leave(object sender, EventArgs e)
        {
            txtLaborCost.Text = GM.ConvertDoubleToString(txtLaborCost,0);
        }

        private void txtPricePerUnit_Leave(object sender, EventArgs e)
        {
            txtPricePerUnit.Text = GM.ConvertDoubleToString(txtPricePerUnit, 0);
        }

        private void txtTotalUSD_Leave(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();

            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotalUSD) * GM.ConvertStringToDouble(txtUSDRate)).ToString();

            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }
        private void txtPricePerGram_Leave(object sender, EventArgs e)
        {
            txtPricePerGram.Text = GM.ConvertDoubleToString(txtPricePerGram, 0);
        }

        private void SetFormatNumber()
        {
            txtAmount.Text = GM.ConvertDoubleToString(txtAmount, 0);
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight);
            txtLaborCost.Text = GM.ConvertDoubleToString(txtLaborCost, 0);
            txtPricePerGram.Text = GM.ConvertDoubleToString(txtPricePerGram, 0);
            txtPricePerUnit.Text = GM.ConvertDoubleToString(txtPricePerUnit, 0);
            txtTotalUSD.Text = GM.ConvertDoubleToString(txtTotalUSD, 0);
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
            txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
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

        
    }
}
