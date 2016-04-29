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
    public partial class DiamondDetailCatalog : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsDiamondDetail tds = new dsDiamondDetail();
        public int productID = 0;

        public DiamondDetailCatalog()
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(cmbShape, "Shape");
            //binder.BindControl(txtWeight, "Weight");
            //binder.BindControl(cmbColorGrade, "ColorGrade");
            //binder.BindControl(cmbColor, "Color");
            //binder.BindControl(cmbClarity, "Clarity");
            //binder.BindControl(txtGIANumber, "GIANumber");
        }

        public DiamondDetailCatalog(int id)
        {
            InitializeComponent();
            Initial();

            //binder.BindControl(cmbShape, "Shape");
            //binder.BindControl(txtWeight, "Weight");
            //binder.BindControl(cmbColorGrade, "ColorGrade");
            //binder.BindControl(cmbColor, "Color");
            //binder.BindControl(cmbClarity, "Clarity");
            //binder.BindControl(txtGIANumber, "GIANumber");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            //cmbColorGrade.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            //cmbColorGrade.ValueMember = "ID";
            //cmbColorGrade.DisplayMember = "Detail";
            //cmbColorGrade.Refresh();

            //cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //cmbShape.ValueMember = "ID";
            //cmbShape.DisplayMember = "Detail";
            //cmbShape.Refresh();

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
    }
}
