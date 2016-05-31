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
using DiamondDS.DS;
using DiamondShop.DiamondService;


namespace DiamondShop
{
    public partial class DiamondDetailCatalog : FormInfo
    {
        //Service1 ser = GM.GetService();
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        dsInvDiamondCerDetail tds = new dsInvDiamondCerDetail();
        dsInvDiamondDetail tds2 = new dsInvDiamondDetail();

        public DiamondDetailCatalog()
        {
            InitializeComponent();
            Initial();
        }

        public DiamondDetailCatalog(int id)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            //cmbColorGrade.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            //cmbColorGrade.ValueMember = "ID";
            //cmbColorGrade.DisplayMember = "Detail";
            //cmbColorGrade.Refresh();

            //cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //cmbShape.ValueMember = "ID";
            //cmbShape.DisplayMember = "Detail";
            //cmbShape.Refresh();

            //cmbClarity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            //cmbClarity.ValueMember = "ID";
            //cmbClarity.DisplayMember = "Detail";
            //cmbClarity.Refresh();

            //cmbShape.Select();

            //SetFieldService.SetRequireField(txtWeight, txtGIANumber);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("InvDiamondCerDetail", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("InvDiamondDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.InvDiamondCerDetail.Rows.Count > 0)
            {
                grid1.Rows.Clear();
                BindingGridDiamondDetail(grid1);
                //BindingDSDiamondDetail(0);
            }

            if (tds2.InvDiamondDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail(grid2);
                //BindingDSDiamondDetail(1);
            }

            base.LoadData();
        }
        #region Binding Grid, Dataset
        private void BindingGridDiamondDetail(DataGridView grid)
        {
            int i = 0;

            if (grid.Name == "grid1")
            {
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    grid1.Rows.Add();
                    grid1.Rows[i].Cells["ID"].Value = row["ID"].ToString();
                    grid1.Rows[i].Cells["RowNum"].Value = row["RowNum"].ToString();
                    grid1.Rows[i].Cells["Code"].Value = row["Code"].ToString();
                    grid1.Rows[i].Cells["ReportNumber"].Value = row["ReportNumber"].ToString();
                    grid1.Rows[i].Cells["LabName"].Value = row["LabName"].ToString();
                    grid1.Rows[i].Cells["ShapeName"].Value = row["ShapeName"].ToString();
                    grid1.Rows[i].Cells["Weight"].Value = row["Weight"].ToString();
                    grid1.Rows[i].Cells["ColorName"].Value = row["ColorName"].ToString();
                    grid1.Rows[i].Cells["ClearityName"].Value = row["ClearityName"].ToString();

                    i++;
                }

                i = 0;
                CalSum(0);
            }

            else if (grid.Name == "grid2")
            {
                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    grid2.Rows.Add();
                    grid2.Rows[i].Cells["ID1"].Value = row["ID"].ToString();
                    grid2.Rows[i].Cells["RowNum1"].Value = row["RowNum"].ToString();
                    grid2.Rows[i].Cells["Shape"].Value = row["Shape"].ToString();
                    grid2.Rows[i].Cells["WeightPerStone"].Value = row["WeightPerStone"].ToString();
                    grid2.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["Color"].Value = row["Color"].ToString();
                    grid2.Rows[i].Cells["Clearity1"].Value = row["Clearity"].ToString();

                    i++;
                    CalSum(1);
                }
            }
        }

        //private void BindingDSDiamondDetail(int type)
        //{
        //    int i = 0;

        //    if (type == 0)
        //    {
        //        tds.Clear();

        //        foreach (DataGridViewRow row in grid1.Rows)
        //        {
        //            tds.Tables[0].Rows.Add();

        //            if (row.Cells["ID"].Value != null)
        //            { tds.Tables[0].Rows[i]["ID"] = row.Cells["ID"].Value; }

        //            if (row.Cells["RowNum"].Value != null)
        //            { tds.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum"].Value; }

        //            if (row.Cells["RefID"].Value != null)
        //            { tds.Tables[0].Rows[i]["refID"] = row.Cells["refID"].Value; }

        //            tds.Tables[0].Rows[i]["refID1"] = row.Cells["refID1"].Value;
        //            tds.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice"].Value;

        //            i++;
        //        }

        //        i = 0;
        //        tds.AcceptChanges();
        //    }
        //    else
        //    {
        //        tds2.Clear();
        //        foreach (DataGridViewRow row in grid2.Rows)
        //        {
        //            tds2.Tables[0].Rows.Add();

        //            if (row.Cells["ID1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["ID"] = row.Cells["ID1"].Value; }

        //            if (row.Cells["RowNum1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum1"].Value; }

        //            if (row.Cells["WeightPerStone"].Value != null)
        //            { tds2.Tables[0].Rows[i]["WeightPerStone"] = row.Cells["WeightPerStone"].Value; }

        //            if (row.Cells["Amount"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount"].Value; }

        //            if (row.Cells["Weight1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value; }

        //            if (row.Cells["Shape"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value; }

        //            if (row.Cells["Color"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value; }

        //            if (row.Cells["Clearity1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Clearity"] = row.Cells["Clearity1"].Value; }

        //            if (row.Cells["CostPerCarat"].Value != null)
        //            { tds2.Tables[0].Rows[i]["CostPerCarat"] = row.Cells["CostPerCarat"].Value; }

        //            if (row.Cells["Cost1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["Cost"] = row.Cells["Cost1"].Value; }

        //            if (row.Cells["MinPricePerCarat"].Value != null)
        //            { tds2.Tables[0].Rows[i]["MinPricePerCarat"] = row.Cells["MinPricePerCarat"].Value; }

        //            if (row.Cells["MinPrice1"].Value != null)
        //            { tds2.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice1"].Value; }

        //            if (row.Cells["refID2"].Value != null)
        //            { tds2.Tables[0].Rows[i]["refID"] = row.Cells["refID2"].Value; }

        //            i++;
        //        }

        //        tds2.AcceptChanges();
        //    }
        //}
        #endregion

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CalSum(int type)
        {
            if (type == 0)
            {
                txtSumWeight.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight"].Value))).ToString();

                txtSumWeight.Text = GM.ConvertDoubleToString(txtSumWeight);
            }
            else
            {
                txtSumAmount1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Amount"].Value))).ToString();

                txtSumWeight1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight1"].Value))).ToString();

                txtSumAmount1.Text = GM.ConvertDoubleToString(txtSumAmount1);
                txtSumWeight1.Text = GM.ConvertDoubleToString(txtSumWeight1);
            }

        }
    }
}
