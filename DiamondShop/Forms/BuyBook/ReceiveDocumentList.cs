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
    public partial class ReceiveDocumentList : FormList
    {
        int mode = 0;
        public int ReceiveDocID = 0;
        public string ReceiveDocNo = "";
        public ReceiveDocumentList()
        {
            InitializeComponent();
            Initial();
            dtSReceiveDate.Value = dtSReceiveDate.Value.AddDays(-90);
            DoLoadData();
            
        }
        public ReceiveDocumentList(int mode)
        {
            InitializeComponent();
            Initial();
            this.mode = mode;

            btnClose.Visible = true;
            DoLoadData();
        }

        protected override void Initial()
        {
            ds = GM.GetBuyer();
            DataRow row = ds.Tables[0].NewRow();
            row["ID"] = 0;
            row["DisplayName"] = "All";
            ds.Tables[0].Rows.Add(row);

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.SelectedIndex = ds.Tables[0].Rows.Count - 1;
            cmbReceiver.Refresh();

            txtSeller.Select();
            gridReceiveDocument.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("ReceiveDocument", -1, 0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridReceiveDocument.DataSource = ds.Tables[0];
                gridReceiveDocument.Refresh();
            }
            else
            {
                gridReceiveDocument.DataSource = null;
                gridReceiveDocument.Refresh();
            }

            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReceiveDocument frm = new ReceiveDocument();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchReceiveDocument(txtReceiveNo.Text, dtSReceiveDate.Value, dtEReceiveDate.Value, Convert.ToInt32(cmbReceiver.SelectedValue.ToString()), txtSeller.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridReceiveDocument.DataSource = ds.Tables[0];
                gridReceiveDocument.Refresh();
            }
            else { gridReceiveDocument.DataSource = null; gridReceiveDocument.Refresh(); }
        }

        private void gridSell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == 0)
            {
                if (gridReceiveDocument.RowCount > 0 && gridReceiveDocument.SelectedRows.Count > 0)
                {
                    id = (int)gridReceiveDocument.SelectedRows[0].Cells["ID"].Value;
                    ReceiveDocument frm = new ReceiveDocument(id);
                    frm.ShowDialog();

                    if (frm.isEdit)
                    {
                        DoLoadData();
                    }
                }
            }
            else //mode = 1 Search
            {
                ReceiveDocID = (int)gridReceiveDocument.SelectedRows[0].Cells["ID"].Value;
                ReceiveDocNo = gridReceiveDocument.SelectedRows[0].Cells["ReceiveNo"].Value.ToString();

                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
