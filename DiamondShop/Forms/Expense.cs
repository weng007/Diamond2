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
    public partial class Expense : FormInfo
    {
        dsExpense tds = new dsExpense();

        public Expense()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbExpenseGroup, "ExpenseGroup");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(dtMemoDate, "CreateDate");
            binder.BindControl(txtCost, "Cost");

            txtShop.Text = ApplicationInfo.ShopName;

        }
        protected override void Initial()
        {
            //SetFieldService.SetRequireField(txtExpenseGroup);
            ds = GM.GetExpenseGroup();

            cmbExpenseGroup.DataSource = ds.Tables[0];
            cmbExpenseGroup.ValueMember = "ID";
            cmbExpenseGroup.DisplayMember = "ExpenseGroup";
            cmbExpenseGroup.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbExpenseGroup.Refresh();

        }
        public Expense(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbExpenseGroup, "ExpenseGroup");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(dtMemoDate, "CreateDate");
            binder.BindControl(txtCost, "Cost");

            this.id = id;
            LoadData();
            isEdit = false;
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Expense", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Expense.Rows.Count > 0)
            {             
                binder.BindValueToControl(tds.Expense[0]);
                txtExpenseDate.Text = string.Format("{0:d/M/yyyy}", tds.Expense[0]["ExpenseDate"]);
                EnableDelete = true;
            }

            base.LoadData();
            //cmbShop.SelectedValueChanged += cmbShop_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsExpense.ExpenseRow row = null;

            if (tds.Expense.Rows.Count > 0)
            {
                row = tds.Expense[0];
            }
            else
            {
                row = tds.Expense.NewExpenseRow();           
                tds.Expense.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            if (txtExpenseDate.Text == "")
            {
                row.ExpenseDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.ExpenseDate = Convert.ToDateTime(txtExpenseDate.Text.ToString());
            }
            row.Shop = ApplicationInfo.Shop;
            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);      
                    chkFlag = ser.DoInsertData("Expense", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Expense", tds);
                }

                tds.AcceptChanges();
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

            //if (txtFirstName.Text == "")
            //{
            //    message += "Please input FirstName.\n";
            //}
            //if (txtLastName.Text == "")
            //{
            //    message += "Please input LastName.\n";
            //}
            //if (txtUserName.Text == "")
            //{
            //    message += "Please input UserName.\n";
            //}
            //if (txtPassword1.Text == "")
            //{
            //    message += "Please input Password.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("Expense", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtTitleName_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbShop_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtExpenseDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
            isEdit = true;
        }
        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtExpenseDate.Text != "" && Convert.ToDateTime(txtExpenseDate.Text).Year == 1901)
            {
                txtExpenseDate.Text = "";
            }

        }
    }
}
