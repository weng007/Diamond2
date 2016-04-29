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
    public partial class BuyBookGemstoneCerList : FormList
    {       
        public BuyBookGemstoneCerList()
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


            txtReportNumber.Select();

            gridGemstoneCer.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookGemstoneCer", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGemstoneCer.DataSource = ds.Tables[0];
                gridGemstoneCer.Refresh();
            }
            else
            {
                gridGemstoneCer.DataSource = null;
                gridGemstoneCer.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookGemstoneCer frm = new BuyBookGemstoneCer();
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
                if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
                {
                    id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("DiamondCer", id);
                }
            }
            return chkFlag;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
            {
                id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
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

            ds = ser2.DoSearchBuyBookGemstoneCer(txtCode.Text, txtReportNumber.Text, Convert.ToInt16(cmbShape.SelectedValue.ToString()),
                Convert.ToInt16(cmbLab.SelectedValue.ToString()),
                GM.ConvertStringToDouble(txtSWeight),
                GM.ConvertStringToDouble(txtEWeight),
                Convert.ToInt16(cmbIdentification.SelectedValue.ToString()),
                Convert.ToInt16(cmbComment.SelectedValue.ToString()),
                Convert.ToInt16(cmbOrigin.SelectedValue.ToString()),
                Convert.ToInt16(cmbStatus.SelectedValue.ToString()),
                Convert.ToInt16(cmbShop.SelectedValue.ToString()));

            gridGemstoneCer.DataSource = ds.Tables[0];
            gridGemstoneCer.Refresh();
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridGemstoneCer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridGemstoneCer.RowCount > 0 && gridGemstoneCer.SelectedRows.Count > 0)
            {
                id = (int)gridGemstoneCer.SelectedRows[0].Cells["ID"].Value;
                DiamondCer frm = new DiamondCer(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
