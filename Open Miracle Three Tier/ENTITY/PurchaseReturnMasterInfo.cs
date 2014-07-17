using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for PurchaseReturnMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class PurchaseReturnMasterInfo    
{    
    private decimal _purchaseReturnMasterId;    
    private string _voucherNo;    
    private string _invoiceNo;    
    private decimal _suffixPrefixId;    
    private decimal _voucherTypeId;    
    private DateTime _date;
    private decimal _purchaseMasterId;   
    private decimal _ledgerId;
    private decimal _discount;
    private string _narration;    
    private decimal _purchaseAccount;    
    private decimal _totalTax;
    private decimal _grandTotal; 
    private decimal _totalAmount;    
    private decimal _userId;    
    private string _lrNo;    
    private string _transportationCompany;    
    private decimal _financialYearId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;
    private decimal _exchangeRateId;

    public decimal PurchaseReturnMasterId    
    {    
        get { return _purchaseReturnMasterId; }    
        set { _purchaseReturnMasterId = value; }    
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
    public decimal SuffixPrefixId    
    {    
        get { return _suffixPrefixId; }    
        set { _suffixPrefixId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }
    public decimal PurchaseMasterId
    {
        get { return _purchaseMasterId; }
        set { _purchaseMasterId = value; }
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }
    public decimal Discount
    {
        get { return _discount; }
        set { _discount = value; }
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public decimal PurchaseAccount    
    {    
        get { return _purchaseAccount; }    
        set { _purchaseAccount = value; }    
    }    
    public decimal TotalTax    
    {    
        get { return _totalTax; }    
        set { _totalTax = value; }    
    }
    public decimal GrandTotal
    {
        get { return _grandTotal; }
        set { _grandTotal = value; }
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
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
    }
    
}    
}
