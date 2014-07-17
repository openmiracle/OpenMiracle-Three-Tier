using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for PhysicalStockMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class PhysicalStockMasterInfo    
{    
    private decimal _physicalStockMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _suffixPrefixId;    
    private decimal _voucherTypeId;    
    private DateTime _date;    
    private string _narration;    
    private decimal _totalAmount;    
    private decimal _financialYearId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal PhysicalStockMasterId    
    {    
        get { return _physicalStockMasterId; }    
        set { _physicalStockMasterId = value; }    
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
