using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for SuffixPrefixInfo    
//</summary>    
namespace ENTITY    
{    
public class SuffixPrefixInfo    
{    
    private decimal _suffixprefixId;    
    private decimal _voucherTypeId;    
    private DateTime _fromDate;    
    private DateTime _toDate;    
    private decimal _startIndex;    
    private string _prefix;    
    private string _suffix;    
    private int _widthOfNumericalPart;    
    private bool _prefillWithZero;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal SuffixprefixId    
    {    
        get { return _suffixprefixId; }    
        set { _suffixprefixId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public DateTime FromDate    
    {    
        get { return _fromDate; }    
        set { _fromDate = value; }    
    }    
    public DateTime ToDate    
    {    
        get { return _toDate; }    
        set { _toDate = value; }    
    }    
    public decimal StartIndex    
    {    
        get { return _startIndex; }    
        set { _startIndex = value; }    
    }    
    public string Prefix    
    {    
        get { return _prefix; }    
        set { _prefix = value; }    
    }    
    public string Suffix    
    {    
        get { return _suffix; }    
        set { _suffix = value; }    
    }    
    public int WidthOfNumericalPart    
    {    
        get { return _widthOfNumericalPart; }    
        set { _widthOfNumericalPart = value; }    
    }    
    public bool PrefillWithZero    
    {    
        get { return _prefillWithZero; }    
        set { _prefillWithZero = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
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
