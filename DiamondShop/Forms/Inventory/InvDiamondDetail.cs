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
    public partial class InvDiamondDetail : FormInfo
    {
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        int rowIndex, rowIndex1;
        int chkGrid, DelID;
        dsInvDiamondCerDetail tds = new dsInvDiamondCerDetail();
        dsDiamondCer tdsDiamondCer = new dsDiamondCer();
        dsInvDiamondDetail tds2 = new dsInvDiamondDetail();

        public InvDiamondDetail()
        {
            InitializeComponent();
            Initial();
        }

        public InvDiamondDetail(int id)
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

            Color = (DataGridViewComboBoxColumn)grid2.Columns["Color"];
            Color.DataSource = (GM.GetMasterTableDetail("C017")).Tables[0];
            Color.ValueMember = "ID";
            Color.DisplayMember = "Detail";
            Color.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C017")).Tables[0].Rows[0][1];

            Clearity1 = (DataGridViewComboBoxColumn)grid2.Columns["Clearity1"];
            Clearity1.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            Clearity1.ValueMember = "ID";
            Clearity1.DisplayMember = "Detail";
            Clearity1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C002")).Tables[0].Rows[0][1];

            grid2.Refresh();
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("InvDiamondCerDetail", id,0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("InvDiamondDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.InvDiamondCerDetail.Rows.Count > 0)
            {
                grid1.Rows.Clear();
                BindingGridDiamondDetail(grid1);
                BindingDSDiamondDetail(0);
            }

            if (tds2.InvDiamondDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail(grid2);
                BindingDSDiamondDetail(1);
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            try
            {
                //Cer Diamond
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
                chkFlag = ser.DoInsertData("InvDiamondCerDetail", tds);

                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        row["RefID"] = id;

                        if (row["Shape"].ToString() == "") { row["Shape"] = 133; }
                        if (row["Color"].ToString() == "") { row["Color"] = 126; }
                        if (row["Clearity"].ToString() == "") { row["Clearity"] = 25; }

                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }

                tds2.AcceptChanges();
                chkFlag = ser.DoInsertData("InvDiamondDetail", tds2);

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
                    chkFlag = ser.DoDeleteData("InvDiamondCerDetail", DelID);
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
                    chkFlag = ser.DoDeleteData("InvDiamondDetail", DelID);
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

            //if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight)==0)
            //{
            //    message = "Please input Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiamondCerList frm = new DiamondCerList(1);
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser.DoSelectData("DiamondCer", frm.refID1, 0);
                tdsDiamondCer.Clear();
                tdsDiamondCer.Merge(tmp);

                grid1.Rows.Add();
                rowIndex = grid1.Rows.GetLastRow(DataGridViewElementStates.Displayed);

                grid1.Rows[rowIndex].Cells["Code"].Value = tdsDiamondCer.Tables[0].Rows[0]["Code"].ToString();
                grid1.Rows[rowIndex].Cells["ReportNumber"].Value = tdsDiamondCer.Tables[0].Rows[0]["ReportNumber"].ToString();
                grid1.Rows[rowIndex].Cells["LabName"].Value = tdsDiamondCer.Tables[0].Rows[0]["LabName"].ToString();
                grid1.Rows[rowIndex].Cells["ShapeName"].Value = tdsDiamondCer.Tables[0].Rows[0]["ShapeName"].ToString();
                grid1.Rows[rowIndex].Cells["Weight"].Value = tdsDiamondCer.Tables[0].Rows[0]["Weight"].ToString();
                grid1.Rows[rowIndex].Cells["ColorName"].Value = tdsDiamondCer.Tables[0].Rows[0]["ColorName"].ToString();
                grid1.Rows[rowIndex].Cells["ClearityName"].Value = tdsDiamondCer.Tables[0].Rows[0]["ClearityName"].ToString();
                grid1.Rows[rowIndex].Cells["MinPrice"].Value = 0;
                grid1.Rows[rowIndex].Cells["TotalBaht"].Value = tdsDiamondCer.Tables[0].Rows[0]["TotalBaht"].ToString();
                grid1.Rows[rowIndex].Cells["refID1"].Value = frm.refID1;

                tds.Tables[0].Rows.Add();
                tds.Tables[0].Rows[rowIndex]["refID1"] = frm.refID1;
                tds.Tables[0].Rows[rowIndex]["MinPrice"] = grid1.Rows[rowIndex].Cells["MinPrice"].Value;

                tds.AcceptChanges();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid1.Rows.Count > 0)
                {
                    if (grid1.Rows[rowIndex].Cells["ID"].Value != null && Convert.ToInt16(grid1.Rows[rowIndex].Cells["ID"].Value.ToString()) > 0)
                    {
                        DeleteDataGrid(0);
                    }
                        
                }
                grid1.Rows.RemoveAt(rowIndex);
                tds.Tables[0].Rows[rowIndex].Delete();
                tds.AcceptChanges();

                
            }
            catch(Exception ex)
            {

            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            grid2.Rows.Add();
            tds2.Tables[0].Rows.Add();

            tds2.AcceptChanges();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid2.Rows.Count > 0)
                {
                    if (grid2.Rows[rowIndex1].Cells["ID1"].Value != null && Convert.ToInt16(grid2.Rows[rowIndex1].Cells["ID1"].Value.ToString()) > 0)
                    {
                        DeleteDataGrid(1);
                    }

                }

                grid2.Rows.RemoveAt(rowIndex1);
                tds2.Tables[0].Rows[rowIndex1].Delete();
                tds2.AcceptChanges();
            }
            catch (Exception ex)
            {

            }
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
                    grid2.Rows[i].Cells["Shape"].Value = row["Shape"].ToString();
                    grid2.Rows[i].Cells["WeightPerStone"].Value = row["WeightPerStone"].ToString();
                    grid2.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["Color"].Value = row["Color"].ToString();
                    grid2.Rows[i].Cells["Clearity1"].Value = row["Clearity"].ToString();
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

                    if (row.Cells["RefID"].Value != null)
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

                    if(row.Cells["ID1"].Value != null)
                    { tds2.Tables[0].Rows[i]["ID"] = row.Cells["ID1"].Value; }

                    if(row.Cells["RowNum1"].Value != null)
                    { tds2.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum1"].Value; }
                    
                    if(row.Cells["WeightPerStone"].Value != null)
                    { tds2.Tables[0].Rows[i]["WeightPerStone"] = row.Cells["WeightPerStone"].Value; }
                    
                    if(row.Cells["Amount"].Value != null)
                    { tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount"].Value; }
                    
                    if(row.Cells["Weight1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value; }
                    
                    if(row.Cells["Shape"].Value != null)
                    { tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value; }

                    if (row.Cells["Color"].Value != null)
                    { tds2.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value; }

                    if (row.Cells["Clearity1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Clearity"] = row.Cells["Clearity1"].Value; }

                    if (row.Cells["CostPerCarat"].Value != null)
                    { tds2.Tables[0].Rows[i]["CostPerCarat"] = row.Cells["CostPerCarat"].Value; }

                    if (row.Cells["Cost1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Cost"] = row.Cells["Cost1"].Value; }
                        
                    if(row.Cells["MinPricePerCarat"].Value != null)
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
        #endregion

        private void grid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (grid1.Rows[e.RowIndex].Cells[10].Value.ToString().Trim() == "")
                {
                    grid1.Rows[e.RowIndex].Cells[10].Value = 0;
                }

                grid1.RefreshEdit();
                BindingDSDiamondDetail(0);          
            }
                   
            CalSum(0);
        }

        private void grid2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 8 || e.ColumnIndex == 10)
            {              
                if(grid2.Rows[e.RowIndex].Cells[3].Value ==null || grid2.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[3].Value = 0;
                }
                if (grid2.Rows[e.RowIndex].Cells[4].Value == null || grid2.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[4].Value = 0;
                }

                if (grid2.Rows[e.RowIndex].Cells[8].Value == null || grid2.Rows[e.RowIndex].Cells[8].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[8].Value = 0;
                }

               

                if (grid2.Rows[e.RowIndex].Cells[10].Value == null || grid2.Rows[e.RowIndex].Cells[10].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[10].Value = 0;
                }              

                grid2.Rows[e.RowIndex].Cells[5].Value = Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt16(grid2.Rows[e.RowIndex].Cells[4].Value);
                grid2.Rows[e.RowIndex].Cells[9].Value = Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[5].Value) * Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[8].Value);
                grid2.Rows[e.RowIndex].Cells[11].Value = Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[5].Value) * Convert.ToDecimal(grid2.Rows[e.RowIndex].Cells[10].Value);
            }

            grid2.RefreshEdit();
            BindingDSDiamondDetail(1);

            CalSum(1);
        }

        private void grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
        }

        private void grid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex != this.grid2.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
        }

        private void CalSum(int type)
        {
            if(type == 0)
            {
                txtSumWeight.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight"].Value))).ToString();

                txtSumCost.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["TotalBaht"].Value))).ToString();

                txtSumMinPrice.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["MinPrice"].Value))).ToString();

                txtSumWeight.Text = GM.ConvertDoubleToString(txtSumWeight);
                txtSumCost.Text = GM.ConvertDoubleToString(txtSumCost,0);
                txtSumMinPrice.Text = GM.ConvertDoubleToString(txtSumMinPrice,0);
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
                txtSumCost1.Text = GM.ConvertDoubleToString(txtSumCost1,0);
                txtSumMinPrice1.Text = GM.ConvertDoubleToString(txtSumMinPrice1,0);
            }

        }

        private void grid2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grid2.CurrentCell.ColumnIndex != 0 || grid2.CurrentCell.ColumnIndex != 1 || grid2.CurrentCell.ColumnIndex != 5 ||
                 grid2.CurrentCell.ColumnIndex != 6) 
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
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

        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (grid.Name == "grid1")
                {
                    rowIndex = e.RowIndex;
                    if (grid1.Rows[e.RowIndex].Cells["ID"].Value != null)
                    { DelID = Convert.ToInt16(grid1.Rows[e.RowIndex].Cells["ID"].Value.ToString()); }              
                }
                else
                {
                    rowIndex1 = e.RowIndex;
                    
                    if(grid2.Rows[e.RowIndex].Cells["ID1"].Value != null)
                    { DelID = Convert.ToInt16(grid2.Rows[e.RowIndex].Cells["ID1"].Value.ToString()); }
                    
                }

            }
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

        private bool CheckDataExist(int tmp)
        {
            if(grid1.Rows.Count > 0)
            {
                for(int i = 0; i < grid1.Rows.Count; i++)
                {
                    if(tmp == Convert.ToInt32(grid1.Rows[i].Cells["RefID1"].Value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
