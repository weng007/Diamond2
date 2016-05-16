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
        int chkGrid;
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

            Color = (DataGridViewComboBoxColumn)grid2.Columns["Color"];
            Color.DataSource = (GM.GetMasterTableDetail("C017")).Tables[0];
            Color.ValueMember = "ID";
            Color.DisplayMember = "Detail";

            Clearity1 = (DataGridViewComboBoxColumn)grid2.Columns["Clearity1"];
            Clearity1.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            Clearity1.ValueMember = "ID";
            Clearity1.DisplayMember = "Detail";

            grid2.Refresh();
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("InvDiamondCerDetail", -1);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("InvDiamondDetail", -1);          
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
                    if(row["RowNum"].ToString() == "")
                    {
                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }                 
                }

                chkFlag = ser.DoInsertData("InvDiamondCerDetail", tds);
                tds.AcceptChanges();

                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Unchanged)
                    {
                        SetCreateBy(row);
                        chkFlag = ser.DoInsertData("InvDiamondDetail", tds2);
                    }
                    else if (row.RowState == DataRowState.Modified)
                    {
                        SetEditBy(row);
                        chkFlag = ser.DoUpdateData("InvDiamondDetail", tds2);
                    }
                }
                tds2.AcceptChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            if(chkGrid == 0)
            {
                try
                {
                    chkFlag = ser.DoDeleteData("InvDiamondCerDetail", Convert.ToInt16(grid1.SelectedRows[0].Cells["ID"].Value.ToString()));
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
                    chkFlag = ser.DoDeleteData("InvDiamondDetail", Convert.ToInt16(grid2.SelectedRows[0].Cells["ID"].Value.ToString()));
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiamondCerList frm = new DiamondCerList(1);
            frm.ShowDialog();

            if (frm.refID != 0)
            { 
                tmp = ser.DoSelectData("DiamondCer", frm.refID);
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
                grid1.Rows[rowIndex].Cells["RefID"].Value = frm.refID;

                tds.Tables[0].Rows.Add();
                tds.Tables[0].Rows[rowIndex]["RefID"] = frm.refID;
                tds.Tables[0].Rows[rowIndex]["MinPrice"] = grid1.Rows[rowIndex].Cells["MinPrice"].Value;

                tds.AcceptChanges();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            grid1.Rows.RemoveAt(rowIndex);
            tds.Tables[0].Rows[rowIndex].Delete();

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
            tds2.AcceptChanges();
        }

        private void grid1_SelectionChanged(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count > 0)
            {
                rowIndex = grid1.SelectedRows[0].Index;
            }
        }

        private void grid2_SelectionChanged(object sender, EventArgs e)
        {
            if (grid2.SelectedRows.Count > 0)
            {
                rowIndex1 = grid2.SelectedRows[0].Index;
            }
        }

        #region Binding Grid, Dataset
        private void BindingGridDiamondDetail(DataGridView grid)
        {
            int i = 0;

            if(grid.Name == "grid1")
            {
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    grid1.Rows.Add();
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
                    grid1.Rows[i].Cells["RefID"].Value = row["RefID"].ToString();

                    i++;
                }   

                i = 0;
            }

            else if (grid.Name == "grid2")
            {
                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    grid2.Rows.Add();
                    grid2.Rows[i].Cells["RowNum1"].Value = row["RowNum"].ToString();
                    grid2.Rows[i].Cells["Shape"].Value = row["Shape"].ToString();
                    grid2.Rows[i].Cells["WeightPerStone"].Value = row["WeightPerStone"].ToString();
                    grid2.Rows[i].Cells["Amount"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weigh1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["Color"].Value = row["Color"].ToString();
                    grid2.Rows[i].Cells["Clearity1"].Value = row["Clearity"].ToString();
                    grid2.Rows[i].Cells["CostPerCarat"].Value = row["CostPerCarat"].ToString();
                    grid2.Rows[i].Cells["Cost1"].Value = row["Cost"].ToString();
                    grid2.Rows[i].Cells["MinPricePerCarat"].Value = row["MinPricePerCarat"].ToString();
                    grid2.Rows[i].Cells["MinPrice"].Value = row["MinPrice"].ToString();
                    grid2.Rows[i].Cells["RefID1"].Value = row["RefID"].ToString();

                    i++;
                }
            }
        }

        private void BindingDSDiamondDetail(int type)
        {
            int i = 0;
            tds.Clear();
            tds2.Clear();

            if (type == 0)
            {
                
                foreach (DataGridViewRow row in grid1.Rows)
                {
                    tds.Tables[0].Rows.Add();
                    tds.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum"].Value;
                    tds.Tables[0].Rows[i]["RefID"] = row.Cells["RefID"].Value;
                    tds.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice"].Value;

                    i++;
                }
            
                i = 0;
                tds.AcceptChanges();
            }
            else
            {
                foreach (DataGridViewRow row in grid2.Rows)
                {
                    tds2.Tables[0].Rows.Add();
                    tds2.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum1"].Value;
                    tds2.Tables[0].Rows[i]["WeightPerStone"] = row.Cells["WeightPerStone"].Value;
                    tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount"].Value;
                    tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value;
                    tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value;
                    tds2.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value;
                    tds2.Tables[0].Rows[i]["Clearity"] = row.Cells["Clearity1"].Value;
                    tds2.Tables[0].Rows[i]["CostPerCarat"] = row.Cells["CostPerCarat"].Value;
                    tds2.Tables[0].Rows[i]["Cost"] = row.Cells["Cost1"].Value;
                    tds2.Tables[0].Rows[i]["MinPricePerCarat"] = row.Cells["MinPricePerCarat"].Value;
                    tds2.Tables[0].Rows[i]["MinPrice"] = row.Cells["MinPrice1"].Value;
                    tds2.Tables[0].Rows[i]["RefID"] = row.Cells["RefID1"].Value;
                    i++;
                }

                tds2.AcceptChanges();
            }       
        }
        #endregion

        private void DeleteDataGrid(int type)
        {
            if(type == 0)
            {
                chkGrid = 0;
            }
            else
            {
                chkGrid = 1;
            }
        }
    }
}
