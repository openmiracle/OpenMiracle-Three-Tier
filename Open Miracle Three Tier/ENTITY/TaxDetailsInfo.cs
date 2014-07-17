using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for TaxDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class TaxDetailsInfo    
{    
    private decimal _taxdetailsId;    
    private decimal _taxId;    
    private decimal _selectedtaxId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal TaxdetailsId    
    {    
        get { return _taxdetailsId; }    
        set { _taxdetailsId = value; }    
    }    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
    }    
    public decimal SelectedtaxId    
    {    
        get { return _selectedtaxId; }    
        set { _selectedtaxId = value; }    
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
