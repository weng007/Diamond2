using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class Warning : FormInfo
    {
        Service2 ser1;
        dsWarning tds = new dsWarning();
        MemoryStream ms1;
        byte[] image1;
        int custID = 0;
        int refID = 0;
        string isPrintPrice = "1";

        public Warning()
        {
            InitializeComponent();
            Initial();
            BinderControl();
        }
        public Warning(int id)
        {
            InitializeComponent();
            Initial();

            BinderControl();

            this.id = id;
            LoadData();
        }
        private void BinderControl()
        {
            binder.BindControl(txtSender, "Sender");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(txtMessageStatus, "MessageStatus");
            binder.BindControl(cmbFactoryStatus, "FactoryStatus");
            binder.BindControl(txtReadDate, "ReadDate");
            binder.BindControl(txtConfirmDate, "ConfirmDate");
            binder.BindControl(txtCancelDate, "CancelDate");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtNote, "Note");
        }
        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();


            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C034")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            //SetFieldService.SetRequireField(txtNetPrice,txtCode,txtCustomer);
        }

        protected override void LoadData()
        {
            

            ds = ser.DoSelectData("Warning", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Warning.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Warning[0]);

                EnableDelete = true;
            }
            SetFormatNumber();
            base.LoadData();


            cmbFactoryStatus.SelectedValueChanged += CmbFactoryStatus_SelectedValueChanged;

        }

        private void CmbFactoryStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        protected override bool SaveData()
        {
            dsWarning.WarningRow row = null;

            if (tds.Warning.Rows.Count > 0)
            {
                row = tds.Warning[0];
            }
            else
            {
                row = tds.Warning.NewWarningRow();
                tds.Warning.Rows.Add(row);
            }
            
            binder.BindValueToDataRow(row);
            row.ReadDate = DateTime.MinValue.AddYears(1900);
            row.ConfirmDate = DateTime.MinValue.AddYears(1900);
            row.CancelDate = DateTime.MinValue.AddYears(1900);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Warning", tds, 0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Warning", tds);
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
                    chkFlag = ser.DoDeleteData("Warning", id);

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

            //if (txtCode.Text == "")
            //{
            //    message = "Please Choose Product.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }
  
        private void SetFormatNumber()
        {
            //txtPriceTag.Text = GM.ConvertDoubleToString(txtPriceTag, 0);
            //txtNetPrice.Text = GM.ConvertDoubleToString(txtNetPrice, 0);
        }

        private void txtNetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
