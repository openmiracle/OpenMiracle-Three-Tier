using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for StockJournalMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class StockJournalMasterInfo    
{    
    private decimal _stockJournalMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _suffixPrefixId;    
    private decimal _voucherTypeId;    
    private DateTime _date;    
    private string _narration;    
    private decimal _additionalCost;    
    private decimal _financialYearId;
    private decimal _exchangeRateId;
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal StockJournalMasterId    
    {    
        get { return _stockJournalMasterId; }    
        set { _stockJournalMasterId = value; }    
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
    public decimal AdditionalCost    
    {    
        get { return _additionalCost; }    
        set { _additionalCost = value; }    
    }    
    public decimal FinancialYearId    
    {    
        get { return _financialYearId; }    
        set { _financialYearId = value; }    
    }
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
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
