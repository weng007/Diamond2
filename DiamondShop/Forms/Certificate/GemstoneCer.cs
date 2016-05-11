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
    public partial class GemstoneCer : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsGemstoneCer tds = new dsGemstoneCer();
        MemoryStream ms1;
        byte[] image1;

        public GemstoneCer()
        {
            InitializeComponent();
            Initial();

            BinderData();

        }
        public GemstoneCer(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();
            this.id = id;
            LoadData();
        }

        private void BinderData()
        {
            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtSetting, "SettingName");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtIdentification, "IdentificationName");
            binder.BindControl(dtReportDate, "ReportDate");
            binder.BindControl(txtLab, "LabName");
            binder.BindControl(txtOrigin, "OriginName");
            binder.BindControl(txtW, "W");
            binder.BindControl(txtL, "L");
            binder.BindControl(txtD, "D");
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtShape, "ShapeName");
            binder.BindControl(txtColor, "ColorName");
            binder.BindControl(txtCut, "CutName");
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("GemstoneCer", id);
            tds.Clear();
            tds.Merge(ds);


            if (tds.GemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.GemstoneCer[0]);

                image1 = tds.GemstoneCer[0].Image1;
                if (image1 != null)
                {
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsGemstoneCer.GemstoneCerRow row = null;

            if (tds.GemstoneCer.Rows.Count > 0)
            {
                row = tds.GemstoneCer[0];
            }
            else
            {
                row = tds.GemstoneCer.NewGemstoneCerRow();
                tds.GemstoneCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("GemstoneCer", tds);
                

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
                //chkFlag = ser.DoDeleteData("GemstoneCer", id);
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
            //    message = "Please input GIA Number.\n";
            //}
            //if(txtW.Text == "" || txtL.Text == "" || txtD.Text == ""
            //&& GM.ConvertStringToDouble(txtW) == 0 || GM.ConvertStringToDouble(txtL) == 0 || GM.ConvertStringToDouble(txtD) == 0)
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

        protected override void Initial()
        {
            txtNote.Select();

            //SetFieldService.SetRequireField(txtCode, txtW, txtL, txtD, txtCarat);
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
