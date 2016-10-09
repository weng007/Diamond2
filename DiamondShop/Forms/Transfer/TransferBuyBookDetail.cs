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
    public partial class TransferBuyBookDetail : FormList
    {
        int shop;
        public int refID1 = 0;
        public TransferBuyBookDetail()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbBuybookType.DisplayMember = "Text";
            cmbBuybookType.ValueMember = "Value";
            var items = new[] {
                new { Text = "ALL", Value = "0" },
                new { Text = "BuyBookDiamondCer", Value = "1" },
                new { Text = "BuyBookGemstoneCer", Value = "2" },
                new { Text = "BuyBookJewelry", Value = "3" }
            };
            cmbBuybookType.DataSource = items;
            cmbBuybookType.SelectedIndex = 0;

            gridTransferBuyBook.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            
            shop = ApplicationInfo.Shop;
            ds = ser2.DoSearchTransferBuyBook(shop, "", "", 0, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }

            //btnSearch_Click(null, null);
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

            ds = ser2.DoSearchTransferBuyBook(shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbBuybookType.SelectedValue.ToString()),0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }
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

            refID1 = (int)gridTransferBuyBook.SelectedRows[0].Cells["ID"].Value;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
