using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for ModelNoInfo    
//</summary>    
namespace ENTITY    
{    
public class ModelNoInfo    
{    
    private decimal _modelNoId;    
    private string _modelNo;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal ModelNoId    
    {    
        get { return _modelNoId; }    
        set { _modelNoId = value; }    
    }    
    public string ModelNo    
    {    
        get { return _modelNo; }    
        set { _modelNo = value; }    
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
