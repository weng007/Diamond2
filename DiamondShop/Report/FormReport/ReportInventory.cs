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
using DiamondShop.DiamondService1;
using Microsoft.Reporting.WinForms;

namespace DiamondShop
{
    public partial class ReportInventory : FormList
    {
        Service2 ser1;
        //dsReportBuying ds = new dsReportBuying();
        DataSet ds = new DataSet();
        public ReportInventory()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023", true)).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

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
            Application.UseWaitCursor = true;
            ser1 = GM.GetService1();

            ds = ser1.GetReportInventory(Convert.ToInt32(cmbStatus.SelectedValue), dtSImpDate.Value, dtEImpDate.Value, Convert.ToInt32(txtSPriceTag.Text), Convert.ToInt32(txtEPriceTag.Text));

            ReportDataSource datasource = new ReportDataSource("dsReportInventory", ds.Tables[1]);
            this.reportViewer1.LocalReport.ReportPath = "..\\Report\\ReportInventory.rdlc";


            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            Application.UseWaitCursor = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
