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
        dsGemstoneCer tds = new dsGemstoneCer();
        MemoryStream ms1;
        byte[] image1;
        MemoryStream ms;
        byte[] file;

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
            binder.BindControl(txtPriceCaratUSD, "PriceCaratUSD");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(txtPriceCaratBaht, "PriceCarat");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtNote1, "Note1");
            binder.BindControl(txtShape, "ShapeName");
            binder.BindControl(txtColor, "ColorName");
            binder.BindControl(txtCut, "CutName");
            binder.BindControl(txtUSDPrice, "TotalUSD");
            binder.BindControl(txtBahtPrice, "TotalBaht");
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("GemstoneCer", id, 0);
            tds.Clear();
            tds.Merge(ds);


            if (tds.GemstoneCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.GemstoneCer[0]);

                
                if (tds.GemstoneCer[0].Image1 != null)
                {
                    image1 = tds.GemstoneCer[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                if (tds.GemstoneCer[0]["Certificate"].ToString() != "")
                {
                    file = (byte[])tds.GemstoneCer[0]["Certificate"];
                    linkFile.Text = tds.GemstoneCer[0].FileName;
                }
            }
            SetFormatNumber();
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

            if (message == "") { return true; }
            else { return false; }
        }

        protected override void Initial()
        {
            //เปิดให้เห็นเฉพาะ Owner
            if (ApplicationInfo.Authorized == "Owner")
            {
                panel4.Visible = true;
            }

            txtNote.Select();

            //SetFieldService.SetRequireField(txtCode, txtW, txtL, txtD, txtCarat);
        }

        private void txtCarat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (file != null && file.Length > 0)
            {
                System.IO.FileStream wFile;
                if (!Directory.Exists(GM.Path))
                {
                    Directory.CreateDirectory("C:\\Project");
                }
                wFile = new FileStream("C:\\Project\\"+linkFile.Text, FileMode.Create);
                wFile.Write(file, 0, file.Length);
                wFile.Flush();
                wFile.Close();

                System.Diagnostics.Process.Start(@"C:\\Project\\"+linkFile.Text);
            }
        }
        private void SetFormatNumber()
        {
            txtPriceCaratUSD.Text = GM.ConvertDoubleToString(txtPriceCaratUSD, 0);
            txtPriceCaratBaht.Text = GM.ConvertDoubleToString(txtPriceCaratBaht, 0);
            txtUSDPrice.Text = GM.ConvertDoubleToString(txtUSDPrice, 0);
            txtBahtPrice.Text = GM.ConvertDoubleToString(txtBahtPrice, 0);
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
        }
    }
}
