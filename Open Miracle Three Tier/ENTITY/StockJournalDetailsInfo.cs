using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for StockJournalDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class StockJournalDetailsInfo    
{    
    private decimal _stockJournalDetailsId;    
    private decimal _stockJournalMasterId;    
    private decimal _productId;    
    private decimal _qty;    
    private decimal _rate;    
    private decimal _unitId;    
    private decimal _unitConversionId;    
    private decimal _batchId;    
    private decimal _godownId;    
    private decimal _rackId;    
    private decimal _amount;    
    private string _consumptionOrProduction;    
    private int _slno;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal StockJournalDetailsId    
    {    
        get { return _stockJournalDetailsId; }    
        set { _stockJournalDetailsId = value; }    
    }    
    public decimal StockJournalMasterId    
    {    
        get { return _stockJournalMasterId; }    
        set { _stockJournalMasterId = value; }    
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
    public string ConsumptionOrProduction    
    {    
        get { return _consumptionOrProduction; }    
        set { _consumptionOrProduction = value; }    
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
