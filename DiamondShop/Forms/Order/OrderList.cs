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
    public partial class OrderList : FormList
    {       
        public OrderList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbSeller.DataSource = (GM.GetMasterTableDetail("C019",true)).Tables[0];
            cmbSeller.ValueMember = "ID";
            cmbSeller.DisplayMember = "Detail";
            cmbSeller.Refresh();

            cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C020", true)).Tables[0];
            cmbJewelryType.ValueMember = "ID";
            cmbJewelryType.DisplayMember = "Detail";
            cmbJewelryType.Refresh();

            txtCode.Select();

            gridOrder.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Order", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridOrder.DataSource = ds.Tables[0];
                gridOrder.Refresh();
            }
            else
            {
                gridOrder.DataSource = null;
                gridOrder.Refresh();
            }

            SetGrid();

            btnSearch_Click(null, null);
        }

        private void SetGrid()
        {
            int i = 0;
            foreach (DataGridViewRow row in gridOrder.Rows)
            {
                if (row.Cells["AppointDate"].Value.ToString() == null)
                {
                    gridOrder.Rows[i].DefaultCellStyle.Format = "-";
                }

                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderInfo frm = new OrderInfo();
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchOrder(txtCode.Text, txtCustomerName.Text, Convert.ToInt16(cmbJewelryType.SelectedValue.ToString()),Convert.ToInt16(cmbSeller.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridOrder.DataSource = ds.Tables[0];
                gridOrder.Refresh();
            }
            else { gridOrder.DataSource = null; gridOrder.Refresh(); }
        }

        private void gridDiamondCer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridOrder.RowCount > 0 && gridOrder.SelectedRows.Count > 0)
            {
                id = (int)gridOrder.SelectedRows[0].Cells["ID"].Value;
                OrderInfo frm = new OrderInfo(id,0);
                frm.ShowDialog();

                if (frm.isEdit)
                {
                    DoLoadData();
                }
            }
        }
    }
}
