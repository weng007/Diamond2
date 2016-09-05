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
    public partial class WarningList : FormList
    {
        
        public WarningList()
        {
            InitializeComponent();
            Initial();
            DoLoadData();
            //Timer timer = new Timer();
            //timer.Interval = (1 * 100000); // 10 secs = 10000, 300000 = 5 m
            //timer.Tick += new EventHandler(timer1_Tick);
            //timer.Start();
        }

        protected override void Initial()
        {
            ds = GM.GetSeller();

            cmbReceiver.DataSource = ds.Tables[0];
            cmbReceiver.ValueMember = "ID";
            cmbReceiver.DisplayMember = "DisplayName";
            cmbReceiver.Refresh();

            cmbMessageStatus.DataSource = (GM.GetMasterTableDetail("C033")).Tables[0];
            cmbMessageStatus.ValueMember = "ID";
            cmbMessageStatus.DisplayMember = "Detail";
            cmbMessageStatus.Refresh();

            cmbFactoryStatus.DataSource = (GM.GetMasterTableDetail("C034")).Tables[0];
            cmbFactoryStatus.ValueMember = "ID";
            cmbFactoryStatus.DisplayMember = "Detail";
            cmbFactoryStatus.Refresh();

            cmbShop.DataSource = (GM.GetMasterTableDetail("C007")).Tables[0];
            cmbShop.ValueMember = "ID";
            cmbShop.DisplayMember = "Detail";
            cmbShop.Refresh();

            txtSender.Select();

            gridWarning.AutoGenerateColumns = false;
        }
        protected override void DoLoadData()
        {
            ds = ser.DoSelectData("Warning", -1,0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridWarning.DataSource = ds.Tables[0];
                gridWarning.Refresh();
            }
            else
            {
                gridWarning.DataSource = null;
                gridWarning.Refresh();
            }

            //btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Warning frm = new Warning();
            frm.ShowDialog();
            DoLoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ser2 = GM.GetService2();

            ds = ser2.DoSearchWarning(txtSender.Text, Convert.ToInt32(cmbReceiver.SelectedValue.ToString()), Convert.ToInt32(cmbMessageStatus.SelectedValue.ToString()), Convert.ToInt32(cmbFactoryStatus.SelectedValue.ToString()), Convert.ToInt32(cmbShop.SelectedValue.ToString()));

            if (ds.Tables[0].Rows.Count > 0)
            {
                gridWarning.DataSource = ds.Tables[0];
                gridWarning.Refresh();
            }
            else { gridWarning.DataSource = null; gridWarning.Refresh(); }
        }

        private void gridSell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridWarning.RowCount > 0 && gridWarning.SelectedRows.Count > 0)
            {
                id = (int)gridWarning.SelectedRows[0].Cells["ID"].Value;
                Warning frm = new Warning(id);
                frm.ShowDialog();
            }

            DoLoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoLoadData();
        }

        private void WarningList_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 30000; // 10 secs = 10000, 300000 = 5 m
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
