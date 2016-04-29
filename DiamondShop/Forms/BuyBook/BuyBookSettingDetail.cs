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
        ////Service1 ser = GM.GetService();
        dsBuyBookSettingDetail tds = new dsBuyBookSettingDetail();
        MemoryStream ms1;
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
        public BuyBookSettingDetail(int id)
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
            LoadData();
        }
        protected override void Initial()
        {
            cmbSettingType.DataSource = (GM.GetMasterTableDetail("C005")).Tables[0];
            cmbSettingType.ValueMember = "ID";
            cmbSettingType.DisplayMember = "Detail";
            cmbSettingType.Refresh();

            cmbMaterial.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial.ValueMember = "ID";
            cmbMaterial.DisplayMember = "Detail";
            cmbMaterial.Refresh();

            //dtDate.Select();

            //SetFieldService.SetRequireField(txtAmount, txtMeasure1, txtMeasure2, txtMeasure3, txtCarat);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookSettingDetail", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BBSettingDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BBSettingDetail[0]);
                image1 = tds.BBSettingDetail[0].Image1;

                if (image1 != null)
                {
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                EnableDelete = true;
            }

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
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BBSettingDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BBSettingDetail", tds);
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
                chkFlag = ser.DoDeleteData("BBSettingDetail", id);
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

            if (txtAmount.Text == "")
            {
                message = "Please input GIA Number.\n";
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

        

        private void cmbColorGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "C017";

            //if (cmbColorGrade.SelectedIndex == 0)
            //{
            //    color = "C001";
            //}

            //cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            //cmbColor.ValueMember = "ID";
            //cmbColor.DisplayMember = "Detail";
            //cmbColor.Refresh();
        }

        private void txtCarat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbShapeAndCut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbShapeAndCut.SelectedIndex == 0)
            //{
            //    lbl1.Text = "-";
            //}
            //else
            //{
            //    lbl1.Text = "x";
            //}
        }
    }
}
