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
using DiamondShop.DiamondService1;

namespace DiamondShop
{
    public partial class SearchTransferInventory : FormList
    {
        Service2 ser1;

        dsTransferInventory tds1 = new dsTransferInventory();
        DataSet ds1 = new DataSet();

        public int refID1 = 0;
        public string idSelected = "";

        public SearchTransferInventory()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();

            cmbBuybookType.DataSource = ds.Tables[0];
            cmbBuybookType.ValueMember = "ID";
            cmbBuybookType.DisplayMember = "DisplayName";
            cmbBuybookType.Refresh();

            gridTransferInventory.AutoGenerateColumns = false;    
        }

        protected override void DoLoadData()
        {
            ser2 = GM.GetService2();
            
            ds = ser2.DoSearchTransferInventory(ApplicationInfo.Shop, "", 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TransferInfo frm = new TransferInfo();
            frm.ShowDialog();
            DoLoadData();
        }

        private void DoSearchData()
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchTransferBuyBook(ApplicationInfo.Shop, txtCode.Text, txtCode2.Text, Convert.ToInt16(cmbBuybookType.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridTransferInventory.DataSource = ds.Tables[0];
                gridTransferInventory.Refresh();
            }
            else { gridTransferInventory.DataSource = null; gridTransferInventory.Refresh(); }
        }
        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridTransferInventory.Rows.Count; i++)
            {
                if (gridTransferInventory.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridTransferInventory.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }

            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckSelected();

            this.Close();
        }

        private void SetGrid(string idSelected, int buyBookType)
        {
            if (idSelected != "")
            {
                ser1 = GM.GetService1();

                dsTransferDetail tmp = new dsTransferDetail();

                ds1 = ser1.GetSellBookDetail(idSelected, buyBookType);
                tmp.Clear();
                tmp.Merge(ds1);

                for (int i = 0; i < tmp.TransferDetail.Rows.Count; i++)
                {
                    dsTransferInventory.TransferInventoryRow row = tds1.TransferInventory.NewTransferInventoryRow();
                    row.RefID = id;
                    row.RefID1 = tmp.TransferDetail[i].RefID1;
                    tds1.TransferInventory.Rows.Add(row);
                }

                tds1.AcceptChanges();
                gridTransferInventory.DataSource = tds1.TransferInventory;
                gridTransferInventory.Refresh();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchData();
        }

        private void gridTransferInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            refID1 = (int)gridTransferInventory.SelectedRows[0].Cells["ID"].Value;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
