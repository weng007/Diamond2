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
using DiamondShop.DiamondService1;
using DiamondDS;

namespace DiamondShop
{
    public partial class BuyBookGemstoneCerList : FormList
    {
        public int mode = 0;
        public int refID2 = 0;
        public BuyBookGemstoneCerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        public BuyBookGemstoneCerList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            btnClose.Visible = true;
            btnAdd.Visible = false;
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbShape.DataSource = (GM.GetMasterTableDetail("C019",true)).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbIdentification.DataSource = (GM.GetMasterTableDetail("C016", true)).Tables[0];
            cmbIdentification.ValueMember = "ID";
            cmbIdentification.DisplayMember = "Detail";
            cmbIdentification.Refresh();

            cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024", true)).Tables[0];
            cmbOrigin.ValueMember = "ID";
            cmbOrigin.DisplayMember = "Detail";
            cmbOrigin.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023", true)).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbLab.DataSource = (GM.GetMasterTableDetail("C026", true)).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

            txtReportNumber.Select();

            gridGemstoneCer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstoneCer", -1, mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstoneCer.DataSource = ds.Tables[0];
                gridGemstoneCer.Refresh();
            }
            else
            {
                gridGemstoneCer.DataSource = null;
                gridGemstoneCer.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookGemstoneCer frm = new BuyBookGemstoneCer();
            frm.ShowDialog();

            DoLoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
                {
                    id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("DiamondCer", id);
                }
            }
            return chkFlag;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
            {
                id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                BuyBookGemstoneCer frm = new BuyBookGemstoneCer(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookGemstoneCer(txtCode.Text, txtReportNumber.Text, Convert.ToInt16(cmbShape.SelectedValue.ToString()),
                Convert.ToInt16(cmbLab.SelectedValue.ToString()),
                GM.ConvertStringToDouble(txtSWeight),
                GM.ConvertStringToDouble(txtEWeight),
                Convert.ToInt16(cmbIdentification.SelectedValue.ToString()),
                Convert.ToInt16(cmbComment.SelectedValue.ToString()),
                Convert.ToInt16(cmbOrigin.SelectedValue.ToString()),
                Convert.ToInt16(cmbStatus.SelectedValue.ToString()),
                Convert.ToInt16(cmbShop.SelectedValue.ToString()),txtCode2.Text,mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstoneCer.DataSource = ds.Tables[0];
                gridGemstoneCer.Refresh();
            }
            else { gridGemstoneCer.DataSource = null; gridGemstoneCer.Refresh(); }
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridGemstoneCer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
                    {
                        id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                        BuyBookGemstoneCer frm = new BuyBookGemstoneCer(id);
                        frm.ShowDialog();

                        if (frm.isEdit)
                        {
                            DoLoadData();
                        }

                    frm.Close();
                    }
            }
            else //mode = 1 Search
            {
                refID2 = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                this.Close();
            }

        }

        private void cmbIdentification_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GemstoneType = "";

            if (cmbIdentification.SelectedIndex == 0)
            {
                cmbComment.Enabled = false;
                //GemstoneType = "C029";
            }
            else if (cmbIdentification.SelectedValue.ToString() == "95")
            {
                cmbComment.Enabled = true;
                GemstoneType = "C029";
            }
            else
            {
                cmbComment.Enabled = true;
                GemstoneType = "C028";
            }

            cmbComment.DataSource = (GM.GetMasterTableDetail(GemstoneType, true)).Tables[0];
            cmbComment.ValueMember = "ID";
            cmbComment.DisplayMember = "Detail";
            cmbComment.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridGemstoneCer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Service2 ser1 = GM.GetService1();
            string setting = ((DataGridView)sender).Rows[e.RowIndex].Cells["Setting"].Value.ToString();
            int tmpId = 0;

            if (e.ColumnIndex == 22)
            {
                if (setting != "" && setting != "Not Yet")
                {
                    tmpId = ser1.DoSearchInventoryByCode(setting);
                    Inventory frm = new Inventory(tmpId);
                    frm.ShowDialog();
                }
            }
        }
    }
}
