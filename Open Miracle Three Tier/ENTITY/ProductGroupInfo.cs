using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for ProductGroupInfo    
//</summary>    
namespace ENTITY    
{    
public class ProductGroupInfo    
{    
    private decimal _groupId;    
    private string _groupName;    
    private decimal _groupUnder;    
    private string _narration;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal GroupId    
    {    
        get { return _groupId; }    
        set { _groupId = value; }    
    }    
    public string GroupName    
    {    
        get { return _groupName; }    
        set { _groupName = value; }    
    }    
    public decimal GroupUnder    
    {    
        get { return _groupUnder; }    
        set { _groupUnder = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
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
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    
}    
}
