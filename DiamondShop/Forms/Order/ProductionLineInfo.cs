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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class ProductionLineInfo : FormInfo
    {
        Service2 ser1;
        dsProductionLine tds = new dsProductionLine();
        bool isAuthorize = false;
        Decimal TotalPrice;
        int SFactoryStatus;

        public ProductionLineInfo()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbFactoryStatus, "FactoryStatus");

        }
        public ProductionLineInfo(int id,int SFactoryStatus)
        {
            InitializeComponent();
            Initial();
            //this.TotalPrice = TotalPrice;

            binder.BindControl(cmbFactoryStatus, "FactoryStatus");

            this.id = id;
            this.SFactoryStatus = SFactoryStatus;
            LoadData();
            SetControlEnable(false);
            isEdit = false;
            
        }

        protected override void Initial()
        {
            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C036")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            //SetFieldService.SetRequireField(txtSeller, txtPrice);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("ProductionLine", id, 0);
            tds.Clear();
            tds.Merge(ds);;

            if (tds.ProductionLine.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.ProductionLine[0]);
                
                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            base.LoadData();
        }

        protected override bool SaveData()
        {
            ser1 = GM.GetService1();
            try
            {
                ser1.UpdateProductionLine(id, Convert.ToInt32(cmbFactoryStatus.SelectedValue.ToString()), ApplicationInfo.UserID);
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
                RequirePassword frm = new RequirePassword(ApplicationInfo.Shop);
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

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

            
            //if (txtPrice.Text == "" || GM.ConvertStringToDouble(txtPrice) == 0)
            //{
            //    message += "Please input Price > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void SetControlEnable(bool status)
        {
            //txtPrice.Enabled = status;
        }

        private void txtPayDate_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
