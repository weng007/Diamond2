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
    public partial class SellList : FormList
    {
        
        public SellList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbType.DataSource = (GM.GetMasterTableDetail("C015",true)).Tables[0];
            cmbType.ValueMember = "ID";
            cmbType.DisplayMember = "Detail";

            txtCode.Select();

            gridSell.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Sell", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSell.DataSource = ds.Tables[0];
                gridSell.Refresh();
            }
            else
            {
                gridSell.DataSource = null;
                gridSell.Refresh();
            }

            ////btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sell frm = new Sell();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchSell(txtCode.Text, Convert.ToInt16(cmbType.SelectedValue.ToString()));

            gridSell.DataSource = ds.Tables[0];
            gridSell.Refresh();
        }

        private void gridSell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridSell.RowCount > 0 && gridSell.SelectedRows.Count > 0)
            {
                id = (int)gridSell.SelectedRows[0].Cells["ID"].Value;
                Sell frm = new Sell(id);
                frm.ShowDialog();
            }
        }
    }
}
