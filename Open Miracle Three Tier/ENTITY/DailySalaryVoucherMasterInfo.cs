using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY; 
//<summary>    
//Summary description for DailySalaryVoucherMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class DailySalaryVoucherMasterInfo    
{
    private decimal _dailySalaryVoucherMasterId;    
    private decimal _ledgerId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private DateTime _date;    
    private DateTime _salaryDate;    
    private decimal _totalAmount;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    private decimal _suffixPrefixId;    
    private decimal _voucherTypeId;
    private decimal _financialYearId;

    public decimal DailySalaryVoucehrMasterId    
    {
        get { return _dailySalaryVoucherMasterId; }
        set { _dailySalaryVoucherMasterId = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public string VoucherNo    
    {    
        get { return _voucherNo; }    
        set { _voucherNo = value; }    
    }    
    public string InvoiceNo    
    {    
        get { return _invoiceNo; }    
        set { _invoiceNo = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public DateTime SalaryDate    
    {    
        get { return _salaryDate; }    
        set { _salaryDate = value; }    
    }    
    public decimal TotalAmount    
    {    
        get { return _totalAmount; }    
        set { _totalAmount = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    public decimal SuffixPrefixId    
    {    
        get { return _suffixPrefixId; }    
        set { _suffixPrefixId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }
    public decimal FinancialYearId
    {
        get { return _financialYearId; }
        set { _financialYearId = value; }
    }
    
}    
}
