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

namespace DiamondShop
{
    public partial class Main : FormList
    {
        //ID ของ Tabpage
        int tabIndex = 0;
        //นับจำนวน Tab
        int countTab = 0;

        public Main()
        {
            InitializeComponent();
            SetAuthorized();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserList frm = new UserList();
            SetFormList(frm,0,"User");
        }

        private void menuCerDiamond_Click(object sender, EventArgs e)
        {
            BuyBookDiamondCerList frm = new BuyBookDiamondCerList();
            SetFormList(frm, 2, "BBCer. Diamond");
        }

        private void menuCerGemstone_Click(object sender, EventArgs e)
        {
            BuyBookGemstoneCerList frm = new BuyBookGemstoneCerList();
            SetFormList(frm, 3, "BBCer. Gemstone");
        }

        private void menuJewelry_Click(object sender, EventArgs e)
        {
            BuyBookJewelryList frm = new BuyBookJewelryList();
            SetFormList(frm, 4, "BuyBookJewelryList");
        }

        private void menuNonCerDiamond_Click(object sender, EventArgs e)
        {
            BuyBookDiamondList frm = new BuyBookDiamondList();
            SetFormList(frm, 5, "BuyBookDiamond");
        }

        private void menuNonCerGemstone_Click(object sender, EventArgs e)
        {
            BuyBookGemstoneList frm = new BuyBookGemstoneList();
            SetFormList(frm, 6, "BuyBookGemstone");
        }

        private void menuGold_Click(object sender, EventArgs e)
        {
            BuyBookGoldList frm = new BuyBookGoldList();
            SetFormList(frm, 7, "BuyBookGold");
        }

        private void menuSetting_Click(object sender, EventArgs e)
        {
            BuyBookSettingList frm = new BuyBookSettingList();
            SetFormList(frm, 8, "BuyBookSetting");
        }

        private void menuETC_Click(object sender, EventArgs e)
        {
            BuyBookETCList frm = new BuyBookETCList();
            SetFormList(frm, 9, "BuyBookETC");
        }

        private void mnCatDR_Click(object sender, EventArgs e)
        {
            string prefix = ((ToolStripMenuItem)sender).AccessibleDescription;
            CatalogList frm = new CatalogList(prefix);
            SetFormList(frm, 10, "Catalog " + prefix);
        }

        private void btnCerDiamond_Click(object sender, EventArgs e)
        {
            DiamondCerList frm = new DiamondCerList();
            SetFormList(frm, 11, "DiamondCer");
        }

        private void btnCerGemstone_Click(object sender, EventArgs e)
        {
            GemstoneCerList frm = new GemstoneCerList();
            SetFormList(frm, 12, "GemstoneCer");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList();
            SetFormList(frm, 13, "Customer");
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellList frm = new SellList();
            SetFormList(frm, 14, "Sell");
        }

        private void mnInvDR_Click(object sender, EventArgs e)
        {
            string prefix = ((ToolStripMenuItem)sender).AccessibleDescription;
            InventoryList frm = new InventoryList(prefix);
            SetFormList(frm, 15, "Inventory " + prefix);
        }
        private void MenuPayment_Click(object sender, EventArgs e)
        {
            PaymentList frm = new PaymentList();
            SetFormList(frm, 16, "Payment");
        }
        private void warningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarningList frm = new WarningList();
            SetFormList(frm, 17, "Warning");
        }
        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarActivity frm = new CalendarActivity();
            SetFormList(frm, 18, "CalendarActivity");
        }
        private void buyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferBuyBookList frm = new TransferBuyBookList();
            SetFormList(frm, 19, "Transfer");
        }
        private void orderJewelryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderList frm = new OrderList();
            SetFormList(frm, 20, "Order");
        }
        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransferInventoryList frm = new TransferInventoryList();
            SetFormList(frm, 21, "TransferInventory");
        }
        private void productionLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionLineList frm = new ProductionLineList();
            SetFormList(frm, 22, "ProductionLine");
        }
        private void mnSellBook_Click(object sender, EventArgs e)
        {
            SellBookList frm = new SellBookList();
            SetFormList(frm, 23, "SellBook");
        }
        private void expenseGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseGroupList frm = new ExpenseGroupList();
            SetFormList(frm, 24, "ExpenseGroup");
        }
        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseList frm = new ExpenseList();
            SetFormList(frm, 25, "Expense");
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReceiveDocumentList frm = new ReceiveDocumentList();
            SetFormList(frm, 26, "ReceiveDocument");
        }
        private void btnReportBuying_Click(object sender, EventArgs e)
        {
            ReportBuyingList frm = new ReportBuyingList();
            frm.ShowDialog();
        }
        private void btnReportSelling_Click(object sender, EventArgs e)
        {
            ReportSellingList frm = new ReportSellingList();
            frm.ShowDialog();
        }
        private void btnReportInventory_Click(object sender, EventArgs e)
        {
            ReportInventory frm = new ReportInventory();
            frm.ShowDialog();
        }
        private void btnReportDebt_Click(object sender, EventArgs e)
        {
            ReportDebtList frm = new ReportDebtList();
            frm.ShowDialog();
        }
        private void btnReportCustomer_Click(object sender, EventArgs e)
        {
            ReportCustomerList frm = new ReportCustomerList();
            frm.ShowDialog();
        }

        private void menuExchangeRate_Click(object sender, EventArgs e)
        {
            ExchangeRate frm = new ExchangeRate();
            frm.ShowDialog();
        }
        private void SetFormList(Form frm, int ImageIndex, string tabPageText)
        {
            //Check ว่ามี Tabpage นั้นเปิดอยู่แล้วหรือยัง
            bool exist = CheckTabPageExist(tabControl1,tabPageText);

            if (exist)
            {
                frm.TopLevel = false;
                frm.Visible = true;
                frm.Dock = DockStyle.Fill;
                frm.AutoScroll = true;

                Point p = new Point(1300, 0);

                tabControl1.TabPages.Add(tabPageText,"");
                tabControl1.TabPages[tabPageText].Controls.Add(frm);
                tabControl1.ImageList = imageList1;
                tabControl1.TabPages[tabPageText].ImageIndex = ImageIndex;
                tabControl1.SelectedIndex = countTab;

                //Running Tab ID
                tabIndex++;

                countTab++;
            }
        }

        private bool CheckTabPageExist(TabControl tab,string tabPageText)
        {
            bool chk = true;

            if (tabControl1.TabPages.ContainsKey(tabPageText))
            { chk = false; tabControl1.SelectedTab = tabControl1.TabPages[tabPageText]; }
            else { chk = true; }

            return chk;
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

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            //เก็บ TabSelected
            int tabIndex = 0;

            // check if the left mouse button was pressed
            if (e.Button == MouseButtons.Left)
            {
                // iterate through all the tab pages
                for (int i = 0; i < tabControl1.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    //Rectangle r = tabControl1.GetTabRect(i);
                    if ((e.X > 165+(188*i) && e.X<180+(188*i)) && (e.Y > 5 && e.Y < 20))
                    {
                        tabIndex = tabControl1.SelectedIndex;
                        tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                        
                        ////เมื่อปิด Tab จะแสดง TabSelected ก่อนหน้า
                        //if(tabIndex != 0) {tabControl1.SelectedIndex = tabIndex - 1; }
                        
                        countTab--;
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtFullName.Text = ApplicationInfo.DisplayName;
        }

        private void SetAuthorized()
        {
            if (ApplicationInfo.Authorized == "Staff")
            {
                btnActivity.Visible = false;
                btnMaster.Visible = false;
                btnInventory.Visible = false;
                btnTransfer.Visible = false;
                btnOrderFactory.Visible = false;
                btnBuyBook.Visible = false;
                btnAccounting.Visible = false;
                btnReport.Visible = false;                  
            }
            else if (ApplicationInfo.Authorized == "Owner")
            {           
                btnActivity.Visible = true;
                btnMaster.Visible = true;
                btnInventory.Visible = true;
                btnTransfer.Visible = true;
                btnOrderFactory.Visible = true;
                btnBuyBook.Visible = true;
                btnAccounting.Visible = true;
                btnReport.Visible = true;

                ////สิทธิ์ Sub Menu ภายใน
                //if (ApplicationInfo.Shop != 209)// Office ใช้เท่านั้น
                //{
                //    mnBBCD.Enabled = false;
                //    mnBBCG.Enabled = false;
                //    mnBBJW.Enabled = false;
                //    mnBBNCD.Enabled = false;
                //    mnBBNCG.Enabled = false;
                //    mnBBG.Enabled = false;
                //    mnBBST.Enabled = false;
                //    mnBBETC.Enabled = false;
                //}
                //if(ApplicationInfo.Shop == 232)// Factory ซื้อทองได้
                //{
                //    mnBBG.Enabled = true;
                //}
            }         
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            Login frm = new Login();
            frm.ShowDialog();            
        }
    }
}
