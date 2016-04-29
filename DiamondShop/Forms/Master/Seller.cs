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
    public partial class Seller : FormInfo
    {
        //Service1 ser = GM.GetService();
        dsSeller tds = new dsSeller();

        public Seller()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtDisplayName, "DisplayName");
            binder.BindControl(txtTitleName, "TitleName");
            binder.BindControl(txtFirstName, "FirstName");
            binder.BindControl(txtLastName, "LastName");
            binder.BindControl(dtBirthDate, "BirthDate");
            binder.BindControl(cmbRole, "Role");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(dtStartDate, "StartDate");
        }

        public Seller(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtDisplayName, "DisplayName");
            binder.BindControl(txtTitleName, "TitleName");
            binder.BindControl(txtFirstName, "FirstName");
            binder.BindControl(txtLastName, "LastName");
            binder.BindControl(dtBirthDate, "BirthDate");
            binder.BindControl(cmbRole, "Role");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(cmbStatus, "Status");
            binder.BindControl(dtStartDate, "StartDate");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            cmbRole.DataSource = (GM.GetMasterTableDetail("C013")).Tables[0];
            cmbRole.ValueMember = "ID";
            cmbRole.DisplayMember = "Detail";
            cmbRole.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C022")).Tables[0]; //UserStatus Active, InActive
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            txtTitleName.Select();

            SetFieldService.SetRequireField(txtDisplayName);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Seller", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Seller.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Seller[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsSeller.SellerRow row = null;

            if (tds.Seller.Rows.Count > 0)
            {
                row = tds.Seller[0];
            }
            else
            {
                row = tds.Seller.NewSellerRow();
                tds.Seller.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Seller", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Seller", tds);
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
                chkFlag = ser.DoDeleteData("Seller", id);
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

            if (txtDisplayName.Text == "")
            {
                message = "Please input Display Name.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }
    }
}
