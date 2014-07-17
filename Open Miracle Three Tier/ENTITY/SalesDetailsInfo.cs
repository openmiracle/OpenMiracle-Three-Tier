using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for SalesDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class SalesDetailsInfo    
{    
    private decimal _salesDetailsId;    
    private decimal _salesMasterId;    
    private decimal _deliveryNoteDetailsId;    
    private decimal _orderDetailsId;    
    private decimal _quotationDetailsId;    
    private decimal _productId;    
    private decimal _qty;    
    private decimal _rate;    
    private decimal _unitId;    
    private decimal _unitConversionId;    
    private decimal _discount;    
    private decimal _taxId;    
    private decimal _batchId;    
    private decimal _godownId;    
    private decimal _rackId;    
    private decimal _taxAmount;    
    private decimal _grossAmount;    
    private decimal _netAmount;    
    private decimal _amount;    
    private int _slNo;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal SalesDetailsId    
    {    
        get { return _salesDetailsId; }    
        set { _salesDetailsId = value; }    
    }    
    public decimal SalesMasterId    
    {    
        get { return _salesMasterId; }    
        set { _salesMasterId = value; }    
    }    
    public decimal DeliveryNoteDetailsId    
    {    
        get { return _deliveryNoteDetailsId; }    
        set { _deliveryNoteDetailsId = value; }    
    }    
    public decimal OrderDetailsId    
    {    
        get { return _orderDetailsId; }    
        set { _orderDetailsId = value; }    
    }    
    public decimal QuotationDetailsId    
    {    
        get { return _quotationDetailsId; }    
        set { _quotationDetailsId = value; }    
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
    public decimal Discount    
    {    
        get { return _discount; }    
        set { _discount = value; }    
    }    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
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
    public decimal TaxAmount    
    {    
        get { return _taxAmount; }    
        set { _taxAmount = value; }    
    }    
    public decimal GrossAmount    
    {    
        get { return _grossAmount; }    
        set { _grossAmount = value; }    
    }    
    public decimal NetAmount    
    {    
        get { return _netAmount; }    
        set { _netAmount = value; }    
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
