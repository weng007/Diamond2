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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class ProductionLineInfo : FormInfo
    {
        Service2 ser1;
        dsProductionLine tds = new dsProductionLine();
        bool isAuthorize = false;
        int factoryStatus;
        string[] idSelected;

        public ProductionLineInfo()
        {
            InitializeComponent();
            Initial();

            binder.BindControl(cmbFactoryStatus, "FactoryStatus");
        }
        public ProductionLineInfo(string idSelected,int tmp)
        {
            InitializeComponent();
            Initial();
            this.factoryStatus = tmp;
            this.idSelected = idSelected.Split(',');

            if (factoryStatus != 221)
            {
                cmbFactoryStatus.SelectedValue = factoryStatus + 1;
            }

            LoadData();     
        }

        protected override void Initial()
        {
            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C034")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();
        }

        protected override void LoadData()
        {
            ds = ser.DoSelectData("ProductionLine", id, 0);
            tds.Clear();
            tds.Merge(ds);;

            if (tds.ProductionLine.Rows.Count > 0)
            {
                binder.BindValueToControl(tds.ProductionLine[0]);
                
                EnableSave = false;
                EnableEdit = true;
                EnableDelete = false;
            }
            base.LoadData();
        }

        protected override bool SaveData()
        {
            ser1 = GM.GetService1();
            try
            {
                for (int i = 0; i < idSelected.Length; i++)
                {
                    ser1.UpdateProductionLine(Convert.ToInt32(idSelected[i]), Convert.ToInt32(cmbFactoryStatus.SelectedValue.ToString()), ApplicationInfo.UserID);
                }             
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }

        protected override void EditData()
        {
            if (isAuthorize)
            {
                EnableSave = true;
                EnableDelete = true;
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
                    base.EditData();
                }
            }
        }
    }
}
