using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for AccountGroupInfo    
//</summary>    
namespace ENTITY    
{    
public class AccountGroupInfo    
{    
    private decimal _accountGroupId;    
    private string _accountGroupName;    
    private decimal _groupUnder;    
    private string _narration;    
    private bool _isDefault;    
    private string _nature;    
    private string _affectGrossProfit;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;

    public decimal AccountGroupId    
    {    
        get { return _accountGroupId; }    
        set { _accountGroupId = value; }    
    }    
    public string AccountGroupName    
    {    
        get { return _accountGroupName; }    
        set { _accountGroupName = value; }    
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
    public bool IsDefault    
    {    
        get { return _isDefault; }    
        set { _isDefault = value; }    
    }    
    public string Nature    
    {    
        get { return _nature; }    
        set { _nature = value; }    
    }    
    public string AffectGrossProfit    
    {    
        get { return _affectGrossProfit; }    
        set { _affectGrossProfit = value; }    
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
