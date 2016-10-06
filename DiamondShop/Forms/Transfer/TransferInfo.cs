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
    public partial class TransferInfo : FormInfo
    {
        Service2 ser1;
        dsTransfer tds = new dsTransfer();
        dsTransferDetail tds2 = new dsTransferDetail();
        //dsWarningTransfer tds3 = new dsWarningTransfer();
        DataSet tmp = new DataSet();
        bool isAuthorize = false;
        DataSet ds2 = new DataSet();
        int chk = 0;
        int rowIndex, rowIndex1;
        int refID1 = 0;
        dsTransferBuyBook tds1 = new dsTransferBuyBook();
        public Service3 ser2;
        int shop;
        int flag;

        public TransferInfo()
        {
            InitializeComponent();
            Initial();
            BinderData();
            txtTransferStatus.Text = "Send";
            txtSender.Text = ApplicationInfo.DisplayName;
            txtSShop.Text = ApplicationInfo.ShopName;
        }
        public TransferInfo(int id)
        {
            InitializeComponent();
            Initial();
            BinderData();

            btnAdd.Enabled = true;
            btnDel.Enabled = true;

            this.id = id;
            LoadData();
            SetControlEnable(false);
            SetPermission();
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
            SetFieldService.SetRequireField(txtSender);
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

            ds2 = ser.DoSelectData("TransferDetail", id, 0);
            tds1.Clear();
            tds1.Merge(ds2);

            if (tds.Transfer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Transfer[0]);
                txtReceivedDate.Text = string.Format("{0:d/M/yyyy}", tds.Transfer[0]["ReceiveDate"]);

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }

            if (ds2.Tables[0].Rows.Count > 0)
            {
                gridTransfer.DataSource = ds2.Tables[0];
                gridTransfer.Refresh();
            }

            SetFormatNumber();
            base.LoadData();
        }
        protected override bool SaveData()
        {
            dsTransfer.TransferRow row = null;
            //dsWarningTransfer.WarningTransferRow row2 = null;

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
            row.TransferStatus = 222;
            row.Sender = Convert.ToInt32(ApplicationInfo.UserID.ToString());
            row.ReceiveDate = DateTime.MinValue.AddYears(1900);
            row.IsBuyBook = "1";
            row.SShop = ApplicationInfo.Shop;

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    row.TransferNo = GM.GetRunningNumber("TRF");
                    chkFlag = ser.DoInsertData("Transfer", tds, 0);

                }
                else
                {
                    //Receiver 
                    if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
                    {
                        row.TransferStatus = 223; //สถานะ received
                        row.ReceiveDate = Convert.ToDateTime(DateTime.Now.ToString());
                    }
                    SetEditBy(row);
                    
                    BindingDSOrderDetail();
                    if (tds2.TransferDetail.Rows.Count > 0)
                    {
                        chkFlag = ser.DoInsertData("TransferDetail", tds2, 0);
                    }
                    else
                    {
                        chkFlag = ser.DoUpdateData("Transfer", tds);
                    }

                }
                tds.AcceptChanges();

                if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
                {
                    btnPrint.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        private void BindingDSOrderDetail()
        {
            tds2.Clear();
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                if (ds2.Tables[0].Rows[i]["ID"].ToString() == "")
                {
                    DataRow dr = tds2.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RowNum"] = ds2.Tables[0].Rows[i]["RowNum"];
                    dr["RefID1"] = ds2.Tables[0].Rows[i]["RefID1"];
                    dr["flag"] = ds2.Tables[0].Rows[i]["Flag"];
                    //Sender
                    if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) != ApplicationInfo.UserID)
                    {
                        dr["EShop"] = ds2.Tables[0].Rows[i]["Shop"];//Shop BuyBook
                        dr["Status"] = 255;//Reserved
                    }
                    //Receiver 
                    if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
                    {
                        dr["EShop"] = shop;//shop ฝั่งรับ
                        dr["Status"] = 73; //Available
                    }
                    
                    SetCreateBy(dr);
                    SetEditBy(dr);

                    tds2.Tables[0].Rows.Add(dr);
                }
            }

            tds2.AcceptChanges();
        }
        protected override bool DeleteData()
        {
            try
            {
                if (chk == 0)
                {
                    chkFlag = ser.DoDeleteData("Transfer", id);
                }
                else if (chk == 1)
                {
                    chkFlag = ser.DoDeleteData("TransferDetail", Convert.ToInt32(gridTransfer.SelectedRows[0].Cells["ID"].Value));

                    chk = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            LoadData();

            return chkFlag;
        }
        protected override bool ValidateData()
        {
            message = "";

            if (txtSender.Text == "")
            {
                message = "Please input Seller.\n";
            }

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
            shop = ApplicationInfo.Shop;
            TransferBuyBookDetail frm = new TransferBuyBookDetail();
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser2.DoSearchTransferBuyBook(shop, "", "", 0);
                tds1.Clear();
                tds1.Merge(tmp);

                DataRow dr = ds2.Tables[0].NewRow();
                dr["Code"] = tds1.Tables[0].Rows[0]["Code"];
                dr["Weight"] = tds1.Tables[0].Rows[0]["Weight"];
                dr["JewelryTypeName"] = tds1.Tables[0].Rows[0]["JewelryTypeName"];
                dr["ShapeName"] = tds1.Tables[0].Rows[0]["ShapeName"];
                dr["ColorTypeName"] = tds1.Tables[0].Rows[0]["ColorTypeName"];
                dr["ColorName"] = tds1.Tables[0].Rows[0]["ColorName"];
                dr["TotalBaht"] = tds1.Tables[0].Rows[0]["TotalBaht"];
                dr["Flag"] = tds1.Tables[0].Rows[0]["Flag"];
                dr["RefID1"] = tds1.Tables[0].Rows[0]["ID"];
                dr["EShop"] = tds1.Tables[0].Rows[0]["Shop"];
                ds2.Tables[0].Rows.Add(dr);
                gridTransfer.DataSource = ds2.Tables[0];
                gridTransfer.RefreshEdit();
            }
        }
        private bool CheckDataExist(int tmp)
        {
            if (gridTransfer.Rows.Count > 0)
            {
                for (int i = 0; i < gridTransfer.Rows.Count; i++)
                {
                    if (tmp == Convert.ToInt32(gridTransfer.Rows[i].Cells["RefID1"].Value))
                    {
                        return false;
                    }
                }
            }
            return true;
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
            if (gridTransfer.SelectedRows.Count > 0)
            {
                chk = 1;
                DeleteData();
            }
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) != ApplicationInfo.UserID)
            {
                chk = 2;
                DeleteData();
            }
        }
        private void SetControlEnable(bool status)
        {
            dtSendDate.Enabled = status;
            txtSender.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            gridTransfer.Enabled = status;
        }
        private void btnRecieve_Click(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            txtReceivedDate.Text = DateTime.Now.ToString();
            txtTransferStatus.Text = "Received";
            flag = 1;
            ser1.UpdateMessageStatus(id, "2", "1");
        }
        private void SetPermission()
        {
            //Receiver
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
            {
                btnRecieve.Enabled = true;
                btnPrint.Enabled = true;
            }
        }
    }
}
