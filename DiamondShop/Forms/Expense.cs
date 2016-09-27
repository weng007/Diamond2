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
        dsExpenseGroup tds = new dsExpenseGroup();

        public Expense()
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(txtExpenseGroup, "ExpenseGroup");
        }
        protected override void Initial()
        {
           //SetFieldService.SetRequireField(txtExpenseGroup);
        }
        public Expense(int id)
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(txtExpenseGroup, "ExpenseGroup");

            this.id = id;
            LoadData();
            isEdit = false;
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("ExpenseGroup", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.ExpenseGroup.Rows.Count > 0)
            {             

                binder.BindValueToControl(tds.ExpenseGroup[0]);
                EnableDelete = true;
            }

            base.LoadData();
            //cmbShop.SelectedValueChanged += cmbShop_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsExpenseGroup.ExpenseGroupRow row = null;

            if (tds.ExpenseGroup.Rows.Count > 0)
            {
                row = tds.ExpenseGroup[0];
            }
            else
            {
                row = tds.ExpenseGroup.NewExpenseGroupRow();           
                tds.ExpenseGroup.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {

                if (id == 0)
                {
                    SetCreateBy(row);      
                    chkFlag = ser.DoInsertData("ExpenseGroup", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("ExpenseGroup", tds);
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
                chkFlag = ser.DoDeleteData("ExpenseGroup", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbRole.SelectedIndex == 1)
            //{   
            //    lblInventory.Visible = true;
            //    txtPassword2.Visible = true;
            //    lblBuyBook.Visible = true;
            //    txtPassword3.Visible = true;
            //}
            //else
            //{
            //    lblInventory.Visible = false;
            //    txtPassword2.Visible = false;
            //    lblBuyBook.Visible = false;
            //    txtPassword3.Visible = false;
            //}
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
    }
}
