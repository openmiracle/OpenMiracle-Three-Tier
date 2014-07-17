using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for UnitInfo    
//</summary>    
namespace ENTITY    
{    
public class UnitInfo    
{    
    private decimal _unitId;    
    private string _unitName;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;
    private decimal _noOfDecimalplaces;
    private string _formalName;

    public decimal UnitId    
    {    
        get { return _unitId; }    
        set { _unitId = value; }    
    }    
    public string UnitName    
    {    
        get { return _unitName; }    
        set { _unitName = value; }    
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
    public decimal noOfDecimalplaces
    {
        get { return _noOfDecimalplaces; }
        set { _noOfDecimalplaces = value; }
    }
    public string formalName
    {
        get { return _formalName; }
        set { _formalName = value; }
    }    
}    
}
