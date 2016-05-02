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
    public partial class BBJewelryDiamondDetail : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsDiamondDetail tds = new dsDiamondDetail();
        public int productID = 0;

        public BBJewelryDiamondDetail()
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(Shape, "Shape");
            //binder.BindControl(txtWeight, "Amount");
            //binder.BindControl(cmbColorGrade, "Weight");
            //binder.BindControl(cmbColor, "Color");
            //binder.BindControl(cmbClarity, "Clarity");
        }

        public BBJewelryDiamondDetail(int id)
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(Shape, "Shape");
            //binder.BindControl(txtWeight, "Amount");
            //binder.BindControl(cmbColorGrade, "Weight");
            //binder.BindControl(cmbColor, "Color");
            //binder.BindControl(cmbClarity, "Clarity");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            Company.DataSource= (GM.GetMasterTableDetail("C019")).Tables[0];
            Company.ValueMember = "ID";
            Company.DisplayMember = "Detail";

            Shape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape.ValueMember = "ID";
            Shape.DisplayMember = "Detail";

            Color.DataSource = (GM.GetMasterTableDetail("C001")).Tables[0];
            Color.ValueMember = "ID";
            Color.DisplayMember = "Detail";

            Clearity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            Clearity.ValueMember = "ID";
            Clearity.DisplayMember = "Detail";

            Shape1.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Shape1.ValueMember = "ID";
            Shape1.DisplayMember = "Detail";

            Color1.DataSource = (GM.GetMasterTableDetail("C001")).Tables[0];
            Color1.ValueMember = "ID";
            Color1.DisplayMember = "Detail";

            Clearity1.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            Clearity1.ValueMember = "ID";
            Clearity1.DisplayMember = "Detail";

            //cmbClarity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            //cmbClarity.ValueMember = "ID";
            //cmbClarity.DisplayMember = "Detail";
            //cmbClarity.Refresh();

            //cmbShape.Select();

            //SetFieldService.SetRequireField(txtWeight, txtGIANumber);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("DiamondDetail", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.DiamondDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.DiamondDetail[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsDiamondDetail.DiamondDetailRow row = null;

            if (tds.DiamondDetail.Rows.Count > 0)
            {
                row = tds.DiamondDetail[0];
            }
            else
            {
                row = tds.DiamondDetail.NewDiamondDetailRow();
                tds.DiamondDetail.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.ProductID = productID;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("DiamondDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("DiamondDetail", tds);
                }

                tds.AcceptChanges();
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
                chkFlag = ser.DoDeleteData("DiamondDetail", id);
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

            //if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight)==0)
            //{
            //    message = "Please input Weight > 0.\n";
            //}
            //if (txtGIANumber.Text == "")
            //{
            //    message += "Please input Certificate.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void cmbColorGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "C017";

            //if (cmbColorGrade.SelectedIndex == 0)
            //{
            //    color = "C001";
            //}

            //cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            //cmbColor.ValueMember = "ID";
            //cmbColor.DisplayMember = "Detail";
            //cmbColor.Refresh();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void grid1_CellEnter(object sender, DataGridViewCellEventArgs e)
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
