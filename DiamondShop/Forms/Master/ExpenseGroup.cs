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
    public partial class ExpenseGroup : FormInfo
    {
        dsExpenseGroup tds = new dsExpenseGroup();

        public ExpenseGroup()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtExpenseGroup, "ExpenseGroup");
        }
        protected override void Initial()
        {
            txtExpenseGroup.Select();
            SetFieldService.SetRequireField(txtExpenseGroup);
        }
        public ExpenseGroup(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtExpenseGroup, "ExpenseGroup");

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

            if (txtExpenseGroup.Text == "")
            {
                message = "Please input Expense Group.\n";
            }

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

            isEdit = true;
            return chkFlag;
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
