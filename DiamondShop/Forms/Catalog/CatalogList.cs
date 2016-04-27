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

        protected override void Initial()
        {
            //cmbShop.DataSource = (GM.GetMasterTableDetail("C007",true)).Tables[0];
            //cmbShop.ValueMember = "ID";
            //cmbShop.DisplayMember = "Detail";
            //cmbShop.Refresh();

            //cmbStatus.DataSource = (GM.GetMasterTableDetail("C023",true)).Tables[0];
            //cmbStatus.ValueMember = "ID";
            //cmbStatus.DisplayMember = "Detail";
            //cmbStatus.Refresh();

            //cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015",true)).Tables[0];
            //cmbJewelryType.ValueMember = "ID";
            //cmbJewelryType.DisplayMember = "Detail";
            //cmbJewelryType.Refresh();

            txtCode.Select();

            grid.AutoGenerateColumns = false;
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            //ds = ser2.DoSearchProduct(txtCode.Text, Convert.ToInt16(cmbShop.SelectedValue.ToString()),
            //       Convert.ToInt16(cmbStatus.SelectedValue.ToString()), Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid.DataSource = ds.Tables["Product"];
                grid.Refresh();
            }
            else { grid.DataSource = null; grid.Refresh(); }
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Product", -1);

            if (ds.Tables["Product"].Rows.Count > 0)
            {
                grid.DataSource = ds.Tables["Product"];
                grid.Refresh();
            }
            else { grid.DataSource = null; grid.Refresh(); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.RowCount > 0 && grid.SelectedRows.Count > 0)
            {
                //id = (int)grid.SelectedRows[0].Cells["ID"].Value;
                //Catalog frm = new Catalog(id);
                //frm.ShowDialog();
            }

            DoLoadData();
        }
    }
}
