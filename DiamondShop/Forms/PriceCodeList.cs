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
using DiamondDS;

namespace DiamondShop
{
    public partial class PriceCodeList : FormList
    {
        public PriceCodeList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            gridPriceCode.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {      
            ds = ser.DoSelectData("PriceCode", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridPriceCode.DataSource = tds.PriceCode;
                gridPriceCode.Refresh();
            }
            else
            {
                gridPriceCode.DataSource = null;
                gridPriceCode.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PriceCode frm = new PriceCode();
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteData();
            DoLoadData();
        }

        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (gridPriceCode.RowCount > 0 && gridPriceCode.SelectedRows.Count > 0)
                {
                    id = (int)gridPriceCode.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("PriceCode", id);
                }
            }

            return chkFlag;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridPriceCode.RowCount > 0 && gridPriceCode.SelectedRows.Count > 0)
            {
                id = (int)gridPriceCode.SelectedRows[0].Cells["ID"].Value;
                PriceCode frm = new PriceCode(id);          
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
