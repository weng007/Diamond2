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
    public partial class OrderDetail : FormInfo
    {
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        int rowIndex, rowIndex1;
        int chkGrid, DelID;
        dsOrderDetail tds = new dsOrderDetail();
        dsBuyBookDiamondCer tds1 = new dsBuyBookDiamondCer();
        dsBuyBookGemstoneCer tds2 = new dsBuyBookGemstoneCer();
        public string materail = "";

        public OrderDetail()
        {
            InitializeComponent();
            Initial();
        }

        public OrderDetail(int id)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("OrderDetail", id,0);

            if (ds.Tables[1].Rows.Count > 0)
            {
                grid1.DataSource = ds.Tables[1];
                grid1.Refresh();
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid2.DataSource = ds.Tables[0];
                grid2.Refresh();
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
                        row["RefID"] = id;//OrdID
                        row["Flag"] = 0;
                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }

                //tds
                chkFlag = ser.DoInsertData("OrderDetail", tds,0);

                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        row["RefID"] = id;//OrdID
                        row["Flag"] = 1;
                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }

                tds2.AcceptChanges();
                chkFlag = ser.DoInsertData("OrderDetail", tds,0);

                GetMaterial();       

                this.Close();

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
                    chkFlag = ser.DoDeleteData("OrderDiamondCerDetail", DelID);
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
                    chkFlag = ser.DoDeleteData("OrderGemstoneCerDetail", DelID);
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
            BuyBookDiamondCerList frm = new BuyBookDiamondCerList(1);
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser.DoSelectData("BuyBookDiamondCer", frm.refID1, 0);
                tds1.Clear();
                tds1.Merge(tmp);

                DataRow dr = ds.Tables[1].NewRow();
                dr["Code2"] = tds1.Tables[0].Rows[0]["Code2"];

                ds.Tables[1].Rows.Add(dr);
                grid1.RefreshEdit();
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
            BuyBookGemstoneCerList frm = new BuyBookGemstoneCerList(1);
            frm.ShowDialog();

            if (frm.refID2 != 0 && CheckDataExist(frm.refID2))
            {
                tmp = ser.DoSelectData("BuyBookGemstoneCer", frm.refID2, 0);
                tds2.Clear();
                tds2.Merge(tmp);

                grid2.Rows.Add();
                rowIndex = grid2.Rows.GetLastRow(DataGridViewElementStates.Displayed);

                grid2.Rows[rowIndex].Cells["Code11"].Value = tds2.Tables[0].Rows[0]["Code"].ToString();
                grid2.Rows[rowIndex].Cells["Code22"].Value = tds2.Tables[0].Rows[0]["Code2"].ToString();
                grid2.Rows[rowIndex].Cells["ReportNumber2"].Value = tds2.Tables[0].Rows[0]["ReportNumber"].ToString();
                grid2.Rows[rowIndex].Cells["IdentificationName"].Value = tds2.Tables[0].Rows[0]["IdentificationName"].ToString();
                grid2.Rows[rowIndex].Cells["LabName2"].Value = tds2.Tables[0].Rows[0]["LabName"].ToString();
                grid2.Rows[rowIndex].Cells["ShapeName2"].Value = tds2.Tables[0].Rows[0]["ShapeName"].ToString();
                grid2.Rows[rowIndex].Cells["Weight2"].Value = tds2.Tables[0].Rows[0]["Weight"].ToString();
                grid2.Rows[rowIndex].Cells["ColorName2"].Value = tds2.Tables[0].Rows[0]["ColorName"].ToString();
                grid2.Rows[rowIndex].Cells["OriginName"].Value = tds2.Tables[0].Rows[0]["OriginName"].ToString();
                grid2.Rows[rowIndex].Cells["TotalBaht2"].Value = tds2.Tables[0].Rows[0]["TotalBaht"].ToString();
                grid2.Rows[rowIndex].Cells["ShopName2"].Value = tds2.Tables[0].Rows[0]["ShopName"].ToString();
                grid2.Rows[rowIndex].Cells["RefID2"].Value = frm.refID2;

                tds.Tables[0].Rows.Add();
                tds.Tables[0].Rows[rowIndex]["RefID1"] = frm.refID2; //ID ของ BuyBookGemstoneCer

                tds.AcceptChanges();
            }
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
                    grid1.Rows[i].Cells["Code1"].Value = row["Code"].ToString();
                    grid1.Rows[i].Cells["Code2"].Value = row["Code2"].ToString();
                    grid1.Rows[i].Cells["ReportNumber"].Value = row["ReportNumber"].ToString();
                    grid1.Rows[i].Cells["LabName"].Value = row["LabName"].ToString();
                    grid1.Rows[i].Cells["ShapeName"].Value = row["ShapeName"].ToString();
                    grid1.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid1.Rows[i].Cells["ColorName"].Value = row["ColorName"].ToString();
                    grid1.Rows[i].Cells["ClearityName"].Value = row["ClearityName"].ToString();
                    grid1.Rows[i].Cells["TotalBaht"].Value = row["TotalBaht"].ToString();
                    grid1.Rows[i].Cells["ShopName"].Value = row["ShopName"].ToString();
                    grid1.Rows[i].Cells["refID"].Value = row["refID"].ToString();

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
                    grid2.Rows[i].Cells["ID2"].Value = row["ID"].ToString();
                    grid2.Rows[i].Cells["RowNum2"].Value = row["RowNum"].ToString();
                    grid2.Rows[i].Cells["Code11"].Value = row["Code"].ToString();
                    grid2.Rows[i].Cells["Code22"].Value = row["Code2"].ToString();
                    grid2.Rows[i].Cells["ReportNumber2"].Value = row["ReportNumber"].ToString();
                    grid2.Rows[i].Cells["IdentificationName"].Value = row["IdentificationName"].ToString();
                    grid2.Rows[i].Cells["LabName2"].Value = row["LabName"].ToString();
                    grid2.Rows[i].Cells["ShapeName2"].Value = row["ShapeName"].ToString();
                    grid2.Rows[i].Cells["Weight2"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["ColorName2"].Value = row["ColorName"].ToString();
                    grid2.Rows[i].Cells["OriginName"].Value = row["OriginName"].ToString();
                    grid2.Rows[i].Cells["TotalBaht2"].Value = row["TotalBaht"].ToString();
                    grid2.Rows[i].Cells["ShopName2"].Value = row["ShopName"].ToString();
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
            //if ((e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            //{
            //    double d = double.Parse(e.Value.ToString());
            //    e.Value = d.ToString("N0");
            //}
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
                //txtSumWeight.Text = (grid1.Rows.Cast<DataGridViewRow>()
                //.Sum(t => Convert.ToDecimal(t.Cells["Weight"].Value))).ToString();

                //txtSumCost.Text = (grid1.Rows.Cast<DataGridViewRow>()
                //.Sum(t => Convert.ToDecimal(t.Cells["TotalBaht"].Value))).ToString();

                //txtSumMinPrice.Text = (grid1.Rows.Cast<DataGridViewRow>()
                //.Sum(t => Convert.ToDecimal(t.Cells["MinPrice"].Value))).ToString();

                txtSumWeight.Text = GM.ConvertDoubleToString(txtSumWeight);
                txtSumCost.Text = GM.ConvertDoubleToString(txtSumCost,0);
                //txtSumMinPrice.Text = GM.ConvertDoubleToString(txtSumMinPrice,0);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid2.Rows.Count > 0)
                {
                    if (grid2.Rows[rowIndex].Cells["ID"].Value != null && Convert.ToInt16(grid2.Rows[rowIndex].Cells["ID"].Value.ToString()) > 0)
                    {
                        DeleteDataGrid(0);
                    }

                }
                grid2.Rows.RemoveAt(rowIndex);
                tds.Tables[0].Rows[rowIndex].Delete();
                tds.AcceptChanges();


            }
            catch (Exception ex)
            {

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

        private void GetMaterial()
        {
            int i = 1;
            foreach (DataRow row in tds.Tables[0].Rows)
            {
                materail += i.ToString()+"."+ row["Code"].ToString()+" "+row["Weight"].ToString()+"\n";
            }
          
            foreach (DataRow row in tds2.Tables[0].Rows)
            {
                materail += i.ToString() + "." + row["Code"].ToString() + row["Type"].ToString() + " " + row["Weight"].ToString() + "\n";
            }
        }
    }
}
