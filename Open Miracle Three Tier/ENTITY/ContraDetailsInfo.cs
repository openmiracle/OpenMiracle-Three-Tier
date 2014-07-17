using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY; 
//<summary>    
//Summary description for ContraDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class ContraDetailsInfo    
{    
    private decimal _contraDetailsId;    
    private decimal _contraMasterId;    
    private decimal _ledgerId;    
    private decimal _amount;
    private decimal _exchangeRateId;    
    private string _chequeNo;    
    private DateTime _chequeDate;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal ContraDetailsId    
    {    
        get { return _contraDetailsId; }    
        set { _contraDetailsId = value; }    
    }    
    public decimal ContraMasterId    
    {    
        get { return _contraMasterId; }    
        set { _contraMasterId = value; }    
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
