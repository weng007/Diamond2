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

        public TransferInfo()
        {
            InitializeComponent();
            Initial();
            BinderData();


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

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

            cmbTransferStatus.DataSource = (GM.GetMasterTableDetail("C035")).Tables[0];
            cmbTransferStatus.ValueMember = "ID";
            cmbTransferStatus.DisplayMember = "Detail";
            cmbTransferStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtSender.Select();
            SetFieldService.SetRequireField(txtSender);
        }

        private void BinderData()
        {
            binder.BindControl(dtSendDate, "SendDate");
            binder.BindControl(dtReceiveDate, "ReceiveDate");
            binder.BindControl(txtSender, "Sender");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(cmbTransferStatus, "TransferStatus");
            binder.BindControl(cmbShop, "EShop");
            binder.BindControl(txtNote, "Note");
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("Transfer", id, 0);
            tds.Clear();
            tds.Merge(ds);

            ds2 = ser.DoSelectData("transferDetail", id, 0);
            tds2.Clear();
            tds2.Merge(ds2);

            if (tds.Transfer.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Transfer[0]);

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            //if (tds.BBSetting[0]["IsPaid"].ToString() == "0")
            //{
            //    rdoYes.Checked = false;
            //    rdoNo.Checked = true;
            //}
            //else
            //{
            //    rdoYes.Checked = true;
            //    rdoNo.Checked = false;
            //}

            if (tds2.TransferDetail.Rows.Count > 0)
            {
                BindingGridBBSettingDetail();
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
            //row.IsPaid = rdoYes.Checked ? "1" : "0";
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
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
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
                RequirePassword frm = new RequirePassword("2");
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
            //BuyBookSettingDetail frm = new BuyBookSettingDetail(id, 0);
            //frm.ShowDialog();

            //LoadData();
            CatalogList frm = new CatalogList(1);
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1))
            {
                tmp = ser.DoSelectData("Catalog", frm.refID1, 0);
                tdsCatalog.Clear();
                tdsCatalog.Merge(tmp);

                gridTransfer.Rows.Add();
                rowIndex = gridTransfer.Rows.GetLastRow(DataGridViewElementStates.Displayed);

                gridTransfer.Rows[rowIndex].Cells["Code"].Value = tdsCatalog.Tables[0].Rows[0]["Code"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount1"].Value = tdsCatalog.Tables[0].Rows[0]["Amount1"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight1"].Value = tdsCatalog.Tables[0].Rows[0]["Weight1"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount2"].Value = tdsCatalog.Tables[0].Rows[0]["Amount2"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight2"].Value = tdsCatalog.Tables[0].Rows[0]["Weight2"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount3"].Value = tdsCatalog.Tables[0].Rows[0]["Amount3"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight3"].Value = tdsCatalog.Tables[0].Rows[0]["Weight3"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount4"].Value = tdsCatalog.Tables[0].Rows[0]["Amount4"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight4"].Value = tdsCatalog.Tables[0].Rows[0]["Weight4"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount5"].Value = tdsCatalog.Tables[0].Rows[0]["Amount5"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight5"].Value = tdsCatalog.Tables[0].Rows[0]["Weight5"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Amount6"].Value = tdsCatalog.Tables[0].Rows[0]["Amount6"].ToString();
                gridTransfer.Rows[rowIndex].Cells["Weight6"].Value = tdsCatalog.Tables[0].Rows[0]["Weight6"].ToString();
                gridTransfer.Rows[rowIndex].Cells["CatID"].Value = tdsCatalog.Tables[0].Rows[0]["ID"].ToString();

                tds.Tables[0].Rows.Add();
                tds.Tables[0].Rows[rowIndex]["CatID"] = tdsCatalog.Tables[0].Rows[0]["ID"].ToString(); ;

                tds.AcceptChanges();
            }
        }
        private bool CheckDataExist(int tmp)
        {
            if (gridTransfer.Rows.Count > 0)
            {
                for (int i = 0; i < gridTransfer.Rows.Count; i++)
                {
                    if (tmp == Convert.ToInt32(gridTransfer.Rows[i].Cells["CatID"].Value))
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
            //txtBuyPrice.Text = GM.ConvertDoubleToString(txtBuyPrice, 0);
            //txtSalePrice.Text = GM.ConvertDoubleToString(txtSalePrice, 0);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridTransfer.SelectedRows.Count > 0)
            {
                chk = 1;
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
            cmbReceiver.Enabled = status;
        }
    }
}
