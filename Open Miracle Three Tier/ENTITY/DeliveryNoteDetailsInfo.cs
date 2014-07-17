using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for DeliveryNoteDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class DeliveryNoteDetailsInfo    
{    
    private decimal _deliveryNoteDetails1Id;    
    private decimal _deliveryNoteMasterId;    
    private decimal _orderDetails1Id;    
    private decimal _productId;    
    private decimal _qty;    
    private decimal _rate;    
    private decimal _unitId;    
    private decimal _unitConversionId;    
    private decimal _amount;    
    private decimal _quotationDetails1Id;    
    private decimal _batchId;    
    private decimal _godownId;    
    private decimal _rackId;    
    private int _slNo;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal DeliveryNoteDetails1Id    
    {    
        get { return _deliveryNoteDetails1Id; }    
        set { _deliveryNoteDetails1Id = value; }    
    }    
    public decimal DeliveryNoteMasterId    
    {    
        get { return _deliveryNoteMasterId; }    
        set { _deliveryNoteMasterId = value; }    
    }    
    public decimal OrderDetails1Id    
    {    
        get { return _orderDetails1Id; }    
        set { _orderDetails1Id = value; }    
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
    public decimal QuotationDetails1Id    
    {    
        get { return _quotationDetails1Id; }    
        set { _quotationDetails1Id = value; }    
    }    
    public decimal BatchId    
    {    
        get { return _batchId; }    
        set { _batchId = value; }    
    }    
    public decimal GodownId    
    {    
        get { return _godownId; }    
        set { _godownId = value; }    
    }    
    public decimal RackId    
    {    
        get { return _rackId; }    
        set { _rackId = value; }    
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
