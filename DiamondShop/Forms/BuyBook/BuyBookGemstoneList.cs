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
    public partial class BuyBookGemstoneList : FormList
    {       
        public BuyBookGemstoneList()
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

            gridGemstone.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("DiamondCer", -1);

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
            DiamondCer frm = new DiamondCer();
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
                if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
                {
                    id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("DiamondCer", id);
                }
            }
            return chkFlag;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
            {
                id = (int)gridGemstone.SelectedRows[0].Cells["ID"].Value;
                DiamondCer frm = new DiamondCer(id);
                frm.ShowDialog();
            }

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

            //ds = ser2.DoSearchDiamondCer(txtSearch.Text, GM.ConvertStringToDouble(txtWeightForm), GM.ConvertStringToDouble(txtWeightTo),
            //    Convert.ToInt16(cmbShape.SelectedValue.ToString()), Convert.ToInt16(cmbColorGrade.SelectedValue.ToString()),
            //    Convert.ToInt16(cmbColor.SelectedValue.ToString()), Convert.ToInt16(cmbClarity.SelectedValue.ToString()));

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
    }
}
