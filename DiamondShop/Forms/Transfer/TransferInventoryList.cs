﻿using System;
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
    public partial class TransferInventoryList : FormList
    {
        
        public TransferInventoryList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
            //dtSSendDate.Value = dtSSendDate.Value.AddDays(-90);
            //dtSReceiveDate.Value = dtSReceiveDate.Value.AddDays(-90);
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbSender.DataSource = ds.Tables[0];
            cmbSender.ValueMember = "ID";
            cmbSender.DisplayMember = "DisplayName";
            cmbSender.Refresh();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

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

            gridTransferInventory.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Transfer", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else
            {
                gridTransferInventory.DataSource = null;
                gridTransferInventory.Refresh();
            }

            btnSearch_Click(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TransferInventoryInfo frm = new TransferInventoryInfo();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransfer(Convert.ToInt16(cmbSender.SelectedValue.ToString()), Convert.ToInt16(cmbTransferStatus.SelectedValue.ToString()), Convert.ToInt16(cmbShop.SelectedValue.ToString()), Convert.ToInt16(cmbEShop.SelectedValue.ToString()),dtSSendDate.Value, dtSSendDate.Value,dtSReceiveDate.Value, dtEReceiveDate.Value,"1");

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        protected override bool DoDeleteData()
        {
            return chkFlag;
        }

        private void gridSetting_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridTransferInventory.RowCount > 0 && gridTransferInventory.SelectedRows.Count > 0)
            {
                id = (int)gridTransferInventory.SelectedRows[0].Cells["ID"].Value;
                TransferInventoryInfo frm = new TransferInventoryInfo(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}