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
    public partial class InvGemstoneDetail : FormInfo
    {
        //Service1 ser = GM.GetService();
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        int rowIndex, rowIndex1;
        int chkGrid, DelID;
        dsInvGemstoneCerDetail tds = new dsInvGemstoneCerDetail();
        dsInvGemstoneDetail tds2 = new dsInvGemstoneDetail();
        dsGemstoneCer tdsGemstoneCer = new dsGemstoneCer();
        

        public InvGemstoneDetail()
        {
            InitializeComponent();
            Initial();
        }

        public InvGemstoneDetail(int id)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;
            grid2.AutoGenerateColumns = false;

            Shape = (DataGridViewComboBoxColumn)grid2.Columns["Shape"];
            Shape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape.ValueMember = "ID";
            Shape.DisplayMember = "Detail";
            Shape.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0][1];

            GemstoneType.DataSource = (GM.GetMasterTableDetail("C016", true)).Tables[0];
            GemstoneType.ValueMember = "ID";
            GemstoneType.DisplayMember = "Detail";
            GemstoneType.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C016")).Tables[0].Rows[0][1];

            Origin.DataSource = (GM.GetMasterTableDetail("C024", true)).Tables[0];
            Origin.ValueMember = "ID";
            Origin.DisplayMember = "Detail";
            Origin.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C024")).Tables[0].Rows[0][1];


            grid2.Refresh();
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

                txtSumCost.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["TotalBaht"].Value))).ToString();

                txtSumMinPrice.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["MinPrice"].Value))).ToString();

                txtSumWeight.Text = GM.ConvertDoubleToString(txtSumWeight);
                txtSumCost.Text = GM.ConvertDoubleToString(txtSumCost, 0);
                txtSumMinPrice.Text = GM.ConvertDoubleToString(txtSumMinPrice, 0);
            }
            else
            {
                txtSumAmount1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Amount"].Value))).ToString();

                txtSumWeight1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight1"].Value))).ToString();

                txtSumCost1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Cost1"].Value))).ToString();

                txtSumMinPrice1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["MinPrice1"].Value))).ToString();

                txtSumAmount1.Text = GM.ConvertDoubleToString(txtSumAmount1,0);
                txtSumWeight1.Text = GM.ConvertDoubleToString(txtSumWeight1);
                txtSumCost1.Text = GM.ConvertDoubleToString(txtSumCost1, 0);
                txtSumMinPrice1.Text = GM.ConvertDoubleToString(txtSumMinPrice1, 0);
            }

        }
        private void BindingDSDiamondDetail(int type)
        {
            int i = 0;

            if (type == 0)
            {
                tds.Clear();

                foreach (DataGridViewRow row in grid1.Rows)
                {
                    tds.Tables[0].Rows.Add();

                    if (row.Cells["ID"].Value != null)
                    { tds.Tables[0].Rows[i]["ID"] = row.Cells["ID"].Value; }

                    if (row.Cells["RowNum"].Value != null)
                    { tds.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum"].Value; }

                    if (row.Cells["refID"].Value != null)
                    { tds.Tables[0].Rows[i]["refID"] = row.Cells["refID"].Value; }

                    tds.Tables[0].Rows[i]["refID1"] = row.Cells["refID1"].Value;
                    tds.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice"].Value;

                    i++;
                }

                i = 0;
                tds.AcceptChanges();
            }
            else
            {
                tds2.Clear();
                foreach (DataGridViewRow row in grid2.Rows)
                {
                    tds2.Tables[0].Rows.Add();

                    if (row.Cells["ID1"].Value != null)
                    { tds2.Tables[0].Rows[i]["ID"] = row.Cells["ID1"].Value; }

                    if (row.Cells["RowNum1"].Value != null)
                    { tds2.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum1"].Value; }

                    if (row.Cells["GemstoneType"].Value != null)
                    { tds2.Tables[0].Rows[i]["GemstoneType"] = row.Cells["GemstoneType"].Value; }

                    if (row.Cells["Shape"].Value != null)
                    { tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value; }

                    if (row.Cells["Amount"].Value != null)
                    { tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount"].Value; }

                    if (row.Cells["Weight1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value; }

                    if (row.Cells["CostPerCarat"].Value != null)
                    { tds2.Tables[0].Rows[i]["CostPerCarat"] = row.Cells["CostPerCarat"].Value; }

                    if (row.Cells["Origin"].Value != null)
                    { tds2.Tables[0].Rows[i]["Origin"] = row.Cells["Origin"].Value; }

                    if (row.Cells["Cost1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Cost"] = row.Cells["Cost1"].Value; }

                    if (row.Cells["MinPricePerCarat"].Value != null)
                    { tds2.Tables[0].Rows[i]["MinPricePerCarat"] = row.Cells["MinPricePerCarat"].Value; }

                    if (row.Cells["MinPrice1"].Value != null)
                    { tds2.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice1"].Value; }

                    if (row.Cells["refID2"].Value != null)
                    { tds2.Tables[0].Rows[i]["refID"] = row.Cells["refID2"].Value; }

                    i++;
                }

                tds2.AcceptChanges();
            }
        }

        protected override bool SaveData()
        {
            try
            {
                //Cer Gemstone
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        row["RefID"] = id;
                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }

                tds.AcceptChanges();
                chkFlag = ser.DoInsertData("InvGemstoneCerDetail", tds,0);

                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        row["RefID"] = id;

                        if (row["GemstoneType"].ToString() == "") { row["GemstoneType"] = 94; }
                        if (row["Shape"].ToString() == "") { row["Shape"] = 133; }
                        if (row["Origin"].ToString() == "") { row["Origin"] = 111; }

                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }

                tds2.AcceptChanges();
                chkFlag = ser.DoInsertData("InvGemstoneDetail", tds2,0);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            if (chkGrid == 0)
            {
                try
                {
                    chkFlag = ser.DoDeleteData("InvGemstoneCerDetail", DelID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    chkFlag = ser.DoDeleteData("InvGemstoneDetail", DelID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            //if (txtAmount.Text == "" || GM.ConvertStringToDouble(txtAmount) == 0)
            //{
            //    message += "Please input Amount > 0.\n";
            //}

            //if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            //{
            //    message += "Please input Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void grid2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }

            if (datagridview.Name == "grid1")
             { rowIndex = e.RowIndex; }
             else { rowIndex1 = e.RowIndex; }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            grid1.Rows.RemoveAt(rowIndex);
            tds.Tables[0].Rows[rowIndex].Delete();
            tds.AcceptChanges();

            DeleteDataGrid(0);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            grid2.Rows.Add();
            tds2.Tables[0].Rows.Add();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            grid2.Rows.RemoveAt(rowIndex1);
            tds2.Tables[0].Rows[rowIndex1].Delete();
            tds2.AcceptChanges();

            DeleteDataGrid(1);
        }

        private void DeleteDataGrid(int type)
        {
            if (type == 0)
            {
                chkGrid = 0;
                DeleteData();
            }
            else
            {
                chkGrid = 1;
                DeleteData();
            }
        }

        private void grid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                if (grid1.Rows[e.RowIndex].Cells[13].Value.ToString().Trim() == "")
                {
                    grid1.Rows[e.RowIndex].Cells[13].Value = 0;
                }

                grid1.RefreshEdit();
                BindingDSDiamondDetail(0);
            }

            CalSum(0);
        }

        private void grid2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) // Amount
            {
                if (grid2.Rows[e.RowIndex].Cells[5].Value == null || grid2.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[5].Value = 0;
                }
            }
            if (e.ColumnIndex == 6 || e.ColumnIndex == 8) // Weight, Cost/Carat
            {
                if (grid2.Rows[e.RowIndex].Cells[6].Value == null || grid2.Rows[e.RowIndex].Cells[6].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[6].Value = 0;
                }
                if (grid2.Rows[e.RowIndex].Cells[8].Value == null || grid2.Rows[e.RowIndex].Cells[8].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[8].Value = 0;
                }

                // Cost = Weight * Costpercarat
                grid2.Rows[e.RowIndex].Cells[9].Value = Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[6].Value) * Convert.ToInt32(grid2.Rows[e.RowIndex].Cells[8].Value);
                
            }
            else if (e.ColumnIndex == 10) // minPrice/carat 
            {
                if (grid2.Rows[e.RowIndex].Cells[10].Value == null || grid2.Rows[e.RowIndex].Cells[10].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[10].Value = 0;
                }
                // Cost = Weight * minPricepercarat
                grid2.Rows[e.RowIndex].Cells[11].Value = Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[6].Value) * Convert.ToInt32(grid2.Rows[e.RowIndex].Cells[10].Value);
            }

            grid2.RefreshEdit();
            BindingDSDiamondDetail(1);

            CalSum(1);
        }

        private void grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 12 || e.ColumnIndex == 13 ) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
            if ((e.ColumnIndex == 9) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void grid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
            if ((e.ColumnIndex == 6) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void grid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grid1.CurrentCell.ColumnIndex != 0 || grid1.CurrentCell.ColumnIndex != 3 || grid1.CurrentCell.ColumnIndex != 9)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void grid2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grid2.CurrentCell.ColumnIndex != 0 || grid2.CurrentCell.ColumnIndex != 2 || grid2.CurrentCell.ColumnIndex != 6)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (grid.Name == "grid1")
                {
                    rowIndex = e.RowIndex;
                    if (grid1.Rows[e.RowIndex].Cells["ID"].Value != null)
                    { DelID = Convert.ToInt32(grid1.Rows[e.RowIndex].Cells["ID"].Value.ToString()); }
                }
                else
                {
                    rowIndex1 = e.RowIndex;

                    if (grid2.Rows[e.RowIndex].Cells["ID1"].Value != null)
                    { DelID = Convert.ToInt32(grid2.Rows[e.RowIndex].Cells["ID1"].Value.ToString()); }

                }

            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GemstoneCerList frm = new GemstoneCerList(1);
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser.DoSelectData("GemstoneCer", frm.refID1, 0);
                tdsGemstoneCer.Clear();
                tdsGemstoneCer.Merge(tmp);

                grid1.Rows.Add();
                rowIndex = grid1.Rows.GetLastRow(DataGridViewElementStates.Displayed);

                grid1.Rows[rowIndex].Cells["Code"].Value = tdsGemstoneCer.Tables[0].Rows[0]["Code"].ToString();
                grid1.Rows[rowIndex].Cells["ReportNumber"].Value = tdsGemstoneCer.Tables[0].Rows[0]["ReportNumber"].ToString();
                grid1.Rows[rowIndex].Cells["IdentificationName"].Value = tdsGemstoneCer.Tables[0].Rows[0]["IdentificationName"].ToString();
                grid1.Rows[rowIndex].Cells["LabName"].Value = tdsGemstoneCer.Tables[0].Rows[0]["LabName"].ToString();
                grid1.Rows[rowIndex].Cells["ShapeName"].Value = tdsGemstoneCer.Tables[0].Rows[0]["ShapeName"].ToString();
                grid1.Rows[rowIndex].Cells["Weight"].Value = tdsGemstoneCer.Tables[0].Rows[0]["Weight"].ToString();
                grid1.Rows[rowIndex].Cells["ColorName"].Value = tdsGemstoneCer.Tables[0].Rows[0]["ColorName"].ToString();
                grid1.Rows[rowIndex].Cells["OriginName"].Value = tdsGemstoneCer.Tables[0].Rows[0]["OriginName"].ToString();
                grid1.Rows[rowIndex].Cells["MinPrice"].Value = 0;
                grid1.Rows[rowIndex].Cells["TotalBaht"].Value = tdsGemstoneCer.Tables[0].Rows[0]["TotalBaht"].ToString();
                grid1.Rows[rowIndex].Cells["refID1"].Value = frm.refID1;

                tds.Tables[0].Rows.Add();
                tds.Tables[0].Rows[rowIndex]["refID1"] = frm.refID1;
                tds.Tables[0].Rows[rowIndex]["MinPrice"] = grid1.Rows[rowIndex].Cells["MinPrice"].Value;

                tds.AcceptChanges();
            }
        }

        private bool CheckDataExist(int tmp)
        {
            if (grid1.Rows.Count > 0)
            {
                for (int i = 0; i < grid1.Rows.Count; i++)
                {
                    if (tmp == Convert.ToInt32(grid1.Rows[i].Cells["RefID1"].Value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
