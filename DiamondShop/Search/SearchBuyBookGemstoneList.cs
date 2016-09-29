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
    public partial class SearchBuyBookGemstoneList : FormList
    {       
        public SearchBuyBookGemstoneList()
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

            gridGemstone.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstone", -1, 0);

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
            BuyBookGemstone frm = new BuyBookGemstone();
            frm.ShowDialog();

            DoLoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookGemstone(txtCode.Text, GM.ConvertStringToDouble(txtSize), GM.ConvertStringToDouble(txtESize), cmbShape.SelectedValue.ToString(),txtCode2.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstone.DataSource = ds.Tables[0];
                gridGemstone.Refresh();
            }
            else { gridGemstone.DataSource = null; gridGemstone.Refresh(); }
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridGemstone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
            {
                id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                BuyBookGemstone frm = new BuyBookGemstone(id);
                frm.ShowDialog();

                if (frm.isEdit)
                {
                    DoLoadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
