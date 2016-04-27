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
        public CustomerList()
        {
            InitializeComponent();
            Initial();
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
            ds = ser.DoSelectData("Customer", -1);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridCustomer.RowCount > 0 && gridCustomer.SelectedRows.Count > 0)
            {
                id = (int)gridCustomer.SelectedRows[0].Cells["ID"].Value;
                Customer frm = new Customer(id);
                frm.ShowDialog();
            }

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
    }
}
