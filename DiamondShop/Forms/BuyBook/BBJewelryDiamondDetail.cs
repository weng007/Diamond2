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
        //Service1 ser = GM.GetService();
        dsBBJewelryDiamondCerDetail tds = new dsBBJewelryDiamondCerDetail();
        dsBBJewelryDiamondDetail tds2 = new dsBBJewelryDiamondDetail();
        DataSet ds2 = new DataSet();
        //public int productID = 0;

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

            ds = ser.DoSelectData("BBJewelryDiamondCerDetail", id);
            ds2 = ser.DoSelectData("BBJewelryDiamondDetail", id);
            tds.Clear();
            tds.Merge(ds);
            tds2.Clear();
            tds2.Merge(ds2);

            ds = ser.DoSelectData("BBJewelryDiamondCerDetail", id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid1.DataSource = ds.Tables[0];
                grid1.Refresh();
            }
            else
            {
                grid1.DataSource = null;
                grid1.Refresh();
            }

            ds2 = ser.DoSelectData("BBJewelryDiamondDetail", id);

            if (ds2.Tables[0].Rows.Count > 0)
            {
                grid2.DataSource = ds2.Tables[0];
                grid2.Refresh();
            }
            else
            {
                grid2.DataSource = null;
                grid2.Refresh();
            }

            //if (tds.BBJewelryDiamondCerDetail.Rows.Count > 0)
            //{
            //    binder.BindValueToControl(tds.BBJewelryDiamondCerDetail[0]);
            //}

            //if (tds2.BBJewelryDiamondDetail.Rows.Count > 0)
            //{
            //    binder.BindValueToControl(tds2.BBJewelryDiamondDetail[0]);
            //}

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBBJewelryDiamondCerDetail.BBJewelryDiamondCerDetailRow row = null;
            dsBBJewelryDiamondDetail.BBJewelryDiamondDetailRow row2 = null;

            if (tds.BBJewelryDiamondCerDetail.Rows.Count > 0)
            {
                row = tds.BBJewelryDiamondCerDetail[0];
            }
            else
            {
                row = tds.BBJewelryDiamondCerDetail.NewBBJewelryDiamondCerDetailRow();
                tds.BBJewelryDiamondCerDetail.Rows.Add(row);
            }
            //binder.BindValueToDataRow(row);
            //row.ProductID = productID;

            if (tds2.BBJewelryDiamondDetail.Rows.Count > 0)
            {
                row2 = tds2.BBJewelryDiamondDetail[0];
            }
            else
            {
                row2 = tds2.BBJewelryDiamondDetail.NewBBJewelryDiamondDetailRow();
                tds2.BBJewelryDiamondDetail.Rows.Add(row);
            }


            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BBJewelryDiamondCerDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BBJewelryDiamondCerDetail", tds);
                }

                tds.AcceptChanges();

                if (id == 0)
                {
                    SetCreateBy(row2);
                    chkFlag = ser.DoInsertData("BBJewelryDiamondDetail", tds2);
                }
                else
                {
                    SetEditBy(row2);
                    chkFlag = ser.DoUpdateData("BBJewelryDiamondDetail", tds2);
                }

                tds2.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        //protected override bool DeleteData()
        //{
        //    try
        //    {
        //        //chkFlag = ser.DoDeleteData("GemstoneDetail", id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return chkFlag;
        //}

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

        private void grid1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                chkFlag = ser.DoDeleteData("BBJewelryDiamondCerDetail", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grid2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                chkFlag = ser.DoDeleteData("BBJewelryDiamondDetail", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
