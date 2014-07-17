using System;
using System.Collections.Generic;
using System.Text;
using ENTITY;
//<summary>    
//Summary description for PriceListInfo    
//</summary>    
namespace ENTITY
{
    public class PriceListInfo
    {
        private decimal _pricelistId;
        private decimal _productId;
        private decimal _pricinglevelId;
        private decimal _unitId;
        private decimal _rate;
        private decimal _batchId;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public decimal PricelistId
        {
            get { return _pricelistId; }
            set { _pricelistId = value; }
        }
        public decimal ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public decimal PricinglevelId
        {
            get { return _pricinglevelId; }
            set { _pricinglevelId = value; }
        }
        public decimal UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        public decimal BatchId
        {
            get { return _batchId; }
            set { _batchId = value; }
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
