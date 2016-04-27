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
using DiamondShop.DiamondService;
using DiamondDS.DS;

namespace DiamondShop
{
    public partial class PriceCode : FormInfo
    {
        Service1 ser = GM.GetService();
        dsPriceCode tds = new dsPriceCode();

        public PriceCode()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtValue, "Value");
        }

        protected override void Initial()
        {
            txtCode.Select();

            SetFieldService.SetRequireField(txtCode, txtValue);
        }

        public PriceCode(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtValue, "Value");

            this.id = id;
            LoadData();
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("PriceCode", id);
            tds.Clear();         
            tds.Merge(ds);

            if (tds.PriceCode.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.PriceCode[0]);
                EnableDelete = true;
            }
        }

        protected override bool SaveData()
        {
            dsPriceCode.PriceCodeRow row = null;

            if (tds.PriceCode.Rows.Count > 0)
            {
                row = tds.PriceCode[0];
            }
            else
            {
                row = tds.PriceCode.NewPriceCodeRow();
                tds.PriceCode.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("PriceCode", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("PriceCode", tds);
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
                chkFlag = ser.DoDeleteData("PriceCode", id);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            if(txtCode.Text == "")
            {
                message = "Please input Code.\n";
            }
            if(txtValue.Text =="")
            {
                message += "Please input Value.\n";
            }

            if(message == "") { return true; }
            else { return false; }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            chkFlag = GM.CheckLetter(txtCode.Text);
            if (chkFlag)
            {
                txtCode.Text = txtCode.Text.Substring(0, 1);
            }
            else { txtCode.Text = ""; }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            chkFlag = GM.CheckNumber(txtValue.Text);
            if (chkFlag)
            {
                txtValue.Text = txtValue.Text.Substring(0, 1);
            }
            else { txtValue.Text = ""; }
        }
    }
}
