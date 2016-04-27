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
        Service1 ser = GM.GetService();
        dsGemstoneDetail tds = new dsGemstoneDetail();
        public int productID = 0;

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
            //cmbOrigin.DataSource = (GM.GetMasterTableDetail("C024")).Tables[0];
            //cmbOrigin.ValueMember = "ID";
            //cmbOrigin.DisplayMember = "Detail";
            //cmbOrigin.Refresh();

            //cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            //cmbShape.ValueMember = "ID";
            //cmbShape.DisplayMember = "Detail";
            //cmbShape.Refresh();

            //cmbGemstoneType.DataSource = (GM.GetMasterTableDetail("C006")).Tables[0];
            //cmbGemstoneType.ValueMember = "ID";
            //cmbGemstoneType.DisplayMember = "Detail";
            //cmbGemstoneType.Refresh();

            //cmbShape.Select();

            //SetFieldService.SetRequireField(txtAmount, txtWeight);
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("GemstoneDetail", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.GemstoneDetail.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.GemstoneDetail[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsGemstoneDetail.GemstoneDetailRow row = null;

            if (tds.GemstoneDetail.Rows.Count > 0)
            {
                row = tds.GemstoneDetail[0];
            }
            else
            {
                row = tds.GemstoneDetail.NewGemstoneDetailRow();
                tds.GemstoneDetail.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.ProductID = productID;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("GemstoneDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("GemstoneDetail", tds);
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
                chkFlag = ser.DoDeleteData("GemstoneDetail", id);
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
    }
}
