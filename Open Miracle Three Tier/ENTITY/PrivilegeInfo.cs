using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PrivilegeInfo    
//</summary>    
namespace ENTITY    
{    
public class PrivilegeInfo    
{    
    private decimal _privilegeId;    
    private decimal _userId;    
    private string _formName;    
    private string _action;
    private decimal _roleId;
    private DateTime _extraDate;    
    private string _exatra1;    
    private string _extra2;    
    
    public decimal PrivilegeId    
    {    
        get { return _privilegeId; }    
        set { _privilegeId = value; }    
    }    
    public decimal UserId    
    {    
        get { return _userId; }    
        set { _userId = value; }    
    }    
    public string FormName    
    {    
        get { return _formName; }    
        set { _formName = value; }    
    }    
    public string Action    
    {    
        get { return _action; }    
        set { _action = value; }    
    }
    public decimal RoleId
    {
        get { return _roleId; }
        set { _roleId = value; }
    }
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _exatra1; }    
        set { _exatra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    
}    
}
