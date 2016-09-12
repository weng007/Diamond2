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


namespace DiamondShop
{
    public partial class OrderInfo : FormInfo
    {
        dsOrder tds = new dsOrder();
        bool isAuthorize = false;
        string FilePath;
        int custID = 0;
        MemoryStream ms1;
        MemoryStream ms2;
        MemoryStream ms3;
        MemoryStream ms4;
        MemoryStream ms5;
        byte[] image1, image2, image3, image4, image5;

        public OrderInfo()
        {
            InitializeComponent();
            Initial();
            //ds = ser.DoSelectData("ExchangeRate", id, 0);
            //txtPayDate.Text = ds.Tables[0].Rows[0]["USDRate"].ToString();

            //cmbCut.SelectedIndex = 1;
            //cmbPolish.SelectedIndex = 1;
            //cmbSymmetry.SelectedIndex = 1;

            BinderControl();


            //dtDueDate.Value = dtBuyDate.Value.AddDays(30);
        }
        public OrderInfo(int id)
        {
            InitializeComponent();
            Initial();

            BinderControl();

            this.id = id;
            //btnImportExcel.Enabled = false;
            LoadData();
            SetControlEnable(false);

            isEdit = false;
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbSeller.DataSource = ds.Tables[0];
            cmbSeller.ValueMember = "ID";
            cmbSeller.DisplayMember = "DisplayName";
            cmbSeller.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbSeller.Refresh();

            cmbQuality.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
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

            dtBuyDate.Select();

            //SetFieldService.SetRequireField(txtWeight, txtPrice, txtRap, txtUSDRate);
        }
        private void BinderControl()
        {
            binder.BindControl(dtBuyDate, "BuyDate");
            binder.BindControl(txtCustomer, "CustomerName");
            binder.BindControl(txtCode, "Code");
            binder.BindControl(txtTel, "Tel");
            binder.BindControl(cmbJewelryType, "ColorType");
            binder.BindControl(cmbMaterial, "Material");
            binder.BindControl(cmbQuality, "Quality");
            binder.BindControl(cmbSeller, "Seller");

            binder.BindControl(txtSize, "Size");
            binder.BindControl(txtCoating, "Coating");
            binder.BindControl(txtLaser, "Laser");
            binder.BindControl(txtOldBody, "OldBody");

            binder.BindControl(dtReceiveDate, "ReceiveDate");
            binder.BindControl(cmbShop1, "ReceiveAt");
            binder.BindControl(txtBodyDate, "BodyDate");
            binder.BindControl(cmbShop2, "BodyAt");

            binder.BindControl(txtCustNote, "CustomerNote");
            binder.BindControl(txtImageNote, "ImageNote");
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
                txtBodyDate.Text = string.Format("{0:d/M/yyyy}", tds.Order[0]["BodyDate"]);

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

                //if (tds.BuyBookDiamondCer[0]["Certificate"].ToString() != "")
                //{
                //    file = (byte[])tds.BuyBookDiamondCer[0]["Certificate"];
                //    linkFile.Text = tds.BuyBookDiamondCer[0].FileName;
                //}

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
                    rdoHave.Checked = false;
                    rdoNotHave.Checked = true;
                }
                else
                {
                    rdoHave.Checked = true;
                    rdoNotHave.Checked = false;
                }


                //EnableSave = false;
                //EnableEdit = true;
                //EnableDelete = false;
              }

              SetFormatNumber();
              base.LoadData();

            cmbJewelryType.SelectedValueChanged += cmbColorType_SelectedValueChanged;
        }

        protected override bool SaveData()
        {
            dsOrder.OrderRow row = null;

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
            row.IsHave = rdoHave.Checked ?"1":"0";
            row.IsReceive = rdoReceive.Checked ? "1" : "0";
            if (txtBodyDate.Text == "")
            {
                row.BodyDate = DateTime.MinValue.AddYears(1900);
            }
            else
            {
                row.BodyDate = Convert.ToDateTime(txtBodyDate.Text.ToString());
            }

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("ORD");
                    //พึ่งซื้อยังไม่ได้ขายให้ลูกค้า
                    //row.SoldTo = 0;
                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("Order", tds,0);
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

            return chkFlag;
        }
        protected override bool DeleteData()
        {
            try
            {
                //if (cmbStatus.SelectedIndex == 0)
                //{
                //chkFlag = ser.DoDeleteData("BuyBookDiamondCer", id);
                //}
                //else
                //{
                //    Popup.Popup pop = new Popup.Popup("Diamond Cer ไม่อยู่ในสถานะลบได้");
                //    pop.ShowDialog();
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        //protected override void EditData()
        //{
        //    if(isAuthorize)
        //    {
        //        EnableSave = true;
        //        EnableDelete = true;
        //        SetControlEnable(true);
        //    }
        //    else
        //    {
        //        RequirePassword frm = new RequirePassword("2");
        //        frm.ShowDialog();
        //        isAuthorize = frm.isAuthorize;
        //        frm.Close();

        //        if (isAuthorize)
        //        {
        //            EnableSave = true;
        //            EnableDelete = true;
        //            SetControlEnable(true);
        //            base.EditData();
        //        }
        //    }
        //}

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

        private void cmbColorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string color = "";

            //if (cmbColorType.SelectedIndex == 0)
            //{
            //    color = "C001";
            //}
            //else
            //{
            //    color = "C017";
            //}

            //cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            //cmbColor.ValueMember = "ID";
            //cmbColor.DisplayMember = "Detail";
            //cmbColor.Refresh();
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbShape.SelectedIndex != 0)
            //{
            //    cmbCut.SelectedIndex = 0;
            //    cmbCut.Enabled = false;
            //}
            //else
            //{
            //    cmbCut.Enabled = true;
            //}
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists)
            //{      
            //    using (var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
            //    {
            //        using (var reader = new BinaryReader(stream))
            //        {
            //            file = reader.ReadBytes((int)stream.Length);
            //        }
            //    }

            //    //if(file.Length > 0)
            //    //{
            //    //    linkFile.Text = openFileDialog1.SafeFileName;
            //    //}
            //}
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            //txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
            //    * GM.ConvertStringToDouble(txtWeight)).ToString();
            //txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        } 

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            //txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
            //    * GM.ConvertStringToDouble(txtWeight)).ToString();
            //txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }

        private void txtRap_Leave(object sender, EventArgs e)
        {
            //txtTotal.Text = (GM.ConvertStringToDouble(txtRap) * 100 * (1 + GM.ConvertStringToDouble(txtPrice) / 100.0)
            //    * GM.ConvertStringToDouble(txtWeight)).ToString();
            //txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
        }

        private void txtUSDRate_Leave(object sender, EventArgs e)
        {
                //txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
                //txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //txtTotalBaht.Text = (GM.ConvertStringToDouble(txtTotal) * GM.ConvertStringToDouble(txtUSDRate)).ToString();
            //txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);

            isEdit = true;
        }

        private void SetFormatNumber()
        {
            if (txtBodyDate.Text != "" && Convert.ToDateTime(txtBodyDate.Text).Year == 1901)
            {
                txtBodyDate.Text = "";
            }
            //txtTotal.Text = GM.ConvertDoubleToString(txtTotal);
            //txtTotalBaht.Text = GM.ConvertDoubleToString(txtTotalBaht, 0);          
        }
        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //if(file != null && file.Length > 0)
            //{
            //    System.IO.FileStream wFile;
            //    if (!Directory.Exists(GM.Path))
            //    {
            //        Directory.CreateDirectory("C:\\Project");
            //    }
            //    wFile = new FileStream("C:\\Project\\"+linkFile.Text, FileMode.Create);
            //    wFile.Write(file, 0, file.Length);
            //    wFile.Flush();
            //    wFile.Close();

            //    System.Diagnostics.Process.Start(@"C:\\Project\\"+linkFile.Text);             
            //}
        }
        private void SetControlEnable(bool status)
        {
            //dtBuyDate.Enabled = status;
            //txtCustomer.Enabled = status;
            //txtCode.Enabled = status;
            //txtPrice.Enabled = status;
            //cmbColorType.Enabled = status;
            //cmbCut.Enabled = status;
            //cmbPolish.Enabled = status;
            //cmbSymmetry.Enabled = status;
            //cmbFluorescent.Enabled = status;
            //cmbLab.Enabled = status;
            //txtReportNumber.Enabled = status;
            //txtWeight.Enabled = status;
            //cmbShape.Enabled = status;
            //cmbColor.Enabled = status;
            //cmbClearity.Enabled = status;
            //cmbShop.Enabled = status;
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            //dtDueDate.Value = dtBuyDate.Value.AddDays(30);
            //isEdit = true;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            //if (openFileDialog2.ShowDialog() == DialogResult.OK && openFileDialog2.CheckFileExists)
            //{
            //    using (var stream = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read))
            //    {
            //        using (var reader = new BinaryReader(stream))
            //        {
            //            file = reader.ReadBytes((int)stream.Length);
            //        }
            //    }

            //    if (file.Length > 0)
            //    {
            //        FilePath = openFileDialog2.FileName;
            //    }
            //}
            //BuyBookDiamonCerExcel frm = new BuyBookDiamonCerExcel(id,FilePath);
            //frm.ShowDialog();

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
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
            custID = frm.custID;
            txtCustomer.Text = frm.customerName;
            txtTel.Text = frm.Tel;
        }

        private void dtBuyDate_ValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBodyDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
