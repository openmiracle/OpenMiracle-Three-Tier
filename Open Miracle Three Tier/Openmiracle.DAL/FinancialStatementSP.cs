//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
using ENTITY;
namespace OpenMiracle.DAL
{
    public class FinancialStatementSP : DBConnection
    {
        /// <summary>
        /// Function to get the details of Fund flow
        /// </summary>
        /// <param name="strfromDate"></param>
        /// <param name="strtoDate"></param>
        /// <returns></returns>
        public DataSet FundFlow(DateTime strfromDate, DateTime strtoDate)
        {
            DataSet dsetFundflow = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("FundFlow", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strtoDate;
                sqlda.Fill(dsetFundflow);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return dsetFundflow;
        }
        /// <summary>
        /// Function to get all are the details to fill the balance sheet based on the date
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public DataSet BalanceSheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BalanceSheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        /// <summary>
        /// Function to get the details to ProfitAndLoss Analysis
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtTodate"></param>
        /// <returns></returns>
        public DataSet ProfitAndLossAnalysis(DateTime dtFromdate, DateTime dtTodate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProfitAndLossAnalysis", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlda.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        /// <summary>
        /// Function to print the fundflow report of the compony
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public List<DataTable> FundFlowReportPrintCompany(decimal decCompanyId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("FundFlowReportPrintCompany", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to print the detals of profit and loss of the company
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public List<DataTable> ProfitAndLossReportPrintCompany(decimal decCompanyId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProfitAndLossReportPrintCompany", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get all are the details to fill the TrialBalance
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public DataSet TrialBalance(DateTime fromDate, DateTime toDate, decimal decAccountGroupId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("Trialbalance", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
                sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Function to get Stock Value get On Date
        /// </summary>
        /// <param name="date"></param>
        /// <param name="calculationMethod"></param>
        /// <param name="isOpeningStock"></param>
        /// <param name="isFromBalanceSheet"></param>
        /// <returns></returns>
        public decimal StockValueGetOnDate(DateTime date, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
        {
            decimal dcstockValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                object obj = null;
                SqlParameter prm = new SqlParameter();
                SqlCommand sccmd = new SqlCommand();
                if (calculationMethod == "FIFO")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            prm.Value = PublicVariables._dtFromDate;
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            //prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                            prm.Value = PublicVariables._dtToDate;
                        }
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByFIFO", sqlcon);
                    }
                }
                else if (calculationMethod == "Average Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByAVCOForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByAVCOForOpeningStockForBalanceSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtToDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByAVCO", sqlcon);
                    }
                }
                else if (calculationMethod == "High Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByHighCostForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByHighCostForOpeningStockBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtFromDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByHighCost", sqlcon);
                    }
                }
                else if (calculationMethod == "Low Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLowCostForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLowCostForOpeningStockForBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtFromDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByLowCost", sqlcon);
                    }
                }
                else if (calculationMethod == "Last Purchase Rate")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStockBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtFromDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRate", sqlcon);
                    }
                }
                sccmd.CommandType = CommandType.StoredProcedure;
                prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                prm.Value = date;
                obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decimal.TryParse(obj.ToString(), out dcstockValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dcstockValue;
        }
        /// <summary>
        /// Function to get Stock value on date for Profit and loss account
        /// </summary>
        /// <param name="date"></param>
        /// <param name="dtToDate"></param>
        /// <param name="calculationMethod"></param>
        /// <param name="isOpeningStock"></param>
        /// <param name="isFromBalanceSheet"></param>
        /// <returns></returns>
        public decimal StockValueGetOnDate(DateTime date, DateTime dtToDate, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
        {
            decimal dcstockValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                object obj = null;
                SqlParameter prm = new SqlParameter();
                SqlCommand sccmd = new SqlCommand();
                if (calculationMethod == "FIFO")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStock", sqlcon);
                            prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                            prm.Value = PublicVariables._dtToDate;
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByFIFOForOpeningStockForBalancesheet", sqlcon);
                            prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                            prm.Value = PublicVariables._dtToDate;
                        }
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByFIFO", sqlcon);
                    }
                }
                else if (calculationMethod == "Average Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByAVCOForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByAVCOForOpeningStockForBalanceSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = dtToDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByAVCO", sqlcon);
                    }
                }
                else if (calculationMethod == "High Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByHighCostForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByHighCostForOpeningStockBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtToDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByHighCost", sqlcon);
                    }
                }
                else if (calculationMethod == "Low Cost")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLowCostForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLowCostForOpeningStockForBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = PublicVariables._dtToDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByLowCost", sqlcon);
                    }
                }
                else if (calculationMethod == "Last Purchase Rate")
                {
                    if (isOpeningStock)
                    {
                        if (!isFromBalanceSheet)
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStock", sqlcon);
                        }
                        else
                        {
                            sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRateForOpeningStockBlncSheet", sqlcon);
                        }
                        prm = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                        prm.Value = dtToDate;
                    }
                    else
                    {
                        sccmd = new SqlCommand("StockValueOnDateByLastPurchaseRate", sqlcon);
                    }
                }
                sccmd.CommandType = CommandType.StoredProcedure;
                prm = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                prm.Value = date;
                obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decimal.TryParse(obj.ToString(), out dcstockValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dcstockValue;
        }
        /// <summary>
        /// Function to fill the details of daybook form
        /// </summary>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="blCondenced"></param>
        /// <returns></returns>
        public List< DataTable> DayBook(DateTime dtFromDate, DateTime dtToDate, decimal decVoucherTypeId, decimal decLedgerId, bool blCondenced)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("DayBook", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@iscondensed", SqlDbType.VarChar).Value = blCondenced;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to print the daybook trasaction about the company
        /// </summary>
        /// <returns></returns>
        public List<DataTable> DayBookReportPrintCompany()
        {
            List<DataTable> listDayBook = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DayBookReportPrintCompany", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listDayBook.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listDayBook;
        }
        /// <summary>
        /// Function to Profit And Loss Analysis UpTo Date For Balansheet
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForBalansheet", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        /// <summary>
        /// Function to Profit And Loss Analysis UpTo a Date For Previous Years
        /// </summary>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitAndLossAnalysisUpToaDateForPreviousYears", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = toDate;
                sdaadapter.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dset;
        }
        /// <summary>
        /// Function to fill the details about the cash flow
        /// </summary>
        /// <param name="strfromDate"></param>
        /// <param name="strtoDate"></param>
        /// <returns></returns>
        public DataSet CashFlow(DateTime strfromDate, DateTime strtoDate)
        {
            DataSet dsetCashflow = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CashFlow", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strtoDate;
                sqlda.Fill(dsetCashflow);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return dsetCashflow;
        }
        /// <summary>
        /// Function to print the details about the cash flow of compony
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public List<DataTable> CashflowReportPrintCompany(decimal decCompanyId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CashFlowReportPrintCompany", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to fill the details about the cash or bankbook in the curresponding form
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="groupId"></param>
        /// <param name="isShowOpBalance"></param>
        /// <returns></returns>
        public  List<DataTable> CashOrBankBookGridFill(DateTime fromDate, DateTime toDate, string groupId, bool isShowOpBalance)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankBookGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                prm.Value = fromDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                prm.Value = toDate;
                prm = sdaadapter.SelectCommand.Parameters.Add("@isShowOpeningBalance", SqlDbType.Bit);
                prm.Value = isShowOpBalance;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
       
    }
}
