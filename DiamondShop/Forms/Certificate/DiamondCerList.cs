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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class DiamondCerList : FormList
    {
        public int mode = 0;
        public int refID1=0;

        public DiamondCerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public DiamondCerList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            btnClose.Visible = true;
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbShape.DataSource = (GM.GetMasterTableDetail("C019",true)).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbLab.DataSource = (GM.GetMasterTableDetail("C020", true)).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

            cmbSColor.DataSource = (GM.GetMasterTableDetail("C001", true)).Tables[0];
            cmbSColor.ValueMember = "ID";
            cmbSColor.DisplayMember = "Detail";
            cmbSColor.Refresh();

            cmbEColor.DataSource = (GM.GetMasterTableDetail("C001", true)).Tables[0];
            cmbEColor.ValueMember = "ID";
            cmbEColor.DisplayMember = "Detail";
            cmbEColor.Refresh();

            cmbSClearity.DataSource = (GM.GetMasterTableDetail("C002",true)).Tables[0];
            cmbSClearity.ValueMember = "ID";
            cmbSClearity.DisplayMember = "Detail";
            cmbSClearity.Refresh();

            cmbEClearity.DataSource = (GM.GetMasterTableDetail("C002", true)).Tables[0];
            cmbEClearity.ValueMember = "ID";
            cmbEClearity.DisplayMember = "Detail";
            cmbEClearity.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023", true)).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbColorType.DataSource = (GM.GetMasterTableDetail("C025", true)).Tables[0];
            cmbColorType.ValueMember = "ID";
            cmbColorType.DisplayMember = "Detail";
            cmbColorType.Refresh();

            txtReportNumber.Select();

            gridDiamondCer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("DiamondCer", -1, mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridDiamondCer.DataSource = ds.Tables[0];
                gridDiamondCer.Refresh();
            }
            else
            {
                gridDiamondCer.DataSource = null;
                gridDiamondCer.Refresh();
            }

            btnSearch_Click(null,null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchDiamondCer(txtCode.Text, txtReportNumber.Text, Convert.ToInt16(cmbShape.SelectedValue.ToString()), 
                Convert.ToInt16(cmbLab.SelectedValue.ToString()), GM.ConvertStringToDouble(txtSWeight), 
                GM.ConvertStringToDouble(txtEWeight),
                Convert.ToInt16(cmbColorType.SelectedValue.ToString()),
                Convert.ToInt16(cmbSColor.SelectedValue.ToString()),
                Convert.ToInt16(cmbEColor.SelectedValue.ToString()), Convert.ToInt16(cmbSClearity.SelectedValue.ToString())
                , Convert.ToInt16(cmbEClearity.SelectedValue.ToString()), Convert.ToInt16(cmbStatus.SelectedValue.ToString()), 
                Convert.ToInt16(cmbShop.SelectedValue.ToString()),mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridDiamondCer.DataSource = ds.Tables[0];
                gridDiamondCer.Refresh();
            }
            else { gridDiamondCer.DataSource = null; gridDiamondCer.Refresh(); }
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridDiamondCer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridDiamondCer.RowCount > 0 && gridDiamondCer.SelectedRows.Count > 0)
                {
                    id = (int)gridDiamondCer.SelectedRows[0].Cells["ID"].Value;
                    DiamondCer frm = new DiamondCer(id);
                    frm.ShowDialog();

                    if (frm.isEdit)
                    {
                        DoLoadData();
                    }
                }
                
            }
            else //mode = 1 Search
            {
                refID1 = (int)gridDiamondCer.SelectedRows[0].Cells["ID"].Value;
                this.Close();
            }    
        }

        private void cmbColorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            if (cmbColorType.SelectedIndex == 0)
            {
                cmbSColor.Enabled = false;
                cmbEColor.Enabled = false;
                color = "C001";
            }
            else if (cmbColorType.SelectedIndex == 1)
            {
                cmbSColor.Enabled = true;
                cmbEColor.Enabled = true;
                color = "C001";
            }
            else
            {
                cmbSColor.Enabled = true;
                cmbEColor.Enabled = false;
                color = "C017";
            }

            cmbSColor.DataSource = (GM.GetMasterTableDetail(color, true)).Tables[0];
            cmbSColor.ValueMember = "ID";
            cmbSColor.DisplayMember = "Detail";
            cmbSColor.Refresh();

            cmbEColor.DataSource = (GM.GetMasterTableDetail(color, true)).Tables[0];
            cmbEColor.ValueMember = "ID";
            cmbEColor.DisplayMember = "Detail";
            cmbEColor.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDiamondCer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Service2 ser1 = GM.GetService1();
            string setting = ((DataGridView)sender).Rows[e.RowIndex].Cells["Setting"].Value.ToString();
            int tmpId = 0;

            if (e.ColumnIndex == 18)
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
