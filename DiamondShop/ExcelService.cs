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

        public static DataTable GetExcel(string FileName,int mode)
        {
            DataSet ds = new DataSet();
            DataTable dt = GetDatatable(mode);

            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                //Check จำนวน Column
                int maxColumn = 0;
                if (mode == 0) { maxColumn = 26; }
                else if (mode == 1) { maxColumn = 24; }

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;

                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = (range.Cells[i, 1] as Excel.Range).Value2;

                    if (dr[0].ToString() == "")
                    { break; }

                    for (int j = 1; j <= maxColumn; j++)
                    {
                        dr[j - 1] = (range.Cells[i, j] as Excel.Range).Value2;
                    }
                    dt.Rows.Add(dr);
                }
                dt.AcceptChanges();


                xlWorkBook.Close(true, null, null);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            catch(Exception ex)
            {
                
            }

            return dt;
        }

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
        public static DataTable GetDatatable(int mode)
        {
            DataTable dt = new DataTable();
            if (mode == 0)
            {
                dt.Columns.Add("Seller");
                dt.Columns.Add("ColorType");
                dt.Columns.Add("Shape");
                dt.Columns.Add("Cut");
                dt.Columns.Add("Polish");
                dt.Columns.Add("Symmetry");
                dt.Columns.Add("Fluorescent");
                dt.Columns.Add("Lab");
                dt.Columns.Add("ReportNumber");
                dt.Columns.Add("Weight");
                dt.Columns.Add("Color");
                dt.Columns.Add("Clearity");
                dt.Columns.Add("Shop");
                dt.Columns.Add("Price");
                dt.Columns.Add("Rap");
                dt.Columns.Add("Total");
                dt.Columns.Add("Inscription");
                dt.Columns.Add("Payment");
                dt.Columns.Add("USDRate");
                dt.Columns.Add("TotalBaht");
                dt.Columns.Add("Note");
                dt.Columns.Add("Buyer");
                dt.Columns.Add("W");
                dt.Columns.Add("L");
                dt.Columns.Add("D");
                dt.Columns.Add("Code2");
            }
            else if (mode == 1)
            {
                dt.Columns.Add("Seller");
                dt.Columns.Add("Shape");
                dt.Columns.Add("Cut");
                dt.Columns.Add("Weight");
                dt.Columns.Add("ReportNumber");
                dt.Columns.Add("Identification");
                dt.Columns.Add("Color");
                dt.Columns.Add("Lab");
                dt.Columns.Add("Origin");
                dt.Columns.Add("Comment");
                dt.Columns.Add("Shop");
                dt.Columns.Add("Payment");
                dt.Columns.Add("PayByUSD");
                dt.Columns.Add("PriceCaratUSD");
                dt.Columns.Add("PriceCaratBaht");
                dt.Columns.Add("USDRate");
                dt.Columns.Add("TotalUSD");
                dt.Columns.Add("TotalBath");
                dt.Columns.Add("Note");
                dt.Columns.Add("Buyer");
                dt.Columns.Add("W");
                dt.Columns.Add("L");
                dt.Columns.Add("D");
                dt.Columns.Add("Code2");
            }

            return dt;
        }

     }
 }
