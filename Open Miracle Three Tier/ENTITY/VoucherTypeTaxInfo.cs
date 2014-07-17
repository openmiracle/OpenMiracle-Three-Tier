using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for VoucherTypeTaxInfo    
//</summary>    
namespace ENTITY    
{    
public class VoucherTypeTaxInfo    
{    
    private decimal _voucherTypeTaxId;    
    private decimal _voucherTypeId;    
    private decimal _taxId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal VoucherTypeTaxId    
    {    
        get { return _voucherTypeTaxId; }    
        set { _voucherTypeTaxId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
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
