using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class DiamondCer : FormInfo
    {
        dsDiamondCer tds = new dsDiamondCer();
        MemoryStream ms;
        Service2 ser1;
        byte[] file;

        public DiamondCer()
        {
            InitializeComponent();
            Initial();

            BinderData();
        }
        public DiamondCer(int id)
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
            binder.BindControl(txtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtShape, "ShapeName");
            binder.BindControl(txtColor, "ColorName");
            binder.BindControl(txtCut, "CutName");
            binder.BindControl(txtClearity, "ClearityName");
            binder.BindControl(txtPolish, "PolishName");
            binder.BindControl(txtSymmetry, "SymmetryName");
            binder.BindControl(txtFluorescent, "FluorescentName");
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(txtRap, "Rap");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(lnkSetting, "Setting");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(txtUSDPrice, "TotalUSD");
            binder.BindControl(txtBahtPrice, "TotalBaht");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(txtNote1, "Note1");
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("DiamondCer", id, 0);
            tds.Clear();
            tds.Merge(ds);


            if (tds.DiamondCer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.DiamondCer[0]);

                if (tds.DiamondCer[0]["Certificate"].ToString() != "")
                {
                    file = (byte[])tds.DiamondCer[0]["Certificate"];
                    linkFile.Text = tds.DiamondCer[0].FileName;
                }
            }
            SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsDiamondCer.DiamondCerRow row = null;

            if (tds.DiamondCer.Rows.Count > 0)
            {
                row = tds.DiamondCer[0];
            }
            else
            {
                row = tds.DiamondCer.NewDiamondCerRow();
                tds.DiamondCer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("DiamondCer", tds);

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
                chkFlag = ser.DoDeleteData("DiamondCer", id);
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
            if(ApplicationInfo.Authorized == "Owner")
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
                wFile = new FileStream("C:\\Project\\Certificate"+linkFile.Text, FileMode.Create);
                wFile.Write(file, 0, file.Length);
                wFile.Flush();
                wFile.Close();

                System.Diagnostics.Process.Start(@"C:\\Project\\"+linkFile.Text);
            }
        }
        private void SetFormatNumber()
        {
            txtRap.Text = GM.ConvertDoubleToString(txtRap, 0);
            txtUSDPrice.Text = GM.ConvertDoubleToString(txtUSDPrice, 0);
            txtBahtPrice.Text = GM.ConvertDoubleToString(txtBahtPrice, 0);
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void lnkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int tmpId = 0;
            tmpId = ser1.DoSearchInventoryByCode(lnkSetting.Text);

            Inventory frm = new Inventory(tmpId);
            frm.ShowDialog();
        }
    }
}
