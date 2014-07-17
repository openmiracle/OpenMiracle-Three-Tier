using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for RejectionOutDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class RejectionOutDetailsInfo    
{    
    private decimal _rejectionOutDetailsId;    
    private decimal _rejectionOutMasterId;    
    private decimal _materialReceiptDetailsId;    
    private decimal _productId;    
    private decimal _qty;    
    private decimal _rate;    
    private decimal _unitId;    
    private decimal _unitConversionId;    
    private decimal _batchId;    
    private decimal _godownId;    
    private decimal _rackId;    
    private decimal _amount;    
    private int _slno;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal RejectionOutDetailsId    
    {    
        get { return _rejectionOutDetailsId; }    
        set { _rejectionOutDetailsId = value; }    
    }    
    public decimal RejectionOutMasterId    
    {    
        get { return _rejectionOutMasterId; }    
        set { _rejectionOutMasterId = value; }    
    }    
    public decimal MaterialReceiptDetailsId    
    {    
        get { return _materialReceiptDetailsId; }    
        set { _materialReceiptDetailsId = value; }    
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
    public decimal Amount    
    {    
        get { return _amount; }    
        set { _amount = value; }    
    }    
    public int Slno    
    {    
        get { return _slno; }    
        set { _slno = value; }    
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
