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
    public partial class BuyBookDiamondList : FormList
    {       
        public BuyBookDiamondList()
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

            //cmbClarity.DataSource = (GM.GetMasterTableDetail("C002",true)).Tables[0];
            //cmbClarity.ValueMember = "ID";
            //cmbClarity.DisplayMember = "Detail";
            //cmbClarity.Refresh();

            //txtSearch.Select();

            gridDiamond.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("DiamondCer", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridDiamond.DataSource = ds.Tables[0];
                gridDiamond.Refresh();
            }
            else
            {
                gridDiamond.DataSource = null;
                gridDiamond.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiamondCer frm = new DiamondCer();
            frm.ShowDialog();

            DoLoadData();
        }

        private void cmbColorGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            //if(cmbColorGrade.SelectedIndex == 0)
            //{
            //    cmbColor.Enabled = false;
            //    color = "C001";
            //}
            //else if(cmbColorGrade.SelectedIndex == 1)
            //{
            //    color = "C001";
            //    cmbColor.Enabled = true;     
            //}
            //else
            //{
            //    color = "C017";
            //    cmbColor.Enabled = true;
            //}

            //cmbColor.DataSource = (GM.GetMasterTableDetail(color,true)).Tables[0];
            //cmbColor.ValueMember = "ID";
            //cmbColor.DisplayMember = "Detail";
            //cmbColor.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchDiamondCer(txtSearch.Text, GM.ConvertStringToDouble(txtSSize), GM.ConvertStringToDouble(txtWeightTo),
            //    Convert.ToInt16(cmbShape.SelectedValue.ToString()), Convert.ToInt16(cmbColorGrade.SelectedValue.ToString()),
            //    Convert.ToInt16(cmbColor.SelectedValue.ToString()), Convert.ToInt16(cmbClarity.SelectedValue.ToString()));

            gridDiamond.DataSource = ds.Tables[0];
            gridDiamond.Refresh();
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridDiamond_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDiamond.RowCount > 0 && gridDiamond.SelectedRows.Count > 0)
            {
                id = (int)gridDiamond.SelectedRows[0].Cells["ID"].Value;
                BuyBookDiamond frm = new BuyBookDiamond(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
