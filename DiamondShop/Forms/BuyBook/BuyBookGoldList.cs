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
    public partial class BuyBookGoldList : FormList
    {
        
        public BuyBookGoldList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            gridGold.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookGold", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGold.DataSource = ds.Tables[0];
                gridGold.Refresh();
            }
            else
            {
                gridGold.DataSource = null;
                gridGold.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookGold(Convert.ToDateTime(dtSBuyDate.Text),Convert.ToDateTime( dtEBuyDate.Text));

            gridGold.DataSource = ds.Tables[0];
            gridGold.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookGold frm = new BuyBookGold();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridGold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridGold.RowCount > 0 && gridGold.SelectedRows.Count > 0)
            {
                id = (int)gridGold.SelectedRows[0].Cells["ID"].Value;
                BuyBookGold frm = new BuyBookGold(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }

    }
}
