using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;

namespace DiamondShop
{
    public partial class ExpenseList : FormList
    {
        public ExpenseList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            grid.AutoGenerateColumns = false;

            ds = GM.GetExpenseGroup();
            DataRow row = ds.Tables[0].NewRow();
            row["ID"] = 0;
            row["ExpenseGroup"] = "All";
            ds.Tables[0].Rows.Add(row);
            cmbExpenseGroup.DataSource = ds.Tables[0];
            cmbExpenseGroup.ValueMember = "ID";
            cmbExpenseGroup.DisplayMember = "ExpenseGroup";
            cmbExpenseGroup.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbExpenseGroup.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Expense", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid.DataSource = ds.Tables[0];
                grid.Refresh();
            }
            else
            {
                grid.DataSource = null;
                grid.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Expense frm = new Expense();
            frm.ShowDialog();

            DoLoadData();
        }

        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (grid.RowCount > 0 && grid.SelectedRows.Count > 0)
                {
                    id = (int)grid.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Expense", id);
                }
            }

            return chkFlag;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchExpense(Convert.ToInt32(cmbExpenseGroup.SelectedValue.ToString()), Convert.ToInt32(cmbShop.SelectedValue.ToString()), dtSMemoDate.Value, dtEMemoDate.Value,
               dtSExpense.Value, dtEExpense.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid.DataSource = ds.Tables[0];
                grid.Refresh();
            }
            else
            {
                grid.DataSource = null;
                grid.Refresh();
            }
        }

        private void grid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        private void grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid.RowCount > 0 && grid.SelectedRows.Count > 0)
            {
                id = (int)grid.SelectedRows[0].Cells["ID"].Value;
                Expense frm = new Expense(id);
                frm.ShowDialog();

                if (frm.isEdit)
                {
                    DoLoadData();
                }
            }

        }
    }
}
