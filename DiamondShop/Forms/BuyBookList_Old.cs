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
using DiamondShop.DiamondService;
using DiamondDS;

namespace DiamondShop
{
    public partial class BuyBookList : FormList
    {
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        int tabIndex = 0;

        public BuyBookList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            //DiamondCer
            cmbColorGrade.DataSource = (GM.GetMasterTableDetail("C025", true)).Tables[0];
            cmbColorGrade.ValueMember = "ID";
            cmbColorGrade.DisplayMember = "Detail";
            cmbColorGrade.Refresh();
            cmbClarity.DataSource = (GM.GetMasterTableDetail("C002", true)).Tables[0];
            cmbClarity.ValueMember = "ID";
            cmbClarity.DisplayMember = "Detail";
            cmbClarity.Refresh();

            //DiamondNoCer
            cmbColorGrade1.DataSource = (GM.GetMasterTableDetail("C025", true)).Tables[0];
            cmbColorGrade1.ValueMember = "ID";
            cmbColorGrade1.DisplayMember = "Detail";
            cmbColorGrade1.Refresh();
            cmbClarity1.DataSource = (GM.GetMasterTableDetail("C002", true)).Tables[0];
            cmbClarity1.ValueMember = "ID";
            cmbClarity1.DisplayMember = "Detail";
            cmbClarity1.Refresh();

            //GemStone
            cmbGemStoneType.DataSource = (GM.GetMasterTableDetail("C016", true)).Tables[0];
            cmbGemStoneType.ValueMember = "ID";
            cmbGemStoneType.DisplayMember = "Detail";
            cmbGemStoneType.Refresh();
            cmbStatus2.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbStatus2.ValueMember = "ID";
            cmbStatus2.DisplayMember = "Detail";
            cmbStatus2.Refresh();

            gridDiamondCer.AutoGenerateColumns = false;
            gridDiamond.AutoGenerateColumns = false;
            gridGemstone.AutoGenerateColumns = false;
            gridGold.AutoGenerateColumns = false;
            gridSpecial.AutoGenerateColumns = false;

            //Gold
            cmbStatus3.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbStatus3.ValueMember = "ID";
            cmbStatus3.DisplayMember = "Detail";
            cmbStatus3.Refresh();
        }

        #region DoLoadData
        protected override void DoLoadData()
        {
            DoLoadData(tabIndex);
        }

        private void DoLoadData(int tabIndex)
        {
            if(tabIndex == 0)
            {
                //Tab Diamond Cer
                ds = ser.DoSelectData("BuyBookDiamondCer", -1);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridDiamondCer.DataSource = ds.Tables[0];
                    gridDiamondCer.Refresh();
                }
                else { gridDiamondCer.DataSource = null; gridDiamondCer.Refresh(); }
            }
            else if(tabIndex == 1)
            {
                //Tab Diamond
                ds1 = ser.DoSelectData("BuyBookDiamond", -1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    gridDiamond.DataSource = ds1.Tables[0];
                    gridDiamond.Refresh();
                }
                else { gridDiamond.DataSource = null; gridDiamond.Refresh(); }
            }
            else if (tabIndex == 2)
            {
                //Tab Gemstone
                ds2 = ser.DoSelectData("BuyBookGemstone", -1);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    gridGemstone.DataSource = ds2.Tables[0];
                    gridGemstone.Refresh();
                }
                else { gridGemstone.DataSource = null; gridGemstone.Refresh(); }
            }
            else if (tabIndex == 3)
            {
                //Tab Gold
                ds3 = ser.DoSelectData("BuyBookGold", -1);
                if (ds3.Tables[0].Rows.Count > 0)
                {
                    gridGold.DataSource = ds3.Tables[0];
                    gridGold.Refresh();
                }
                else { gridGold.DataSource = null; gridGold.Refresh(); }
            }
            else if (tabIndex == 4)
            {
                //Tab Special
                ds4 = ser.DoSelectData("BuyBookSpecial", -1);
                if (ds4.Tables[0].Rows.Count > 0)
                {
                    gridSpecial.DataSource = ds4.Tables[0];
                    gridSpecial.Refresh();
                }
                else { gridSpecial.DataSource = null; gridSpecial.Refresh(); }
            }
        }
        #endregion

        #region Do Search Data
        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            if (tabIndex == 0)
            {
                ds = ser2.DoSearchBuyBookDiamondCer(txtSearch.Text, Convert.ToInt16(cmbColorGrade.SelectedValue.ToString()),
                    Convert.ToInt16(cmbColor.SelectedValue.ToString()), Convert.ToDouble(txtSWeight.Text),
                    Convert.ToDouble(txtEWeight.Text), Convert.ToInt16(cmbClarity.SelectedValue.ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridDiamondCer.DataSource = ds.Tables[0];
                    gridDiamondCer.Refresh();
                }
                else { gridDiamondCer.DataSource = null; gridDiamondCer.Refresh(); }
            }
            else if (tabIndex == 1)
            {
                ds = ser2.DoSearchBuyBookDiamond(Convert.ToDouble(txtSize1.Text),Convert.ToDouble(txtSize2.Text), 
                    Convert.ToInt16(cmbColorGrade1.SelectedValue.ToString()),
                    Convert.ToInt16(cmbColor1.SelectedValue.ToString()), Convert.ToInt16(cmbClarity1.SelectedValue.ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridDiamond.DataSource = ds.Tables[0];
                    gridDiamond.Refresh();
                }
                else { gridDiamond.DataSource = null; gridDiamond.Refresh(); }
            }
            else if (tabIndex == 2)
            {
                ds = ser2.DoSearchBuyBookGemstone(Convert.ToInt16(cmbGemStoneType.SelectedValue.ToString()),
                    Convert.ToInt16(cmbStatus2.SelectedValue.ToString()), Convert.ToDouble(txtSSize.Text),
                    Convert.ToDouble(txtESize.Text));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridGemstone.DataSource = ds.Tables[0];
                    gridGemstone.Refresh();
                }
                else { gridGemstone.DataSource = null; gridGemstone.Refresh(); }
            }
            else if (tabIndex == 3)
            {
                ds = ser2.DoSearchBuyBookGold(Convert.ToDouble(txtSWeight3.Text),
                    Convert.ToDouble(txtEWeight3.Text), Convert.ToInt16(cmbStatus3.SelectedValue.ToString()));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridGold.DataSource = ds.Tables[0];
                    gridGold.Refresh();
                }
                else { gridGold.DataSource = null; gridGold.Refresh(); }
            }
            else if (tabIndex == 4)
            {
                ds = ser2.DoSearchBuyBookSpecial(txtSearch4.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridSpecial.DataSource = ds.Tables[0];
                    gridSpecial.Refresh();
                }
                else { gridSpecial.DataSource = null; gridSpecial.Refresh(); }
            }
        }
        #endregion

        #region DoDeleteDate
        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (tabIndex == 0)
                {
                    if (gridDiamondCer.RowCount > 0 && gridDiamondCer.SelectedRows.Count > 0)
                    {
                        id = (int)gridDiamondCer.SelectedRows[0].Cells["ID"].Value;
                        chkFlag = ser.DoDeleteData("BuyBookDiamondCer", id);
                    }
                }
                else if(tabIndex ==1)
                {
                    if (gridDiamond.RowCount > 0 && gridDiamond.SelectedRows.Count > 0)
                    {
                        id = (int)gridDiamond.SelectedRows[0].Cells["ID1"].Value;
                        chkFlag = ser.DoDeleteData("BuyBookDiamond", id);
                    }
                }
                else if (tabIndex == 2)
                {
                    if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
                    {
                        id = (int)gridGemstone.SelectedRows[0].Cells["ID2"].Value;
                        chkFlag = ser.DoDeleteData("BuyBookGemstone", id);
                    }
                }
                else if (tabIndex == 3)
                {
                    if (gridGold.RowCount > 0 && gridGold.SelectedRows.Count > 0)
                    {
                        id = (int)gridGold.SelectedRows[0].Cells["ID3"].Value;
                        chkFlag = ser.DoDeleteData("BuyBookGold", id);
                    }
                }
                else if (tabIndex == 4)
                {
                    if (gridSpecial.RowCount > 0 && gridSpecial.SelectedRows.Count > 0)
                    {
                        id = (int)gridSpecial.SelectedRows[0].Cells["ID4"].Value;
                        chkFlag = ser.DoDeleteData("BuyBookSpecial", id);
                    }
                }
            }
            return chkFlag;
        }
        #endregion

       

        private void cmbColorGradeCer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            if (cmbColorGrade.SelectedIndex == 0)
            {
                cmbColor.Enabled = false;
                color = "C001";
            }
            else if (cmbColorGrade.SelectedIndex == 1)
            {
                color = "C001";
                cmbColor.Enabled = true;
            }
            else
            {
                color = "C017";
                cmbColor.Enabled = true;
            }

            cmbColor.DataSource = (GM.GetMasterTableDetail(color, true)).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();
        }

        private void cmbColGradeDiamond_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            if (cmbColorGrade1.SelectedIndex == 0)
            {
                cmbColor1.Enabled = false;
                color = "C001";
            }
            else if (cmbColorGrade1.SelectedIndex == 1)
            {
                color = "C001";
                cmbColor1.Enabled = true;
            }
            else
            {
                color = "C017";
                cmbColor1.Enabled = true;
            }

            cmbColor1.DataSource = (GM.GetMasterTableDetail(color, true)).Tables[0];
            cmbColor1.ValueMember = "ID";
            cmbColor1.DisplayMember = "Detail";
            cmbColor1.Refresh();
        }


        #region Tab Diamond Cer
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookDiamondCer frm = new BuyBookDiamondCer();
            frm.ShowDialog();
            DoLoadData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridDiamondCer.RowCount > 0 && gridDiamondCer.SelectedRows.Count > 0)
            {
                id = (int)gridDiamondCer.SelectedRows[0].Cells["ID"].Value;
                BuyBookDiamondCer frm = new BuyBookDiamondCer(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        #endregion

        #region Tab Diamond No Cer
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
        private void btnAddDiamon_Click(object sender, EventArgs e)
        {
            BuyBookDiamond frm = new BuyBookDiamond();
            frm.ShowDialog();

            DoLoadData();
        }
        private void btnEditDiamond_Click(object sender, EventArgs e)
        {
            if (gridDiamond.RowCount > 0 && gridDiamond.SelectedRows.Count > 0)
            {
                id = (int)gridDiamond.SelectedRows[0].Cells["ID1"].Value;
                BuyBookDiamond frm = new BuyBookDiamond(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        #endregion

        #region Tab Gemstone
        private void btnSearch2_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            BuyBookGemstone frm = new BuyBookGemstone();
            frm.ShowDialog();

            DoLoadData();
        }
        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (gridGemstone.RowCount > 0 && gridGemstone.SelectedRows.Count > 0)
            {
                id = (int)gridGemstone.SelectedRows[0].Cells["ID2"].Value;
                BuyBookGemstone frm = new BuyBookGemstone(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        #endregion

        #region Tab Gold
        private void btnSearch3_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }
        private void btnAdd3_Click(object sender, EventArgs e)
        {
            BuyBookGold frm = new BuyBookGold();
            frm.ShowDialog();

            DoLoadData();
        }
        private void btnEdit3_Click(object sender, EventArgs e)
        {
            if (gridGold.RowCount > 0 && gridGold.SelectedRows.Count > 0)
            {
                id = (int)gridGold.SelectedRows[0].Cells["ID3"].Value;
                BuyBookGold frm = new BuyBookGold(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
        private void btnDelete3_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        #endregion

        #region Tab Special
        private void btnSearch4_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            BuyBookSpecial frm = new BuyBookSpecial();
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnEdit4_Click(object sender, EventArgs e)
        {
            if (gridSpecial.RowCount > 0 && gridSpecial.SelectedRows.Count > 0)
            {
                id = (int)gridSpecial.SelectedRows[0].Cells["ID4"].Value;
                BuyBookSpecial frm = new BuyBookSpecial(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }
        #endregion


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabIndex = tabControl1.SelectedIndex;
            DoLoadData();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
