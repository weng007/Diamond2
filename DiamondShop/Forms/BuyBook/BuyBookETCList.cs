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
using DiamondDS;

namespace DiamondShop
{
    public partial class BuyBookETCList : FormList
    {
        
        public BuyBookETCList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {

            txtSeller.Select();

            gridETC.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookETC", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridETC.DataSource = ds.Tables[0];
                gridETC.Refresh();
            }
            else { gridETC.DataSource = null; gridETC.Refresh(); }

            //btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookETC frm = new BuyBookETC();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();
            ds = ser2.DoSearchBuyBookETC(txtSeller.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridETC.DataSource = ds.Tables[0];
                gridETC.Refresh();
            }
            else { gridETC.DataSource = null; gridETC.Refresh(); }
        }

        private void gridETC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridETC.RowCount > 0 && gridETC.SelectedRows.Count > 0)
            {
                id = (int)gridETC.SelectedRows[0].Cells["ID"].Value;
                BuyBookETC frm = new BuyBookETC(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
