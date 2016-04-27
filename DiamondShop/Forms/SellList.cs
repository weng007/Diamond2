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
            cmbType.Refresh();

            txtCode.Select();

            gridSell.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Sell", -1);

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
        }
        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (gridSell.RowCount > 0 && gridSell.SelectedRows.Count > 0)
                {
                    id = (int)gridSell.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Sell", id);
                }
            }
            return chkFlag;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sell frm = new Sell();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

    private void btnEdit_Click(object sender, EventArgs e)
    {
            if (gridSell.RowCount > 0 && gridSell.SelectedRows.Count > 0)
            {
                id = (int)gridSell.SelectedRows[0].Cells["ID"].Value;
                Sell frm = new Sell(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
}
}
