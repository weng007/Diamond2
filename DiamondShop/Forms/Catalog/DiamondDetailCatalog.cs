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
            }

            if (tds2.InvDiamondDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail(grid2);
            }

            base.LoadData();
        }

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
                    grid2.Rows[i].Cells["ShapeName1"].Value = row["ShapeName"].ToString();
                    grid2.Rows[i].Cells["WeightPerStone"].Value = row["WeightPerStone"].ToString();
                    grid2.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["ColorName1"].Value = row["ColorName"].ToString();
                    grid2.Rows[i].Cells["ClearityName1"].Value = row["ClearityName"].ToString();

                    i++;
                    CalSum(1);
                }
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
