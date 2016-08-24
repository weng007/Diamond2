using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class PaymentList : FormList
    {
        public decimal TotalPrice = 0;

        public PaymentList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }
        protected override void Initial()
        {
            cmbBuyBookType.DataSource = (GM.GetMasterTableDetail("C030", true)).Tables[0];
            cmbBuyBookType.ValueMember = "ID";
            cmbBuyBookType.DisplayMember = "Detail";
            cmbBuyBookType.Refresh();

            cmbIsPaid.DisplayMember = "Text";
            cmbIsPaid.ValueMember = "Value";

            var items = new[] {
                new { Text = "ALL", Value = "-1" },
                new { Text = "ยังไม่ชำระ", Value = "0" },
                new { Text = "ชำระแล้ว", Value = "1" }
            };

            cmbIsPaid.DataSource = items;

            cmbIsPaid.SelectedIndex = 0;

            txtSeller.Select();

            gridBuyBookPayment.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookPayment", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridBuyBookPayment.DataSource = ds.Tables[0];
                gridBuyBookPayment.Refresh();
            }
            else
            {
                gridBuyBookPayment.DataSource = null;
                gridBuyBookPayment.Refresh();
            }

            SetBackGroundColor();

            btnSearch_Click(null, null);
        }

        private void SetBackGroundColor()
        {
            int i = 0;
            foreach (DataGridViewRow row in gridBuyBookPayment.Rows)
            {
                if (row.Cells["IsPaid"].Value.ToString() == "0")
                {
                    gridBuyBookPayment.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                }

                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment(id, TotalPrice);
            frm.ShowDialog();

            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookPayment(txtSeller.Text, cmbBuyBookType.SelectedValue.ToString(),dtSBuyDate.Value, dtEBuyDate.Value,cmbIsPaid.SelectedValue.ToString(),
                dtSPayDate.Value, dtEPayDate.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridBuyBookPayment.DataSource = ds.Tables[0];
                gridBuyBookPayment.Refresh();
            }
            else { gridBuyBookPayment.DataSource = null; gridBuyBookPayment.Refresh(); }
        }

        private void txtWeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gridDiamondCer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (gridBuyBookPayment.RowCount > 0 && gridBuyBookPayment.SelectedRows.Count > 0)
            //{
            //    id = (int)gridBuyBookPayment.SelectedRows[0].Cells["ID"].Value;
            //    Payment frm = new Payment(id);
            //    frm.ShowDialog();
            //}

            //DoLoadData();
        }

        private void gridBuyBookPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridBuyBookPayment.SelectedCells[0].Value == null)
                {
                    gridBuyBookPayment.SelectedCells[0].Value = true;
                    id = (int)gridBuyBookPayment.SelectedRows[0].Cells["ID"].Value;
                    TotalPrice += Convert.ToDecimal(gridBuyBookPayment.SelectedRows[0].Cells["TotalBaht"].Value.ToString());
                }
                else
                {
                    gridBuyBookPayment.SelectedCells[0].Value = false;
                    TotalPrice -= Convert.ToDecimal(gridBuyBookPayment.SelectedRows[0].Cells["TotalBaht"].Value.ToString());
                }
            }
           
        }
    }
}
