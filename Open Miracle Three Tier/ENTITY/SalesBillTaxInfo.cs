using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for SalesBillTaxInfo    
//</summary>    
namespace ENTITY    
{    
public class SalesBillTaxInfo    
{    
    private decimal _salesBillTaxId;    
    private decimal _salesMasterId;    
    private decimal _taxId;    
    private decimal _taxAmount;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal SalesBillTaxId    
    {    
        get { return _salesBillTaxId; }    
        set { _salesBillTaxId = value; }    
    }    
    public decimal SalesMasterId    
    {    
        get { return _salesMasterId; }    
        set { _salesMasterId = value; }    
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
