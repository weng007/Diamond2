using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamondShop.DiamondService;
using DiamondShop.Popup;

namespace DiamondShop.FormMaster
{
    public partial class FormInfo : Form
    {
        public int id = 0;
        public bool chkFlag = false;
        public string message = "";
        public bool isClosed = true;
        public DataBinder binder = new DataBinder();
        public DataSet ds = new DataSet();
        public Service1 ser = GM.GetService();

        #region Standard Control
        //Standard Control     
        bool enableSave = true;
        bool enableEdit = false;
        bool enableDelete = false;

        public bool isEdit = false;

        [Category("Toolbar")]
        public bool EnableEdit
        {
            get { return enableEdit; }
            set { enableEdit = value; }
        }

        [Category("Toolbar")]
        public bool EnableSave
        {
            get { return enableSave; }
            set { enableSave = value; }
        }

        [Category("Toolbar")]
        public bool EnableDelete
        {
            get { return enableDelete; }
            set { enableDelete = value; }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        public FormInfo()
        {
            InitializeComponent();
            EnableButton();
        }

        private void EnableButton()
        {
            btnSave.Enabled = EnableSave;
            btnDelete.Enabled = EnableDelete;
            btnEdit.Enabled = EnableEdit;
        }

        protected virtual void Initial()
        {

        }

        protected virtual void LoadData()
        {
            EnableButton();
        }

        protected virtual bool SaveData()
        {
            return true;
        }

        protected virtual bool DeleteData()
        {
            return true;
        }

        protected virtual void EditData()
        {
            EnableButton();
        }

        protected virtual bool ValidateData()
        {
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Popup.Popup WinMessage = new Popup.Popup("Do you want to save Data !!!");
                WinMessage.ShowDialog();
                chkFlag = WinMessage.result;

                if (chkFlag)
                {
                    SaveData();

                    if (isClosed)
                    {
                        this.Close();
                    }
                }
            }   
            else
            {
                Popup.Popup WinMessage = new Popup.Popup(message);
                WinMessage.ShowDialog();
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Popup.Popup WinMessage = new Popup.Popup("Do you want to Delete Data !!!");
            WinMessage.ShowDialog();
            chkFlag = WinMessage.result;

            if (chkFlag)
            {
                DeleteData();
                this.Close();
            }
        }

        public void SetCreateBy(DataRow row)
        {
            if (row.Table.Columns.Contains("CreateBy"))
            {
                row["CreateBy"] = ApplicationInfo.UserID;
            }
            if (row.Table.Columns.Contains("EditBy"))
            {
                row["EditBy"] = ApplicationInfo.UserID;
            }
        }

        public void SetCreateBy(DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["CreateBy"] = ApplicationInfo.UserID;
                    row["EditBy"] = ApplicationInfo.UserID;
                }  
            }
        }

        public void SetEditBy(DataRow row)
        {
            if (row.Table.Columns.Contains("EditBy"))
            {
                row["EditBy"] = ApplicationInfo.UserID;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }
    }
}
