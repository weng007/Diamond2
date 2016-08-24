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
    public partial class UserList : FormList
    {
        public UserList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            grid.AutoGenerateColumns = false;

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtName.Select();
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("User", -1, 0);

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
            User frm = new User();
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
                    chkFlag = ser.DoDeleteData("User", id);
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

            ds = ser2.DoSearchUser(txtName.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()));

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
                User frm = new User(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
