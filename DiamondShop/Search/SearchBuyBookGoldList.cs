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

namespace DiamondShop
{
    public partial class SearchBuyBookGoldList : FormList
    {
        public string idSelected = "";

        public SearchBuyBookGoldList()
        {
            InitializeComponent();
            Initial();
            dtSBuyDate.Value = dtSBuyDate.Value.AddDays(-90);

            DoLoadData();           
        }

        protected override void Initial()
        {
            gridGold.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookGold", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGold.DataSource = ds.Tables[0];
                gridGold.Refresh();
            }
            else
            {
                gridGold.DataSource = null;
                gridGold.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridGold.Rows.Count; i++)
            {
                if (gridGold.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridGold.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }

            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookGold(dtSBuyDate.Value,dtEBuyDate.Value);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridGold.DataSource = ds.Tables[0];
                gridGold.Refresh();
            }
            else { gridGold.DataSource = null; gridGold.Refresh(); }
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
    }
}
