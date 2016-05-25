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

namespace DiamondShop
{
    public partial class Customer : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsCustomer tds = new dsCustomer();
        int sellerID = 0;

        public Customer()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtTilte, "TitleName");
            binder.BindControl(txtFirstName, "FirstName");
            binder.BindControl(txtLastName, "LastName");
            binder.BindControl(txtDisplayName, "NickName");
            binder.BindControl(cmbGender, "Gender");
            binder.BindControl(dtAnniversary, "AnniversaryDate");
            binder.BindControl(dtBirthdate, "BirthDate");
            binder.BindControl(txtContactphone, "MobilePhone");
            binder.BindControl(dtUpdatedate, "EditDate");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtComment, "Comment");
            binder.BindControl(txtNecklace, "Necklace");
            binder.BindControl(txtRing1, "Ring1");
            binder.BindControl(txtRing2, "Ring2");
            binder.BindControl(txtRing3, "Ring3");
            binder.BindControl(txtRing4, "Ring4");
            binder.BindControl(txtRing5, "Ring5");
            binder.BindControl(txtRing6, "Ring6");
            binder.BindControl(txtRing7, "Ring7");
            binder.BindControl(txtRing8, "Ring8");
            binder.BindControl(txtRing9, "Ring9");
            binder.BindControl(txtRing10, "Ring10");
            binder.BindControl(txtBracelet, "Bracelet");

        }
        public Customer(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtTilte, "TitleName");
            binder.BindControl(txtFirstName, "FirstName");
            binder.BindControl(txtLastName, "LastName");
            binder.BindControl(txtDisplayName, "NickName");
            binder.BindControl(cmbGender, "Gender");
            binder.BindControl(dtAnniversary, "AnniversaryDate");
            binder.BindControl(dtBirthdate, "BirthDate");
            binder.BindControl(txtContactphone, "MobilePhone");
            binder.BindControl(dtUpdatedate, "EditDate");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtComment, "Comment");
            binder.BindControl(txtNecklace, "Necklace");
            binder.BindControl(txtRing1, "Ring1");
            binder.BindControl(txtRing2, "Ring2");
            binder.BindControl(txtRing3, "Ring3");
            binder.BindControl(txtRing4, "Ring4");
            binder.BindControl(txtRing5, "Ring5");
            binder.BindControl(txtRing6, "Ring6");
            binder.BindControl(txtRing7, "Ring7");
            binder.BindControl(txtRing8, "Ring8");
            binder.BindControl(txtRing9, "Ring9");
            binder.BindControl(txtRing10, "Ring10");
            binder.BindControl(txtBracelet, "Bracelet");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtTilte.Select();

            SetFieldService.SetRequireField(txtFirstName,txtLastName,dtBirthdate);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Customer", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Customer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Customer[0]);

                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsCustomer.CustomerRow row = null;

            if (tds.Customer.Rows.Count > 0)
            {
                row = tds.Customer[0];
            }
            else
            {
                row = tds.Customer.NewCustomerRow();
                tds.Customer.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            //row.RefID = refID;
            //row.CustID = custID;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Customer", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Customer", tds);
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
                chkFlag = ser.DoDeleteData("Customer", id);
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

            if (txtFirstName.Text == "")
            {
                message = "Please input FirstName.\n";
            }
            if (txtLastName.Text == "")
            {
                message += "Please input LastName.\n";
            }
            if (dtBirthdate.Text == "")
            {
                message += "Please input Birth Date.\n";
            }
           
            if (message == "") { return true; }
            else { return false; }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellerSearch frm = new SellerSearch();
            frm.ShowDialog();
            txtSeller.Text = frm.fullName;
            sellerID = frm.id;       
        }

        private void txtNecklace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
