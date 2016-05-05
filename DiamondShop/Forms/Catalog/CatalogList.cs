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
using DiamondDS;

namespace DiamondShop
{
    public partial class CatalogList : FormList
    {
        
        public CatalogList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public CatalogList(string prefix)
        {
            InitializeComponent();
            Initial();

            txtPrefix.Text = prefix;
            DoLoadData();
        }

        protected override void Initial()
        { 

            txtCode.Select();

            grdCatalog.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Catalog", -1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grdCatalog.DataSource = ds.Tables[0];
                grdCatalog.Refresh();
            }
            else
            {
                grdCatalog.DataSource = null;
                grdCatalog.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Catalog frm = new Catalog();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchCatalog(txtPrefix.Text+"-"+txtCode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grdCatalog.DataSource = ds.Tables[0];
                grdCatalog.Refresh();
            }
            else { grdCatalog.DataSource = null; grdCatalog.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        protected override bool DoDeleteData()
        {
            Popup.Popup winMessage = new Popup.Popup("Do you want to Delete data?");
            winMessage.ShowDialog();
            chkFlag = winMessage.result;

            if (chkFlag)
            {
                if (grdCatalog.RowCount > 0 && grdCatalog.SelectedRows.Count > 0)
                {
                    id = (int)grdCatalog.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Catalog", id);
                }
            }
            return chkFlag;
        }

        private void grdCatalog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdCatalog.RowCount > 0 && grdCatalog.SelectedRows.Count > 0)
            {
                id = (int)grdCatalog.SelectedRows[0].Cells["ID"].Value;
                Catalog frm = new Catalog(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
