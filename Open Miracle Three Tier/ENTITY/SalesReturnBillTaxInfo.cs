using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for SalesReturnBillTaxInfo    
//</summary>    
namespace ENTITY    
{    
public class SalesReturnBillTaxInfo    
{    
    private decimal _salesReturnBillTaxId;    
    private decimal _salesReturnMasterId;    
    private decimal _taxId;    
    private decimal _taxAmount;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal SalesReturnBillTaxId    
    {    
        get { return _salesReturnBillTaxId; }    
        set { _salesReturnBillTaxId = value; }    
    }    
    public decimal SalesReturnMasterId    
    {    
        get { return _salesReturnMasterId; }    
        set { _salesReturnMasterId = value; }    
    }    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
    }    
    public decimal TaxAmount    
    {    
        get { return _taxAmount; }    
        set { _taxAmount = value; }    
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
