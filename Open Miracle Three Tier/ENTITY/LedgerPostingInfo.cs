using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for LedgerPostingInfo    
//</summary>    
namespace ENTITY    
{    
public class LedgerPostingInfo    
{    
    private decimal _ledgerPostingId;    
    private DateTime _date;    
    private decimal _voucherTypeId;     
    private string _voucherNo;    
    private decimal _ledgerId;    
    private decimal _debit;    
    private decimal _credit;    
     
    private decimal _detailsId;    
    private decimal _yearId;    
    private string _invoiceNo;
    private string _chequeNo;
    private DateTime _chequeDate;
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;  
  
    
    public decimal LedgerPostingId    
    {    
        get { return _ledgerPostingId; }    
        set { _ledgerPostingId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public decimal VoucherTypeId    
    {
        get { return _voucherTypeId; }
        set { _voucherTypeId = value; }    
    }    
    public string VoucherNo    
    {    
        get { return _voucherNo; }    
        set { _voucherNo = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public decimal Debit    
    {    
        get { return _debit; }    
        set { _debit = value; }    
    }    
    public decimal Credit    
    {    
        get { return _credit; }    
        set { _credit = value; }    
    }    
  
    public decimal DetailsId    
    {    
        get { return _detailsId; }    
        set { _detailsId = value; }    
    }    
    public decimal YearId    
    {    
        get { return _yearId; }    
        set { _yearId = value; }    
    }    
    public string InvoiceNo   
    {    
        get { return _invoiceNo; }    
        set { _invoiceNo = value; }    
    }
    public string ChequeNo
    {
        get { return _chequeNo; }
        set { _chequeNo = value; }
    }
    public DateTime ChequeDate
    {
        get { return _chequeDate; }
        set { _chequeDate = value; }
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
