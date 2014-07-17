using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using ENTITY;
using OpenMiracle.BLL;

namespace Open_Miracle
{
    class ExportNew
    {
        public bool CheckWhetherOfficeInstalled()
        {
            // Checking whether excel is installed on system
            RegistryKey TargetKey = default(RegistryKey);
            TargetKey = Registry.ClassesRoot.OpenSubKey("excel.application");
            if (TargetKey == null)
            {
                MessageBox.Show("Install Office", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else
            {
                return true;
            }
        }
        
        public void ExportExcel(DataGridView dgv, string rptName, int inFirstRow, int inFirstCol, string Format, object dtFromDate, object dtToDate, string header)//, string credit, string debit, string closing)
        {
            try
            {
                if (CheckWhetherOfficeInstalled())
                {
                    int inColN = 1;
                    Cursor.Current = Cursors.WaitCursor;
                    string strName = "", strAddress = "", strPhone = "";

                    Excel.Range range = null;
                    Excel.Application excel = new Excel.Application();

                    Excel.Workbook wb = excel.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)excel.ActiveSheet;

                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    //BranchInfo InfoBranch = new BranchInfo();
                    //BranchSP SpBranch = new BranchSP();
                    // InfoBranch = SpBranch.BranchView(PublicVariables._branchId);
                    strAddress = listObjCompany[0].Rows[0].ItemArray[3].ToString().Replace("\r\n", " ");
                    strPhone = listObjCompany[0].Rows[0].ItemArray[4].ToString();
                    strName = listObjCompany[0].Rows[0].ItemArray[1].ToString();

                    //BranchInfo InfoBranch = new BranchInfo();
                    //BranchSP SpBranch = new BranchSP();
                    //InfoBranch = SpBranch.BranchView(PublicVariables._branchId);
                    //strAddress = InfoBranch.Address.Replace("\r\n", " ");
                    //if (InfoBranch.PhoneNo == "")
                    //{
                    //    strPhone = InfoBranch.Mobile;
                    //}
                    //else
                    //{
                    //    strPhone = InfoBranch.PhoneNo;
                    //}
                    //strName = InfoBranch.BranchName;

                    //**************Report Header ***************************************
                    //range = (Excel.Range)ws.Cells[1, 1];
                    range = ws.get_Range("A1", "I1");
                    range.MergeCells = true;
                    range.Font.Size = 15;
                    range.RowHeight = 27;
                    range.Interior.Color = ColorTranslator.ToWin32(Color.LightGray);
                    range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    range.Value2 = strName;

                    range = ws.get_Range("A2", "I2");
                    range.MergeCells = true;
                    range.Font.Size = 10;

                    range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.Value2 = strAddress;

                    range = ws.get_Range("A3", "I3");
                    range.MergeCells = true;
                    range.Font.Size = 10;

                    range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.Value2 = "Phone No :" + strPhone;

                    range = ws.get_Range("A5", "G5");
                    range.MergeCells = true;
                    range.Font.Size = 11;
                    range.Value2 = rptName;
                    range.Font.Underline = true;
                    range.Font.Bold = true;
                    range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    range = ws.get_Range("A6", "G6");
                    range.MergeCells = true;
                    //range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.Font.Size = 11;
                    if (dtFromDate != null && dtToDate != null)
                    {
                        range.Value2 = "(" + DateTime.Parse(dtFromDate.ToString()).Date.ToString("dd-MMM-yyyy") + "  To  " + DateTime.Parse(dtToDate.ToString()).Date.ToString("dd-MMM-yyyy") + ")";
                    }
                    else if (dtFromDate != null)
                    {
                        range.Value2 = DateTime.Parse(dtFromDate.ToString()).Date.ToString("dd-MMM-yyyy");
                    }
                    range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.MergeCells = true;
                    range.Font.Bold = true;


                    range = ws.get_Range("H5", "H5");
                    range.Value2 = "Date :";
                    range.Font.Bold = true;

                    range = ws.get_Range("I5", "I5");
                    range.Value2 = PublicVariables._dtCurrentDate.Date.ToString("dd-MMM-yyyy");
                    range.Font.Bold = true;
                   



                    int inNewRow = 0;
                    inNewRow = inFirstRow;


                    for (int inRow = inFirstRow; inRow < dgv.Rows.Count; inRow++)
                    {
                        if (dgv.Rows[inRow].Visible != false)
                        {
                            for (int inCol = inFirstCol; inCol < dgv.Columns.Count; inCol++)
                            {
                                if (inRow == 0)
                                {
                                    if (dgv.Columns[inCol].Visible == true)
                                    {
                                        range = (Excel.Range)ws.Cells[inNewRow + 8, inColN];
                                        range.Font.Bold = true;
                                        range.Interior.Color = ColorTranslator.ToWin32(Color.LightGray);
                                        range.Value2 = dgv.Columns[inCol].HeaderText;
                                    }
                                }
                                range = (Excel.Range)ws.Cells[inNewRow + 9, inColN];

                                if (dgv[inCol, inRow].Style.Font != null)
                                {
                                    if (dgv[inCol, inRow].Style.Font.Bold)
                                    {
                                        range.Font.Bold = true;
                                    }
                                }
                                if (dgv.Rows[inRow].DefaultCellStyle.BackColor == Color.LightSkyBlue)
                                {
                                    range.Font.Bold = true;
                                    range.Interior.Color = ColorTranslator.ToWin32(Color.LightGray);

                                }
                                if (dgv.Rows[inRow].DefaultCellStyle.ForeColor == Color.Red)
                                {
                                    range.Font.Bold = true;
                                    range.Interior.Color = ColorTranslator.ToWin32(Color.LightGray);
                                    
                                }

                                //if (dgv.Rows[inRow].Visible != false)
                                //{
                                if (dgv.Columns[inCol].Visible == true)
                                {

                                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlHairline, Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                                    if (dgv[inCol, inRow].Value != null)
                                    {
                                        string str = dgv[inCol, inRow].Value.ToString();

                                        try
                                        {
                                            if (dgv.Columns[inCol].HeaderText.Replace(" ", "").ToLower() == "phoneno" || dgv.Columns[inCol].HeaderText.Replace(" ", "").ToLower() == "phonenumber")
                                                range.NumberFormat = "@";
                                            else
                                            {
                                                decimal.Parse(str);
                                                decimal dc = Math.Round(decimal.Parse(str), 2);
                                                str = dc.ToString();
                                                if (dgv.Columns[inCol].Name.ToLower() == "debit" || dgv.Columns[inCol].Name.ToLower() == "credit")
                                                    range.NumberFormat = "#00.00#";
                                                else
                                                    range.NumberFormat = "General";
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            try
                                            {
                                                DateTime.Parse(str);
                                                range.NumberFormat = "dd-MMM-yyyy";
                                                range.NumberFormat = "General";
                                            }
                                            catch (Exception)
                                            {
                                                range.NumberFormat = "@";
                                            }
                                        }
                                        if (str.Contains("Dr") || str.Contains("Cr"))

                                            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                                        //try
                                        //{
                                        //    if (dgv.Columns[inCol].HeaderText.Replace(" ", "").ToLower() == "phoneno" || dgv.Columns[inCol].HeaderText.Replace(" ", "").ToLower() == "phonenumber")
                                        //        range.NumberFormat = "@";
                                        //    else
                                        //    {
                                        //        decimal.Parse(str);
                                        //        decimal dc = Math.Round(decimal.Parse(str), 2);
                                        //        str = dc.ToString();
                                        //    }
                                        //}
                                        //catch (Exception)
                                        //{
                                        //    try
                                        //    {
                                        //        DateTime.Parse(str);
                                        //        range.NumberFormat = "dd-MMM-yyyy";
                                        //        range.NumberFormat = "General";
                                        //    }
                                        //    catch (Exception)
                                        //    {
                                        //        //range.NumberFormat = "@";
                                        //        range.NumberFormat = "General";
                                        //    }
                                        //}
                                        //------------------------------------
                                        //------------------------------------
                                        range.Value2 = str;// dgv[inCol, inRow].Value;
                                        
                                    }
                                    inColN++;
                                }
                                //}
                            }
                            inColN = 1;
                            inNewRow++;
                        }
                    }
                    inNewRow = inNewRow + 10;
                    

                    ws.Columns.AutoFit();

                    if (Format == "Excel")
                    {
                        excel.Visible = true;
                    }
                    //else if (Format == "Html")
                    //{
                    //    //***********Deleting all format*************
                    //    ws.Columns.AutoFit();
                    //    FileInfo infoHtml = new FileInfo(Application.StartupPath + "\\Report.html");
                    //    if (infoHtml.Exists)
                    //    {
                    //        infoHtml.Delete();
                    //    }
                    //    //*******************************************

                    //    ws.SaveAs(Application.StartupPath + "\\Report.html", Excel.XlFileFormat.xlHtml, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    //    excel.Quit();
                    //    System.Diagnostics.Process.Start("IExplore.exe", Application.StartupPath + "\\Report.html");
                    //}
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Install office", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
