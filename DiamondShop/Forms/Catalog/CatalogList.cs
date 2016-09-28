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
        public int mode = 0;
        public int refID1 = 0;
        public string code1="";
        public string typeName="";
        public decimal priceTag = 0;
        public byte[] image1;

        public CatalogList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        public CatalogList(int mode)
        {
            InitializeComponent();
            Initial();

            this.mode = mode;
            btnClose.Visible = true;

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
            gridCatalog.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser2.DoSearchCatalogByType(txtPrefix.Text, mode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridCatalog.DataSource = ds.Tables[0];
                gridCatalog.Refresh();
            }
            else
            {
                gridCatalog.DataSource = null;
                gridCatalog.Refresh();
            }

            btnSearch_Click(null, null);
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

            ds = ser2.DoSearchCatalog(txtPrefix.Text + txtCode.Text,mode,ApplicationInfo.Shop);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridCatalog.DataSource = ds.Tables[0];
                gridCatalog.Refresh();
            }
            else { gridCatalog.DataSource = null; gridCatalog.Refresh(); }
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
                if (gridCatalog.RowCount > 0 && gridCatalog.SelectedRows.Count > 0)
                {
                    id = (int)gridCatalog.SelectedRows[0].Cells["ID"].Value;
                    chkFlag = ser.DoDeleteData("Catalog", id);
                }
            }
            return chkFlag;
        }

        private void gridCatalog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridCatalog.RowCount > 0 && gridCatalog.SelectedRows.Count > 0)
                {
                    id = (int)gridCatalog.SelectedRows[0].Cells["ID"].Value;
                    Catalog frm = new Catalog(id);
                    frm.ShowDialog();

                    if (frm.isEdit)
                    {
                        DoLoadData();
                    }
                }
            }
            else //mode = 1 Search
            {
                refID1 = (int)gridCatalog.SelectedRows[0].Cells["ID"].Value;
                code1 = gridCatalog.SelectedRows[0].Cells["Code"].Value.ToString();
                typeName = gridCatalog.SelectedRows[0].Cells["JewelryTypeName"].Value.ToString();
                priceTag = Convert.ToDecimal(gridCatalog.SelectedRows[0].Cells["PriceTag"].Value);

                if (gridCatalog.SelectedRows[0].Cells["Image1"].Value != null && gridCatalog.SelectedRows[0].Cells["Image1"].Value.ToString() !="")
                {
                    image1 = (byte[])gridCatalog.SelectedRows[0].Cells["Image1"].Value;
                }

                this.Close();   
            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
