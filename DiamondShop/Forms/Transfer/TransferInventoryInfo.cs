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
    public partial class TransferInventoryInfo : FormInfo
    {
        dsTransfer tds = new dsTransfer();
        dsTransferDetail tds2 = new dsTransferDetail();
        dsCatalog tdsCatalog = new dsCatalog();
        DataSet tmp = new DataSet();
        bool isAuthorize = false;
        DataSet ds2 = new DataSet();
        int chk = 0;
        int rowIndex, rowIndex1;
        int refID1 = 0;
        dsTransferInventory tds1 = new dsTransferInventory();
        public Service3 ser2;
        int shop;

        public TransferInventoryInfo()
        {
            InitializeComponent();
            Initial();
            BinderData();
            txtTransferStatus.Text = "Send";
            txtSender.Text = ApplicationInfo.DisplayName;
            txtSShop.Text = ApplicationInfo.ShopName;
        }
        public TransferInventoryInfo(int id)
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
            gridTransferINV.AutoGenerateColumns = false;
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
                gridTransferINV.DataSource = ds2.Tables[0];
                gridTransferINV.Refresh();
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
            row.TransferStatus = 256;
            row.Sender = Convert.ToInt32(ApplicationInfo.UserID.ToString());
            row.ReceiveDate = DateTime.MinValue.AddYears(1900);
            row.IsBuyBook = "0";
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
                        row.TransferStatus = 254; //สถานะ received
                        row.ReceiveDate = Convert.ToDateTime(DateTime.Now.ToString());
                    }
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Transfer", tds);

                    BindingDSOrderDetail();
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

        private void BindingDSOrderDetail()
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
                    //Sender
                    if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) != ApplicationInfo.UserID)
                    {
                        dr["EShop"] = ds2.Tables[0].Rows[i]["Shop"];//Shop Inventory
                        dr["Status"] = 255;//Reserved
                    }
                    //Receiver 
                    if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
                    {
                        dr["EShop"] = 239;//shop ฝั่งรับ
                        dr["Status"] = 73; //Available
                    }
                    SetCreateBy(dr);
                    SetEditBy(dr);

                    tds2.Tables[0].Rows.Add(dr);
                }
            }

            tds2.AcceptChanges();
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
            {
                btnPrint.Visible = true;
            }
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
                    chkFlag = ser.DoDeleteData("TransferDetail", Convert.ToInt32(gridTransferINV.SelectedRows[0].Cells["ID"].Value));

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
                RequirePassword frm = new RequirePassword("2",0);
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

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();
            shop = ApplicationInfo.Shop;
            TransferInventoryDetail frm = new TransferInventoryDetail();
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser2.DoSearchTransferInventory(shop, "", 0);
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
                gridTransferINV.DataSource = ds2.Tables[0];
                gridTransferINV.RefreshEdit();
            }
        }
        private bool CheckDataExist(int tmp)
        {
            if (gridTransferINV.Rows.Count > 0)
            {
                for (int i = 0; i < gridTransferINV.Rows.Count; i++)
                {
                    if (tmp == Convert.ToInt32(gridTransferINV.Rows[i].Cells["ID"].Value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void gridSetting_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (gridTransfer.SelectedRows.Count > 0)
            //{
            //    BuyBookSettingDetail frm = new BuyBookSettingDetail(id, 1);
            //    frm.ShowDialog();

            //    LoadData();
            //}
        }

        private void gridSetting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 ||
                e.ColumnIndex == 8) && e.RowIndex != this.gridTransferINV.NewRowIndex && e.Value != null
                && e.Value.ToString() != "")
            {
                double d = double.Parse(e.Value.ToString());

                if (e.ColumnIndex != 5) { e.Value = d.ToString("N0"); }
                else { e.Value = d.ToString("N2"); }
            }
        }

        private void txtBuyPrice_Leave(object sender, EventArgs e)
        {
            //txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
        }

        private void txtSalePrice_Leave(object sender, EventArgs e)
        {
            //txtSalePrice.Text = GM.ConvertDoubleToString(txtSalePrice, 0);
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
            if (gridTransferINV.SelectedRows.Count > 0)
            {
                chk = 1;
                DeleteData();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTransferStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetControlEnable(bool status)
        {
            dtSendDate.Enabled = status;
            txtSender.Enabled = status;
            btnAdd.Enabled = status;
            btnDel.Enabled = status;
            gridTransferINV.Enabled = status;
        }
    }
}
