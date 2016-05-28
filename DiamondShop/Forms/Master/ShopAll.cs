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
                    }
                    if(i == 1)
                    {
                        btnShop2.Visible = true;
                        Shop2.Visible = true;
                        Shop2.Text = ds.Tables[0].Rows[1][1].ToString();
                    }
                    if (i == 2)
                    {
                        btnShop3.Visible = true;
                        Shop3.Visible = true;
                        Shop3.Text = ds.Tables[0].Rows[2][1].ToString();
                    }
                    if (i == 3)
                    {
                        btnShop4.Visible = true;
                        Shop4.Visible = true;
                        Shop4.Text = ds.Tables[0].Rows[3][1].ToString();
                    }
                    if (i == 4)
                    {
                        btnShop5.Visible = true;
                        Shop5.Visible = true;
                        Shop5.Text = ds.Tables[0].Rows[4][1].ToString();
                    }
                    if (i == 5)
                    {
                        btnShop6.Visible = true;
                        Shop6.Visible = true;
                        Shop6.Text = ds.Tables[0].Rows[5][1].ToString();
                    }
                }
            }
        }

        private void btnShopAll_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.ShowDialog();

            this.Close();
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
    }
}
