using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondDS.DS;
using DiamondShop.DiamondService1;
using DiamondShop.FormMaster;

namespace DiamondShop
{
    public partial class RequirePassword : Form
    {
        public bool isAuthorize = false;
        string typeLogin = "";
        int AppShop;

        public RequirePassword()
        {
            InitializeComponent();
        }

        public RequirePassword(int Shop)
        {
            InitializeComponent();
            AppShop = Shop;

            txtPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Service2 ser1 = new Service2();

            DataSet ds = ser1.DoAuthenticate(txtUserName.Text, GM.Encrypt(txtPassword.Text.Trim()), AppShop);

            if (ds.Tables[0].Rows.Count > 0)
            {
                isAuthorize = true;
                this.Close();
            }
            else
            {
                isAuthorize = false;
                Popup.Popup WinMessage = new Popup.Popup("Password is not correct or unauthorized.");
                WinMessage.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequirePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            txtUserName.Text = ApplicationInfo.UserName;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnOK.PerformClick();
            }
        }
    }
}
