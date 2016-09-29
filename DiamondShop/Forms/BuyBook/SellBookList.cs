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

namespace DiamondShop
{
    public partial class SellBookList : FormList
    {
        
        public SellBookList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            txtCode.Select();

            gridSellBook.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("SellBook", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSellBook.DataSource = ds.Tables[0];
                gridSellBook.Refresh();
            }
            else
            {
                gridSellBook.DataSource = null;
                gridSellBook.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SellBook frm = new SellBook();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchSellBook(txtCode.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSellBook.DataSource = ds.Tables[0];
                gridSellBook.Refresh();
            }
            else { gridSellBook.DataSource = null; gridSellBook.Refresh(); }
        }

        private void gridSell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridSellBook.RowCount > 0 && gridSellBook.SelectedRows.Count > 0)
            {
                id = (int)gridSellBook.SelectedRows[0].Cells["ID"].Value;
                SellBook frm = new SellBook(id);
                frm.ShowDialog();

                if (frm.isEdit)
                {
                    DoLoadData();
                }
            }
        }
    }
}
