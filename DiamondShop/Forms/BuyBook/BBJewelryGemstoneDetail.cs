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
    public partial class BBJewelryGemstoneDetail : FormInfo
    {
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        int rowIndex, rowIndex1;
        int chkGrid, DelID;
        dsBBJewelryGemstoneCerDetail tds = new dsBBJewelryGemstoneCerDetail();
        //dsDiamondCer tdsBBjewelryDC = new dsDiamondCer();
        dsBBJewelryGemstoneDetail tds2 = new dsBBJewelryGemstoneDetail();

        public BBJewelryGemstoneDetail()
        {
            InitializeComponent();
            Initial();
        }

        public BBJewelryGemstoneDetail(int id)
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

            GemstoneType = (DataGridViewComboBoxColumn)grid1.Columns["GemstoneType"];
            GemstoneType.DataSource = (GM.GetMasterTableDetail("C016")).Tables[0];
            GemstoneType.ValueMember = "ID";
            GemstoneType.DisplayMember = "Detail";
            GemstoneType.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C016")).Tables[0].Rows[0][1];

            Company = (DataGridViewComboBoxColumn)grid1.Columns["Company"];
            Company.DataSource = (GM.GetMasterTableDetail("C026")).Tables[0];
            Company.ValueMember = "ID";
            Company.DisplayMember = "Detail";
            Company.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C026")).Tables[0].Rows[0][1];

            Shape = (DataGridViewComboBoxColumn)grid1.Columns["Shape"];
            Shape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape.ValueMember = "ID";
            Shape.DisplayMember = "Detail";
            Shape.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0][1];

            Color = (DataGridViewComboBoxColumn)grid1.Columns["Color"];
            Color.DataSource = (GM.GetMasterTableDetail("C009")).Tables[0];
            Color.ValueMember = "ID";
            Color.DisplayMember = "Detail";
            Color.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C009")).Tables[0].Rows[0][1];

            Origin = (DataGridViewComboBoxColumn)grid1.Columns["Origin"];
            Origin.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            Origin.ValueMember = "ID";
            Origin.DisplayMember = "Detail";
            Origin.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C024")).Tables[0].Rows[0][1];


            GemstoneType1 = (DataGridViewComboBoxColumn)grid2.Columns["GemstoneType1"];
            GemstoneType1.DataSource = (GM.GetMasterTableDetail("C016")).Tables[0];
            GemstoneType1.ValueMember = "ID";
            GemstoneType1.DisplayMember = "Detail";
            GemstoneType1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C016")).Tables[0].Rows[0][1];

            Shape1 = (DataGridViewComboBoxColumn)grid2.Columns["Shape1"];
            Shape1.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape1.ValueMember = "ID";
            Shape1.DisplayMember = "Detail";
            Shape1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0][1];

            Origin1 = (DataGridViewComboBoxColumn)grid2.Columns["Origin1"];
            Origin1.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            Origin1.ValueMember = "ID";
            Origin1.DisplayMember = "Detail";
            Origin1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C024")).Tables[0].Rows[0][1];

            grid1.Refresh();
            grid2.Refresh();
        }
        protected override void LoadData()
        {

            ds = ser.DoSelectData("BBJewelryGemstoneCerDetail", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BBJewelryGemstoneDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BBJewelryGemstoneCerDetail.Rows.Count > 0)
            {
                grid1.Rows.Clear();
                BindingGridDiamondDetail(grid1);
                BindingDSDiamondDetail(0);
            }

            if (tds2.BBJewelryGemstoneDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail(grid2);
                BindingDSDiamondDetail(1);
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
                    grid1.Rows[i].Cells["GemstoneType"].Value = row["GemstoneType"].ToString();
                    grid1.Rows[i].Cells["Company"].Value = row["Company"].ToString();
                    grid1.Rows[i].Cells["Shape"].Value = row["Shape"].ToString();
                    grid1.Rows[i].Cells["Weight"].Value = row["Weight"].ToString();
                    grid1.Rows[i].Cells["Color"].Value = row["Color"].ToString();
                    grid1.Rows[i].Cells["Origin"].Value = row["Origin"].ToString();
                    grid1.Rows[i].Cells["RefID"].Value = row["RefID"].ToString();


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
                    grid2.Rows[i].Cells["GemstoneType1"].Value = row["GemstoneType"].ToString();
                    grid2.Rows[i].Cells["Shape1"].Value = row["Shape"].ToString();
                    grid2.Rows[i].Cells["Amount1"].Value = row["Amount"].ToString();
                    grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["Origin1"].Value = row["Origin"].ToString();
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
                .Sum(t => Convert.ToDecimal(t.Cells["Amount1"].Value))).ToString();

                txtSumWeight1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight1"].Value))).ToString();

                txtSumAmount1.Text = GM.ConvertDoubleToString(txtSumAmount1,0);
                txtSumWeight1.Text = GM.ConvertDoubleToString(txtSumWeight1);
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

                    if (row.Cells["Code"].Value != null)
                    { tds.Tables[0].Rows[i]["Code"] = row.Cells["Code"].Value; }

                    if (row.Cells["RefID"].Value != null)
                    { tds.Tables[0].Rows[i]["refID"] = row.Cells["refID"].Value; }

                    if (row.Cells["ReportNumber"].Value != null)
                    { tds.Tables[0].Rows[i]["ReportNumber"] = row.Cells["ReportNumber"].Value; }

                    if (row.Cells["GemstoneType"].Value != null)
                    { tds.Tables[0].Rows[i]["GemstoneType"] = row.Cells["GemstoneType"].Value; }

                    if (row.Cells["Company"].Value != null)
                    { tds.Tables[0].Rows[i]["Company"] = row.Cells["Company"].Value; }

                    if (row.Cells["Shape"].Value != null)
                    { tds.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value; }

                    if (row.Cells["Weight"].Value != null)
                    { tds.Tables[0].Rows[i]["Weight"] = row.Cells["Weight"].Value; }

                    if (row.Cells["Color"].Value != null)
                    { tds.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value; }

                    if (row.Cells["Origin"].Value != null)
                    { tds.Tables[0].Rows[i]["Origin"] = row.Cells["Origin"].Value; }

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

                    if (row.Cells["GemstoneType1"].Value != null)
                    { tds2.Tables[0].Rows[i]["GemstoneType"] = row.Cells["GemstoneType1"].Value; }

                    if (row.Cells["Shape1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape1"].Value; }

                    if (row.Cells["Amount1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount1"].Value; }

                    if (row.Cells["Weight1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value; }

                    if (row.Cells["Origin1"].Value != null)
                    { tds2.Tables[0].Rows[i]["Origin"] = row.Cells["Origin1"].Value; }

                    if (row.Cells["refID2"].Value != null)
                    { tds2.Tables[0].Rows[i]["refID"] = row.Cells["refID2"].Value; }

                    i++;
                }

                tds2.AcceptChanges();
            }
        }
        #endregion
        protected override bool SaveData()
        {
            try
            {
                //Cer Diamond
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        row["Code"] = GM.GetRunningNumber("JGC");
                        row["RefID"] = id;
                        if (row["GemstoneType"].ToString() == "") { row["GemstoneType"] = 94; }
                        if (row["Company"].ToString() == "") { row["Company"] = 156; }
                        if (row["Shape"].ToString() == "") { row["Shape"] = 133; }
                        if (row["Color"].ToString() == "") { row["Color"] = 162; }
                        if (row["Origin"].ToString() == "") { row["Origin"] = 111; }
                        SetCreateBy(row);
                    }
                    else
                    {
                        SetEditBy(row);
                    }
                }
                tds.AcceptChanges();
                chkFlag = ser.DoInsertData("BBJewelryGemstoneCerDetail", tds,0);


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
                chkFlag = ser.DoInsertData("BBJewelryGemstoneDetail", tds2,0);

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
                    chkFlag = ser.DoDeleteData("BBJewelryGemstoneCerDetail", DelID);
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
                    chkFlag = ser.DoDeleteData("BBJewelryGemstoneDetail", DelID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            isEdit = true;
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

        //private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void grid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (grid1.Rows[e.RowIndex].Cells[8].Value == null || grid1.Rows[e.RowIndex].Cells[8].Value.ToString().Trim() == "")
                {
                    grid1.Rows[e.RowIndex].Cells[8].Value = 0;
                }
            }
            grid1.RefreshEdit();
            BindingDSDiamondDetail(0);

            CalSum(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grid1.Rows.Add();
            tds.Tables[0].Rows.Add();

            tds.AcceptChanges();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid1.Rows.Count > 0)
                {
                    if (Convert.ToInt16(grid1.Rows[rowIndex1].Cells["ID"].Value.ToString()) > 0)
                    {
                        DeleteDataGrid(0);
                    }

                }
                grid1.Rows.RemoveAt(rowIndex);
                tds.Tables[0].Rows[rowIndex].Delete();
                tds.AcceptChanges();


            }
            catch (Exception ex)
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
                    if (Convert.ToInt16(grid2.Rows[rowIndex1].Cells["ID1"].Value.ToString()) > 0)
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

                    if (grid2.Rows[e.RowIndex].Cells["ID1"].Value != null)
                    { DelID = Convert.ToInt16(grid2.Rows[e.RowIndex].Cells["ID1"].Value.ToString()); }

                }

            }
        }

        private void grid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 4) && e.RowIndex != this.grid2.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
            if ((e.ColumnIndex == 5) && e.RowIndex != this.grid2.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void grid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grid1.CurrentCell.ColumnIndex == 8)
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
            if (grid2.CurrentCell.ColumnIndex == 4 || grid2.CurrentCell.ColumnIndex == 5)
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

        private void grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 8) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void grid2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (grid2.Rows[e.RowIndex].Cells[4].Value == null || grid2.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[4].Value = 0;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (grid2.Rows[e.RowIndex].Cells[5].Value == null || grid2.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == "")
                {
                    grid2.Rows[e.RowIndex].Cells[5].Value = 0;
                }
            }
            grid2.RefreshEdit();
            BindingDSDiamondDetail(1);

            CalSum(1);
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
    }
}
