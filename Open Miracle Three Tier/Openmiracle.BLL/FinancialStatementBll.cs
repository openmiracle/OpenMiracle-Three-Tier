using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;

namespace OpenMiracle.BLL
{
    public class FinancialStatementBll
    {
        FinancialStatementSP spFinancialStatement = new FinancialStatementSP();

        public List<DataTable> CashOrBankBookGridFill(DateTime fromDate, DateTime toDate, string groupId, bool isShowOpBalance)
        {
            List<DataTable> list = new List<DataTable>();
            try
            {


                list = spFinancialStatement.CashOrBankBookGridFill(fromDate, toDate, groupId, isShowOpBalance);
            }

            catch (Exception ex)
            {
                MessageBox.Show("FS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public DataSet BalanceSheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
               try
            {
                dset = spFinancialStatement. BalanceSheet( fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }
        public decimal StockValueGetOnDate(DateTime date, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
        {
            
            decimal decIdentity = 0;
            try
            {
                decIdentity = spFinancialStatement.StockValueGetOnDate( date,  calculationMethod,  isOpeningStock,  isFromBalanceSheet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(DateTime fromDate, DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement. ProfitAndLossAnalysisUpToaDateForBalansheet( fromDate,  toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(DateTime toDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.ProfitAndLossAnalysisUpToaDateForPreviousYears( toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
 
        }
       
 
        
        public DataSet FundFlow(DateTime strfromDate, DateTime strtoDate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.FundFlow( strfromDate,  strtoDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }
        public DataSet ProfitAndLossAnalysis(DateTime dtFromdate, DateTime dtTodate)
        {
            DataSet dset = new DataSet();
            try
            {
                dset = spFinancialStatement.ProfitAndLossAnalysis( dtFromdate,  dtTodate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FS8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dset;
        }
      
       public List<DataTable> ProfitAndLossReportPrintCompany(decimal decCompanyId)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {


               list = spFinancialStatement.ProfitAndLossReportPrintCompany( decCompanyId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("FS9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public decimal StockValueGetOnDate(DateTime date, DateTime dtToDate, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet)
       {
           decimal decIdentity = 0;
           try
           {
               decIdentity = spFinancialStatement. StockValueGetOnDate( date,  dtToDate,  calculationMethod,  isOpeningStock,  isFromBalanceSheet);
           }
           catch (Exception ex)
           {
               MessageBox.Show("FS10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;
       }
       public DataSet TrialBalance(DateTime fromDate, DateTime toDate, decimal decAccountGroupId)
       {
           DataSet dset = new DataSet();
           try
           {
               dset = spFinancialStatement.TrialBalance( fromDate,toDate,decAccountGroupId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("FS12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dset;
       }
       public List<DataTable> FundFlowReportPrintCompany(decimal decCompanyId)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               list = spFinancialStatement.FundFlowReportPrintCompany(decCompanyId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("FS13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public List<DataTable> CashflowReportPrintCompany(decimal decCompanyId)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               list = spFinancialStatement.CashflowReportPrintCompany(decCompanyId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("FS14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
         public List<DataTable> DayBookReportPrintCompany()
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               list = spFinancialStatement.DayBookReportPrintCompany();
           }

           catch (Exception ex)
           {
               MessageBox.Show("FS15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
         public DataSet CashFlow(DateTime strfromDate, DateTime strtoDate)
         {
             DataSet dset = new DataSet();
             try
             {
                 dset = spFinancialStatement.CashFlow( strfromDate, strtoDate);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("FS16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return dset;
         }
         public List< DataTable> DayBook(DateTime dtFromDate, DateTime dtToDate, decimal decVoucherTypeId, decimal decLedgerId, bool blCondenced)
         {
             List<DataTable> list = new List<DataTable>();
           try
           {
               list = spFinancialStatement. DayBook( dtFromDate,  dtToDate,  decVoucherTypeId,  decLedgerId,  blCondenced);
           }

           catch (Exception ex)
           {
               MessageBox.Show("FS17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
         }
            
             
        }
    }

