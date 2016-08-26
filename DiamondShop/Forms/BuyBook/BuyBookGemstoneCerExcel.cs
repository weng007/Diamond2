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

namespace DiamondShop
{
    public partial class BuyBookGemstoneCerExcel : FormInfo
    {
        DataSet ds2 = new DataSet();
        dsBuyBookGemstoneCer_Excel tds = new dsBuyBookGemstoneCer_Excel();
        bool isAuthorize = false;
        string FilePath;

        public BuyBookGemstoneCerExcel()
        {
            InitializeComponent();
            Initial();
        }

        public BuyBookGemstoneCerExcel(int id,string FilePath)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            this.FilePath = FilePath;
            LoadData();
        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;
        }
        protected override void LoadData()
        {
            ds.Tables.Add(ExcelService.GetExcel(FilePath,1));

            grid1.DataSource = ds.Tables[0];
            grid1.Refresh();

            base.LoadData();
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
                RequirePassword frm = new RequirePassword("2");
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
       
        private void BindingDSDiamondDetail()
        {
            int i = 0;

            tds.Clear();
            foreach (DataGridViewRow row in grid1.Rows)
            {
                tds.Tables[0].Rows.Add();


                if (row.Cells["Seller"].Value != null)
                { tds.Tables[0].Rows[i]["Seller"] = row.Cells["Seller"].Value; }

                if (row.Cells["Shape"].Value != null)
                { tds.Tables[0].Rows[i]["Shape"] = row.Cells["Shape"].Value; }

                if (row.Cells["Cut"].Value != null)
                { tds.Tables[0].Rows[i]["Cut"] = row.Cells["Cut"].Value; }

                if (row.Cells["Weight"].Value != null)
                { tds.Tables[0].Rows[i]["Weight"] = row.Cells["Weight"].Value; }

                if (row.Cells["ReportNumber"].Value != null)
                { tds.Tables[0].Rows[i]["ReportNumber"] = row.Cells["ReportNumber"].Value; }

                if (row.Cells["Identification"].Value != null)
                { tds.Tables[0].Rows[i]["Identification"] = row.Cells["Identification"].Value; }

                if (row.Cells["Color"].Value != null)
                { tds.Tables[0].Rows[i]["Color"] = row.Cells["Color"].Value; }

                if (row.Cells["Lab"].Value != null)
                { tds.Tables[0].Rows[i]["Lab"] = row.Cells["Lab"].Value; }

                if (row.Cells["Origin"].Value != null)
                { tds.Tables[0].Rows[i]["Origin"] = row.Cells["Origin"].Value; }

                if (row.Cells["Comment"].Value != null)
                { tds.Tables[0].Rows[i]["Comment"] = row.Cells["Comment"].Value; }

                if (row.Cells["Shop"].Value != null)
                { tds.Tables[0].Rows[i]["Shop"] = row.Cells["Shop"].Value; }

                if (row.Cells["Payment"].Value != null)
                { tds.Tables[0].Rows[i]["IsPaid"] = row.Cells["Payment"].Value; }

                if (row.Cells["PayByUSD"].Value != null)
                { tds.Tables[0].Rows[i]["PayByUSD"] = row.Cells["PayByUSD"].Value; }

                if (row.Cells["PriceCaratUSD"].Value != null)
                { tds.Tables[0].Rows[i]["PriceCaratUSD"] = row.Cells["PriceCaratUSD"].Value; }

                if (row.Cells["PriceCaratBaht"].Value != null)
                { tds.Tables[0].Rows[i]["PriceCarat"] = row.Cells["PriceCaratBaht"].Value; }

                if (row.Cells["USDRate"].Value != null)
                { tds.Tables[0].Rows[i]["USDRate"] = row.Cells["USDRate"].Value; }

                if (row.Cells["TotalUSD"].Value != null)
                { tds.Tables[0].Rows[i]["TotalUSD"] = row.Cells["TotalUSD"].Value; }

                if (row.Cells["TotalBath"].Value != null)
                { tds.Tables[0].Rows[i]["TotalBaht"] = row.Cells["TotalBath"].Value; }

                if (row.Cells["Note"].Value != null)
                { tds.Tables[0].Rows[i]["Note"] = row.Cells["Note"].Value; }

                i++;
            }

            tds.AcceptChanges();
        }

        protected override bool SaveData()
        {
            try
            {
                BindingDSDiamondDetail();
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    row["Code"] = GM.GetRunningNumber("GC");
                    SetCreateBy(row);
                    SetEditBy(row);
                }
                tds.AcceptChanges();
                chkFlag = ser.DoInsertData("BuyBookGemstoneCer", tds,1);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            BBJewelryDiamondDetailInfo frm = new BBJewelryDiamondDetailInfo(0, id);
            frm.ShowDialog();

            LoadData();
        }

        private void tds_Load(object sender, EventArgs e)
        {

        }
    }
}
