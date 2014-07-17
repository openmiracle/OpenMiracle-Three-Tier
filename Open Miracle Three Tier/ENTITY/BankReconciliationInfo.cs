using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for BankReconciliationInfo    
//</summary>    
namespace ENTITY    
{    
public class BankReconciliationInfo    
{    
    private decimal _reconcileId;    
    private decimal _ledgerPostingId;    
    private DateTime _statementDate;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal ReconcileId    
    {    
        get { return _reconcileId; }    
        set { _reconcileId = value; }    
    }    
    public decimal LedgerPostingId    
    {    
        get { return _ledgerPostingId; }    
        set { _ledgerPostingId = value; }    
    }    
    public DateTime StatementDate    
    {    
        get { return _statementDate; }    
        set { _statementDate = value; }    
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
