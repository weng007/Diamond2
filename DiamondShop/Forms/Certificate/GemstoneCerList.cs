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
    public partial class GemstoneCerList : FormList
    {
        public int mode = 0;
        public int refID1 = 0;

        public GemstoneCerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();

        }
        public GemstoneCerList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            btnClose.Visible = true;
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbIdentification.DataSource = (GM.GetMasterTableDetail("C016", true)).Tables[0];
            cmbIdentification.ValueMember = "ID";
            cmbIdentification.DisplayMember = "Detail";
            cmbIdentification.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019", true)).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbLab.DataSource = (GM.GetMasterTableDetail("C026", true)).Tables[0];
            cmbLab.ValueMember = "ID";
            cmbLab.DisplayMember = "Detail";
            cmbLab.Refresh();

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

            txtCode.Select();

            gridGemstone.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("GemstoneCer", -1, mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstone.DataSource = ds.Tables[0];
                gridGemstone.Refresh();
            }
            else
            {
                gridGemstone.DataSource = null;
                gridGemstone.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GemstoneCer frm = new GemstoneCer();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchGemstoneCer(Convert.ToInt16(cmbIdentification.SelectedValue.ToString()),
                 txtCode.Text, txtReportNumber.Text,
                 GM.ConvertStringToDouble(txtSWeight), GM.ConvertStringToDouble(txtEWeight),
                 Convert.ToInt16(cmbShape.SelectedValue.ToString()),
                 Convert.ToInt16(cmbComment.SelectedValue.ToString()),  
                 Convert.ToInt16(cmbLab.SelectedValue.ToString()),
                 Convert.ToInt16(cmbOrigin.SelectedValue.ToString()),
                 Convert.ToInt16(cmbStatus.SelectedValue.ToString()), 
                 Convert.ToInt16(cmbShop.SelectedValue.ToString()),mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstone.DataSource = ds.Tables[0];
                gridGemstone.Refresh();
            }
            else { gridGemstone.DataSource = null; gridGemstone.Refresh(); }
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void gridGemstone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
                {
                    id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                    GemstoneCer frm = new GemstoneCer(id);
                    frm.ShowDialog();

                    if (frm.isEdit)
                    {
                        DoLoadData();
                    }
                }
                
            }
            else //mode = 1 Search
            {
                refID1 = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
