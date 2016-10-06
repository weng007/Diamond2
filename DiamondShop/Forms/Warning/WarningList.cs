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
using System.IO;

namespace DiamondShop
{
    public partial class WarningList : FormList
    {
        public int WarningID = 0;
        int IsInbox = 1;
        Service2 ser1;
        
        public WarningList()
        {
            InitializeComponent();
            Initial();
            dtSEditDate.Value = dtSEditDate.Value.AddDays(-90);
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbStatusType.DisplayMember = "Text";
            cmbStatusType.ValueMember = "Value";
            var items = new[] {
                new { Text = "ALL", Value = "0" },
                new { Text = "Order Jewelry", Value = "1" },
                new { Text = "Transfer", Value = "2" }
            };
            cmbStatusType.DataSource = items;
            cmbStatusType.SelectedIndex = 0;


            gridWarning.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            // Inbox
            ds = ser2.DoSearchWarning(txtRefID.Text, Convert.ToInt32(cmbStatusType.SelectedValue.ToString()), dtSEditDate.Value, dtEEditDate.Value,ApplicationInfo.UserID, IsInbox);
            tds.Clear();
            tds.Merge(ds);


            if (tds.Tables[0].Rows.Count > 0)
            {
                gridWarning.DataSource = tds.Tables[0];

                SetGrid();
                SetGridimage();
                gridWarning.Refresh();
            }

            else { gridWarning.DataSource = null; gridWarning.Refresh(); }
        }

        private void btnSendBox_Click(object sender, EventArgs e)
        {
            IsInbox = 0;//SendBox
            SearchData();

            SetGrid();     
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            IsInbox = 1;//InBox
            SearchData();

            SetGrid();
        }
        private void SearchData()
        {
            ser2 = GM.GetService2();
            
            ds = ser2.DoSearchWarning(txtRefID.Text, Convert.ToInt16(cmbStatusType.SelectedValue.ToString()), dtSEditDate.Value, dtEEditDate.Value, ApplicationInfo.UserID, IsInbox);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Tables[0].Rows.Count > 0)
            {
                gridWarning.DataSource = tds.Tables[0];

                SetGrid();
                SetGridimage();
                gridWarning.Refresh();
            }
            else { gridWarning.DataSource = null; gridWarning.Refresh(); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SearchData();
        }

        private void WarningList_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 6000; // 10 secs = 10000, 300000 = 5 m
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalendarActivity frm = new CalendarActivity();
            frm.ShowDialog();
        }

        private void gridWarning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == gridWarning.Columns.Count-1)
            {
                if (gridWarning.Rows[e.RowIndex].Cells["StatusType"].Value.ToString() == "1")
                {
                    id = Convert.ToInt32(gridWarning.SelectedRows[0].Cells["RefID"].Value);
                    WarningID = Convert.ToInt32(gridWarning.SelectedRows[0].Cells["ID"].Value);
                    OrderInfo frm = new OrderInfo(id, WarningID);
                    frm.ShowDialog();
                }
                else
                {
                    id = (int)gridWarning.SelectedRows[0].Cells["RefID"].Value;
                    WarningID = Convert.ToInt32(gridWarning.SelectedRows[0].Cells["ID"].Value);
                    TransferInfo frm = new TransferInfo(id);
                    frm.ShowDialog();
                }

                ser1 = GM.GetService1();
                ser1.UpdateMessageStatus(WarningID, "0");

                if (gridWarning.Rows[e.RowIndex].Cells["MessageStatus"].Value.ToString() == "245")
                {
                    gridWarning.Rows[e.RowIndex].Cells["IsRead"].Value = imageList1.Images[1];
                }
                else
                {
                    gridWarning.Rows[e.RowIndex].Cells["IsRead"].Value = imageList1.Images[0];
                }

            }
            
        }
        private void SetGridimage()
        {
            foreach (dsWarning.WarningRow row in tds.Tables[0].Rows)
            {
                if (row["MessageStatus"].ToString() == "245")
                {
                    row["IsRead"] = (Image)imageList1.Images[1];
                }
                else
                {
                    row["IsRead"] = (Image)imageList1.Images[0];
                }
            }

            tds.AcceptChanges();
        }

        private void SetGrid()
        {
            if (IsInbox == 1)
            {
                gridWarning.Columns["ReceiverName"].Visible = false;
                gridWarning.Columns["Status"].Visible = false;

                gridWarning.Columns["SenderName"].Visible = true;
            }
            else
            {
                gridWarning.Columns["ReceiverName"].Visible = true;
                gridWarning.Columns["Status"].Visible = true;

                gridWarning.Columns["SenderName"].Visible = false;
            }
        }
    }
}
