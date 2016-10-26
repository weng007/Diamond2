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

namespace DiamondShop
{
    public partial class SearchBuyBookJewelryList : FormList
    {
        public string idSelected = "";

        public SearchBuyBookJewelryList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            txtCode.Select();

            gridJewelry.AutoGenerateColumns = false;
        }

        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookJewelry", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables[0];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridJewelry.Rows.Count; i++)
            {
                if (gridJewelry.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridJewelry.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }

            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchBuyBookJewelry(txtPrefix.Text + "-" + txtCode.Text,txtCode2.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridJewelry.DataSource = ds.Tables[0];
                gridJewelry.Refresh();
            }
            else { gridJewelry.DataSource = null; gridJewelry.Refresh(); }
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
