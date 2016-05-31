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
        dsSell tds = new dsSell();
        MemoryStream ms1;
        byte[] image1;
        int custID = 0;
        int refID = 0;

        public Sell()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtJewelryTypeName, "JewelryTypeName");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(cmbShopRecive, "ShopReceive");
            binder.BindControl(dtSellDate, "SellDate");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(dtPaymentDate, "PaymentDate");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtNote, "Note");
        }
        public Sell(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtJewelryTypeName, "JewelryTypeName");
            binder.BindControl(txtPriceTag, "PriceTag");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(cmbShopRecive, "ShopReceive");
            binder.BindControl(dtSellDate, "SellDate");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtNetPrice, "NetPrice");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(dtPaymentDate, "PaymentDate");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtNote, "Note");

            this.id = id;
            LoadData();
        }
        protected override void Initial()
        {
            ds = GM.GetSeller();

            cmbSeller.DataSource = ds.Tables[0];
            cmbSeller.ValueMember = "ID";
            cmbSeller.DisplayMember = "DisplayName";
            cmbSeller.Refresh();

            cmbPayment.DataSource = (GM.GetMasterTableDetail("C027")).Tables[0];
            cmbPayment.ValueMember = "ID";
            cmbPayment.DisplayMember = "Detail";
            cmbPayment.Refresh();

            cmbShopRecive.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShopRecive.ValueMember = "ID";
            cmbShopRecive.DisplayMember = "Detail";
            cmbShopRecive.Refresh();

            

            SetFieldService.SetRequireField(txtNetPrice,txtCode,txtCustomer);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Sell", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Sell.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Sell[0]);

                if (image1 != null)
                {
                    image1 = tds.Sell[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                EnableDelete = true;
            }

            base.LoadData();
            SetFormatNumber();
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
            row.RefID = refID;
            row.CustID = custID;
            row.ShopReceive = Convert.ToInt32(cmbShopRecive.SelectedValue.ToString());

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

            if (txtCode.Text == "")
            {
                message = "Please Choose Product.\n";
            }
            if (txtNetPrice.Text == "" || GM.ConvertStringToDouble(txtNetPrice) == 0)
            {
                message += "Please Input NetPrice > 0.\n";
            }

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

        private void txtNetPrice_Leave(object sender, EventArgs e)
        {
            txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice,0);
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPayment.SelectedIndex == 0)
            {
                dtPaymentDate.Enabled = false;
            }
            else
            {
                dtPaymentDate.Enabled = true;
            }
        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
            CatalogList frm = new CatalogList(1);
            frm.ShowDialog();

            refID = frm.refID1;
            txtCode.Text = frm.code1;
            txtJewelryTypeName.Text = frm.typeName;
            txtPriceTag.Text = frm.priceTag.ToString();
            txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);
        }
        
        private void SetFormatNumber()
        {
            txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);
            txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice, 0);
        }

        private void txtNetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList(1);
            frm.ShowDialog();
            custID = frm.custID;
            txtCustomer.Text = frm.customerName;
        }

        private void txtPriceTag_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = GM.ConvertDoubleToString(txt, 0);
        }
    }
}
