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
    public partial class ExchangeRate : FormInfo
    {
        dsExchangeRate tds = new dsExchangeRate();
        bool isAuthorize = false;

        public ExchangeRate()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtRate, "USDRate");
            LoadData();
            
            
        }
        public ExchangeRate(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtRate, "USDRate");

            this.id = id;
            LoadData();
            SetControlEnable(false);
        }

        protected override void Initial()
        {

            txtRate.Select();

            //SetFieldService.SetRequireField(txtSeller, txtPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("ExchangeRate", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.ExchangeRate.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.ExchangeRate[0]);

                //EnableSave = false;
                //EnableEdit = true;
                //EnableDelete = false;
            }
            //SetFormatNumber();
            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsExchangeRate.ExchangeRateRow row = null;

            if (tds.ExchangeRate.Rows.Count > 0)
            {
                row = tds.ExchangeRate[0];
            }
            else
            {
                row = tds.ExchangeRate.NewExchangeRateRow();
                tds.ExchangeRate.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("ExchangeRate", tds);

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
            }
            else
            {
                //RequirePassword frm = new RequirePassword("2");
                //frm.ShowDialog();
                //isAuthorize = frm.isAuthorize;
                //frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    SetControlEnable(true);
                    base.EditData();
                }
            }
        }

        protected override bool ValidateData()
        {
            message = "";

            
            if (txtRate.Text == "" || GM.ConvertStringToDouble(txtRate) == 0)
            {
                message += "Please input USDRate > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            txtRate.Text = GM.ConvertDoubleToString(txtRate,0);
        }
        private void SetFormatNumber()
        {
            txtRate.Text = GM.ConvertDoubleToString(txtRate,0);
        }

        private void SetControlEnable(bool status)
        {
            txtRate.Enabled = status;
        }
    }
}
