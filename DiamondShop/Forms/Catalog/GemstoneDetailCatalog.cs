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
    public partial class GemstoneDetailCatalog : FormInfo
    {
        //Service1 ser = GM.GetService();
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        dsInvGemstoneCerDetail tds = new dsInvGemstoneCerDetail();
        dsInvGemstoneDetail tds2 = new dsInvGemstoneDetail();

        public GemstoneDetailCatalog()
        {
            InitializeComponent();
        }

        public GemstoneDetailCatalog(int id)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            //cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            //cmbOrigin.ValueMember = "ID";
            //cmbOrigin.DisplayMember = "Detail";
            //cmbOrigin.Refresh();

            //cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //cmbShape.ValueMember = "ID";
            //cmbShape.DisplayMember = "Detail";
            //cmbShape.Refresh();

            //cmbGemstoneType.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            //cmbGemstoneType.ValueMember = "ID";
            //cmbGemstoneType.DisplayMember = "Detail";
            //cmbGemstoneType.Refresh();

            //cmbShape.Select();

            //SetFieldService.SetRequireField(txtAmount, txtWeight);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("InvGemstoneCerDetail", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("InvGemstoneDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.InvGemstoneCerDetail.Rows.Count > 0)
            {
                grid1.Rows.Clear();
                BindingGridDiamondDetail(grid1);
                BindingDSDiamondDetail(0);
            }

            if (tds2.InvGemstoneDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail(grid2);
                BindingDSDiamondDetail(1);
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
                    grid1.Rows[i].Cells["IdentificationName"].Value = row["IdentificationName"].ToString();
                    grid1.Rows[i].Cells["LabName"].Value = row["LabName"].ToString();
                    grid1.Rows[i].Cells["ShapeName"].Value = row["ShapeName"].ToString();
                    grid1.Rows[i].Cells["Weight"].Value = row["Weight"].ToString();
                    grid1.Rows[i].Cells["ColorName"].Value = row["ColorName"].ToString();
                    grid1.Rows[i].Cells["OriginName"].Value = row["OriginName"].ToString();
                    grid1.Rows[i].Cells["MinPrice"].Value = row["MinPrice"].ToString();
                    grid1.Rows[i].Cells["TotalBaht"].Value = row["TotalBaht"].ToString();
                    grid1.Rows[i].Cells["refID"].Value = row["refID"].ToString();
                    grid1.Rows[i].Cells["refID1"].Value = row["refID1"].ToString();

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
                    grid2.Rows[i].Cells["GemstoneType"].Value = row["GemstoneType"].ToString();
                    grid2.Rows[i].Cells["Shape"].Value = row["Shape"].ToString();
                    //grid2.Rows[i].Cells["WeightPerStone"].Value = row["WeightPerStone"].ToString();
                    grid2.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["Origin"].Value = row["Origin"].ToString();
                    grid2.Rows[i].Cells["CostPerCarat"].Value = row["CostPerCarat"].ToString();
                    grid2.Rows[i].Cells["Cost1"].Value = row["Cost"].ToString();
                    grid2.Rows[i].Cells["MinPricePerCarat"].Value = row["MinPricePerCarat"].ToString();
                    grid2.Rows[i].Cells["MinPrice1"].Value = row["MinPrice"].ToString();
                    grid2.Rows[i].Cells["refID2"].Value = row["refID"].ToString();

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

        

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
