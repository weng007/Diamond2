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
    public partial class Customer : FormInfo
    {
        dsCustomer tds = new dsCustomer();
        int refID = 0;

        public Customer()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtTilte, "TitleName");
            binder.BindControl(txtFirstName, "FirstName");
            binder.BindControl(txtLastName, "LastName");
            binder.BindControl(txtDisplayName, "DisplayName");
            binder.BindControl(cmbGender, "Gender");
            binder.BindControl(dtAnniversary, "AnniversaryDate");
            binder.BindControl(dtBirthDate, "BirthDate");
            binder.BindControl(txtMobilePhone, "MobilePhone");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(dtUpdateDate, "EditDate");
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
            binder.BindControl(txtDisplayName, "DisplayName");
            binder.BindControl(cmbGender, "Gender");
            binder.BindControl(dtAnniversary, "AnniversaryDate");
            binder.BindControl(dtBirthDate, "BirthDate");
            binder.BindControl(txtMobilePhone, "MobilePhone");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(dtUpdateDate, "EditDate");
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
            isEdit = false;
        }

        protected override void Initial()
        {
            ds = GM.GetSeller();

            cmbSeller.DataSource = ds.Tables[0];
            cmbSeller.ValueMember = "ID";
            cmbSeller.DisplayMember = "DisplayName";
            cmbSeller.Refresh();

            cmbGender.Items.Insert(0, "Man");
            cmbGender.Items.Insert(1, "Female");

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtTilte.Select();
            cmbGender.SelectedIndex = 0;

            SetFieldService.SetRequireField(txtFirstName,txtLastName,txtDisplayName,dtBirthDate);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Customer", id,0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Customer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Customer[0]);
                cmbGender.SelectedIndex = Convert.ToInt16(tds.Customer[0].Gender);

                EnableDelete = true;
            }

            base.LoadData();
            cmbSeller.SelectedValueChanged += cmbSeller_SelectedValueChanged;
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
            row.Gender = cmbGender.SelectedIndex.ToString();

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("CUST");             
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Customer", tds,0);
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

            isEdit = true;
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
            if (txtDisplayName.Text == "")
            {
                message += "Please input DisplayName.\n";
            }
            if (dtBirthDate.Text == "")
            {
                message += "Please input BirthDate.\n";
            }
           
            if (message == "") { return true; }
            else { return false; }
        }

        private void txtNecklace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Today.Year - dtBirthDate.Value.Year).ToString();
            isEdit = true;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void dtAnniversary_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbSeller_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
