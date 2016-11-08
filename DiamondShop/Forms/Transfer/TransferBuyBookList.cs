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
using DiamondDS;

namespace DiamondShop
{
    public partial class TransferBuyBookList : FormList
    {
        
        public TransferBuyBookList()
        {
            InitializeComponent();
            Initial();
            dtSSendDate.Value = dtSSendDate.Value.AddDays(-90);
            dtSReceiveDate.Value = dtSReceiveDate.Value.AddDays(-90);
            DoLoadData();
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();
            DataRow row = ds.Tables[0].NewRow();
            row["ID"] = 0;
            row["DisplayName"] = "All";
            ds.Tables[0].Rows.Add(row);

            cmbSender.DataSource = ds.Tables[0];
            cmbSender.ValueMember = "ID";
            cmbSender.DisplayMember = "DisplayName";
            cmbSender.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbSender.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbTransferStatus.DataSource = (GM.GetMasterTableDetail("C035", true)).Tables[0];
            cmbTransferStatus.ValueMember = "ID";
            cmbTransferStatus.DisplayMember = "Detail";
            cmbTransferStatus.Refresh();

            cmbEShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbEShop.ValueMember = "ID";
            cmbEShop.DisplayMember = "Detail";
            cmbEShop.Refresh();

            gridTransfer.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Transfer", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransfer.DataSource = ds.Tables[0];
                gridTransfer.Refresh();
            }
            else
            {
                gridTransfer.DataSource = null;
                gridTransfer.Refresh();
            }

            btnSearch_Click(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TransferInfo frm = new TransferInfo();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransfer(Convert.ToInt16(cmbSender.SelectedValue.ToString()), Convert.ToInt16(cmbTransferStatus.SelectedValue.ToString()), Convert.ToInt16(cmbShop.SelectedValue.ToString()), Convert.ToInt16(cmbEShop.SelectedValue.ToString()),dtSSendDate.Value, dtESendDate.Value,dtSReceiveDate.Value, dtEReceiveDate.Value,"0");

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransfer.DataSource = ds.Tables[0];
                gridTransfer.Refresh();
            }
            else { gridTransfer.DataSource = null; gridTransfer.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        protected override bool DoDeleteData()
        {
            return chkFlag;
        }

        private void gridTransferBuyBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridTransfer.RowCount > 0 && gridTransfer.SelectedRows.Count > 0)
            {
                id = (int)gridTransfer.SelectedRows[0].Cells["ID"].Value;
                TransferInfo frm = new TransferInfo(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
