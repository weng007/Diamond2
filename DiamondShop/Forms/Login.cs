using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;
using DiamondShop.FormMaster;

namespace DiamondShop
{
    public partial class Login : Form
    {
        Service1 ser = GM.GetService();
        Service2 ser1 = GM.GetService1();
        DiamondDS.DS.dsUser tds = new DiamondDS.DS.dsUser();
        bool chkFlag;

        public Login()
        {
            InitializeComponent();
        }

        private bool ValidateLogin()
        {
            chkFlag = true;
            lblError.Text = "";

            errorProvider1.Clear();
            if (txtUserName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUserName, "UserName can not be empty.");
                chkFlag = false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPassword, "Password can not be empty.");
                chkFlag = false;
            }
            if (chkFlag)
            {
                dsUser ds = ser1.DoAuthenticate(txtUserName.Text.Trim(), GM.Encrypt(txtPassword.Text.Trim()),0);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dsUser.UserRow row = (dsUser.UserRow)ds.User.Rows[0];
                    ApplicationInfo.UserID = row.ID;
                    ApplicationInfo.UserName = row.UserName;
                    ApplicationInfo.Shop = row.Shop;
                    ApplicationInfo.ShopName = row.ShopName;
                    ApplicationInfo.DisplayName = row.DisplayName;

                    if(row.Role == 65) { ApplicationInfo.Authorized = "Staff"; }
                    else if (row.Role == 64) { ApplicationInfo.Authorized = "Owner"; }               
                }
                else
                {
                    chkFlag = false;
                    lblError.Text = "Invalid UserName OR Password.";
                }            
            }

            return chkFlag;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ValidateLogin())
            {
                if(ApplicationInfo.Authorized == "Owner")
                {
                    ShopAll f = new ShopAll(0);
                    f.ShowDialog();

                    this.Close();
                }
                else
                {
                    Main frm = new Main();
                    frm.ShowDialog();

                    this.Close();
                }             
            }      
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
        }
    }
}
