using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PurchaseBillTaxInfo    
//</summary>    
namespace ENTITY    
{    
public class PurchaseBillTaxInfo    
{    
    private decimal _purchaseBillTaxId;    
    private decimal _purchaseMasterId;    
    private decimal _taxId;    
    private decimal _taxAmount;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal PurchaseBillTaxId    
    {    
        get { return _purchaseBillTaxId; }    
        set { _purchaseBillTaxId = value; }    
    }    
    public decimal PurchaseMasterId    
    {    
        get { return _purchaseMasterId; }    
        set { _purchaseMasterId = value; }    
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
