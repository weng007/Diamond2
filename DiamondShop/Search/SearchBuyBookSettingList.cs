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
using DiamondDS;
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class SearchBuyBookSettingList : FormList
    {
        Service2 ser1;
        public string idSelected = "";

        public SearchBuyBookSettingList()
        {
            InitializeComponent();
            Initial();
            dtSBuyDate.Value = dtSBuyDate.Value.AddDays(-90);

            DoLoadData();        
        }

        protected override void Initial()
        {
            gridSetting.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser1 = GM.GetService1();
            ds = ser1.DoSearchBBSettingDetail(1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables[0];
                gridSetting.Refresh();
            }
            else
            {
                gridSetting.DataSource = null;
                gridSetting.Refresh();
            }
        }

        private void CheckSelected()
        {
            string comma = ",";
            idSelected = "";

            for (int i = 0; i < gridSetting.Rows.Count; i++)
            {
                if (gridSetting.Rows[i].Cells["Select"].Value != null)
                {
                    if (gridSetting.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        idSelected += gridSetting.Rows[i].Cells["ID"].Value.ToString() + comma;
                    }
                }
            }

            if (idSelected.Length > 0)
            {
                idSelected = idSelected.Remove(idSelected.Length - 1, 1);
            }
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookSetting(txtSeller.Text, dtSBuyDate.Value, dtEBuyDate.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridSetting.DataSource = ds.Tables[0];
                gridSetting.Refresh();
            }
            else { gridSetting.DataSource = null; gridSetting.Refresh(); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void gridSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridSetting.SelectedCells[0].Value == null || gridSetting.SelectedCells[0].Value.ToString() == "False")
                {
                    gridSetting.SelectedCells[0].Value = true;
                    id = (int)gridSetting.SelectedRows[0].Cells["ID"].Value;
                }
                else
                {
                    gridSetting.SelectedCells[0].Value = false;
                }
            }
        }
    }
}
