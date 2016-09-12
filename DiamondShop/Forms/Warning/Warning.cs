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
    public partial class Warning : FormInfo
    {
        Service2 ser1;
        dsWarning tds = new dsWarning();
        int flag = 0;

        public Warning()
        {
            InitializeComponent();
            Initial();
            BinderControl();
            txtSender.Text = ApplicationInfo.DisplayName;
        }
        public Warning(int id)
        {
            InitializeComponent();
            Initial();
            BinderControl();

            this.id = id;
            
            //Receiver
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
            {   

                if (txtConfirmDate.Text != "" || txtCancelDate.Text != "")
                {
                    cmbReceiver.Enabled = false;
                    cmbFactoryStatus.Enabled = false;
                    cmbShop.Enabled = false;
                    txtNote.Text = "";
                    EnableSave = false;
                }
                //ผู้รับจะไม่สามารถแก้ไขได้
                cmbReceiver.Enabled = false;
                cmbShop.Enabled = false;
            }
            //Sender
            else if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) != ApplicationInfo.UserID)
            {
                ser1 = GM.GetService1();
                ser1.UpdateMessageStatus(id, "0");

                    cmbReceiver.Enabled = false;
                    //cmbFactoryStatus.Enabled = false;
                    cmbShop.Enabled = false;
                    txtNote.Text = "";
                    EnableSave = false;
            }
            
            LoadData();
            isEdit = false;
        }
        private void BinderControl()
        {
            binder.BindControl(txtSender, "SenderName");
            binder.BindControl(cmbReceiver, "Receiver");
            binder.BindControl(txtMessageStatus, "MessageStatusName");
            binder.BindControl(cmbFactoryStatus, "FactoryStatus");
            binder.BindControl(cmbShop, "Shop");
            binder.BindControl(txtNote, "Note");
        }
        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C034")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            //SetFieldService.SetRequireField(txtNetPrice,txtCode,txtCustomer);
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("Warning", id, 0);
            tds.Clear();
            tds.Merge(ds);

            if (tds.Warning.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.Warning[0]);
                txtReadDate.Text = string.Format("{0:d/M/yyyy}", tds.Warning[0]["ReadDate"]);
                txtConfirmDate.Text = string.Format("{0:d/M/yyyy}", tds.Warning[0]["ConfirmDate"]);
                txtCancelDate.Text = string.Format("{0:d/M/yyyy}", tds.Warning[0]["CancelDate"]);
                EnableDelete = true;
            }
            SetFormat();
            base.LoadData();

            cmbFactoryStatus.SelectedValueChanged += CmbFactoryStatus_SelectedValueChanged;
        }

        private void CmbFactoryStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        protected override bool SaveData()
        {
            dsWarning.WarningRow row = null;

            if (tds.Warning.Rows.Count > 0)
            {
                row = tds.Warning[0];
            }
            else
            {
                row = tds.Warning.NewWarningRow();
                tds.Warning.Rows.Add(row);
            }          
            binder.BindValueToDataRow(row);           

            try
            {
                if (id == 0)
                {
                    SetCreateBy(row);
                    row.ReadDate = DateTime.MinValue.AddYears(1900);
                    row.CancelDate = DateTime.MinValue.AddYears(1900);
                    row.ConfirmDate = DateTime.MinValue.AddYears(1900);
                    row.Sender = ApplicationInfo.UserID;
                    chkFlag = ser.DoInsertData("Warning", tds, 0);
                }
                else
                {
                    SetEditBy(row);
                    if(flag == 1)
                    {
                        row.CancelDate = DateTime.MinValue.AddYears(1900);
                    }
                    else if(flag == 2)
                    {
                        row.ConfirmDate = DateTime.MinValue.AddYears(1900);
                    }
                    chkFlag = ser.DoUpdateData("Warning", tds);
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
                chkFlag = ser.DoDeleteData("Warning", id);
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

            //if (txtCode.Text == "")
            //{
            //    message = "Please Choose Product.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }
  
        private void SetFormat()
        {
            //ดักเคส MinValue
            if(txtReadDate.Text != "" && Convert.ToDateTime(txtReadDate.Text).Year == 1901)
            {
                txtReadDate.Text = "";
            }
            if (txtConfirmDate.Text != "" && Convert.ToDateTime(txtConfirmDate.Text).Year == 1901)
            {
                txtConfirmDate.Text = "";
            }
            if (txtCancelDate.Text != "" && Convert.ToDateTime(txtCancelDate.Text).Year == 1901)
            {
                txtCancelDate.Text = "";
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
            {
                ser1 = GM.GetService1();
                ser1.UpdateMessageStatus(id, "1");
                LoadData();
                txtCancelDate.Text = "";

                flag = 1;
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmbReceiver.SelectedValue.ToString()) == ApplicationInfo.UserID)
            {
                ser1 = GM.GetService1();
                ser1.UpdateMessageStatus(id, "2");
                LoadData();
                txtConfirmDate.Text = "";

                flag = 2;
            }       
        }
    }
}
