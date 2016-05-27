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

namespace DiamondShop
{
    public partial class BuyBookJewelryDiamondDetail : FormInfo
    {
        dsBBJewelryDiamondCerDetail tds = new dsBBJewelryDiamondCerDetail();
        bool isAuthorize = false;
        byte[] file;

        public BuyBookJewelryDiamondDetail()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbColorType, "ColorType");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");
        }
        public BuyBookJewelryDiamondDetail(int id)
        {
            InitializeComponent();
            Initial();

            binder.BindControl(txtCode, "Code");
            binder.BindControl(cmbColorType, "ColorType");
            binder.BindControl(txtReportNumber, "ReportNumber");
            binder.BindControl(txtWeight, "Weight");
            binder.BindControl(cmbShape, "Shape");
            binder.BindControl(cmbColor, "Color");
            binder.BindControl(cmbClearity, "Clearity");

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            cmbColorType.DataSource = (GM.GetMasterTableDetail("C025")).Tables[0];
            cmbColorType.ValueMember = "ID";
            cmbColorType.DisplayMember = "Detail";
            cmbColorType.Refresh();
            
            cmbShape.DataSource = (GM.GetMasterTableDetail("C019")).Tables[0];
            cmbShape.ValueMember = "ID";
            cmbShape.DisplayMember = "Detail";
            cmbShape.Refresh();

            cmbClearity.DataSource = (GM.GetMasterTableDetail("C002")).Tables[0];
            cmbClearity.ValueMember = "ID";
            cmbClearity.DisplayMember = "Detail";
            cmbClearity.Refresh();    

            cmbCompany.DataSource = (GM.GetMasterTableDetail("C020")).Tables[0];
            cmbCompany.ValueMember = "ID";
            cmbCompany.DisplayMember = "Detail";
            cmbCompany.Refresh();

            txtReportNumber.Select();

            SetFieldService.SetRequireField(txtWeight);
        }

        protected override void LoadData()
        {
              ds = ser.DoSelectData("BBJewelryDiamondCerDetail", id);
              tds.Clear();
              tds.Merge(ds);

              if (tds.BBJewelryDiamondCerDetail.Rows.Count > 0)
              {
                binder.BindValueToControl(tds.BBJewelryDiamondCerDetail[0]);

                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
              }

              SetFormatNumber();
              base.LoadData();
        }

        protected override bool SaveData()
        {
            dsBBJewelryDiamondCerDetail.BBJewelryDiamondCerDetailRow row = null;

            if (tds.BBJewelryDiamondCerDetail.Rows.Count > 0)
            {
                row = tds.BBJewelryDiamondCerDetail[0];
            }
            else
            {
                row = tds.BBJewelryDiamondCerDetail.NewBBJewelryDiamondCerDetailRow();
                tds.BBJewelryDiamondCerDetail.Rows.Add(row);
            }
            binder.BindValueToDataRow(row);

            try
            {
                if (id == 0)
                {
                    row.Code = GM.GetRunningNumber("JDC");
                    //พึ่งซื้อยังไม่ได้ขายให้ลูกค้า

                    SetCreateBy(row);
                    chkFlag = ser.DoInsertData("BBJewelryDiamondCerDetail", tds);
                }
                else
                {
                    SetEditBy(row);
                    chkFlag = ser.DoUpdateData("BBJewelryDiamondCerDetail", tds);
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
                chkFlag = ser.DoDeleteData("BBJewelryDiamondCerDetail", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override void EditData()
        {
            if(isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
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
                    base.EditData();
                }
            }
        }

        protected override bool ValidateData()
        {
            message = "";

            if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight) == 0)
            {
                message = "Please Input Weight > 0.\n";
            }

            if (message == "") { return true; }
            else { return false; }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void cmbColorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";

            if (cmbColorType.SelectedIndex == 0)
            {
                color = "C001";
            }
            else
            {
                color = "C017";
            }

            cmbColor.DataSource = (GM.GetMasterTableDetail(color)).Tables[0];
            cmbColor.ValueMember = "ID";
            cmbColor.DisplayMember = "Detail";
            cmbColor.Refresh();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(openFileDialog1.InitialDirectory + openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
        }

        private void SetFormatNumber()
        {
            txtWeight.Text = GM.ConvertDoubleToString(txtWeight, 0);
        }
    }
}
