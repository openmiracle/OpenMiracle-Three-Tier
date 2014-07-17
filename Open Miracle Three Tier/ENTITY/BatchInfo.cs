using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for BatchInfo    
//</summary>    
namespace ENTITY    
{    
public class BatchInfo    
{    
    private decimal _batchId;    
    private string _batchNo;    
    private decimal _productId;    
    private DateTime _manufacturingDate;    
    private DateTime _expiryDate;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;
    private string _narration;
    private string _barcode;
    private string _partNo;
    public decimal BatchId    
    {    
        get { return _batchId; }    
        set { _batchId = value; }    
    }    
    public string BatchNo    
    {    
        get { return _batchNo; }    
        set { _batchNo = value; }    
    }    
    public decimal ProductId    
    {    
        get { return _productId; }    
        set { _productId = value; }    
    }    
    public DateTime ManufacturingDate    
    {    
        get { return _manufacturingDate; }    
        set { _manufacturingDate = value; }    
    }    
    public DateTime ExpiryDate    
    {    
        get { return _expiryDate; }    
        set { _expiryDate = value; }    
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
    public string narration
    {
        get { return _narration; }
        set { _narration = value; }
    }
    public string barcode
    {
        get { return _barcode; }
        set { _barcode = value; }
    }
    public string partNo
    {
        get { return _partNo; }
        set { _partNo = value; }
    }

}    
}
