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
    public partial class TransferInventory : FormInfo
    {
        Service2 ser1;
        Service3 ser2;
        dsTransfer tds = new dsTransfer();
        dsTransferInventory tds1 = new dsTransferInventory();
     
        DataSet tmp = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();

        bool isAuthorize = false;
        int rowIndex;
        int DelID;

        public TransferInventory()
        {
            InitializeComponent();
            Initial();
            isAuthorize = true;

            BinderData();

            txtTransferStatus.Text = "Send";
            txtSender.Text = ApplicationInfo.DisplayName;
            txtSShop.Text = ApplicationInfo.ShopName;
        }
        public TransferInventory(int id)
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

            ds2 = ser.DoSelectData("TransferInventory", id, 0);
            tds1.Clear();
            tds1.Merge(ds2);

            if (tds.Transfer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Transfer[0]);
                txtReceivedDate.Text = string.Format("{0:d/M/yyyy}", tds.Transfer[0]["ReceiveDate"]);

                if (!isAuthorize)
                {
                    EnableSave = false;
                    EnableEdit = (ApplicationInfo.ShopName == txtSShop.Text)?true:false;
                    EnableDelete = false;
                }

                //Receiver 
                if (cmbEShop.SelectedValue.ToString() == ApplicationInfo.Shop.ToString())
                {
                    SetControlEnable(false);
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
            dsTransferInventory.TransferInventoryRow row1 = null;

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
            row.IsBuyBook = "0";           
            
            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    row.Sender = row.CreateBy;
                    row.SShop = ApplicationInfo.Shop;
                    row.TransferNo = GM.GetRunningNumber("TRF");
                    row.ReceiveDate = DateTime.MinValue.AddYears(1900);
                    row.TransferStatus = 222;
                    chkFlag = ser.DoInsertData("Transfer", tds, 0);

                    if (chkFlag)
                    {
                        ser1 = GM.GetService1();
                        id = ser1.DoSearchTransferByCode(row.TransferNo);

                        SetControlEnable(true);
                        isAuthorize = true;
                    }
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Transfer", tds);

                    if (tds1.TransferInventory.Rows.Count > 0)
                    {
                        chkFlag = ser.DoInsertData("TransferInventory", tds1, 0); //Insert, Update Detail                  
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
 
        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("TransferInventory", id);
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

            SearchTransferInventory frm = new SearchTransferInventory();
            frm.ShowDialog();

            if (frm.idSelected != "")
            {
                ser1 = GM.GetService1();

                dsTransferInventory tmp = new dsTransferInventory();

                ds1 = ser1.GetTransferInventoryDetail(frm.idSelected);
                tmp.Clear();
                tmp.Merge(ds1);

                tmp = RemoveRowDuplicate(tmp);

                for (int i = 0; i < tmp.TransferInventory.Rows.Count; i++)
                {
                    dsTransferInventory.TransferInventoryRow row = tds1.TransferInventory.NewTransferInventoryRow();
                    row.RefID = id;
                    row.RefID1 = tmp.TransferInventory[i].RefID1;
                    row.Code = tmp.TransferInventory[i].Code;                        
                    row.JewelryTypeName = tmp.TransferInventory[i].JewelryTypeName;
                    row.Amount1 = tmp.TransferInventory[i].Amount1;
                    row.Weight1 = tmp.TransferInventory[i].Weight1;
                    row.Amount2 = tmp.TransferInventory[i].Amount2;
                    row.Weight2 = tmp.TransferInventory[i].Weight2;
                    row.Weight = tmp.TransferInventory[i].Weight;
                    row.PriceTag = tmp.TransferInventory[i].PriceTag;
                    row.BuyBookType = tmp.TransferInventory[i].BuyBookType;
                    row.CreateBy = ApplicationInfo.UserID;
                    row.EditBy = ApplicationInfo.UserID;
                    tds1.TransferInventory.Rows.Add(row);
                }

                tds1.AcceptChanges();
                gridTransfer.DataSource = tds1.TransferInventory;
                gridTransfer.Refresh();

                isEdit = true;
            }
        }

        private dsTransferInventory RemoveRowDuplicate(dsTransferInventory temp)
        {
            for (int i = 0; i < temp.TransferInventory.Rows.Count; i++)
            {
                for (int j = 0; j < gridTransfer.Rows.Count; j++)
                {
                    if (temp.TransferInventory.Rows[i]["RefID1"].ToString() == gridTransfer.Rows[j].Cells["RefID1"].Value.ToString() &&
                        temp.TransferInventory.Rows[i]["BuyBookType"].ToString() == gridTransfer.Rows[j].Cells["BuyBookType"].Value.ToString())
                    {
                        temp.TransferInventory.Rows[i].Delete();
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
                tds1.TransferInventory.Rows.RemoveAt(rowIndex);

                tds1.AcceptChanges();
                gridTransfer.Refresh();

                if (delID != 0)
                {
                    ser.DoDeleteData("TransferInventory", delID);
                }
            }

            isEdit = true;
        }

        private void SetControlEnable(bool status)
        {
            txtSender.Enabled = status;
            cmbReceiver.Enabled = status;
            cmbEShop.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            txtNote.Enabled = status;
            btnPrint.Enabled = status;
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
            ser1.UpdateTransferReceive(id, Convert.ToInt32(cmbEShop.SelectedValue.ToString()));
            LoadData();

            isEdit = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.ReportDelivery report = new Report.ReportDelivery(id);
            report.ShowDialog();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
