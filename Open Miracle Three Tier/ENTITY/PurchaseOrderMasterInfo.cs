using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PurchaseOrderMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class PurchaseOrderMasterInfo    
{    
    private decimal _purchaseOrderMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _suffixPrefixId;    
    private decimal _voucherTypeId;    
    private DateTime _date;    
    private decimal _ledgerId;    
    //private decimal _currencyCoversionId;    
    private DateTime _dueDate;    
    private bool _cancelled;    
    private decimal _employeeId;    
    private string _narration;    
    private decimal _totalAmount;    
    private decimal _userId; 
    private decimal _exchangeRateId;
    private decimal _financialYearId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal PurchaseOrderMasterId    
    {    
        get { return _purchaseOrderMasterId; }    
        set { _purchaseOrderMasterId = value; }    
    }    
    public string VoucherNo    
    {    
        get { return _voucherNo; }    
        set { _voucherNo = value; }    
    }
    public decimal exchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
    } 
    public string InvoiceNo    
    {    
        get { return _invoiceNo; }    
        set { _invoiceNo = value; }    
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
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    //public decimal CurrencyCoversionId    
    //{    
    //    get { return _currencyCoversionId; }    
    //    set { _currencyCoversionId = value; }    
    //}    
    public DateTime DueDate    
    {    
        get { return _dueDate; }    
        set { _dueDate = value; }    
    }    
    public bool Cancelled    
    {    
        get { return _cancelled; }    
        set { _cancelled = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public decimal TotalAmount    
    {    
        get { return _totalAmount; }    
        set { _totalAmount = value; }    
    }    
    public decimal UserId    
    {    
        get { return _userId; }    
        set { _userId = value; }    
    }    
    public decimal FinancialYearId    
    {    
        get { return _financialYearId; }    
        set { _financialYearId = value; }    
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
    
}    
}
