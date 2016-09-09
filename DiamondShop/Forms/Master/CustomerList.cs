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

namespace DiamondShop
{
    public partial class CustomerList : FormList
    {
        int mode = 0;
        public int custID=0;
        public string customerName = "";
        public string Tel = "";

        public CustomerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public CustomerList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            btnClose.Visible = true;
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007",true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtSearch.Select();

            gridCustomer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Customer", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridCustomer.DataSource = ds.Tables[0];
                gridCustomer.Refresh();
            }
            else
            {
                gridCustomer.DataSource = null;
                gridCustomer.Refresh();
            }

            btnSearch_Click(null, null);
        }
        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (gridCustomer.RowCount > 0 && gridCustomer.SelectedRows.Count > 0)
                {
                    id = (int)gridCustomer.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Customer", id);
                }
            }
            return chkFlag;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchCustomer(txtSearch.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()));

            if(ds.Tables[0].Rows.Count > 0)
            {
                gridCustomer.DataSource = ds.Tables[0];
                gridCustomer.Refresh();
            }
            else
            {
                gridCustomer.DataSource = null;
                gridCustomer.Refresh();
            }
        }

        private void gridCustomer_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        private void gridCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridCustomer.RowCount > 0 && gridCustomer.SelectedRows.Count > 0)
                {
                    id = (int)gridCustomer.SelectedRows[0].Cells["ID"].Value;
                    Customer frm = new Customer(id);
                    frm.ShowDialog();

                    if (frm.isEdit)
                    {
                        DoLoadData();
                    }
                }
            }
            else //mode = 1 Search
            {
                custID = (int)gridCustomer.SelectedRows[0].Cells["ID"].Value;
                customerName = gridCustomer.SelectedRows[0].Cells["DisplayName"].Value.ToString();
                Tel = gridCustomer.SelectedRows[0].Cells["MobilePhone"].Value.ToString();

                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
