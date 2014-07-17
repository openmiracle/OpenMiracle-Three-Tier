using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for ProductBatchInfo    
//</summary>    
namespace ENTITY    
{    
public class ProductBatchInfo    
{    
    private decimal _productBatchId;    
    private decimal _productId;    
    private decimal _batchId;    
    private string _partNo;    
    private string _barcode;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal ProductBatchId    
    {    
        get { return _productBatchId; }    
        set { _productBatchId = value; }    
    }    
    public decimal ProductId    
    {    
        get { return _productId; }    
        set { _productId = value; }    
    }    
    public decimal BatchId    
    {    
        get { return _batchId; }    
        set { _batchId = value; }    
    }    
    public string PartNo    
    {    
        get { return _partNo; }    
        set { _partNo = value; }    
    }    
    public string Barcode    
    {    
        get { return _barcode; }    
        set { _barcode = value; }    
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
