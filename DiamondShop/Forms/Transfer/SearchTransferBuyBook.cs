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
    public partial class SearchTransferBuyBook : FormList
    { 
        public int refID1 = 0;
        public string tmpCode = "";
        public string codeSelected = "";

        public SearchTransferBuyBook()
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
            
            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, "", "", 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbBuybookType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }
        }

        private void CheckSelected()
        {
            string comma = ",";
            codeSelected = "";

            for (int i = 0; i < gridTransferBuyBook.Rows.Count; i++)
            {
                if (gridTransferBuyBook.Rows[i].Cells["Select"].Value != null)
                {
                    if (gridTransferBuyBook.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        codeSelected += gridTransferBuyBook.Rows[i].Cells["Code"].Value.ToString() + comma;
                         
                    }
                }
            }

            if (codeSelected.Length > 0)
            {
                codeSelected = codeSelected.Remove(codeSelected.Length - 1, 1);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridTransferBuyBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridTransferBuyBook.SelectedCells[0].Value == null || gridTransferBuyBook.SelectedCells[0].Value.ToString() == "False")
                {
                    gridTransferBuyBook.SelectedCells[0].Value = true;
                    id = (int)gridTransferBuyBook.SelectedRows[0].Cells["ID"].Value;
                }
                else
                {
                    gridTransferBuyBook.SelectedCells[0].Value = false;
                }
            }
        }
    }
}
