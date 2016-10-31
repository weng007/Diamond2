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
        dsSellBook tds = new dsSellBook();
        dsSellBookDetail tds1 = new dsSellBookDetail();
        DataSet ds1 = new DataSet();
        int custID = 0;
        bool isAuthorize = false;

        public SellBook()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtSellNo, "SellNo");
            binder.BindControl(cmbSeller, "SellBy");
            binder.BindControl(cmbShopReceive, "ShopReceive");
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
            cmbShop.SelectedValue = ApplicationInfo.Shop;
        }
        public SellBook(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtSellNo, "SellNo");
            binder.BindControl(cmbSeller, "SellBy");
            binder.BindControl(cmbShopReceive, "ShopReceive");
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

            cmbShopReceive.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShopReceive.ValueMember = "ID";
            cmbShopReceive.DisplayMember = "Detail";
            cmbShopReceive.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            grid1.AutoGenerateColumns = false;

            SetFieldService.SetRequireField(txtCustomer);
        }

        protected override void LoadData()
        {
            ser1 = GM.GetService1();

            ds = ser.DoSelectData("SellBook", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.SellBook.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.SellBook[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.SellBook[0]["PaymentDate"]);
                custID = tds.SellBook[0].CustID;

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = true;
            }

            ds1 = ser.DoSelectData("SellBookDetail", id, 0);
            tds1.Clear();
            tds1.Merge(ds1);

            if(tds1.SellBookDetail.Rows.Count > 0)
            {
                grid1.DataSource = tds1.SellBookDetail;
                grid1.Refresh();
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
            cmbShopReceive.Enabled = status;
            cmbShop.Enabled = status;
            dtDueDate.Enabled = status;
            txtUSDRate.Enabled = status;
            txtNote.Enabled = status;
            btnChooseDate.Enabled = status;
            btnDC.Enabled = status;
            btnGC.Enabled = status;
            btnJewelry.Enabled = status;
            btnNonDC.Enabled = status;
            btnNonGC.Enabled = status;
            btnGold.Enabled = status;
            btnSetting.Enabled = status;
            btnETC.Enabled = status;
            btnDel.Enabled = status;
        }
        protected override bool SaveData()
        {
            dsSellBook.SellBookRow row = null;

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

                //Save SellBookDetail
                if (tds1.SellBookDetail.Rows.Count > 0)
                {
                    foreach (dsSellBookDetail.SellBookDetailRow row1 in tds1.SellBookDetail.Rows)
                    {
                        if (row1.ID < 0)
                        {
                            SetCreateBy(row1);
                            row1.RefID = id;
                        }
                        else
                        {
                            SetEditBy(row1);
                        }                    
                    }

                    chkFlag = ser.DoInsertData("SellBookDetail", tds1, 0);
                    tds1.AcceptChanges();
                }
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

            txtDiscount.Text = GM.ConvertDoubleToString(txtDiscount, 0);
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
            ser1.UpdateSellBookStatus(id, "Pending");
            LoadData();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            ser1.UpdateSellBookStatus(id, "Sold");
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

        private void btnGC_Click(object sender, EventArgs e)
        {
            SearchBuyBookGemstoneCerList frm = new SearchBuyBookGemstoneCerList(1);
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            SearchBuyBookDiamondCerList frm = new SearchBuyBookDiamondCerList(1);
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnNonDC_Click(object sender, EventArgs e)
        {
            SearchBuyBookDiamondList frm = new SearchBuyBookDiamondList();
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnNonGC_Click(object sender, EventArgs e)
        {
            SearchBuyBookGemstoneList frm = new SearchBuyBookGemstoneList();
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnETC_Click(object sender, EventArgs e)
        {
            SearchBuyBookETCList frm = new SearchBuyBookETCList();
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnJewelry_Click(object sender, EventArgs e)
        {
            SearchBuyBookJewelryList frm = new SearchBuyBookJewelryList();
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            SearchBuyBookGoldList frm = new SearchBuyBookGoldList();
            frm.ShowDialog();

            SetGrid(frm.idSelected);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SearchBuyBookSettingList frm = new SearchBuyBookSettingList();
            frm.ShowDialog();
        }

        private void SetGrid(string idSelected)
        {
            if (idSelected != "")
            {
                ser1 = GM.GetService1();

                dsSellBookDetail tmp = new dsSellBookDetail();

                ds1 = ser1.GetSellBookDetail(idSelected);
                tmp.Clear();
                tmp.Merge(ds1);

                for (int i = 0; i < tmp.SellBookDetail.Rows.Count; i++)
                {
                    dsSellBookDetail.SellBookDetailRow row = tds1.SellBookDetail.NewSellBookDetailRow();
                    row.RefID = id;
                    row.RefID1 = tmp.SellBookDetail[i].RefID1;
                    row.BuyBookType = tmp.SellBookDetail[i].BuyBookType;
                    row.Code = tmp.SellBookDetail[i].Code;
                    row.USDRate = tmp.SellBookDetail[i].USDRate;
                    row.Amount = tmp.SellBookDetail[i].Amount;
                    row.Weight = tmp.SellBookDetail[i].Weight;
                    row.Price = tmp.SellBookDetail[i].Price;
                    tds1.SellBookDetail.Rows.Add(row);           
                }

                tds1.AcceptChanges();
                grid1.DataSource = tds1.SellBookDetail;
                grid1.Refresh();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int delID = 0;

            if(grid1.SelectedRows.Count > 0)
            {
                delID = (int)grid1.SelectedRows[0].Cells["ID"].Value;
                tds1.SellBookDetail.Rows.RemoveAt(grid1.SelectedRows[0].Index);
            }

            tds1.AcceptChanges();
            grid1.Refresh();

            ser.DoDeleteData("SellBookDetail", delID);
        }
    }
}
