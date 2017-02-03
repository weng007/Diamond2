using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DiamondShop.FormMaster;
using DiamondDS.DS;
using DiamondShop.DiamondService;
using System.Data.OleDb;
using System.Data.SqlClient;
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class OrderInfo : FormInfo
    {
        Service2 ser1;
        DiamondDS.DS.dsOrder tds = new DiamondDS.DS.dsOrder();
        dsWarning tds2 = new dsWarning();
        bool isAuthorize = false;
        int custID = 0;
        int InvID = 0;
        int InvID1 = 0;
        int FactoryStatus;
        MemoryStream ms1;
        MemoryStream ms2;
        MemoryStream ms3;
        MemoryStream ms4;
        MemoryStream ms5;
        byte[] image1, image2, image3, image4, image5;
        public string materail = "";
        public int WarningID = 0;
        public int OrderID;

        public OrderInfo()
        {
            InitializeComponent();
            Initial();
            isAuthorize = true;
           
            BinderControl();
        }
        public OrderInfo(int id, int WarningID)
        {
            InitializeComponent();
            Initial();
            ds = ser1.GetFactoryStatus(id);
            tds.Clear();
            tds.Merge(ds);
            if (tds.Order[0].FactoryStatus == 218)
            {
                btnNotYet.Image = imageList1.Images[0];
            }
            if (tds.Order[0].FactoryStatus == 219)
            {
                btnProcessing.Image = imageList1.Images[1];
            }
            if (tds.Order[0].FactoryStatus == 220)
            {
                btnMounting.Image = imageList1.Images[2];
            }
            if (tds.Order[0].FactoryStatus == 221)
            {
                btnJobDone.Image = imageList1.Images[3];
            }

            BinderControl();

            this.id = id;
            this.WarningID = WarningID;
            FactoryStatus = tds.Order[0].FactoryStatus;
            btnDiamond.Enabled = true;

            LoadData();
            SetControlEnable(false);
            //ปิดเปิดปุ่ม Confirm, Print ใบสั่งงาน และสร้าง Inventory
            SetMode();

            isEdit = false;
        }

        protected override void Initial()
        {
            ser1 = GM.GetService1();
            ds = GM.GetBuyer();

            cmbSeller.DataSource = ds.Tables[0];
            cmbSeller.ValueMember = "ID";
            cmbSeller.DisplayMember = "DisplayName";
            cmbSeller.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbSeller.Refresh();

            cmbQuality.DataSource = (GM.GetMasterTableDetail("C031")).Tables[0];
            cmbQuality.ValueMember = "ID";
            cmbQuality.DisplayMember = "Detail";
            cmbQuality.Refresh();

            cmbJewelryType.DataSource = (GM.GetMasterTableDetail("C015")).Tables[0];
            cmbJewelryType.ValueMember = "ID";
            cmbJewelryType.DisplayMember = "Detail";
            cmbJewelryType.Refresh();

            cmbMaterial.DataSource = (GM.GetMasterTableDetail("C014")).Tables[0];
            cmbMaterial.ValueMember = "ID";
            cmbMaterial.DisplayMember = "Detail";
            cmbMaterial.Refresh();

            cmbShop1.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop1.ValueMember = "ID";
            cmbShop1.DisplayMember = "Detail";
            cmbShop1.Refresh();

            cmbShop2.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop2.ValueMember = "ID";
            cmbShop2.DisplayMember = "Detail";
            cmbShop2.Refresh();

            dtOrderDate.Select();
            txtShop.Text = ApplicationInfo.ShopName;

            //SetFieldService.SetRequireField(txtWeight, txtPrice, txtRap, txtUSDRate);
        }
        private void BinderControl()
        {
            binder.BindControl(dtOrderDate, "BuyDate");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtOrderNo, "OrderNo");
            binder.BindControl(txtTel, "MobilePhone");
            binder.BindControl(cmbJewelryType, "JewelryType");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(cmbQuality, "Quality");
            binder.BindControl(txtShop, "ShopName");
            binder.BindControl(cmbSeller, "Seller");
            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtCoating, "Coating");
            binder.BindControl(txtLaser, "Laser");
            binder.BindControl(txtOldBody, "OldBody");
            binder.BindControl(dtReceiveDate, "ReceiveDate");
            binder.BindControl(cmbShop1, "Shop1");
            binder.BindControl(dtOrderDate, "OrderDate");
            binder.BindControl(cmbShop2, "Shop2");
            binder.BindControl(txtCustNote, "CustomerNote");
            binder.BindControl(txtImageNote, "ImageNote");
            binder.BindControl(txtThings, "Things");
            binder.BindControl(txtDetail, "Detail");
            binder.BindControl(txtCustNote, "CustomerNote");
            binder.BindControl(txtNote1, "Note1");
            binder.BindControl(txtNote2, "Note2");
            binder.BindControl(txtNote3, "Note3");
            binder.BindControl(txtPrice, "Price");
            binder.BindControl(txtPaid, "Paid");
        }

        protected override void LoadData()
        {
              ds = ser.DoSelectData("Order", id, 0);
              tds.Clear();
              tds.Merge(ds);

              if (tds.Order.Rows.Count > 0)
              {
                binder.BindValueToControl(tds.Order[0]);
                custID = tds.Order[0].CustID;
                txtAppointDate.Text = string.Format("{0:d/M/yyyy}", tds.Order[0]["AppointDate"]);
                txtMountingDate.Text = string.Format("{0:d/M/yyyy}", tds.Order[0]["MountingDate"]);
                txtJobDoneDate.Text = string.Format("{0:d/M/yyyy}", tds.Order[0]["JobDoneDate"]);

                if (tds.Order[0].Image1 != null)
                {
                    image1 = tds.Order[0].Image1;
                    ms1 = new MemoryStream(image1);
                    Image backImage1 = Image.FromStream(ms1);
                    btnImage1.BackgroundImage = backImage1;
                }
                if (tds.Order[0].Image2 != null)
                {
                    image2 = tds.Order[0].Image2;
                    ms2 = new MemoryStream(image2);
                    Image backImage2 = Image.FromStream(ms2);
                    btnImage2.BackgroundImage = backImage2;
                }
                if (tds.Order[0].Image3 != null)
                {
                    image3 = tds.Order[0].Image3;
                    ms3 = new MemoryStream(image3);
                    Image backImage3 = Image.FromStream(ms3);
                    btnImage3.BackgroundImage = backImage3;
                }
                if (tds.Order[0].Image4 != null)
                {
                    image4 = tds.Order[0].Image4;
                    ms4 = new MemoryStream(image4);
                    Image backImage4 = Image.FromStream(ms4);
                    btnImage4.BackgroundImage = backImage4;
                }
                if (tds.Order[0].Image5 != null)
                {
                    image5 = tds.Order[0].Image5;
                    ms5 = new MemoryStream(image5);
                    Image backImage5 = Image.FromStream(ms5);
                    btnImage5.BackgroundImage = backImage5;
                }
                if (tds.Order[0].RefID > 0)
                {
                    linkLabel1.Text = tds.Order[0].Code1;                   
                }
                if (tds.Order[0].RefID1 > 0)
                {
                    linkLabel2.Text = tds.Order[0].Code2;
                }
                
                InvID = tds.Order[0].RefID;
                InvID1 = tds.Order[0].RefID1;
                OrderID = tds.Order[0].ID;

                if (tds.Order[0]["IsHave"].ToString() == "0")
                {
                    rdoHave.Checked = false;
                    rdoNotHave.Checked = true;                  
                }
                else
                {
                    rdoHave.Checked = true;
                    rdoNotHave.Checked = false;
                }

                if (tds.Order[0]["IsReceive"].ToString() == "0")
                {
                    rdoReceive.Checked = false;
                    rdoNotReceive.Checked = true;
                }
                else
                {
                    rdoReceive.Checked = true;
                    rdoNotReceive.Checked = false;
                }
                if (materail != "")
                {
                    txtThings.Text = materail;
                }
              }

            if (!isAuthorize)
            {
                EnableSave = false;
                EnableEdit = ((ApplicationInfo.ShopName == txtShop.Text)?true:false);
                EnableDelete = false;
            }

            if(tds.Order[0].FactoryStatus == 219)
            {
                btnNotYet.Enabled = false;
                btnProcessing.Enabled = true;
            }

            SetFormatNumber();
            base.LoadData();

            cmbJewelryType.SelectedValueChanged += cmbColorType_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            DiamondDS.DS.dsOrder.OrderRow row = null;

            if (tds.Order.Rows.Count > 0)
            {
                row = tds.Order[0];
            }
            else
            {
                row = tds.Order.NewOrderRow();
                tds.Order.Rows.Add(row);
            }

            binder.BindValueToDataRow(row);
            row.CustID = custID;
            row.Image1 = image1;
            row.Image2 = image2;
            row.Image3 = image3;
            row.Image4 = image4;
            row.Image5 = image5;
            row.IsHave = rdoHave.Checked ? "1" : "0";
            row.IsReceive = rdoReceive.Checked ? "1" : "0";

            if (txtAppointDate.Text == "")
            {
                row.AppointDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.AppointDate = Convert.ToDateTime(txtAppointDate.Text.ToString());
            }

            if (txtMountingDate.Text == "")
            {
                row.MountingDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.MountingDate = Convert.ToDateTime(txtMountingDate.Text.ToString());
            }

            if (txtJobDoneDate.Text == "")
            {
                row.JobDoneDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.JobDoneDate = Convert.ToDateTime(txtJobDoneDate.Text.ToString());
            }
            row.RefID = InvID;
            row.RefID1 = InvID1;

            try
            {
                if (id == 0)
                {
                    row.OrderNo = GM.GetRunningNumber("ORD");             
                    row.FactoryStatus = 218; //Not Yet
                    row.Shop = ApplicationInfo.Shop;
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Order", tds, 0);

                    if (chkFlag)
                    {
                        ser1 = GM.GetService1();
                        id = ser1.DoSearchOrderByCode(row.OrderNo);

                        SetControlEnable(true);
                        isAuthorize = true;
                    }
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("Order", tds);
                }

                tds.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //ไม่ให้ปิดหน้าจอหลัง Save
            isClosed = false;
            LoadData();

            return chkFlag;
        }

        protected override bool DeleteData()
        {
            try
            {
                chkFlag = ser.DoDeleteData("Order", id);
                if(!chkFlag)
                { 
                    Popup.Popup pop = new Popup.Popup("Order นี้อยู่ในกระบวนการผลิตแล้วไม่สามารถลบได้");
                    pop.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            isEdit = true;
            return chkFlag;
        }

        protected override void EditData()
        {
            if (isAuthorize)
            {              
                if (FactoryStatus == 218)
                {
                    EnableSave = true;
                    EnableDelete = true;
                    SetControlEnable(true);
                }          
            }
            else
            {
                RequirePassword frm = new RequirePassword(ApplicationInfo.Shop);
                frm.ShowDialog();
                isAuthorize = frm.isAuthorize;
                frm.Close();

                if (isAuthorize)
                {                    
                    if (FactoryStatus == 218)
                    {
                        EnableSave = true;
                        EnableDelete = true;
                        SetControlEnable(true);
                    }
                    
                    base.EditData();
                }
            }
        }

        protected override bool ValidateData()
        {
            message = "";

            //if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            //{
            //    message = "Please Input Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar!='-'))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void SetFormatNumber()
        {
            if (txtAppointDate.Text != "" && Convert.ToDateTime(txtAppointDate.Text).Year == 1901)
            {
                txtAppointDate.Text = "";
            }
            if (txtMountingDate.Text != "" && Convert.ToDateTime(txtMountingDate.Text).Year == 1901)
            {
                txtMountingDate.Text = "";
            }
            if (txtJobDoneDate.Text != "" && Convert.ToDateTime(txtJobDoneDate.Text).Year == 1901)
            {
                txtJobDoneDate.Text = "";
            }

            txtPrice.Text = GM.ConvertDoubleToString(txtPrice, 0);
            txtPaid.Text = GM.ConvertDoubleToString(txtPaid, 0);
        }

        private void SetControlEnable(bool status)
        {
            dtOrderDate.Enabled = status;
            txtCustomer.Enabled = status;
            cmbJewelryType.Enabled = status;
            cmbMaterial.Enabled = status;
            cmbQuality.Enabled = status;
            cmbSeller.Enabled = status;
            txtSize.Enabled = status;
            txtCoating.Enabled = status;
            txtLaser.Enabled = status;
            txtOldBody.Enabled = status;
            txtPaid.Enabled = status;
            dtReceiveDate.Enabled = status;
            cmbShop1.Enabled = status;
            txtAppointDate.Enabled = status;
            cmbShop2.Enabled = status;
            txtDetail.Enabled = status;
            txtPrice.Enabled = status;
            btnBrowseInv.Enabled = status;
            btnBrowseInv1.Enabled = status;
            btnRefDel.Enabled = status;
            btnRefDel1.Enabled = status;

            groupBox1.Enabled = status;
            txtThings.Enabled = status;
            txtCustNote.Enabled = status;
            btnDiamond.Enabled = status;
            btnImage1.Enabled = status;
            btnImage2.Enabled = status;
            btnImage3.Enabled = status;
            btnImage4.Enabled = status;
            btnImage5.Enabled = status;
            txtImageNote.Enabled = status;
        }

        private void txtThings_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void cmbColorType_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void rdoIns1_CheckedChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList(1);
            frm.ShowDialog();

            if (frm.custID != 0)
            {
                custID = frm.custID;
                txtCustomer.Text = frm.customerName;
                txtTel.Text = frm.Tel;
            }
        }
        private void btnBrownInv_Click(object sender, EventArgs e)
        {
            InventoryList frm = new InventoryList(1);
            frm.ShowDialog();
            InvID = frm.InvID;
            linkLabel1.Text = frm.InvCode;
        }
        private void btnBrownInv1_Click(object sender, EventArgs e)
        {
            InventoryList frm = new InventoryList(1);
            frm.ShowDialog();
            InvID1 = frm.InvID;
            linkLabel2.Text = frm.InvCode;
        }
        private void btnDiamond_Click(object sender, EventArgs e)
        {
            OrderDetail frm = new OrderDetail(id,materail);
            frm.ShowDialog();
            txtThings.Text = frm.materail;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory(InvID);
            frm.ShowDialog();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory(InvID1);
            frm.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {          
            btnNotYet.Image = imageList1.Images[4];
            btnProcessing.Image = imageList1.Images[1];

            ser1 = GM.GetService1();
            ser1.UpdateProductionLine(id, 219,ApplicationInfo.UserID);

            btnPrint.Visible = true;
            btnInventory.Visible = true;
            btnDiamond.Enabled = true;
        }

        private void btnRefDel_Click(object sender, EventArgs e)
        {
            ser1.DeleteDataReference(id, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportOrderList frm = new ReportOrderList(OrderID);
            frm.ShowDialog();
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

        private void btnImage3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage3.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image3 = new byte[fs.Length];
                fs.Read(image3, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage4.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image4 = new byte[fs.Length];
                fs.Read(image4, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void btnImage5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnImage5.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                FileStream fs;
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                image5 = new byte[fs.Length];
                fs.Read(image5, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.Text = GM.ConvertDoubleToString(txtPrice, 0);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPaid_Leave(object sender, EventArgs e)
        {
            txtPaid.Text = GM.ConvertDoubleToString(txtPaid, 0);
        }

        private string SetJewelryType()
        {
            string prefixCode = "";

            if (cmbJewelryType.SelectedValue.ToString() == "74")
            {
                prefixCode = "DR";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "75")
            {
                prefixCode = "GR";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "76")
            {
                prefixCode = "DER";
            }           
            else if (cmbJewelryType.SelectedValue.ToString() == "78")
            {
                prefixCode = "GER";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "79")
            {
                prefixCode = "MTO";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "80")
            {
                prefixCode = "PD";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "81")
            {
                prefixCode = "BR";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "82")
            {
                prefixCode = "BL";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "83")
            {
                prefixCode = "NL";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "84")
            {
                prefixCode = "CL";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "85")
            {
                prefixCode = "WR";
            }
            else if (cmbJewelryType.SelectedValue.ToString() == "86")
            {
                prefixCode = "IC";
            }       
            else if (cmbJewelryType.SelectedValue.ToString() == "207")
            {
                prefixCode = "SJ";
            }        

            return prefixCode;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            int invID = ser1.CheckOrderNoExist(txtOrderNo.Text);

            if (invID > 0)
            {
                Inventory frm = new Inventory(invID);
                frm.ShowDialog();
            }
            else
            {
                Inventory frm = new Inventory(SetJewelryType(), txtOrderNo.Text);
                frm.ShowDialog();
            }
        }

        private void btnRefDel1_Click(object sender, EventArgs e)
        {
            ser1.DeleteDataReference(id, 1);
        }

        private void rdoReceive_CheckedChanged(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.UpdateReceiveMaterial(id, (rdoReceive.Checked)?"1":"0");
        }

        private void Note1Status_CheckedChanged(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.UpdateNoteStatus(id, 1, chkNote1Status.Checked ? "1" : "0");
        }

        private void chkNote2Status_CheckedChanged(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.UpdateNoteStatus(id, 2, chkNote2Status.Checked ? "1" : "0");
        }

        private void chkNote3Status_CheckedChanged(object sender, EventArgs e)
        {
            ser1 = GM.GetService1();
            ser1.UpdateNoteStatus(id, 3, chkNote3Status.Checked ? "1" : "0");
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtAppointDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void SetMode()
        {
            if (ApplicationInfo.Shop == 232)// 232 = Factory
            {
                FactoryStatus = tds.Order[0].FactoryStatus;

                if (FactoryStatus != 218)// Processing
                {
                    btnPrint.Visible = true;
                    btnInventory.Visible = true;

                    //Set Note เพิ่มเติม
                    if (!chkNote1Status.Checked && txtNote1.Text != "")
                    {
                        txtNote1.Visible = true;
                        txtNote1.Enabled = false;
                        chkNote1Status.Visible = true;
                    }
                    if (chkNote1Status.Checked && !chkNote2Status.Checked && txtNote2.Text != "")
                    {
                        txtNote1.Visible = true;
                        txtNote1.Enabled = false;
                        chkNote1Status.Visible = true;
                        chkNote1Status.Enabled = false;

                        txtNote2.Visible = true;
                        txtNote2.Enabled = false;
                        chkNote2Status.Visible = true;
                    }
                    if (chkNote1Status.Checked && chkNote2Status.Checked && !chkNote3Status.Checked)
                    {
                        txtNote1.Visible = true;
                        txtNote1.Enabled = false;
                        chkNote1Status.Enabled = false;

                        txtNote2.Visible = true;
                        txtNote2.Enabled = false;
                        chkNote2Status.Visible = true;
                        chkNote2Status.Enabled = false;

                        txtNote3.Visible = true;
                        txtNote3.Enabled = false;
                        chkNote3Status.Visible = true;
                    }
                    if (chkNote1Status.Checked && chkNote2Status.Checked && chkNote3Status.Checked)
                    {
                        txtNote1.Visible = true;
                        txtNote1.Enabled = false;
                        chkNote1Status.Enabled = false;

                        txtNote2.Visible = true;
                        txtNote2.Enabled = false;
                        chkNote2Status.Visible = true;
                        chkNote2Status.Enabled = false;

                        txtNote3.Visible = true;
                        txtNote3.Enabled = false;
                        chkNote3Status.Visible = true;
                        chkNote3Status.Enabled = false;
                    }
                }
                else// Not yet
                {
                    btnConfirm.Visible = true;
                }

                groupBox2.Enabled = true;
        }
            else
            {
                //Set Note เพิ่มเติม
                if (!chkNote1Status.Checked)
                {
                    txtNote1.Visible = true;
                    chkNote1Status.Visible = true;
                    chkNote1Status.Enabled = false;
                }
                if (chkNote1Status.Checked && !chkNote2Status.Checked)
                {
                    txtNote1.Visible = true;
                    txtNote1.Enabled = false;
                    chkNote1Status.Visible = true;
                    chkNote1Status.Enabled = false;

                    txtNote2.Visible = true;
                    chkNote2Status.Visible = true;
                    chkNote2Status.Enabled = false;
                }
                if (chkNote1Status.Checked && chkNote2Status.Checked && !chkNote3Status.Checked)
                {
                    txtNote1.Visible = true;
                    txtNote1.Enabled = false;
                    chkNote1Status.Visible = true;
                    chkNote1Status.Enabled = false;

                    txtNote2.Visible = true;
                    txtNote2.Enabled = false;
                    chkNote2Status.Visible = true;
                    chkNote2Status.Enabled = false;

                    txtNote3.Visible = true;
                    chkNote3Status.Visible = true;
                    chkNote3Status.Enabled = false;
                }
                if (chkNote1Status.Checked && chkNote2Status.Checked && chkNote3Status.Checked)
                {
                    txtNote1.Visible = true;
                    txtNote1.Enabled = false;
                    chkNote1Status.Visible = true;
                    chkNote1Status.Enabled = false;

                    txtNote2.Visible = true;
                    txtNote2.Enabled = false;
                    chkNote2Status.Visible = true;
                    chkNote2Status.Enabled = false;

                    txtNote3.Visible = true;
                    txtNote3.Enabled = false;
                    chkNote3Status.Visible = true;
                    chkNote3Status.Enabled = false;
                }
            }
        }
    }
}
