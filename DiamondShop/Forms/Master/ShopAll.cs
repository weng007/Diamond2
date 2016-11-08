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
    public partial class ShopAll : FormList
    {
        public ShopAll()
        {
            InitializeComponent();
            Initial();
        }

        public ShopAll(int mode)
        {
            InitializeComponent();
            Initial();

            if(mode == 0)
            {

            }
        }

        protected override void Initial()
        {
            ds = GM.GetMasterTableDetail("C007");

            if(ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0;i < ds.Tables[0].Rows.Count;i++)
                {
                    if(i == 0)
                    {
                        btnShop1.Visible = true;
                        Shop1.Visible = true;
                        Shop1.Text = ds.Tables[0].Rows[0][1].ToString();

                        btnShop1.Enabled = CheckShopAuthorized(Shop1.Text);
                    }
                    if(i == 1)
                    {
                        btnShop2.Visible = true;
                        Shop2.Visible = true;
                        Shop2.Text = ds.Tables[0].Rows[1][1].ToString();

                        btnShop2.Enabled = CheckShopAuthorized(Shop2.Text);
                    }
                    if (i == 2)
                    {
                        btnShop3.Visible = true;
                        Shop3.Visible = true;
                        Shop3.Text = ds.Tables[0].Rows[2][1].ToString();

                        btnShop3.Enabled = CheckShopAuthorized(Shop3.Text);
                    }
                    if (i == 3)
                    {
                        btnShop4.Visible = true;
                        Shop4.Visible = true;
                        Shop4.Text = ds.Tables[0].Rows[3][1].ToString();

                        btnShop4.Enabled = CheckShopAuthorized(Shop4.Text);
                    }
                    if (i == 4)
                    {
                        btnShop5.Visible = true;
                        Shop5.Visible = true;
                        Shop5.Text = ds.Tables[0].Rows[4][1].ToString();

                        btnShop5.Enabled = CheckShopAuthorized(Shop5.Text);
                    }
                    if (i == 5)
                    {
                        btnShop6.Visible = true;
                        Shop6.Visible = true;
                        Shop6.Text = ds.Tables[0].Rows[5][1].ToString();

                        btnShop6.Enabled = CheckShopAuthorized(Shop6.Text);
                    }
                    if (i == 6)
                    {
                        btnFactory.Visible = true;
                        lblFactory.Visible = false;
                        lblFactory.Text = ds.Tables[0].Rows[6][1].ToString();

                        btnFactory.Enabled = CheckShopAuthorized(lblFactory.Text);
                    }
                    if (i == 7)
                    {
                        btnShop8.Visible = true;
                        Shop8.Visible = true;
                        Shop8.Text = ds.Tables[0].Rows[7][1].ToString();

                        btnShop8.Enabled = CheckShopAuthorized(Shop8.Text);
                    }
                   
                }
            }
        }

        private bool CheckShopAuthorized(string shopName)
        {
            if (shopName == ApplicationInfo.ShopName)
            {
                return true;
            }
            else { return false; }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShop1_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.ShowDialog();

            this.Close();
        }
    }
}
