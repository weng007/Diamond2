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
    public partial class DiamondCerList : FormList
    {       
        public DiamondCerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbShape.DataSource = (GM.GetMasterTableDetail("C019",true)).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            //cmbColorGrade.DataSource = (GM.GetMasterTableDetail("C025",true)).Tables[0];
            //cmbColorGrade.ValueMember = "ID";
            //cmbColorGrade.DisplayMember = "Detail";
            //cmbColorGrade.Refresh();

            cmbSClearity.DataSource = (GM.GetMasterTableDetail("C002",true)).Tables[0];
            cmbSClearity.ValueMember = "ID";
            cmbSClearity.DisplayMember = "Detail";
            cmbSClearity.Refresh();

            txtReportNumber.Select();

            gridDiamondCer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("DiamondCer", -1);

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
        }

        private void cmbColorGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            //if(cmbColorGrade.SelectedIndex == 0)
            //{
            //    cmbSColor.Enabled = false;
            //    color = "C001";
            //}
            //else if(cmbColorGrade.SelectedIndex == 1)
            //{
            //    color = "C001";
            //    cmbSColor.Enabled = true;     
            //}
            //else
            //{
            //    color = "C017";
            //    cmbSColor.Enabled = true;
            //}

            cmbSColor.DataSource = (GM.GetMasterTableDetail(color,true)).Tables[0];
            cmbSColor.ValueMember = "ID";
            cmbSColor.DisplayMember = "Detail";
            cmbSColor.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchDiamondCer(txtReportNumber.Text, GM.ConvertStringToDouble(txtSWeight), GM.ConvertStringToDouble(txtEWeight),
            //    Convert.ToInt16(cmbShape.SelectedValue.ToString()), Convert.ToInt16(cmbColorGrade.SelectedValue.ToString()),
            //    Convert.ToInt16(cmbSColor.SelectedValue.ToString()), Convert.ToInt16(cmbSClearity.SelectedValue.ToString()));

            gridDiamondCer.DataSource = ds.Tables[0];
            gridDiamondCer.Refresh();
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridDiamondCer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDiamondCer.RowCount > 0 && gridDiamondCer.SelectedRows.Count > 0)
            {
                id = (int)gridDiamondCer.SelectedRows[0].Cells["ID"].Value;
                DiamondCer frm = new DiamondCer(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
