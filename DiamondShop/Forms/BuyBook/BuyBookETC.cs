using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;

namespace DiamondShop
{
    public partial class BuyBookETC : FormInfo
    {
        dsBuyBookETC tds = new dsBuyBookETC();
        bool isAuthorize = false;

        public BuyBookETC()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtUSDRate, "USDRate");
        }
        public BuyBookETC(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(cmbBuyer, "Buyer");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtUSDRate, "USDRate");

            this.id = id;
            LoadData();
            SetControlEnable(false);

            isEdit = false;
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuyer.DataSource = ds.Tables[0];
            cmbBuyer.ValueMember = "ID";
            cmbBuyer.DisplayMember = "DisplayName";
            cmbBuyer.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbBuyer.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            dtBuyDate.Select();
            cmbShop.SelectedValue = ApplicationInfo.Shop;

            SetFieldService.SetRequireField(txtSeller, txtPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookETC", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookETC.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookETC[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BuyBookETC[0]["PayDate"]);

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = false;
            }
            if (tds.BuyBookETC[0]["IsPaid"].ToString() == "0")
            {
                rdoYes.Checked = false;
                rdoNo.Checked = true;
            }
            else
            {
                rdoYes.Checked = true;
                rdoNo.Checked = false;
            }
            SetFormatNumber();
            base.LoadData();

            cmbBuyer.SelectedValueChanged += cmbBuyer_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsBuyBookETC.BuyBookETCRow row = null;

            if (tds.BuyBookETC.Rows.Count > 0)
            {
                row = tds.BuyBookETC[0];
            }
            else
            {
                row = tds.BuyBookETC.NewBuyBookETCRow();
                tds.BuyBookETC.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.IsPaid = rdoYes.Checked ? "1" : "0";
            if (txtPayDate.Text == "")
            {
                row.PayDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.PayDate = Convert.ToDateTime(txtPayDate.Text.ToString());
            }
            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("ETC");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookETC", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookETC", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookETC", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
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

        protected override bool ValidateData()
        {
            message = "";

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }
            if (txtPrice.Text == "" || GM.ConvertStringToDouble(txtPrice) == 0)
            {
                message += "Please input Price > 0.\n";
            }
            if (rdoYes.Checked == true && txtPayDate.Text == "")
            {
                message += "Please input Paydate";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice,0);
        }
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice,0);
        }

        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtDetail.Enabled = status;
            txtPrice.Enabled = status;
            cmbBuyer.Enabled = status;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void txtSeller_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbBuyer_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
            isEdit = true;
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
        }
    }
}
