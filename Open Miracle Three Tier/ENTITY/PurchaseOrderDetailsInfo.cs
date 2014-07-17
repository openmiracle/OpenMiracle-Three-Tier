using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PurchaseOrderDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class PurchaseOrderDetailsInfo    
{    
    private decimal _purchaseOrderDetailsId;    
    private decimal _purchaseOrderMasterId;    
    private decimal _productId;    
    private decimal _qty;    
    private decimal _rate;    
    private decimal _unitId;    
    private decimal _unitConversionId;    
    private decimal _amount;    
    private int _slNo;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;
    
    public decimal PurchaseOrderDetailsId    
    {    
        get { return _purchaseOrderDetailsId; }    
        set { _purchaseOrderDetailsId = value; }    
    }
   
    public decimal PurchaseOrderMasterId    
    {    
        get { return _purchaseOrderMasterId; }    
        set { _purchaseOrderMasterId = value; }    
    }    
    public decimal ProductId    
    {    
        get { return _productId; }    
        set { _productId = value; }    
    }    
    public decimal Qty    
    {    
        get { return _qty; }    
        set { _qty = value; }    
    }    
    public decimal Rate    
    {    
        get { return _rate; }    
        set { _rate = value; }    
    }    
    public decimal UnitId    
    {    
        get { return _unitId; }    
        set { _unitId = value; }    
    }    
    public decimal UnitConversionId    
    {    
        get { return _unitConversionId; }    
        set { _unitConversionId = value; }    
    }    
    public decimal Amount    
    {    
        get { return _amount; }    
        set { _amount = value; }    
    }    
    public int SlNo    
    {    
        get { return _slNo; }    
        set { _slNo = value; }    
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
