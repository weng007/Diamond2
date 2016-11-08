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
        public string idSelected = "";

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
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridGemstone.Rows.Count; i++)
            {
                if (gridGemstone.Rows[i].Cells["Select"].Value != null)
                {
                    if (gridGemstone.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        idSelected += gridGemstone.Rows[i].Cells["ID"].Value.ToString() + comma;
                    }
                }
            }

            if (idSelected.Length > 0)
            {
                idSelected = idSelected.Remove(idSelected.Length - 1, 1);
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void gridGemstone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridGemstone.SelectedCells[0].Value == null || gridGemstone.SelectedCells[0].Value.ToString() == "False")
                {
                    gridGemstone.SelectedCells[0].Value = true;
                    id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                }
                else
                {
                    gridGemstone.SelectedCells[0].Value = false;
                }
            }
        }
    }
}
