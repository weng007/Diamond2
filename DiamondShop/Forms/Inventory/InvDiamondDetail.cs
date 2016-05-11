﻿using System;
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
        int rowIndex, rowIndex1;

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
            grid2.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn dgvcShape;
            dgvcShape = (DataGridViewComboBoxColumn)grid2.Columns["Shape"];
            dgvcShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            dgvcShape.ValueMember = "ID";
            dgvcShape.DisplayMember = "Detail";

            DataGridViewComboBoxColumn dgvcColor;
            dgvcColor = (DataGridViewComboBoxColumn)grid2.Columns["Color"];
            dgvcColor.DataSource = (GM.GetMasterTableDetail("C001")).Tables[0];
            dgvcColor.ValueMember = "ID";
            dgvcColor.DisplayMember = "Detail";

            DataGridViewComboBoxColumn dgvcClearity1;
            dgvcClearity1 = (DataGridViewComboBoxColumn)grid2.Columns["Clearity1"];
            dgvcClearity1.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            dgvcClearity1.ValueMember = "ID";
            dgvcClearity1.DisplayMember = "Detail";

            grid2.Refresh();
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("InvDiamondCerDetail", -1);
            ds2 = ser.DoSelectData("InvDiamondDetail", -1);
            tds.Clear();
            tds.Merge(ds);
            tds2.Clear();
            tds2.Merge(ds2);


            if (tds.InvDiamondCerDetail.Rows.Count > 0)
            {
                grid1.DataSource = tds.Tables[0];
                grid1.Refresh();
            }

            if (tds2.InvDiamondDetail.Rows.Count > 0)
            {
                grid2.DataSource = tds2.Tables[0];
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
                    if(row.RowState == DataRowState.Added)
                    {
                        SetCreateBy(row);
                        chkFlag = ser.DoInsertData("InvDiamondCerDetail", tds);
                    }
                    else if(row.RowState == DataRowState.Modified)
                    {
                        SetEditBy(row);
                        chkFlag = ser.DoUpdateData("InvDiamondCerDetail", tds);
                    }
                }

                tds.AcceptChanges();


                BindingDataSet(tds2);

                //Non Cer Diamond
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
            //try
            //{
            //    chkFlag = ser.DoDeleteData("InvDiamondDetail", id);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

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
                DiamondCerList frm = new DiamondCerList();
                frm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grid1.Rows.Add();

            dsInvDiamondCerDetail.InvDiamondCerDetailRow row = null;
            row = tds.InvDiamondCerDetail.NewInvDiamondCerDetailRow();
            tds.InvDiamondCerDetail.Rows.Add(row);
            tds.AcceptChanges();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            grid1.Rows.RemoveAt(rowIndex);
            tds.AcceptChanges();
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
        
        private dsInvDiamondDetail BindingDataSet(dsInvDiamondDetail tds2)
        {
            int i = 0;

            foreach(DataGridViewRow row in grid2.Rows)
            {
                tds2.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value;
                tds2.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value;
                tds2.Tables[0].Rows[i]["Clearity"] = row.Cells["Clearity1"].Value;
            }

            return tds2;
        }
    }
}
