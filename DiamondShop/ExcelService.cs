using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using DiamondDS.DS;

namespace DiamondShop
{
    class ExcelService
    {
        public static DataTable GetExcel(string FileName)
        {
            DataSet ds = new DataSet();
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            //string str;
            int rCnt = 2;
            int cCnt = 1;


            DataTable dt = new DataTable();

            dt.Columns.Add("Seller");
            dt.Columns.Add("Color Type");
            dt.Columns.Add("Cut");
            dt.Columns.Add("Polish");
            dt.Columns.Add("Symmetry");
            dt.Columns.Add("Fluorescense");
            dt.Columns.Add("Lab");
            dt.Columns.Add("Report Number");
            dt.Columns.Add("Weight");
            dt.Columns.Add("Shape");
            dt.Columns.Add("Color");
            dt.Columns.Add("Clearity");
            dt.Columns.Add("Shop");
            dt.Columns.Add("Price");
            dt.Columns.Add("Rap");
            dt.Columns.Add("Setting");
            dt.Columns.Add("Status");
            dt.Columns.Add("Inscription");
            dt.Columns.Add("Payment");
            dt.Columns.Add("USD Rate");
            dt.Columns.Add("Total Baht");
            dt.Columns.Add("Note");

            xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open("csharp.net-informations.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkBook = xlApp.Workbooks.Open(FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkBook = xlApp.Workbooks.Open()
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
            {
                DataRow dr = dt.NewRow();

                if ((range.Cells[rCnt, cCnt] as Excel.Range) == null)
                { break; }

                for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                {
                    dr[cCnt] = (range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                }
                dt.Rows.Add(dr);             
            }
            dt.AcceptChanges();

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            return dt;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

            public static void releaseObject(object obj)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
                catch (Exception ex)
                {
                    obj = null;
                    MessageBox.Show("Unable to release the Object " + ex.ToString());
                }
                finally
                {
                    GC.Collect();
                }

            }
        }
    }
