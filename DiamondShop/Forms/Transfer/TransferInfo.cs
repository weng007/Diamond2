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
    public partial class TransferInfo : FormInfo
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
        dsTransferBuyBook tds1 = new dsTransferBuyBook();
        public Service3 ser2;
        int shop;

        public TransferInfo()
        {
            InitializeComponent();
            Initial();
            BinderData();
            txtTransferStatus.Text = "Send";
            txtSender.Text = ApplicationInfo.DisplayName;
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
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            //cmbReceiver.DataSource = ds.Tables[0];
            //cmbReceiver.ValueMember = "ID";
            //cmbReceiver.DisplayMember = "DisplayName";
            //cmbReceiver.Refresh();

            cmbSShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbSShop.ValueMember = "ID";
            cmbSShop.DisplayMember = "Detail";
            cmbSShop.Refresh();

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
            binder.BindControl(txtTransferStatus, "TransferStatusName");
            binder.BindControl(cmbSShop, "SShop");
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

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Transfer", tds, 0);

                }
                else
                {
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
                if (ds2.Tables[0].Rows[i]["ID"].ToString() == "")
                {
                    DataRow dr = tds2.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RowNum"] = ds2.Tables[0].Rows[i]["RowNum"];
                    dr["RefID1"] = ds2.Tables[0].Rows[i]["RefID1"];
                    dr["flag"] = ds2.Tables[0].Rows[i]["Flag"];
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

        private void BindingGridBBSettingDetail()
        {
            int i = 0;
            gridTransfer.Rows.Clear();

            foreach (DataRow row in tds2.Tables[0].Rows)
            {
                gridTransfer.Rows.Add();
                gridTransfer.Rows[i].Cells["RowNum"].Value = row["RowNum"].ToString();
                gridTransfer.Rows[i].Cells["ID"].Value = row["ID"].ToString();
                gridTransfer.Rows[i].Cells["Code"].Value = row["Code"].ToString();
                gridTransfer.Rows[i].Cells["Material1Name"].Value = row["Material1Name"].ToString();
                gridTransfer.Rows[i].Cells["MaterialWeight"].Value = row["MaterialWeight"].ToString();
                gridTransfer.Rows[i].Cells["Material2Name"].Value = row["Material2Name"].ToString();
                gridTransfer.Rows[i].Cells["MaterialWeight2"].Value = row["MaterialWeight2"].ToString();
                gridTransfer.Rows[i].Cells["Detail"].Value = row["Detail"].ToString();

                i++;
            }
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
                e.ColumnIndex == 8) && e.RowIndex != this.gridTransfer.NewRowIndex && e.Value != null
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
            if (gridTransfer.SelectedRows.Count > 0)
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
            gridTransfer.Enabled = status;
        }
    }
}
