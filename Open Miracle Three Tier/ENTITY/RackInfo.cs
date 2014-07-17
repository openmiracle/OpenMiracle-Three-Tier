using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for RackInfo    
//</summary>    
namespace ENTITY    
{    
public class RackInfo    
{    
    private decimal _rackId;    
    private string _rackName;    
    private decimal _godownId;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal RackId    
    {    
        get { return _rackId; }    
        set { _rackId = value; }    
    }    
    public string RackName    
    {    
        get { return _rackName; }    
        set { _rackName = value; }    
    }    
    public decimal GodownId    
    {    
        get { return _godownId; }    
        set { _godownId = value; }    
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
