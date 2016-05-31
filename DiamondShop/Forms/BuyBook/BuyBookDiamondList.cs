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

            txtCode.Select();

            gridDiamond.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookDiamond", -1, 0);

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

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookDiamond frm = new BuyBookDiamond();
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookDiamond(txtCode.Text, GM.ConvertStringToDouble(txtSSize), GM.ConvertStringToDouble(txtESize), Convert.ToInt16(cmbShape.SelectedValue.ToString()));

            gridDiamond.DataSource = ds.Tables[0];
            gridDiamond.Refresh();

        }

        private void txtSSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridDiamond_MouseDoubleClick(object sender, MouseEventArgs e)
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
