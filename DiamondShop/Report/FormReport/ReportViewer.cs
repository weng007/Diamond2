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
using DiamondShop.DiamondService1;
using Microsoft.Reporting.WinForms;

namespace DiamondShop.Report
{
    public partial class ReportViewer : FormList
    {
        Service2 ser1;
        DataSet ds = new DataSet();

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(int id, int report)
        {
            InitializeComponent();
            ser1 = GM.GetService1();
            
           
            ds = ser1.GetReportJewelry(id);

            ReportDataSource datasource = new ReportDataSource("Jewelry", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();

            if (report == 0)
            {
                this.reportViewer1.LocalReport.ReportPath = "..\\Report\\Product.rdlc";
            }
            else if (report == 1)
            {
                this.reportViewer1.LocalReport.ReportPath = "..\\Report\\ShopCertificate.rdlc";
            }

            this.reportViewer1.LocalReport.DataSources.Add(datasource);      
            this.reportViewer1.RefreshReport();
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
