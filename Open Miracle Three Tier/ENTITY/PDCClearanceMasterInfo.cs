using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PDCClearanceMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class PDCClearanceMasterInfo    
{    
    private decimal _PDCClearanceMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _suffixPrefixId;    
    private DateTime _date;    
    private decimal _ledgerId;    
    private string _type;    
    private decimal _againstId;    
    private decimal _voucherTypeId;    
    private string _narration;    
    private string _status;    
    private decimal _userId;    
    private decimal _financialYearId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal PDCClearanceMasterId    
    {    
        get { return _PDCClearanceMasterId; }    
        set { _PDCClearanceMasterId = value; }    
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
    public string Type    
    {    
        get { return _type; }    
        set { _type = value; }    
    }    
    public decimal AgainstId    
    {    
        get { return _againstId; }    
        set { _againstId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public string Status    
    {    
        get { return _status; }    
        set { _status = value; }    
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
