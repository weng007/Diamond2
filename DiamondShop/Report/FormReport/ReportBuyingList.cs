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
    public partial class ReportBuyingList : FormList
    {
        Service2 ser1;
        //dsReportBuying ds = new dsReportBuying();
        DataSet ds = new DataSet();
        public ReportBuyingList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
            dtSBuyDate.Value = dtSBuyDate.Value.AddDays(-90);
            dtSDueDate.Value = dtSDueDate.Value.AddDays(-90);
        }

        protected override void Initial()
        {
            //ds = GM.GetSeller();
            //DataRow row = ds.Tables[0].NewRow();
            //row["ID"] = 0;
            //row["DisplayName"] = "All";
            //ds.Tables[0].Rows.Add(row);

            //cmbSeller.DataSource = ds.Tables[0];
            //cmbSeller.ValueMember = "ID";
            //cmbSeller.DisplayMember = "DisplayName";
            //cmbSeller.SelectedIndex = ds.Tables[0].Rows.Count-1;
            //cmbSeller.Refresh();

            cmbType.DataSource = (GM.GetMasterTableDetail("C030", true)).Tables[0];
            cmbType.ValueMember = "ID";
            cmbType.DisplayMember = "Detail";
            cmbType.Refresh();

            cmbStatus.DataSource = (GM.GetMasterTableDetail("C023", true)).Tables[0];
            cmbStatus.ValueMember = "ID";
            cmbStatus.DisplayMember = "Detail";
            cmbStatus.Refresh();

            cmbPayment.DataSource = (GM.GetMasterTableDetail("C031", true)).Tables[0];
            cmbPayment.ValueMember = "ID";
            cmbPayment.DisplayMember = "Detail";
            cmbPayment.Refresh();

            cmbShape.DataSource = (GM.GetMasterTableDetail("C019", true)).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

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

            ds = ser1.GetReportBuying(Convert.ToInt32(cmbType.SelectedValue), dtSBuyDate.Value, dtEBuyDate.Value, Convert.ToInt32(txtSWeight.Text), Convert.ToInt32(txtEWeight.Text), Convert.ToInt32(cmbShape.SelectedValue), Convert.ToInt32(cmbStatus.SelectedValue),dtSDueDate.Value,dtEDueDate.Value,Convert.ToInt32(cmbPayment.SelectedValue));           

            ReportDataSource datasource = new ReportDataSource("dsReportBuying", ds.Tables[1]);
            this.reportViewer1.LocalReport.ReportPath = "Report\\ReportBuying.rdlc";
            

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
