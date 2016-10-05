using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class ReceiveDocument : FormInfo
    {
        Service2 ser1;
        dsReceiveDocument tds = new dsReceiveDocument();
        int custID = 0;
        int refID = 0;
        bool isAuthorize = false;
        MemoryStream ms1;
        MemoryStream ms2;
        byte[] image1, image2;
        int ID;

        public ReceiveDocument()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtReceiveNo, "ReceiveNo");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(dtReceiveDate, "ReceiveDate");
            binder.BindControl(txtNote, "Detail");

            cmbReceiver.SelectedValue = ApplicationInfo.UserID;
            cmbShop.SelectedValue = ApplicationInfo.Shop;
        }
        public ReceiveDocument(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtReceiveNo, "ReceiveNo");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtSeller, "Seller");
            binder.BindControl(dtReceiveDate, "ReceiveDate");
            binder.BindControl(txtNote, "Detail");

            this.id = id;
            SetControlEnable(false);
            LoadData();
            isEdit = false;
        }
        protected override void Initial()
        {
            ds = GM.GetBuyer();
            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbReceiver.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            SetFieldService.SetRequireField(txtSeller);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("ReceiveDocument", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.ReceiveDocument.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.ReceiveDocument[0]);

                if (tds.ReceiveDocument[0].Image1 != null)
                {
                    image1 = tds.ReceiveDocument[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (tds.ReceiveDocument[0].Image2 != null)
                {
                    image2 = tds.ReceiveDocument[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }
                ID = tds.ReceiveDocument[0].ID;

                EnableSave = false;
                EnableEdit = GM.CheckIsEdit(ApplicationInfo.Shop, Convert.ToInt16(cmbShop.SelectedValue.ToString()));
                EnableDelete = true;
            }
            base.LoadData();

        }
        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
                SetControlEnable(true);
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
        private void SetControlEnable(bool status)
        {
            txtReceiveNo.Enabled = status;
            txtSeller.Enabled = status;
            dtReceiveDate.Enabled = status;
            cmbReceiver.Enabled = status;
            cmbShop.Enabled = status;
            txtNote.Enabled = status;
        }
        protected override bool SaveData()
        {
            dsReceiveDocument.ReceiveDocumentRow row = null;

            if (tds.ReceiveDocument.Rows.Count > 0)
            {
                row = tds.ReceiveDocument[0];
            }
            else
            {
                row = tds.ReceiveDocument.NewReceiveDocumentRow();
                tds.ReceiveDocument.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);
            row.Image1 = image1;
            row.Image2 = image2;

            try
            {
                if (id == 0)
                {
                    row.ReceiveNo = GM.GetRunningNumber("REC");
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("ReceiveDocument", tds,0);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("ReceiveDocument", tds);
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
                    chkFlag = ser.DoDeleteData("ReceiveDocument", id);
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

            if (txtSeller.Text == "")
            {
                message = "Please input Seller.\n";
            }
            //if (txtNetPrice.Text == "" || GM.ConvertStringToDouble(txtNetPrice) == 0)
            //{
            //    message += "Please Input NetPrice > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportReceiveDocumentList frm = new ReportReceiveDocumentList(ID);
            frm.ShowDialog();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbSeller_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnImage1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image1 = new byte[fs.Length];
                fs.Read(image1, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image2 = new byte[fs.Length];
                fs.Read(image2, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void dtSellDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
    }
}
