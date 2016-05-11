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
    public partial class BuyBookSetting : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsBuyBookSetting tds = new dsBuyBookSetting();

        public BuyBookSetting()
        {
            InitializeComponent();
            Initial();
            BinderData();


        }
        public BuyBookSetting(int id)
        {
            InitializeComponent();
            Initial();

            BinderData();

            this.id = id;
            LoadData();
        }
        private void BinderData()
        {
            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtBuyPrice, "BuyPrice");
            binder.BindControl(txtSalePrice, "SalePrice");
        }
        protected override void LoadData()
        {
              ds = ser.DoSelectData("BuyBookSetting", id);
              tds.Clear();
              tds.Merge(ds);

              if (tds.BBSetting.Rows.Count > 0)
              {
                binder.BindValueToControl(tds.BBSetting[0]);
                //if(tds.DiamondCer[0]["Inscription"].ToString() == "0")
                //{
                //    //chkNo.Checked = true;
                //    //chkYes.Checked = false;
                //}
                //else
                //{
                //    //chkYes.Checked = true;
                //    //chkNo.Checked = false;
                //}
                  EnableDelete = true;
              }

              base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookSetting.BBSettingRow row = null;

            if (tds.BBSetting.Rows.Count > 0)
            {
                row = tds.BBSetting[0];
            }
            else
            {
                row = tds.BBSetting.NewBBSettingRow();
                tds.BBSetting.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookSetting", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookSetting", tds);
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
                chkFlag = ser.DoDeleteData("BuyBookSetting", id);
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

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        protected override void Initial()
        {
            dtBuyDate.Select();

            SetFieldService.SetRequireField(txtSeller);
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

        private void txtCarat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbShapeAndCut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbShapeAndCut.SelectedIndex == 0)
            //{
            //    lbl1.Text = "-";
            //}
            //else
            //{
            //    lbl1.Text = "x";
            //}
        }
    }
}
