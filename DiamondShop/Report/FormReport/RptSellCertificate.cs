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
    public partial class RptSellCertificate : FormList
    {
        Service2 ser1;

        DataSet ds = new DataSet();
        public RptSellCertificate()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public RptSellCertificate(int id, bool isPrintPrice)
        {
            InitializeComponent();
            Initial();
            this.id = id;

            ReportDataSource datasource;
            ReportDataSource datasource1;
            ReportDataSource datasource2;
            ReportDataSource datasource3;
            ReportDataSource datasource4 = null;

            Application.UseWaitCursor = true;
            ser1 = GM.GetService1();
            ds = ser1.GetReportCertificate(id, (isPrintPrice)?"1":"0");

            datasource = new ReportDataSource("SP_Rpt_Certificate", ds.Tables[1]);
            datasource1 = new ReportDataSource("Detail", ds.Tables[0]);
            datasource2 = new ReportDataSource("Detail1", ds.Tables[2]);
            datasource3 = new ReportDataSource("Detail2", ds.Tables[3]);
            datasource4 = new ReportDataSource("Total", ds.Tables[4]);

            if (ds.Tables[0].Rows.Count > 0)
            {
                reportViewer1.Visible = true;
                this.reportViewer1.LocalReport.ReportPath = "Report\\CertificateSell.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.LocalReport.DataSources.Add(datasource1);
                this.reportViewer1.LocalReport.DataSources.Add(datasource2);
                this.reportViewer1.LocalReport.DataSources.Add(datasource4);
            }

            if (ds.Tables[2].Rows.Count > 0)
            {
                reportViewer2.Visible = true;
                this.reportViewer2.LocalReport.ReportPath = "Report\\CertificateSell1.rdlc";
                this.reportViewer2.LocalReport.DataSources.Add(datasource);
                this.reportViewer2.LocalReport.DataSources.Add(datasource2);
                this.reportViewer2.LocalReport.DataSources.Add(datasource3);
                this.reportViewer2.LocalReport.DataSources.Add(datasource4);
                this.reportViewer2.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
            
            Application.UseWaitCursor = false;
        }


        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
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

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {
            ser1 = GM.GetService1();

            ser1.UpdateIsPrintCer(id);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                reportViewer1.PrintDialog();
            }

            if (ds.Tables[2].Rows.Count > 0)
            {
                reportViewer2.PrintDialog();
            }

            ser1 = GM.GetService1();
            ser1.UpdateIsPrintCer(id);
        }
    }
}
