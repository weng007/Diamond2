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
    public partial class BuyBookJewelry : FormInfo
    {
        Service1 ser = GM.GetService();
        dsBuyBookJewelry tds = new dsBuyBookJewelry();

        public BuyBookJewelry()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbType, "JewelryType");
            binder.BindControl(CmbStatus, "Status");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCost1, "CostBaht");
            binder.BindControl(txtCost2, "CostUSD");
            binder.BindControl(txtCost3, "CostYen");
            binder.BindControl(txtNote, "NoteForRate");
            binder.BindControl(btnImage1, "Image1");
            binder.BindControl(btnImage2, "Image2");
            binder.BindControl(txtRemark, "Remark");
        }
        public BuyBookJewelry(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbType, "JewelryType");
            binder.BindControl(CmbStatus, "Status");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(txtCost1, "CostBaht");
            binder.BindControl(txtCost2, "CostUSD");
            binder.BindControl(txtCost3, "CostYen");
            binder.BindControl(txtNote, "NoteForRate");
            binder.BindControl(btnImage1, "Image1");
            binder.BindControl(btnImage2, "Image2");
            binder.BindControl(txtRemark, "Remark");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbType.ValueMember = "ID";
            cmbType.DisplayMember = "Detail";
            cmbType.Refresh();

            CmbStatus.DataSource = (GM.GetMasterTableDetail("C023")).Tables[0];
            CmbStatus.ValueMember = "ID";
            CmbStatus.DisplayMember = "Detail";
            CmbStatus.Refresh();

            cmbMaterial.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial.ValueMember = "ID";
            cmbMaterial.DisplayMember = "Detail";
            cmbMaterial.Refresh();

            dtBuyDate.Select();

            //SetFieldService.SetRequireField(txtCode, txtMeasure1, txtMeasure2, txtMeasure3, txtCarat);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("BuyBookJewelry", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.BuyBookJewelry.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.BuyBookJewelry[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBuyBookJewelry.BuyBookJewelryRow row = null;

            if (tds.BuyBookJewelry.Rows.Count > 0)
            {
                row = tds.BuyBookJewelry[0];
            }
            else
            {
                row = tds.BuyBookJewelry.NewBuyBookJewelryRow();
                tds.BuyBookJewelry.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BuyBookJewelry", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BuyBookJewelry", tds);
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
                //chkFlag = ser.DoDeleteData("DiamondCer", id);
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

            if (txtCode.Text == "")
            {
                message = "Please input GIA Number.\n";
            }
            //if(txtMeasure1.Text == "" || txtMeasure2.Text == "" || txtMeasure3.Text == ""
            //&& GM.ConvertStringToDouble(txtMeasure1) == 0 || GM.ConvertStringToDouble(txtMeasure2) == 0 || GM.ConvertStringToDouble(txtMeasure3) == 0)
            //{
            //    message += "Please input Measurement > 0.\n";
            //}
            //if (txtCarat.Text == "" || GM.ConvertStringToDouble(txtCarat) == 0)
            //{
            //    message += "Please input Carat Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }
    }
}
