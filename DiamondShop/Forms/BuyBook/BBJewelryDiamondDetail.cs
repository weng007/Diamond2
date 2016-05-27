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
    public partial class BBJewelryDiamondDetail : FormInfo
    {
        DataSet ds2 = new DataSet();
        int rowIndex1;
        int chkGrid, DelID;
        bool isAuthorize = false;
        dsBBJewelryDiamondCerDetail tds = new dsBBJewelryDiamondCerDetail();
        dsBBJewelryDiamondDetail tds2 = new dsBBJewelryDiamondDetail();

        public BBJewelryDiamondDetail()
        {
            InitializeComponent();
            Initial();
        }

        public BBJewelryDiamondDetail(int id)
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

            //grid2
            Shape1.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape1.ValueMember = "ID";
            Shape1.DisplayMember = "Detail";
            Shape1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C019")).Tables[0].Rows[0][1];

            Color1.DataSource = (GM.GetMasterTableDetail("C017")).Tables[0];
            Color1.ValueMember = "ID";
            Color1.DisplayMember = "Detail";
            Color1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C017")).Tables[0].Rows[0][1];

            Clearity1.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            Clearity1.ValueMember = "ID";
            Clearity1.DisplayMember = "Detail";
            Clearity1.DefaultCellStyle.NullValue = (GM.GetMasterTableDetail("C002")).Tables[0].Rows[0][1];

            grid2.Refresh();
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("BBJewelryDiamondCerDetail", id);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("BBJewelryDiamondDetail", id);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.BBJewelryDiamondCerDetail.Rows.Count > 0)
            {
                grid1.DataSource = tds.Tables[0];
                CalSum(0);
            }

            if (tds2.BBJewelryDiamondDetail.Rows.Count > 0)
            {
                grid2.Rows.Clear();
                BindingGridDiamondDetail();
                BindingDSDiamondDetail();
            }

            EnableSave = false;
            EnableEdit = true;
            EnableDelete = false;

            base.LoadData();
        }

        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
            }
            else
            {
                RequirePassword frm = new RequirePassword("2");
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    base.EditData();
                }
            }
        }

        #region Binding Grid, Dataset
        private void BindingGridDiamondDetail()
        {
            int i = 0;

            foreach (DataRow row in tds2.Tables[0].Rows)
            {
                grid2.Rows.Add();
                grid2.Rows[i].Cells["ID1"].Value = row["ID"].ToString();
                grid2.Rows[i].Cells["RowNum1"].Value = row["RowNum"].ToString();
                grid2.Rows[i].Cells["Shape1"].Value = row["Shape"].ToString();
                grid2.Rows[i].Cells["Amount1"].Value = row["Amount"].ToString();
                grid2.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                grid2.Rows[i].Cells["Color1"].Value = row["Color"].ToString();
                grid2.Rows[i].Cells["Clearity1"].Value = row["Clearity"].ToString();
                grid2.Rows[i].Cells["RefID2"].Value = row["RefID"].ToString();

                i++;
                CalSum(1);
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

                txtSumAmount1.Text = GM.ConvertDoubleToString(txtSumAmount1);
                txtSumWeight1.Text = GM.ConvertDoubleToString(txtSumWeight1);
            }

        }
        private void BindingDSDiamondDetail()
        {
            int i = 0;

            tds2.Clear();
            foreach (DataGridViewRow row in grid2.Rows)
            {
                tds2.Tables[0].Rows.Add();

                if (row.Cells["ID1"].Value != null)
                { tds2.Tables[0].Rows[i]["ID"] = row.Cells["ID1"].Value; }

                if (row.Cells["RowNum1"].Value != null)
                { tds2.Tables[0].Rows[i]["RowNum"] = row.Cells["RowNum1"].Value; }

                if (row.Cells["Amount1"].Value != null)
                { tds2.Tables[0].Rows[i]["Amount"] = row.Cells["Amount1"].Value; }

                if (row.Cells["Weight1"].Value != null)
                { tds2.Tables[0].Rows[i]["Weight"] = row.Cells["Weight1"].Value; }

                if (row.Cells["Shape1"].Value != null)
                { tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape1"].Value; }

                if (row.Cells["Color1"].Value != null)
                { tds2.Tables[0].Rows[i]["Color"] = row.Cells["Color1"].Value; }

                if (row.Cells["Clearity1"].Value != null)
                { tds2.Tables[0].Rows[i]["Clearity"] = row.Cells["Clearity1"].Value; }

                if (row.Cells["RefID2"].Value != null)
                { tds2.Tables[0].Rows[i]["RefID"] = row.Cells["RefID2"].Value; }

                i++;
             }

                tds2.AcceptChanges();
            }
        #endregion

        protected override bool SaveData()
        {
            try
            {
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
                chkFlag = ser.DoInsertData("BBJewelryDiamondDetail", tds2);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("BBJewelryDiamondDetail", DelID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            if (message == "") { return true; }
            else { return false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BBJewelryDiamondDetailInfo frm = new BBJewelryDiamondDetailInfo(0,id);
            frm.ShowDialog();

            LoadData();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            grid2.Rows.Add();
            tds2.Tables[0].Rows.Add();

            grid2.RefreshEdit();
            tds2.AcceptChanges();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid1.Rows.Count > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }
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
                tds.Tables[0].Rows[rowIndex1].Delete();
                tds.AcceptChanges();
            }
            catch (Exception ex)
            {

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
            BindingDSDiamondDetail();

            CalSum(1);
        }

        private void grid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 4) && e.RowIndex != this.grid2.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N0");
            }
            if ((e.ColumnIndex == 5) && e.RowIndex != this.grid2.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
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
            if ((e.ColumnIndex == 7) && e.RowIndex != this.grid1.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }


        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                rowIndex1 = e.RowIndex;

                if (grid2.Rows[e.RowIndex].Cells["ID1"].Value != null)
                { DelID = Convert.ToInt16(grid2.Rows[e.RowIndex].Cells["ID1"].Value.ToString()); }
            }
        }

        private void grid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(grid1.SelectedRows.Count > 0)
            {
                BBJewelryDiamondDetailInfo frm = new BBJewelryDiamondDetailInfo(Convert.ToInt32(grid1.SelectedRows[0].Cells["ID"].Value), id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void DeleteDataGrid(int type)
        {
            chkGrid = 1;
            DeleteData();
        }
    }
}
