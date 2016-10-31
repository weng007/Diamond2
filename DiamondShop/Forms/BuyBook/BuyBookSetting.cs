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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class BuyBookSetting : FormInfo
    {
        dsBuyBookSetting tds = new dsBuyBookSetting();
        dsBuyBookSettingDetail tds2 = new dsBuyBookSettingDetail();
        bool isAuthorize = false;
        Service2 ser1;
        DataSet ds2 = new DataSet();
        int chk = 0;

        public BuyBookSetting()
        {
            InitializeComponent();
            Initial();
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            txtUSDRate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();
            BinderData();
        }
        public BuyBookSetting(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();

            btnAdd.Enabled = true;
            btnDel.Enabled = true;

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
            SetFieldService.SetRequireField(txtSeller);
        }

        private void BinderData()
        {
            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtBuyPrice, "BuyPrice");
            binder.BindControl(txtSalePrice, "SalePrice");
            binder.BindControl(cmbBuyer , "Buyer");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtUSDRate, "USDRate");
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookSetting", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BuyBookSettingDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BBSetting.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BBSetting[0]);
                txtPayDate.Text = string.Format("{0:d/M/yyyy}", tds.BBSetting[0]["PayDate"]);

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = false;
            }
            if (tds.BBSetting[0]["IsPaid"].ToString() == "0")
            {
                rdoYes.Checked = false;
                rdoNo.Checked = true;
            }
            else
            {
                rdoYes.Checked = true;
                rdoNo.Checked = false;
            }

            if (tds2.BBSettingDetail.Rows.Count > 0)
            {
                BindingGridBBSettingDetail();
            }

            SetFormatNumber();
            base.LoadData();
            cmbBuyer.SelectedValueChanged += cmbBuyer_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsBuyBookSetting.BBSettingRow row = null;

            if (tds.BBSetting.Rows.Count > 0)
            {
                row = tds.BBSetting[0];
            }
            else
            {
                row = tds.BBSetting.NewBBSettingRow();
                tds.BBSetting.Rows.Add(row);
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
                    row.Code = GM.GetRunningNumber("SET");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookSetting", tds,0);

                    ser1 = GM.GetService1();
                    id = ser1.DoSearchBBSettingByCode(row.Code);
                    btnAdd.Enabled = true;
                    btnDel.Enabled = true;
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookSetting", tds);
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //ไม่ให้ปิดหน้าจอหลัง Save
            isClosed = false;

            LoadData();

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            try
            {
                if(chk == 0)
                {
                    chkFlag = ser.DoDeleteData("BuyBookSetting", id);
                }
                else if(chk == 1)
                {
                    chkFlag = ser.DoDeleteData("BuyBookSettingDetail", Convert.ToInt32(gridSetting.SelectedRows[0].Cells["ID"].Value));

                    chk = 0;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            LoadData();

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }
            if (rdoYes.Checked == true && txtPayDate.Text == "")
            {
                message += "Please input Paydate";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void BindingGridBBSettingDetail()
        {
            int i = 0;
            gridSetting.Rows.Clear();

            foreach (DataRow row in tds2.Tables[0].Rows)
            {
                gridSetting.Rows.Add();
                gridSetting.Rows[i].Cells["RowNum"].Value = row["RowNum"].ToString();
                gridSetting.Rows[i].Cells["ID"].Value = row["ID"].ToString();
                gridSetting.Rows[i].Cells["SettingType"].Value = row["SettingType"].ToString();
                gridSetting.Rows[i].Cells["SettingTypeName"].Value = row["SettingTypeName"].ToString();
                gridSetting.Rows[i].Cells["Material"].Value = row["Material"].ToString();
                gridSetting.Rows[i].Cells["MaterialName"].Value = row["MaterialName"].ToString();
                gridSetting.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                gridSetting.Rows[i].Cells["Weight"].Value = row["Weight"].ToString();
                gridSetting.Rows[i].Cells["PricePerGram"].Value = row["PricePerGram"].ToString();
                gridSetting.Rows[i].Cells["PricePerUnit"].Value = row["PricePerUnit"].ToString();
                gridSetting.Rows[i].Cells["TotalBaht"].Value = row["TotalBaht"].ToString();
                gridSetting.Rows[i].Cells["RefID"].Value = row["RefID"].ToString();

                i++;
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

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookSettingDetail frm = new BuyBookSettingDetail(id,0);
            frm.ShowDialog();

            LoadData();
        }

        private void gridSetting_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(gridSetting.SelectedRows.Count > 0)
            {
                BuyBookSettingDetail frm = new BuyBookSettingDetail(id,1);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void gridSetting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 ||
                e.ColumnIndex == 8) && e.RowIndex != this.gridSetting.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());

                if (e.ColumnIndex != 5) { e.Value = d.ToString("N0"); }
                else { e.Value = d.ToString("N2"); }
            }
        }

        private void txtBuyPrice_Leave(object sender, EventArgs e)
        {
            txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
        }

        private void txtSalePrice_Leave(object sender, EventArgs e)
        {
            txtSalePrice.Text = GM.ConvertDoubleToString(txtSalePrice, 0);
        }
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtPayDate.Text != "" && Convert.ToDateTime(txtPayDate.Text).Year == 1901)
            {
                txtPayDate.Text = "";
            }
            txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
            txtSalePrice.Text = GM.ConvertDoubleToString(txtSalePrice, 0);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(gridSetting.SelectedRows.Count > 0)
            {
                chk = 1;
                DeleteData();
            }
        }
        private void SetControlEnable(bool status)
        {
            dtBuyDate.Enabled = status;
            txtSeller.Enabled = status;
            txtBuyPrice.Enabled = status;
            txtSalePrice.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            gridSetting.Enabled = status;
            cmbBuyer.Enabled = status;
        }

        private void txtSeller_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbBuyer_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtPayDate_ValueChanged(object sender, EventArgs e)
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
            isEdit = true;
        }

        private void txtUSDRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
            txtUSDRate.Text = GM.ConvertDoubleToString(txtUSDRate);
        }
    }
}
