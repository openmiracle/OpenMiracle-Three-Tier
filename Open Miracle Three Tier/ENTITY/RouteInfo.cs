using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for RouteInfo    
//</summary>    
namespace ENTITY    
{    
public class RouteInfo    
{    
    private decimal _routeId;    
    private string _routeName;    
    private decimal _areaId;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal RouteId    
    {    
        get { return _routeId; }    
        set { _routeId = value; }    
    }    
    public string RouteName    
    {    
        get { return _routeName; }    
        set { _routeName = value; }    
    }    
    public decimal AreaId    
    {    
        get { return _areaId; }    
        set { _areaId = value; }    
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
