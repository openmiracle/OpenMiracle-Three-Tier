using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for SalesQuotationMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class SalesQuotationMasterInfo    
{    
    private decimal _quotationMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _voucherTypeId;    
    private decimal _suffixPrefixId;    
    private DateTime _date;    
    private decimal _pricinglevelId;    
    private decimal _ledgerId;    
    private decimal _employeeId;    
    private bool _approved;    
    private decimal _totalAmount;    
    private string _narration;    
    private decimal _financialYearId;    
    private DateTime _extraDate;
    private decimal _userId;   
    private string _extra1;    
    private string _extra2;
    private decimal _exchangeRateId;
    public decimal QuotationMasterId      
    {    
        get { return _quotationMasterId; }    
        set { _quotationMasterId = value; }    
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
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public decimal SuffixPrefixId    
    {    
        get { return _suffixPrefixId; }    
        set { _suffixPrefixId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public decimal PricinglevelId    
    {    
        get { return _pricinglevelId; }    
        set { _pricinglevelId = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public bool Approved    
    {    
        get { return _approved; }    
        set { _approved = value; }    
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
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
    }
    public decimal userId
    {
        get { return _userId; }
        set { _userId = value; }
    }
}    
}
