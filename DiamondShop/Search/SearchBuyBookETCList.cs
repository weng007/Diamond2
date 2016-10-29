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
    public partial class SearchBuyBookETCList : FormList
    {
        public string idSelected = "";

        public SearchBuyBookETCList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
        }

        protected override void Initial()
        {
            txtSeller.Select();

            gridETC.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("BuyBookETC", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridETC.DataSource = ds.Tables[0];
                gridETC.Refresh();
            }
            else { gridETC.DataSource = null; gridETC.Refresh(); }
        }

        private void CheckSelected()
        {
            string comma = ",";

            for (int i = 0; i < gridETC.Rows.Count; i++)
            {
                if (gridETC.Rows[i].Cells["Select"].Value != null)
                {
                    idSelected += gridETC.Rows[i].Cells["ID"].Value.ToString() + comma;
                }
            }

            idSelected = idSelected.Remove(idSelected.Length - 1, 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();
            ds = ser2.DoSearchBuyBookETC(txtSeller.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridETC.DataSource = ds.Tables[0];
                gridETC.Refresh();
            }
            else { gridETC.DataSource = null; gridETC.Refresh(); }
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

        private void gridETC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (gridETC.SelectedCells[0].Value == null)
                {
                    gridETC.SelectedCells[0].Value = true;
                    id = (int)gridETC.SelectedRows[0].Cells["ID"].Value;
                }
                else
                {
                    gridETC.SelectedCells[0].Value = false;
                }
            }
        }
    }
}
