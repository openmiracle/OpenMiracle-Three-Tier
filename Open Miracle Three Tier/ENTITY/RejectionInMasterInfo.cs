using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for RejectionInMasterInfo    
//</summary>    
namespace ENTITY    
{
    public class RejectionInMasterInfo
    {
        private decimal _rejectionInMasterId;

        private string _voucherNo;
        private string _invoiceNo;
        private decimal _voucherTypeId;
        private decimal _suffixPrefixId;
        private DateTime _date;
        private decimal _ledgerId;
        private decimal _deliveryNoteMasterId;
        private decimal _pricinglevelId;
        private decimal _employeeId;
        private string _narration;
        private decimal _exchangeRateId;
        private decimal _totalAmount;
        private decimal _userId;
        private string _lrNo;
        private string _transportationCompany;
        private decimal _financialYearId;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public decimal RejectionInMasterId
        {
            get { return _rejectionInMasterId; }
            set { _rejectionInMasterId = value; }
        }

        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        public decimal VoucherTypeId
        {
            get { return _voucherTypeId; }
            set { _voucherTypeId = value; }
        }
        public decimal SuffixPrefixId
        {
            get { return _suffixPrefixId; }
            set { _suffixPrefixId = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public decimal LedgerId
        {
            get { return _ledgerId; }
            set { _ledgerId = value; }
        }
        public decimal DeliveryNoteMasterId
        {
            get { return _deliveryNoteMasterId; }
            set { _deliveryNoteMasterId = value; }
        }
        public decimal PricinglevelId
        {
            get { return _pricinglevelId; }
            set { _pricinglevelId = value; }
        }
        public decimal EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
        public decimal ExchangeRateId
        {
            get { return _exchangeRateId; }
            set { _exchangeRateId = value; }
        }
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        public decimal UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string LrNo
        {
            get { return _lrNo; }
            set { _lrNo = value; }
        }
        public string TransportationCompany
        {
            get { return _transportationCompany; }
            set { _transportationCompany = value; }
        }
        public decimal FinancialYearId
        {
            get { return _financialYearId; }
            set { _financialYearId = value; }
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
