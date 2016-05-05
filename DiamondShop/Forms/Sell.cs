using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;

namespace DiamondShop
{
    public partial class Sell : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsSell tds = new dsSell();
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        int custID = 0;

        public Sell()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtSaleDate, "Seller");
            binder.BindControl(dtSaleDate, "SaleDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(txtCustomer, "CustID");
            binder.BindControl(cmbShopRecive, "ShopReceive");
            binder.BindControl(txtRemark, "Remark");
        }
        public Sell(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtSaleDate, "Seller");
            binder.BindControl(dtSaleDate, "SaleDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(txtCustomer, "CustID");
            binder.BindControl(cmbShopRecive, "ShopReceive");
            binder.BindControl(txtRemark, "Remark");

            this.id = id;
            LoadData();
        }
        protected override void Initial()
        {

            cmbPayment.DataSource = (GM.GetMasterTableDetail("C027")).Tables[0];
            cmbPayment.ValueMember = "ID";
            cmbPayment.DisplayMember = "Detail";
            cmbPayment.Refresh();

            cmbShopRecive.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShopRecive.ValueMember = "ID";
            cmbShopRecive.DisplayMember = "Detail";
            cmbShopRecive.Refresh();

            txtCost.Text = GM.ConvertDoubleToString(txtCost);
            //txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice);

            //SetFieldService.SetRequireField(txtNetPrice,txtCode,txtCustomer,txtCost);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Sell", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Sell.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Sell[0]);

                ////Image
                //image1 = tds.Sell[0].Image1;
                //image2 = tds.Sell[0].Image2;
                //if (image1 != null)
                //{
                //    ms1 = new MemoryStream(image1);
                //    Image backImage1 = Image.FromStream(ms1);
                //    btnImage1.BackgroundImage = backImage1;
                //}
                //if (image2 != null)
                //{
                //    ms2 = new MemoryStream(image2);
                //    Image backImage2 = Image.FromStream(ms2);
                //    //btnImage2.BackgroundImage = backImage2;
                //}

                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsSell.SellRow row = null;

            if (tds.Sell.Rows.Count > 0)
            {
                row = tds.Sell[0];
            }
            else
            {
                row = tds.Sell.NewSellRow();
                tds.Sell.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            //row.Image1 = image1;
            //row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Sell", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Sell", tds);
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
                chkFlag = ser.DoDeleteData("Sell", id);
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

            //if (txtCost.Text == "" || GM.ConvertStringToDouble(txtCost) == 0)
            //{
            //    message = "Please input Cost > 0.\n";
            //}
            //if (txtNetPrice.Text == "" || GM.ConvertStringToDouble(txtNetPrice) == 0)
            //{
            //    message += "Please input NetPrice > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerSearch frm = new CustomerSearch();
            frm.ShowDialog();
            //txtCustomer.Text = frm.customerName;
            custID = frm.id;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductSearch frm = new ProductSearch();
            frm.ShowDialog();
            txtCode.Text = frm.code;
            txtJewelryTypeName.Text = frm.jewelryTypename;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void txtCost_Leave(object sender, EventArgs e)
        {
            txtCost.Text = GM.ConvertDoubleToString(txtCost);
        }

        private void txtNetPrice_Leave(object sender, EventArgs e)
        {
            //txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice);
        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //btnImage2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image2 = new byte[fs.Length];
                fs.Read(image2, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }
    }
}
