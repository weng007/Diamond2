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
    public partial class SearchBuyBookDiamondList : FormList
    {
        public string idSelected = "";

        public SearchBuyBookDiamondList()
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
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridDiamond.Rows.Count; i++)
            {
                if (gridDiamond.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridDiamond.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }

            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookDiamond(txtCode.Text, GM.ConvertStringToDouble(txtSSize), GM.ConvertStringToDouble(txtESize), Convert.ToInt16(cmbShape.SelectedValue.ToString()),txtCode2.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridDiamond.DataSource = ds.Tables[0];
                gridDiamond.Refresh();
            }
            else { gridDiamond.DataSource = null; gridDiamond.Refresh(); }
        }

        private void txtSSize_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
