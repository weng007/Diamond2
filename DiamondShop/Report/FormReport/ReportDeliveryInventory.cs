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

namespace DiamondShop.Report
{
    public partial class ReportDeliveryInventory : FormList
    {
        Service2 ser1;
        DataSet ds = new DataSet();

        public ReportDeliveryInventory()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public ReportDeliveryInventory(int id)
        {
            InitializeComponent();
            Initial();

            this.id = id;

            Application.UseWaitCursor = true;
            ser1 = GM.GetService1();
            ds = ser1.GetDeliveryInventory(id);

            ReportDataSource datasource = new ReportDataSource("SP_Rpt_Delivery_Inventory", ds.Tables[1]);
            ReportDataSource datasource1 = new ReportDataSource("Detail", ds.Tables[0]);
            this.reportViewer1.LocalReport.ReportPath = "Report\\DeliverOrderInventory.rdlc";


            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.DataSources.Add(datasource1);
            this.reportViewer1.RefreshReport();
            Application.UseWaitCursor = false;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
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
