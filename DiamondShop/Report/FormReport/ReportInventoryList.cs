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
    public partial class ReportInventoryList : FormList
    {
        
        public ReportInventoryList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            //cmbType.DataSource = (GM.GetMasterTableDetail("C015",true)).Tables[0];
            //cmbType.ValueMember = "ID";
            //cmbType.DisplayMember = "Detail";

            //txtSWeight.Select();

            //gridSell.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            //ds = ser.DoSelectData("Sell", -1,0);

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    gridSell.DataSource = ds.Tables[0];
            //    gridSell.Refresh();
            //}
            //else
            //{
            //    gridSell.DataSource = null;
            //    gridSell.Refresh();
            //}

            //btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ser2 = GM.GetService2();

            //ds = ser2.DoSearchSell(txtSWeight.Text, Convert.ToInt32(cmbType.SelectedValue.ToString()));

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    gridSell.DataSource = ds.Tables[0];
            //    gridSell.Refresh();
            //}
            //else { gridSell.DataSource = null; gridSell.Refresh(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
