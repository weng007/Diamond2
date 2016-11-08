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
using DiamondShop.DiamondService2;

namespace DiamondShop
{
    public partial class TransferInventory : FormInfo
    {
        Service3 ser2;

        dsTransfer tds = new dsTransfer();
        dsTransferInventory tds1 = new dsTransferInventory();
        dsTransferDetail tds2 = new dsTransferDetail();
        dsCatalog tdsCatalog = new dsCatalog();

        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();

        bool isAuthorize = false;
        
        int chk = 0;
        int rowIndex = 0;
        int DelID;
        
        public TransferInventory()
        {
            InitializeComponent();
            Initial();
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

            btnAdd.Enabled = true;
            btnDel.Enabled = true;

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
            SetFieldService.SetRequireField(txtSender);
            gridTransferInventory.AutoGenerateColumns = false;
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

            ds2 = ser.DoSelectData("TransferDetail", id, 1);
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
                gridTransferInventory.DataSource = ds2.Tables[0];
                gridTransferInventory.Refresh();
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
            
            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    row.Sender = row.CreateBy;
                    row.SShop = ApplicationInfo.Shop;
                    row.IsBuyBook = "0";
                    row.ReceiveDate = DateTime.MinValue.AddYears(1900);
                    row.TransferNo = GM.GetRunningNumber("TRF");
                    chkFlag = ser.DoInsertData("Transfer", tds, 0);

                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Transfer", tds);

                    BindingDSTransferInventory();

                    if (tds2.TransferDetail.Rows.Count > 0)
                    {
                        chkFlag = ser.DoInsertData("TransferDetail", tds2, 0);
                    }
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        private void BindingDSTransferInventory()
        {
            tds2.Clear();
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                if (ds2.Tables[0].Rows[i]["RowNum"].ToString() == "")
                {
                    DataRow dr = tds2.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RowNum"] = ds2.Tables[0].Rows[i]["RowNum"];
                    dr["RefID1"] = ds2.Tables[0].Rows[i]["RefID1"];
                    dr["JewelryType"] = ds2.Tables[0].Rows[i]["JewelryType"];
                
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
                    chkFlag = ser.DoDeleteData("Transfer", DelID);
                }
                else if (chk == 1)
                {
                    chkFlag = ser.DoDeleteData("TransferDetail", Convert.ToInt32(gridTransferInventory.SelectedRows[0].Cells["ID"].Value));

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

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser2.DoSearchTransferInventory(ApplicationInfo.Shop, "", 0);
                tds1.Clear();
                tds1.Merge(tmp);

                DataRow dr = ds2.Tables[0].NewRow();
                dr["Code"] = tds1.Tables[0].Rows[0]["Code"];
                dr["Amount1"] = tds1.Tables[0].Rows[0]["Amount1"];
                dr["Weight1"] = tds1.Tables[0].Rows[0]["Weight1"];
                dr["Amount3"] = tds1.Tables[0].Rows[0]["Amount3"];
                dr["Weight3"] = tds1.Tables[0].Rows[0]["Weight3"];
                dr["MinPrice"] = tds1.Tables[0].Rows[0]["MinPrice"];
                dr["JewelryTypeName"] = tds1.Tables[0].Rows[0]["JewelryTypeName"];
                dr["JewelryType"] = tds1.Tables[0].Rows[0]["JewelryType"];
                dr["RefID1"] = tds1.Tables[0].Rows[0]["ID"];
                dr["EShop"] = tds1.Tables[0].Rows[0]["Shop"];
                ds2.Tables[0].Rows.Add(dr);
                gridTransferInventory.DataSource = ds2.Tables[0];
                gridTransferInventory.RefreshEdit();
            }
        }
        private bool CheckDataExist(int tmp)
        {
            if (gridTransferInventory.Rows.Count > 0)
            {
                for (int i = 0; i < gridTransferInventory.Rows.Count; i++)
                {
                    if (tmp == Convert.ToInt32(gridTransferInventory.Rows[i].Cells["ID"].Value))
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
            if (gridTransferInventory.SelectedRows.Count > 0)
            {
                chk = 1;
                DeleteData();
            }
        }

        private void gridTransferInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                if (gridTransferInventory.Rows[e.RowIndex].Cells["ID"].Value != null)
                { DelID = Convert.ToInt32(gridTransferInventory.Rows[e.RowIndex].Cells["ID"].Value.ToString()); }
            }
        }

        private void SetControlEnable(bool status)
        {
            dtSendDate.Enabled = status;
            txtSender.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            gridTransferInventory.Enabled = status;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
