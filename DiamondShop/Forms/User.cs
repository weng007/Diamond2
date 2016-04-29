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
    public partial class User : FormInfo
    {
        dsUser tds = new dsUser();

        public User()
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
            binder.BindControl(txtUserName, "UserName");
            binder.BindControl(txtPassword1, "Password1");
            binder.BindControl(txtPassword2, "Password2");
            binder.BindControl(txtPassword3, "Password3");
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

            SetFieldService.SetRequireField(txtUserName,txtPassword1,txtDisplayName);
        }
        public User(int id)
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
            binder.BindControl(txtUserName, "UserName");
            binder.BindControl(txtPassword1, "Password1");
            binder.BindControl(txtPassword2, "Password2");
            binder.BindControl(txtPassword3, "Password3");

            this.id = id;
            LoadData();
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("User", id);
            tds.Clear();
            tds.Merge(ds);

            if (tds.User.Rows.Count > 0)
            {             
                tds.User[0].Password1 = GM.Decrypt(tds.User[0].Password1);
                tds.User[0].Password2 = GM.Decrypt(tds.User[0].Password2);
                tds.User[0].Password3 = GM.Decrypt(tds.User[0].Password3);

                binder.BindValueToControl(tds.User[0]);
                EnableDelete = true;
            }

            base.LoadData();
        }

        protected override bool SaveData()
        {
            dsUser.UserRow row = null;

            if (tds.User.Rows.Count > 0)
            {
                row = tds.User[0];
            }
            else
            {
                row = tds.User.NewUserRow();           
                tds.User.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                //Encrypt Password ก่อน Save
                row.Password1 = GM.Encrypt(txtPassword1.Text.Trim());
                row.Password2 = GM.Encrypt(txtPassword2.Text.Trim());
                row.Password3 = GM.Encrypt(txtPassword3.Text.Trim());

                if (id == 0)
                {
                    SetCreateBy(row);      
                    chkFlag = ser.DoInsertData("User", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("User", tds);
                }

                tds.AcceptChanges();
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
                message += "Please input FirstName.\n";
            }
            if (txtLastName.Text == "")
            {
                message += "Please input LastName.\n";
            }
            if (txtUserName.Text == "")
            {
                message += "Please input UserName.\n";
            }
            if (txtPassword1.Text == "")
            {
                message += "Please input Password.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("User", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
    }
}
