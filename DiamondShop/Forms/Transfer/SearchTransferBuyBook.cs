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
    public partial class SearchTransferBuyBook : FormList
    { 
        public int refID1 = 0;
        public string tmpCode = "";
        public string idSelected = "";

        public SearchTransferBuyBook()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            cmbBuybookType.DisplayMember = "Text";
            cmbBuybookType.ValueMember = "Value";
            var items = new[] {
                new { Text = "ALL", Value = "0" },
                new { Text = "BuyBookDiamondCer", Value = "1" },
                new { Text = "BuyBookGemstoneCer", Value = "2" },
                new { Text = "BuyBookJewelry", Value = "3" }
            };

            cmbBuybookType.DataSource = items;
            cmbBuybookType.SelectedIndex = 0;

            gridTransferBuyBook.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            
            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, "", "", 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbBuybookType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferBuyBook.DataSource = ds.Tables[0];
                gridTransferBuyBook.Refresh();
            }
            else { gridTransferBuyBook.DataSource = null; gridTransferBuyBook.Refresh(); }
        }

        private void CheckSelected()
        {
            string comma = ",";
            idSelected = "";

            for (int i = 0; i < gridTransferBuyBook.Rows.Count; i++)
            {
                if (gridTransferBuyBook.Rows[i].Cells["Select"].Value != null)
                {
                    if (gridTransferBuyBook.Rows[i].Cells["Select"].Value.ToString() == "True")
                    {
                        idSelected += gridTransferBuyBook.Rows[i].Cells["ID"].Value.ToString() + comma;
                    }
                }
            }

            if (idSelected.Length > 0)
            {
                idSelected = idSelected.Remove(idSelected.Length - 1, 1);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void gridTransferBuyBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            refID1 = (int)gridTransferBuyBook.SelectedRows[0].Cells["ID"].Value;
            tmpCode = gridTransferBuyBook.SelectedRows[0].Cells["Code"].Value.ToString();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
