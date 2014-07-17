using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for BomInfo    
//</summary>    
namespace ENTITY    
{    
public class BomInfo    
{    
    private decimal _bomId;    
    private decimal _productId;    
    private decimal _rowmaterialId;    
    private decimal _quantity;    
    private decimal _unitId;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal BomId    
    {    
        get { return _bomId; }    
        set { _bomId = value; }    
    }    
    public decimal ProductId    
    {    
        get { return _productId; }    
        set { _productId = value; }    
    }    
    public decimal RowmaterialId    
    {    
        get { return _rowmaterialId; }    
        set { _rowmaterialId = value; }    
    }    
    public decimal Quantity    
    {    
        get { return _quantity; }    
        set { _quantity = value; }    
    }    
    public decimal UnitId    
    {    
        get { return _unitId; }    
        set { _unitId = value; }    
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
