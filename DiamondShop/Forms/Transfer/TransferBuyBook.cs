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
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;
using DiamondShop.DiamondService2;

namespace DiamondShop
{
    public partial class TransferBuyBook : FormInfo
    {
        Service2 ser1;
        Service3 ser2;
        dsTransfer tds = new dsTransfer();
        dsTransferBuyBook tds1 = new dsTransferBuyBook();
     
        DataSet tmp = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();

        bool isAuthorize = false;
        int rowIndex;
        int DelID;

        public TransferBuyBook()
        {
            InitializeComponent();
            Initial();

            BinderData();

            txtTransferStatus.Text = "Send";
            txtSender.Text = ApplicationInfo.DisplayName;
            txtSShop.Text = ApplicationInfo.ShopName;
        }
        public TransferBuyBook(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();

            this.id = id;
            LoadData();
            SetControlEnable(false);
        }
        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

            cmbEShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbEShop.ValueMember = "ID";
            cmbEShop.DisplayMember = "Detail";
            cmbEShop.Refresh();

            txtSender.Select();
            
            //SetFieldService.SetRequireField(txtSender);

            gridTransfer.AutoGenerateColumns = false;
        }
        private void BinderData()
        {
            binder.BindControl(dtSendDate, "SendDate");
            binder.BindControl(txtSender, "SenderName");
            binder.BindControl(txtTransferNo, "TransferNo");
            binder.BindControl(txtTransferStatus, "TransferStatusName");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(txtSShop, "SShopName");
            binder.BindControl(cmbEShop, "EShop");
            binder.BindControl(txtNote, "Note");
        }
        protected override void LoadData()
        {
            ser2 = GM.GetService2();

            ds = ser.DoSelectData("Transfer", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("TransferBuyBook", id, 0);
            tds1.Clear();
            tds1.Merge(ds2);

            if (tds.Transfer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Transfer[0]);
                txtReceivedDate.Text = string.Format("{0:d/M/yyyy}", tds.Transfer[0]["ReceiveDate"]);

                if (!isAuthorize)
                {
                    EnableSave = false;
                    EnableEdit = true;
                    EnableDelete = false;
                }

                //Receiver 
                if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
                {
                    btnReceive.Visible = true;
                    btnPrint.Visible = false;
                }
            }

            if (tds1.Tables[0].Rows.Count > 0)
            {
                gridTransfer.DataSource = tds1.Tables[0];
                gridTransfer.Refresh();
            }

            SetFormatNumber();
            base.LoadData();
        }
        protected override bool SaveData()
        {
            dsTransfer.TransferRow row = null;

            if (tds.Transfer.Rows.Count > 0)
            {
                row = tds.Transfer[0];
            }
            else
            {
                row = tds.Transfer.NewTransferRow();
                tds.Transfer.Rows.Add(row);
            }

            binder.BindValueToDataRow(row);
            row.IsBuyBook = "1";
            row.SShop = ApplicationInfo.Shop;
            
            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    row.Sender = row.CreateBy;
                    row.TransferNo = GM.GetRunningNumber("TRF");
                    row.ReceiveDate = DateTime.MinValue.AddYears(1900);
                    row.TransferStatus = 222;
                    chkFlag = ser.DoInsertData("Transfer", tds, 0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Transfer", tds);

                    BindingDSTransferBuyBook();

                    if (tds1.TransferBuyBook.Rows.Count > 0)
                    {
                        chkFlag = ser.DoInsertData("TransferBuyBook", tds1, 0); //Insert, Update Detail                  
                    }
                }
              
                tds.AcceptChanges();
                tds1.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            isClosed = false;
            LoadData();

            return chkFlag;
        }
        private void BindingDSTransferBuyBook()
        {
            tds1.Clear();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                if (ds2.Tables[0].Rows[i]["RefID"].ToString() == "")
                {
                    DataRow dr = tds1.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RowNum"] = ds2.Tables[0].Rows[i]["RowNum"];
                    dr["RefID1"] = ds2.Tables[0].Rows[i]["RefID1"];
                    dr["BuyBookType"] = ds2.Tables[0].Rows[i]["BuyBookType"];
                    dr["ID"] = 0;

                    SetCreateBy(dr);
                    SetEditBy(dr);

                    tds1.Tables[0].Rows.Add(dr);
                }
            }

            tds1.AcceptChanges();
        }
        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("TransferBuyBook", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool ValidateData()
        {
            message = "";

            //if (txtSender.Text == "")
            //{
            //    message = "Please input Seller.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
                base.EditData();
            }
            else
            {
                RequirePassword frm = new RequirePassword(ApplicationInfo.Shop);
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    SetControlEnable(true);
                    base.EditData();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            SearchTransferBuyBook frm = new SearchTransferBuyBook();
            frm.ShowDialog();

            if (frm.codeSelected != "")
            {
                ser1 = GM.GetService1();

                dsTransferBuyBook tmp = new dsTransferBuyBook();

                ds1 = ser1.GetTransferBuyBookDetail(frm.codeSelected);
                tmp.Clear();
                tmp.Merge(ds1);

                tmp = RemoveRowDuplicate(tmp);

                for (int i = 0; i < tmp.TransferBuyBook.Rows.Count; i++)
                {
                    dsTransferBuyBook.TransferBuyBookRow row = tds1.TransferBuyBook.NewTransferBuyBookRow();
                    row.RefID = id;
                    row.RefID1 = tmp.TransferBuyBook[i].RefID1;
                    row.Code = tmp.TransferBuyBook[i].Code;          
                    row.Weight = tmp.TransferBuyBook[i].Weight;
                    row.JewelryTypeName = tmp.TransferBuyBook[i].JewelryTypeName;
                    row.ShapeName = tmp.TransferBuyBook[i].ShapeName;
                    row.ColorTypeName = tmp.TransferBuyBook[i].ColorTypeName;
                    row.ColorName = tmp.TransferBuyBook[i].ColorName;
                    row.TotalBaht = tmp.TransferBuyBook[i].TotalBaht;
                    row.BuyBookType = tmp.TransferBuyBook[i].BuyBookType;
                    tds1.TransferBuyBook.Rows.Add(row);
                }

                tds1.AcceptChanges();
                gridTransfer.DataSource = tds1.TransferBuyBook;
                gridTransfer.Refresh();
            }
        }

        private dsTransferBuyBook RemoveRowDuplicate(dsTransferBuyBook temp)
        {
            for (int i = 0; i < temp.TransferBuyBook.Rows.Count; i++)
            {
                for (int j = 0; j < gridTransfer.Rows.Count; j++)
                {
                    if (temp.TransferBuyBook.Rows[i]["RefID1"].ToString() == gridTransfer.Rows[j].Cells["RefID1"].Value.ToString() &&
                        temp.TransferBuyBook.Rows[i]["BuyBookType"].ToString() == gridTransfer.Rows[j].Cells["BuyBookType"].Value.ToString())
                    {
                        temp.TransferBuyBook.Rows[i].Delete();
                        i--;
                        temp.AcceptChanges();
                        break;
                    }
                }
            }

            return temp;
        }

        private void SetFormatNumber()
        {
            //ดักเคส MinValue
            if (txtReceivedDate.Text != "" && Convert.ToDateTime(txtReceivedDate.Text).Year == 1901)
            {
                txtReceivedDate.Text = "";
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int delID = 0;

            if (rowIndex > -1)
            {
                delID = (int)gridTransfer.Rows[rowIndex].Cells["ID"].Value;
                tds1.TransferBuyBook.Rows.RemoveAt(rowIndex);

                tds1.AcceptChanges();
                gridTransfer.Refresh();

                if (delID != 0)
                {
                    ser.DoDeleteData("TransferBuyBook", delID);
                }
            }
        }

        private void SetControlEnable(bool status)
        {
            txtSender.Enabled = status;
            cmbReceiver.Enabled = status;
            cmbEShop.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            txtNote.Enabled = status;
        }

        private void gridTransfer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                if (gridTransfer.Rows[e.RowIndex].Cells["ID"].Value != null)
                { DelID = Convert.ToInt32(gridTransfer.Rows[e.RowIndex].Cells["ID"].Value.ToString()); }
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.UpdateTransferReceive(id,(int)cmbEShop.SelectedValue);
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.ReportDelivery report = new Report.ReportDelivery(id);
            report.ShowDialog();
        }
    }
}
