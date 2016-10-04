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
    public partial class SellBook : FormInfo
    {
        Service2 ser1;
        dsSellbook tds = new dsSellbook();
        int custID = 0;
        int refID = 0;
        bool isAuthorize = false;

        public SellBook()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtSellNo, "SellNo");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(dtSellDate, "SellDate");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtDiscount, "Discount");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbStatus, "Status");

            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();
            cmbShop.SelectedValue = ApplicationInfo.Shop.ToString();
        }
        public SellBook(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtSellNo, "SellNo");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtUSDRate, "USDRate");
            binder.BindControl(dtSellDate, "SellDate");
            binder.BindControl(dtDueDate, "DueDate");
            binder.BindControl(txtDiscount, "Discount");
            binder.BindControl(cmbPayment, "Payment");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtNote, "Note");
            binder.BindControl(cmbStatus, "Status");

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

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            SetFieldService.SetRequireField(txtCustomer);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Sell", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.SellBook.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.SellBook[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.SellBook[0]["Paydate"]);
                custID = tds.SellBook[0].CustID;

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = true;
            }
            SetFormatNumber();
            base.LoadData();

            cmbSeller.SelectedValueChanged += cmbSeller_SelectedValueChanged;
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
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
        private void SetControlEnable(bool status)
        {
            txtSellNo.Enabled = status;
            cmbSeller.Enabled = status;
            dtSellDate.Enabled = status;
            txtDiscount.Enabled = status;
            cmbPayment.Enabled = status;
            txtCustomer.Enabled = status;
            cmbStatus.Enabled = status;
            cmbShop.Enabled = status;
            dtDueDate.Enabled = status;
            txtUSDRate.Enabled = status;
            txtNote.Enabled = status;
            btnChooseDate.Enabled = status;
        }
        protected override bool SaveData()
        {
            dsSellbook.SellBookRow row = null;

            if (tds.SellBook.Rows.Count > 0)
            {
                row = tds.SellBook[0];
            }
            else
            {
                row = tds.SellBook.NewSellBookRow();
                tds.SellBook.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            //row.RefID = refID;
            row.CustID = custID;
            if (txtPayDate.Text == "")
            {
                row.PaymentDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.PaymentDate = Convert.ToDateTime(txtPayDate.Text.ToString());
            }

            try
            {
                if (id == 0)
                {
                    row.SellNo = GM.GetRunningNumber("MAT");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("SellBook", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("SellBook", tds);
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
                    chkFlag = ser.DoDeleteData("SellBook", id);
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

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPayment.SelectedIndex == 0)
            {
                txtPayDate.Enabled = false;
                //txtPayDate.Text = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                txtPayDate.Enabled = true;
            }
        }
        
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtTotal.Text = GM.ConvertDoubleToString(txtTotal, 0);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiamondCerList frm = new DiamondCerList(1);
            frm.ShowDialog();
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtPayDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void btnGc_Click(object sender, EventArgs e)
        {
            SearchBuyBookGemstoneCerList frm = new SearchBuyBookGemstoneCerList(0);
            frm.ShowDialog();
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            SearchBuyBookDiamondCerList frm = new SearchBuyBookDiamondCerList(0);
            frm.ShowDialog();
        }

        private void btnNonDC_Click(object sender, EventArgs e)
        {
            SearchBuyBookDiamondList frm = new SearchBuyBookDiamondList();
            frm.ShowDialog();
        }

        private void btnNonGC_Click(object sender, EventArgs e)
        {
            SearchBuyBookGemstoneList frm = new SearchBuyBookGemstoneList();
            frm.ShowDialog();
        }

        private void btnETC_Click(object sender, EventArgs e)
        {
            SearchBuyBookETCList frm = new SearchBuyBookETCList();
            frm.ShowDialog();
        }

        private void btnJewelry_Click(object sender, EventArgs e)
        {
            SearchBuyBookJewelryList frm = new SearchBuyBookJewelryList();
            frm.ShowDialog();
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            SearchBuyBookGoldList frm = new SearchBuyBookGoldList();
            frm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SearchBuyBookSettingList frm = new SearchBuyBookSettingList();
            frm.ShowDialog();
        }
    }
}
