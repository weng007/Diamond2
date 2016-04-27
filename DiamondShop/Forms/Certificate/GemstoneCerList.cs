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
        public GemstoneCerList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();

        }
        protected override void Initial()
        {
            //cmbShape.DataSource = (GM.GetMasterTableDetail("C019",true)).Tables[0];
            //cmbShape.ValueMember = "ID";
            //cmbShape.DisplayMember = "Detail";
            //cmbShape.Refresh();

            //cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024",true)).Tables[0];
            //cmbOrigin.ValueMember = "ID";
            //cmbOrigin.DisplayMember = "Detail";
            //cmbOrigin.Refresh();

            //cmbCompanyCer.DataSource = (GM.GetMasterTableDetail("C026",true)).Tables[0];
            //cmbCompanyCer.ValueMember = "ID";
            //cmbCompanyCer.DisplayMember = "Detail";
            //cmbCompanyCer.Refresh();

            cmbGemstoneType.DataSource = (GM.GetMasterTableDetail("C016",true)).Tables[0];
            cmbGemstoneType.ValueMember = "ID";
            cmbGemstoneType.DisplayMember = "Detail";
            cmbGemstoneType.Refresh();

            txtSWeight.Select();

            gridGemstone.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("GemstoneCer", -1);

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

            //ds = ser2.DoSearchGemstoneCer(GM.ConvertStringToDouble(txtSWeight), GM.ConvertStringToDouble(txtWeightTo),
            //    Convert.ToInt16(cmbShape.SelectedValue.ToString()), Convert.ToInt16(cmbOrigin.SelectedValue.ToString()),
            //    Convert.ToInt16(cmbCompanyCer.SelectedValue.ToString()), Convert.ToInt16(cmbGemstoneType.SelectedValue.ToString()));

            gridGemstone.DataSource = ds.Tables[0];
            gridGemstone.Refresh();
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridGemstone_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
            {
                //id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                //GemstoneCer frm = new GemstoneCer(id);
                //frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
