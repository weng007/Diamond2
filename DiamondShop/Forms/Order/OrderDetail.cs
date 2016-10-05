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
    public partial class OrderDetail : FormInfo
    {
        DataSet ds2 = new DataSet();
        DataSet tmp = new DataSet();
        int rowIndex, rowIndex1;
        int chkGrid, DelID;
        int flag;
        dsOrderDetail tds = new dsOrderDetail();
        dsBuyBookDiamondCer tds1 = new dsBuyBookDiamondCer();
        dsBuyBookGemstoneCer tds2 = new dsBuyBookGemstoneCer();
        public string materail = "";

        public OrderDetail()
        {
            InitializeComponent();
            Initial();
        }

        public OrderDetail(int id,string materail)
        {
            InitializeComponent();
            Initial();

            this.id = id;
            LoadData();
        }

        protected override void Initial()
        {
            grid1.AutoGenerateColumns = false;
            grid2.AutoGenerateColumns = false;
        }
        protected override void LoadData()
        {
            ds = ser.DoSelectData("OrderDetail", id,0);

            if (ds.Tables[1].Rows.Count > 0)
            {
                grid1.DataSource = ds.Tables[1];
                grid1.Refresh();
            }
            CalSum(0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grid2.DataSource = ds.Tables[0];
                grid2.Refresh();
            }
            CalSum(1);
            base.LoadData();
        }

        protected override bool SaveData()
        {
            try
            {
                BindingDSOrderDetail();
                chkFlag = ser.DoInsertData("OrderDetail", tds,0);

                GetMaterial();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return chkFlag;
        }
        protected override bool DeleteData()
        {
                try
                {
                    chkFlag = ser.DoDeleteData("OrderDetail", DelID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return chkFlag;
        }

        protected override bool ValidateData()
        {
            message = "";

            //if (txtWeight.Text == "" || GM.ConvertStringToDouble(txtWeight)==0)
            //{
            //    message = "Please input Weight > 0.\n";
            //}

            if (message == "") { return true; }
            else { return false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuyBookDiamondCerList frm = new BuyBookDiamondCerList(1);
            frm.ShowDialog();

            if (frm.refID1 != 0 && CheckDataExist(frm.refID1,0))
            {
                tmp = ser.DoSelectData("BuyBookDiamondCer", frm.refID1, 0);
                tds1.Clear();
                tds1.Merge(tmp);

                DataRow dr = ds.Tables[1].NewRow();
                dr["Code"] = tds1.Tables[0].Rows[0]["Code"];
                dr["ReportNumber"] = tds1.Tables[0].Rows[0]["ReportNumber"];
                dr["Weight"] = tds1.Tables[0].Rows[0]["Weight"];
                dr["LabName"] = tds1.Tables[0].Rows[0]["LabName"];
                dr["ShapeName"] = tds1.Tables[0].Rows[0]["ShapeName"];
                dr["ColorName"] = tds1.Tables[0].Rows[0]["ColorName"];
                dr["ClearityName"] = tds1.Tables[0].Rows[0]["ClearityName"];
                dr["TotalBaht"] = tds1.Tables[0].Rows[0]["TotalBaht"];
                dr["ShopName"] = tds1.Tables[0].Rows[0]["ShopName"];
                dr["RefID1"] = tds1.Tables[0].Rows[0]["ID"];
                dr["ID"] = tds1.Tables[0].Rows[0]["ID"];
                ds.Tables[1].Rows.Add(dr);

                grid1.DataSource = ds.Tables[1];
                grid1.RefreshEdit();
                CalSum(0);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid1.SelectedRows.Count > 0)
                {                 
                    if (grid1.Rows[rowIndex].Cells["ID"].Value != null)
                    {
                        DeleteDataGrid(0);
                    }

                    grid1.Rows.RemoveAt(rowIndex);
                }                       
            }
            catch(Exception ex)
            {

            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            BuyBookGemstoneCerList frm = new BuyBookGemstoneCerList(1);
            frm.ShowDialog();

            if (frm.refID2 != 0 && CheckDataExist(frm.refID2,1))
            {
                tmp = ser.DoSelectData("BuyBookGemstoneCer", frm.refID2, 0);
                tds2.Clear();
                tds2.Merge(tmp);

                DataRow dr = ds.Tables[0].NewRow();
                dr["Code"] = tds2.Tables[0].Rows[0]["Code"];
                dr["ReportNumber"] = tds2.Tables[0].Rows[0]["ReportNumber"];
                dr["IdentificationName"] = tds2.Tables[0].Rows[0]["IdentificationName"];
                dr["LabName"] = tds2.Tables[0].Rows[0]["LabName"];
                dr["ShapeName"] = tds2.Tables[0].Rows[0]["ShapeName"];
                dr["Weight"] = tds2.Tables[0].Rows[0]["Weight"];
                dr["ColorName"] = tds2.Tables[0].Rows[0]["ColorName"];
                dr["OriginName"] = tds2.Tables[0].Rows[0]["OriginName"];
                dr["TotalBaht"] = tds2.Tables[0].Rows[0]["TotalBaht"];
                dr["ShopName"] = tds2.Tables[0].Rows[0]["ShopName"];
                dr["RefID1"] = tds2.Tables[0].Rows[0]["ID"];
                dr["ID"] = tds2.Tables[0].Rows[0]["ID"];
                ds.Tables[0].Rows.Add(dr);

                grid2.DataSource = ds.Tables[0];
                grid2.RefreshEdit();
                CalSum(1);
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid2.SelectedRows.Count > 0)
                {
                    if (grid2.Rows[rowIndex].Cells["ID1"].Value != null)
                    {
                        DeleteDataGrid(1);
                    }

                    grid2.Rows.RemoveAt(rowIndex);
                }
            }
            catch (Exception ex)
            {

            }
        }

        #region Binding Grid, Dataset
        private void BindingGridDiamondDetail(DataGridView grid)
        {
            int i = 0;

            if (grid.Name == "grid1")
            {
                foreach (DataRow row in tds.Tables[0].Rows)
                {
                    grid1.Rows.Add();
                    grid1.Rows[i].Cells["ID"].Value = row["ID"].ToString();
                    grid1.Rows[i].Cells["RowNum"].Value = row["RowNum"].ToString();
                    grid1.Rows[i].Cells["Code1"].Value = row["Code"].ToString();
                    grid1.Rows[i].Cells["Code2"].Value = row["Code2"].ToString();
                    grid1.Rows[i].Cells["ReportNumber"].Value = row["ReportNumber"].ToString();
                    grid1.Rows[i].Cells["LabName"].Value = row["LabName"].ToString();
                    grid1.Rows[i].Cells["ShapeName"].Value = row["ShapeName"].ToString();
                    grid1.Rows[i].Cells["Weight1"].Value = row["Weight"].ToString();
                    grid1.Rows[i].Cells["ColorName"].Value = row["ColorName"].ToString();
                    grid1.Rows[i].Cells["ClearityName"].Value = row["ClearityName"].ToString();
                    grid1.Rows[i].Cells["TotalBaht"].Value = row["TotalBaht"].ToString();
                    grid1.Rows[i].Cells["ShopName"].Value = row["ShopName"].ToString();
                    grid1.Rows[i].Cells["refID"].Value = row["refID"].ToString();

                    i++;
                }

                i = 0;
                CalSum(0);
            }

            else if (grid.Name == "grid2")
            {
                foreach (DataRow row in tds2.Tables[0].Rows)
                {
                    grid2.Rows.Add();
                    grid2.Rows[i].Cells["ID1"].Value = row["ID"].ToString();
                    grid2.Rows[i].Cells["RowNum2"].Value = row["RowNum"].ToString();
                    grid2.Rows[i].Cells["Code11"].Value = row["Code"].ToString();
                    grid2.Rows[i].Cells["Code22"].Value = row["Code2"].ToString();
                    grid2.Rows[i].Cells["ReportNumber2"].Value = row["ReportNumber"].ToString();
                    grid2.Rows[i].Cells["IdentificationName"].Value = row["IdentificationName"].ToString();
                    grid2.Rows[i].Cells["LabName2"].Value = row["LabName"].ToString();
                    grid2.Rows[i].Cells["ShapeName2"].Value = row["ShapeName"].ToString();
                    grid2.Rows[i].Cells["Weight2"].Value = row["Weight"].ToString();
                    grid2.Rows[i].Cells["ColorName2"].Value = row["ColorName"].ToString();
                    grid2.Rows[i].Cells["OriginName"].Value = row["OriginName"].ToString();
                    grid2.Rows[i].Cells["TotalBaht2"].Value = row["TotalBaht"].ToString();
                    grid2.Rows[i].Cells["ShopName2"].Value = row["ShopName"].ToString();
                    grid2.Rows[i].Cells["refID1"].Value = row["refID"].ToString();

                    i++;
                    CalSum(1);
                }
            }
        }

        private void BindingDSOrderDetail()
        {
           tds.Clear();
           for(int i = 0;i < ds.Tables[1].Rows.Count;i++)
            {
                if (ds.Tables[1].Rows[i]["ID"].ToString() == "")
                {
                    DataRow dr = tds.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RefID1"] = ds.Tables[1].Rows[i]["RefID1"];
                    dr["flag"] = 0;
                    SetCreateBy(dr);
                    SetEditBy(dr);

                    tds.Tables[0].Rows.Add(dr);
                }                
            }

           //GemstoneCer
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["ID"].ToString() == "")
                {
                    DataRow dr = tds.Tables[0].NewRow();

                    dr["RefID"] = id;
                    dr["RefID1"] = ds.Tables[0].Rows[i]["RefID1"];
                    dr["flag"] = 1;
                    SetCreateBy(dr);
                    SetEditBy(dr);

                    tds.Tables[0].Rows.Add(dr);
                }             
            }

            tds.AcceptChanges();
        }
        #endregion

        private void CalSum(int type)
        {
            if(type == 0)
            {
                txtSumWeight.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight1"].Value))).ToString();

                txtSumCost.Text = (grid1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["TotalBaht"].Value))).ToString();

                txtSumWeight.Text = GM.ConvertDoubleToString(txtSumWeight);
                txtSumCost.Text = GM.ConvertDoubleToString(txtSumCost,0);
            }
            if (type == 1)
            {
                txtSumWeight1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["Weight2"].Value))).ToString();

                txtSumCost1.Text = (grid2.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["TotalBaht2"].Value))).ToString();

                txtSumWeight1.Text = GM.ConvertDoubleToString(txtSumWeight1);
                txtSumCost1.Text = GM.ConvertDoubleToString(txtSumCost1, 0);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid2.Rows.Count > 0)
                {
                    if (grid2.Rows[rowIndex].Cells["ID"].Value != null && Convert.ToInt16(grid2.Rows[rowIndex].Cells["ID"].Value.ToString()) > 0)
                    {
                        DeleteDataGrid(0);
                    }

                }
                grid2.Rows.RemoveAt(rowIndex);
                tds.Tables[0].Rows[rowIndex].Delete();
                tds.AcceptChanges();


            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteDataGrid(int type)
        {
             DeleteData();
        }

        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (grid.Name == "grid1")
                {
                    rowIndex = e.RowIndex;
                    if (grid1.Rows[e.RowIndex].Cells["ID"].Value != null)
                    { DelID = Convert.ToInt16(grid1.Rows[e.RowIndex].Cells["ID"].Value.ToString()); }
                }
                else
                {
                    rowIndex1 = e.RowIndex;

                    if (grid2.Rows[e.RowIndex].Cells["ID1"].Value != null)
                    { DelID = Convert.ToInt16(grid2.Rows[e.RowIndex].Cells["ID1"].Value.ToString()); }

                }
            }
        }

        private bool CheckDataExist(int tmp,int flag)
        {
            if(flag == 0)
            {
                if (grid1.Rows.Count > 0)
                {
                    for(int i = 0; i < grid1.Rows.Count; i++)
                    {
                         if(tmp == Convert.ToInt32(grid1.Rows[i].Cells["RefID1"].Value))
                         {
                                return false;
                         }
                     }
                 }
            }
            else
            {
                if (grid2.Rows.Count > 0)
                {
                    for (int i = 0; i < grid2.Rows.Count; i++)
                    {
                        if (tmp == Convert.ToInt32(grid2.Rows[i].Cells["RefID2"].Value))
                        {
                            return false;
                        }
                    }
                }
            }
            

            return true;
        }

        private void GetMaterial()
        {
            int i = 1;
            foreach (DataRow row in tds1.Tables[0].Rows)
            {
                materail += i.ToString()+"."+ row["Code"].ToString()+","+" "+row["Weight"].ToString()+"Ct."+"\n";
            }
          
            foreach (DataRow row in tds2.Tables[0].Rows)
            {
                materail += i.ToString() + "." + row["Code"].ToString() + "," + " "+row["IdentificationName"].ToString() + "," + " " + row["Weight"].ToString() + "Ct." + "\n";
            }
        }
    }
}
