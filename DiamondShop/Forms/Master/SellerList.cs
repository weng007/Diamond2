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
    public partial class SellerList : FormList
    {
        public int mode = 0;
        public int refID1 = 0;
        public string SellerName = "";
        public SellerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public SellerList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            DoLoadData();
        }

        protected override void Initial()
        {
            gridSeller.AutoGenerateColumns = false;

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007",true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Seller", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSeller.DataSource = ds.Tables[0];
                gridSeller.Refresh();
            }
            else
            {
                gridSeller.DataSource = null;
                gridSeller.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Seller frm = new Seller();
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
                if (gridSeller.RowCount > 0 && gridSeller.SelectedRows.Count > 0)
                {
                    id = (int)gridSeller.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Seller", id);
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

            ds = ser2.DoSearchSeller(txtName.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSeller.DataSource = ds.Tables[0];
                gridSeller.Refresh();
            }
            else
            {
                gridSeller.DataSource = null;
                gridSeller.Refresh();
            }
        }

        private void gridSeller_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        private void gridSeller_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoLoadData();
            if (mode == 0)
            {
                if (gridSeller.RowCount > 0 && gridSeller.SelectedRows.Count > 0)
                {
                    id = (int)gridSeller.SelectedRows[0].Cells["ID"].Value;
                    Seller frm = new Seller(id);
                    frm.ShowDialog();
                }
            }
            else //mode = 1 Search
            {
                refID1 = (int)gridSeller.SelectedRows[0].Cells["ID"].Value;
                SellerName = gridSeller.SelectedRows[0].Cells["DisplayName"].Value.ToString();;

                this.Close();
            }

            DoLoadData();
        }
    }
}
