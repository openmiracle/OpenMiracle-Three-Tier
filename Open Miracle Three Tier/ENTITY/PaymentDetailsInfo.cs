using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PaymentDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class PaymentDetailsInfo    
{    
    private decimal _paymentDetailsId;    
    private decimal _paymentMasterId;    
    private decimal _ledgerId;    
    private decimal _amount;
    private decimal _exchangeRateId; 
    private string _chequeNo;    
    private DateTime _chequeDate;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal PaymentDetailsId    
    {    
        get { return _paymentDetailsId; }    
        set { _paymentDetailsId = value; }    
    }    
    public decimal PaymentMasterId    
    {    
        get { return _paymentMasterId; }    
        set { _paymentMasterId = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public decimal Amount    
    {    
        get { return _amount; }    
        set { _amount = value; }    
    }
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
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
