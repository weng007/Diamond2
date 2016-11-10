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
        public int factoryStatus = 218; //218 = Not Yet, 219 = Processing, 220 = Mounting Complete, 221 = Job Done
        string idSelected = "";

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

            if (ApplicationInfo.Shop == 232 && GM.IsOwner(ApplicationInfo.Authorized))
            {
                btnAdd.Enabled = true;
            }

            gridProductionLine.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            btnNotYet_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckSelected();

            ProductionLineInfo frm = new ProductionLineInfo(idSelected, factoryStatus);
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
                    if (gridProductionLine.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        idSelected += gridProductionLine.Rows[i].Cells["ID"].Value.ToString() + comma;
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
            ds = ser2.DoSearchProductionLine(txtOrderNo.Text, Convert.ToInt32(cmbJewelryType.SelectedValue.ToString()), 
                Convert.ToInt32(cmbShop.SelectedValue.ToString()), factoryStatus, dtSOrderDate.Value, dtEOrderDate.Value);

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

        private void btnNotYet_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.CornflowerBlue;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.Gray;
            factoryStatus = 218;

            SearchProductionLine(218);
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.CornflowerBlue;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.Gray;
            factoryStatus = 219;

            SearchProductionLine(219);
        }

        private void btnMounting_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.CornflowerBlue;
            btnJobDone.BackColor = Color.Gray;
            factoryStatus = 220;

            SearchProductionLine(220);
        }

        private void btnJobDone_Click(object sender, EventArgs e)
        {
            btnNotYet.BackColor = Color.Gray;
            btnProcessing.BackColor = Color.Gray;
            btnMounting.BackColor = Color.Gray;
            btnJobDone.BackColor = Color.CornflowerBlue;
            factoryStatus = 221;

            SearchProductionLine(221);
        }
        private void SearchProductionLine(int factoryStatus)
        {
            ser2 = GM.GetService2();
            ds = ser2.DoSearchProductionLine(txtOrderNo.Text, Convert.ToInt32(cmbJewelryType.SelectedValue.ToString()), Convert.ToInt32(cmbShop.SelectedValue.ToString()), factoryStatus,
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
