using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for AdditionalCostInfo    
//</summary>    
namespace ENTITY    
{    
public class AdditionalCostInfo    
{    
    private decimal _additionalCostId;    
    private decimal _voucherTypeId;    
    private string _voucherNo;    
    private decimal _ledgerId;    
    private decimal _debit;    
    private decimal _credit;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal AdditionalCostId    
    {    
        get { return _additionalCostId; }    
        set { _additionalCostId = value; }    
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
