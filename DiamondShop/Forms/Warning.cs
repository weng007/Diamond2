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
    public partial class Warning : FormInfo
    {
        Service2 ser1;
        dsWarning tds = new dsWarning();
        MemoryStream ms1;
        byte[] image1;
        int custID = 0;
        int refID = 0;
        string isPrintPrice = "1";

        public Warning()
        {
            InitializeComponent();
            Initial();
            BinderControl();
        }
        public Warning(int id)
        {
            InitializeComponent();
            Initial();

            BinderControl();

            this.id = id;
            LoadData();
        }
        private void BinderControl()
        {
            binder.BindControl(txtSender, "Sender");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(txtReadDate, "ReadDate");
            binder.BindControl(txtConfirmDate, "ConfirmDate");
            binder.BindControl(txtCancelDate, "CancelDate");
            binder.BindControl(cmbMessageStatus, "MessageStatus");
            binder.BindControl(cmbFactoryStatus, "FactoryStatus");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtNote, "Note");
        }
        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

            cmbMessageStatus.DataSource = (GM.GetMasterTableDetail("C033")).Tables[0];
            cmbMessageStatus.ValueMember = "ID";
            cmbMessageStatus.DisplayMember = "Detail";
            cmbMessageStatus.Refresh();

            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C034")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            //SetFieldService.SetRequireField(txtNetPrice,txtCode,txtCustomer);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Warning", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Warning.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Warning[0]);

                //refID = tds.Warning[0].RefID;
                //custID = tds.Sell[0].CustID;
                //chkIsPrintPrice.Checked = tds.Sell[0].IsPrintPrice == "1" ? true : false;

                //SetJewelryDetail();

                EnableDelete = true;
            }
            SetFormatNumber();
            base.LoadData();
            
        }

        protected override bool SaveData()
        {
            dsWarning.WarningRow row = null;

            if (tds.Warning.Rows.Count > 0)
            {
                row = tds.Warning[0];
            }
            else
            {
                row = tds.Warning.NewWarningRow();
                tds.Warning.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    //row.CerNo = GM.GetRunningNumber("JAS");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Warning", tds, 0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Warning", tds);
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
                //if (txtStatus.Text == "Shop")
                //{
                    chkFlag = ser.DoDeleteData("Warning", id);
                //}
                //else
                //{
                //    Popup.Popup pop = new Popup.Popup("รายการขายนี้ไม่อยู่ในสถานะลบได้");
                //    pop.ShowDialog();
                //}
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
            //    message = "Please Choose Product.\n";
            //}
            //if (txtNetPrice.Text == "" || GM.ConvertStringToDouble(txtNetPrice) == 0)
            //{
            //    message += "Please Input NetPrice > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtNetPrice_Leave(object sender, EventArgs e)
        {
            //txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice,0);
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbPayment.SelectedIndex == 0)
            //{
            //    dtPaymentDate.Enabled = false;
            //    dtPaymentDate.Value = DateTime.MinValue.AddYears(1899);
            //}
            //else
            //{
            //    dtPaymentDate.Enabled = true;
            //}
        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
            //CatalogList frm = new CatalogList(1);
            //frm.ShowDialog();

            //refID = frm.refID1;
            //txtCode.Text = frm.code1;
            //txtJewelryTypeName.Text = frm.typeName;
            //txtPriceTag.Text = frm.priceTag.ToString();
            //txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);
            //SetJewelryDetail();

            ////Bind Image
            //if (frm.image1 != null)
            //{
            //    image1 = frm.image1;
            //    ms1 = new MemoryStream(image1);
            //    Image backImage1 = Image.FromStream(ms1);
            //    btnImage1.BackgroundImage = backImage1;
            //}
            //else
            //{
            //    btnImage1.BackgroundImage = null;
            //}
        }

        
        private void SetFormatNumber()
        {
            //txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);
            //txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice, 0);
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
            //txtCustomer.Text = frm.customerName;
        }

        private void txtPriceTag_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = GM.ConvertDoubleToString(txt, 0);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Pending");
            LoadData();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Sold");
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ser1.UpdateJewelryStatus(refID, "Shop");
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.ReportViewer report = new Report.ReportViewer(id);
            report.ShowDialog();
        }
    }
}
