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
            ser1 = GM.GetService1();

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

            CheckUnReadMessage();
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
                //statusType 1 = Order, 2 = Transfer
                string statusType = "1";

                statusType = gridWarning.Rows[e.RowIndex].Cells["StatusType"].Value.ToString();
                
                if (statusType == "1")
                {
                    id = Convert.ToInt32(gridWarning.Rows[e.RowIndex].Cells["RefID"].Value);
                    WarningID = Convert.ToInt32(gridWarning.Rows[e.RowIndex].Cells["ID"].Value);
                    OrderInfo frm = new OrderInfo(id, WarningID);
                    frm.ShowDialog();

                    ser1.UpdateMessageStatus(WarningID, statusType,"0");
                }
                else
                {
                    id = (int)gridWarning.Rows[e.RowIndex].Cells["RefID"].Value;
                    WarningID = Convert.ToInt32(gridWarning.Rows[e.RowIndex].Cells["ID"].Value);
                    TransferInfo frm = new TransferInfo(id);
                    frm.ShowDialog();

                    ser1.UpdateMessageStatus(WarningID, statusType,"0");
                }

                if (gridWarning.Rows[e.RowIndex].Cells["MessageStatus"].Value.ToString() == "215" || gridWarning.Rows[e.RowIndex].Cells["MessageStatus"].Value.ToString() == "217")
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
                if (row["MessageStatus"].ToString() == "215" || row["MessageStatus"].ToString() == "217")
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
                gridWarning.Columns["EShopName"].Visible = false;

                gridWarning.Columns["SenderName"].Visible = true;
                gridWarning.Columns["SShopName"].Visible = true;
            }
            else
            {
                gridWarning.Columns["ReceiverName"].Visible = true;
                gridWarning.Columns["Status"].Visible = true;
                gridWarning.Columns["EShopName"].Visible = true;

                gridWarning.Columns["SenderName"].Visible = false;
                gridWarning.Columns["SShopName"].Visible = false;
            }
        }

        private void CheckUnReadMessage()
        {
            btnInbox.Text = "UnRead(" + ser1.CountUnReadMessage(ApplicationInfo.UserID)+")";
        }
    }
}
