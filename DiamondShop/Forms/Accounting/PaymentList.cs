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
        string idSelected = "";
        string buyBookType = "";
        int flag;

        public PaymentList()
        {
            InitializeComponent();
            Initial();
            dtSBuyDate.Value = dtSBuyDate.Value.AddDays(-90);
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

                if (row.Cells["PayDate"].Value.ToString() == null)
                {
                    gridBuyBookPayment.Rows[i].DefaultCellStyle.Format = "-";
                }

                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckSelected();
            Payment frm = new Payment(idSelected, TotalPrice, buyBookType);
            frm.ShowDialog();

            if (frm.isEdit)
            {
                DoLoadData();
            }
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridBuyBookPayment.Rows.Count; i++)
            {
                if(gridBuyBookPayment.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridBuyBookPayment.Rows[i].Cells["ID"].Value.ToString() + comma;
                    buyBookType += gridBuyBookPayment.Rows[i].Cells["BuyBookTypeID"].Value.ToString() +comma;
                }
            }
            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
            buyBookType = buyBookType.Remove(buyBookType.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();
            DateTime SPaydate,EPaydate;

            if (txtSPayDate.Text == "")
            {
                SPaydate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                SPaydate = Convert.ToDateTime(txtSPayDate.Text.ToString());
            }

            if (txtEPayDate.Text == "")
            {
                EPaydate = DateTime.MaxValue;
            }
            else
            {
                EPaydate = Convert.ToDateTime(txtEPayDate.Text.ToString());
            }


            ds = ser2.DoSearchBuyBookPayment(txtSeller.Text, cmbBuyBookType.SelectedValue.ToString(),dtSBuyDate.Value, dtEBuyDate.Value,cmbIsPaid.SelectedValue.ToString(),
                SPaydate, EPaydate);

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

        private void gridBuyBookPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridBuyBookPayment.SelectedCells[0].Value == null)
                {
                    gridBuyBookPayment.SelectedCells[0].Value = true;
                    id = (int)gridBuyBookPayment.SelectedRows[0].Cells["ID"].Value;
                    TotalPrice += Convert.ToDecimal(gridBuyBookPayment.SelectedRows[0].Cells["TotalBaht"].Value.ToString());
                    //BuyBookType += Convert.Toint32(gridBuyBookPayment.SelectedRows[0].Cells["BuybookTypeID"].Value.ToString());
                }
                else
                {
                    gridBuyBookPayment.SelectedCells[0].Value = false;
                    TotalPrice -= Convert.ToDecimal(gridBuyBookPayment.SelectedRows[0].Cells["TotalBaht"].Value.ToString());
                    
                }
            }           
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (flag == 0)
            {
                txtSPayDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
            else if (flag == 1)
            {
                txtEPayDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
            monthCalendar1.Visible = false; 
            
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
            flag = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
            monthCalendar1.Location = new Point(659, 92); ;
            flag = 1;
        }
    }
}
