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
        //Service1 ser = GM.GetService();
        dsBBJewelryGemstoneCerDetail tds = new dsBBJewelryGemstoneCerDetail();
        dsBBJewelryGemstoneDetail tds2 = new dsBBJewelryGemstoneDetail();
        DataSet ds2 = new DataSet();
        //public int productID = 0;

        public BBJewelryGemstoneDetail()
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(cmbShape, "Shape");
            //binder.BindControl(cmbGemstoneType, "GemstoneType");
            //binder.BindControl(txtAmount, "Amount");
            //binder.BindControl(txtWeight, "Weight");
            //binder.BindControl(cmbOrigin, "Origin");
            //binder.BindControl(txtCertificateNo, "CertificateNo");
        }

        public BBJewelryGemstoneDetail(int id)
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(cmbShape, "Shape");
            //binder.BindControl(cmbGemstoneType, "GemstoneType");
            //binder.BindControl(txtAmount, "Amount");
            //binder.BindControl(txtWeight, "Weight");
            //binder.BindControl(cmbOrigin, "Origin");
            //binder.BindControl(txtCertificateNo, "CertificateNo");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            GemstoneType.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            GemstoneType.ValueMember = "ID";
            GemstoneType.DisplayMember = "Detail";

            Company.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Company.ValueMember = "ID";
            Company.DisplayMember = "Detail";

            Shape.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            Shape.ValueMember = "ID";
            Shape.DisplayMember = "Detail";

            Color.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            Color.ValueMember = "ID";
            Color.DisplayMember = "Detail";

            Origin.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Origin.ValueMember = "ID";
            Origin.DisplayMember = "Detail";

            GemstoneType1.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            GemstoneType1.ValueMember = "ID";
            GemstoneType1.DisplayMember = "Detail";

            Shape1.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            Shape1.ValueMember = "ID";
            Shape1.DisplayMember = "Detail";

            Origin1.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            Origin1.ValueMember = "ID";
            Origin1.DisplayMember = "Detail";


            //cmbShape.Select();

            //SetFieldService.SetRequireField(txtAmount, txtWeight);
        }
        protected override void LoadData()
        {
            
            ds = ser.DoSelectData("BBJewelryGemstoneCerDetail", id);
            ds2 = ser.DoSelectData("BBJewelryGemstoneDetail", id);
            tds.Clear();
            tds.Merge(ds);
            tds2.Clear();
            tds2.Merge(ds2);
            

            if (tds.BBJewelryGemstoneCerDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BBJewelryGemstoneCerDetail[0]);
            }

            if (tds2.BBJewelryGemstoneDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds2.BBJewelryGemstoneDetail[0]);
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBBJewelryGemstoneCerDetail.BBJewelryGemstoneCerDetailRow row = null;
            dsBBJewelryGemstoneDetail.BBJewelryGemstoneDetailRow row2 = null;

            if (tds.BBJewelryGemstoneCerDetail.Rows.Count > 0)
            {
                row = tds.BBJewelryGemstoneCerDetail[0];
            }
            else
            {
                row = tds.BBJewelryGemstoneCerDetail.NewBBJewelryGemstoneCerDetailRow();
                tds.BBJewelryGemstoneCerDetail.Rows.Add(row);
            }
            //binder.BindValueToDataRow(row);
            //row.ProductID = productID;

            if (tds2.BBJewelryGemstoneDetail.Rows.Count > 0)
            {
                row2 = tds2.BBJewelryGemstoneDetail[0];
            }
            else
            {
                row2 = tds2.BBJewelryGemstoneDetail.NewBBJewelryGemstoneDetailRow();
                tds2.BBJewelryGemstoneDetail.Rows.Add(row);
            }


            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BBJewelryGemstoneCerDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BBJewelryGemstoneCerDetail", tds);
                }

                tds.AcceptChanges();

                if (id == 0)
                {
                    SetCreateBy(row2);
                    chkFlag = ser.DoInsertData("BBJewelryGemstoneDetail", tds2);
                }
                else
                {
                    SetEditBy(row2);
                    chkFlag = ser.DoUpdateData("BBJewelryGemstoneDetail", tds2);
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
                //chkFlag = ser.DoDeleteData("GemstoneDetail", id);
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
    }
}
