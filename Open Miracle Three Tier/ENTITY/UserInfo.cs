using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for UserInfo    
//</summary>    
namespace ENTITY    
{    
public class UserInfo    
{    
    private decimal _userId;    
    private string _userName;    
    private string _password;    
    private bool _active;
    private decimal _roleId;
    private string _narration;
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal UserId    
    {    
        get { return _userId; }    
        set { _userId = value; }    
    }    
    public string UserName    
    {    
        get { return _userName; }    
        set { _userName = value; }    
    }    
    public string Password    
    {    
        get { return _password; }    
        set { _password = value; }    
    }    
    public bool Active    
    {    
        get { return _active; }    
        set { _active = value; }    
    }
     public decimal  RoleId   
    {
        get { return _roleId; }
        set { _roleId = value; }    
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
