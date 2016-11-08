using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class ProductionLineList : FormList
    {
        public int SFactoryStatus;
        string idSelected = "";
        int flag;

        public ProductionLineList()
        {
            InitializeComponent();
            Initial();
            dtSOrderDate.Value = dtSOrderDate.Value.AddDays(-90);
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015", true)).Tables[0];
            cmbJewelryType.ValueMember = "ID";
            cmbJewelryType.DisplayMember = "Detail";
            cmbJewelryType.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007", true)).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C036", true)).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            cmbShop.SelectedValue = ApplicationInfo.Shop;

            gridProductionLine.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            btnNotYet_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckSelected();

            ProductionLineInfo frm = new ProductionLineInfo(idSelected, SFactoryStatus);
            frm.ShowDialog();

            DoLoadData();
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridProductionLine.Rows.Count; i++)
            {
                if (gridProductionLine.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridProductionLine.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }
            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();
            ds = ser2.DoSearchProductionLine(txtOrderNo.Text, Convert.ToInt32(cmbJewelryType.SelectedValue.ToString()), Convert.ToInt32(cmbShop.SelectedValue.ToString()), Convert.ToInt32(cmbFactoryStatus.SelectedValue.ToString()),
               dtSOrderDate.Value, dtEOrderDate.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridProductionLine.DataSource = ds.Tables[0];
                gridProductionLine.Refresh();
            }
            else { gridProductionLine.DataSource = null; gridProductionLine.Refresh(); }
        }

        private void gridProductionLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridProductionLine.SelectedCells[0].Value == null)
                {
                    gridProductionLine.SelectedCells[0].Value = true;
                }
                else
                {
                    gridProductionLine.SelectedCells[0].Value = false;
                }
            }
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            flag = 0;
        }
        private void btnNotYet_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.CadetBlue;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.Gray;
            SFactoryStatus = 218;

            SearchProductionLine(218);
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.CadetBlue;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.Gray;
            SFactoryStatus = 219;

            SearchProductionLine(219);
        }

        private void btnMounting_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.CadetBlue;
            btnJobDone.BackColor = Color.Gray;
            SFactoryStatus = 220;

            SearchProductionLine(220);
        }

        private void btnJobDone_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.CadetBlue;
            SFactoryStatus = 221;

            SearchProductionLine(221);
        }
        private void SearchProductionLine(int FactoryStatus)
        {
            ser2 = GM.GetService2();
            ds = ser2.DoSearchProductionLine(txtOrderNo.Text, Convert.ToInt32(cmbJewelryType.SelectedValue.ToString()), Convert.ToInt32(cmbShop.SelectedValue.ToString()), FactoryStatus,
               dtSOrderDate.Value, dtEOrderDate.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridProductionLine.DataSource = ds.Tables[0];
                gridProductionLine.Refresh();
            }
            else { gridProductionLine.DataSource = null; gridProductionLine.Refresh(); }
        }
    }
}
