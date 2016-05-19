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
            LoadData();
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

            SetFieldService.SetRequireField(txtAmount,txtWeight);
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
                if (mode == 0)
                {
                    row.RefID = id;

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

            if (txtAmount.Text == "" || GM.ConvertStringToDouble(txtAmount) == 0)
            {
                message = "Please input Amount > 0.\n";
            }
            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message += "Please input Weight > 0.\n";
            }
            if (txtTotalBaht.Text == "" || GM.ConvertStringToDouble(txtTotalBaht) == 0)
            {
                message += "Please input Total Baht > 0.\n";
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
    }
}
