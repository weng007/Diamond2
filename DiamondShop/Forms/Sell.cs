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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class Sell : FormInfo
    {
        Service2 ser1;
        dsSell tds = new dsSell();
        MemoryStream ms1;
        byte[] image1;

        bool isAuthorize = false;

        int custID = 0;
        int refID = 0;
        public string isPrice;

        public Sell()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtCerNo, "CerNo");
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
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(cmbShop, "Shop");
        }
        public Sell(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtCerNo, "CerNo");
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
            binder.BindControl(txtStatus, "StatusName");
            binder.BindControl(cmbShop, "Shop");
            
            this.id = id;
            SetControlEnable(false);
            LoadData();
            isEdit = false;
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

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtNetPrice.Select();
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

                refID = tds.Sell[0].RefID;
                custID = tds.Sell[0].CustID;
                chkIsPrintPrice.Checked = tds.Sell[0].IsPrintPrice=="1"? true:false;

                SetJewelryDetail();

                if (tds.Sell[0].Image1 != null)
                {
                    image1 = tds.Sell[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }

                if (!isAuthorize)
                {
                    EnableSave = false;
                    EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                    EnableDelete = false;
                }
            }
            SetFormatNumber();
            base.LoadData();

            cmbSeller.SelectedValueChanged += cmbSeller_SelectedValueChanged;
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
            row.IsPrintPrice = chkIsPrintPrice.Checked?"1":"0";

            try
            {
                if (id == 0)
                {
                    row.CerNo = GM.GetRunningNumber("JAS");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Sell", tds,0);

                    if (chkFlag)
                    {
                        ser1 = GM.GetService1();
                        id = ser1.DoSearchSellByCode(row.CerNo);
                    }
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

            isClosed = false;
            LoadData();

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            try
            {
                if (txtStatus.Text == "Shop")
                {
                    chkFlag = ser.DoDeleteData("Sell", id);
                }
                else
                {
                    Popup.Popup pop = new Popup.Popup("รายการขายนี้ไม่อยู่ในสถานะลบได้");
                    pop.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        private void SetControlEnable(bool status)
        {
            txtCode.Enabled = status;
            dtDueDate.Enabled = status;
            txtNote.Enabled = status;
            txtCerNo.Enabled = status;
            txtNetPrice.Enabled = status;
            cmbShopRecive.Enabled = status;
            dtSellDate.Enabled = status;
            cmbPayment.Enabled = status;
            dtPaymentDate.Enabled = status;
            btnAvailable.Enabled = status;
            btnPending.Enabled = status;
            btnSold.Enabled = status;
            btnBrowseCatalog.Enabled = status;
            btnBrowseCustomer.Enabled = status;
            cmbSeller.Enabled = status;
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

        private void txtNetPrice_Leave(object sender, EventArgs e)
        {
            txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice,0);
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPayment.SelectedIndex == 0)
            {
                dtPaymentDate.Enabled = false;
                dtPaymentDate.Value = DateTime.MinValue.AddYears(1899);
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

            if (frm.refID1 != 0)
            {
                refID = frm.refID1;
                txtCode.Text = frm.code1;
                txtJewelryTypeName.Text = frm.typeName;
                txtPriceTag.Text = frm.price.ToString();
                cmbShop.SelectedValue = frm.shop;
                txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);

                txtStatus.Text = "Avai.";
                SetJewelryDetail();

                //Bind Image
                if (frm.image != null)
                {
                    image1 = frm.image;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                else
                {
                    btnImage1.BackgroundImage = null;
                }
            }        
        }

        private void SetJewelryDetail()
        {
            DataSet tmp = new DataSet();
            ser1 = GM.GetService1();

            txtMaterial.Text = "";
            txtDiamond.Text = "";
            txtGemstone.Text = "";
            txtCertified.Text = "";

            ds = ser1.GetJewelryDetail(refID);

            if(ds.Tables[1].Rows.Count > 0)
            {
                txtMaterial.Text = ds.Tables[1].Rows[0]["Material1Name"].ToString() + "  "+ds.Tables[1].Rows[0]["MaterialWeight1"].ToString()+" gram";
                if (ds.Tables[1].Rows[0]["Material2Name"].ToString() != "")
                {
                    txtMaterial.Text += "\r\n" + ds.Tables[1].Rows[0]["Material2Name"].ToString() + "  " + ds.Tables[1].Rows[0]["MaterialWeight2"].ToString()+" gram";
                }
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtDiamond.Text += ds.Tables[0].Rows[i]["ShapeName"].ToString() + "  " + ds.Tables[0].Rows[i]["Amount"].ToString()+" เม็ด" + "  " +
                        ds.Tables[0].Rows[i]["Weight"].ToString()+" ct" + "\r\n";
                }
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                {
                    txtGemstone.Text += ds.Tables[2].Rows[i]["ShapeName"].ToString() + "  " + ds.Tables[2].Rows[i]["Amount"].ToString() + " เม็ด"+"  " +
                        ds.Tables[2].Rows[i]["Weight"].ToString()+" ct" + "\r\n";
                }
            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
                {
                    txtCertified.Text += ds.Tables[3].Rows[i]["ReportNumber"].ToString() + "  " + ds.Tables[3].Rows[i]["Type"].ToString() + "  " +
                        ds.Tables[3].Rows[i]["LabName"].ToString() + "  "+ds.Tables[3].Rows[i]["ShapeName"].ToString() + "  " +
                        ds.Tables[3].Rows[i]["Weight"].ToString() + "  " + ds.Tables[3].Rows[i]["Detail"].ToString() + "\r\n";
                }
            }
            if (ds.Tables[4].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[4].Rows.Count; i++)
                {
                    txtCertified.Text += ds.Tables[4].Rows[i]["ReportNumber"].ToString() + "  " + ds.Tables[4].Rows[i]["Type"].ToString() + "  " +
                       ds.Tables[4].Rows[i]["LabName"].ToString() + "  " + ds.Tables[4].Rows[i]["ShapeName"].ToString() + "  " +
                       ds.Tables[4].Rows[i]["Weight"].ToString() + "  " + ds.Tables[4].Rows[i]["Detail"].ToString() + "\r\n";
                }
            }
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
                base.EditData();
            }
            else
            {
                RequirePassword frm = new RequirePassword(ApplicationInfo.Shop);
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    SetControlEnable(true);
                    base.EditData();
                }
            }
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
            if(frm.custID != 0)
            {
                custID = frm.custID;
                txtCustomer.Text = frm.customerName;
            }
        }

        private void txtPriceTag_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = GM.ConvertDoubleToString(txt, 0);
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Available",ApplicationInfo.Shop);
            LoadData();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Pending",211);
            LoadData();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Sold", ApplicationInfo.Shop);
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (chkIsPrintPrice.Checked)
            {
                isPrice = "1";
            }
            else
            {
                isPrice = "0";
            }

            Report.ReportViewer report = new Report.ReportViewer(id,isPrice);
            report.ShowDialog();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbSeller_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtSellDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
