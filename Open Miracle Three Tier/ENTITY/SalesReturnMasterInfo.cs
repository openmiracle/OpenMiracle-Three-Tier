using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for SalesReturnMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class SalesReturnMasterInfo
{
    private decimal _salesReturnMasterId;
    private string _voucherNo;
    private string _invoiceNo;
    private decimal _voucherTypeId;
    private decimal _suffixPrefixId;
    private decimal _ledgerId;
    private decimal _salesMasterId;
    private decimal _salesAccount;
    private decimal _pricinglevelId;
    private decimal _employeeId;
    private string _narration;
    private decimal _exchangeRateId;
    private decimal _discount;
    private decimal _taxAmount;
    private decimal _userId;
    private string _lrNo;
    private string _transportationCompany;
    private DateTime _date;
    private decimal _totalAmount;
    private decimal _financialYearId;
    private DateTime _extraDate;
    private decimal _grandTotal;
    private string _extra1;
    private string _extra2;

    public decimal SalesReturnMasterId
    {
        get { return _salesReturnMasterId; }
        set { _salesReturnMasterId = value; }
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
    public decimal LedgerId
    {
        get { return _ledgerId; }
        set { _ledgerId = value; }
    }
    public decimal SalesMasterId
    {
        get { return _salesMasterId; }
        set { _salesMasterId = value; }
    }
    public decimal SalesAccount
    {
        get { return _salesAccount; }
        set { _salesAccount = value; }
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
    public decimal Discount
    {
        get { return _discount; }
        set { _discount = value; }
    }
    public decimal TaxAmount
    {
        get { return _taxAmount; }
        set { _taxAmount = value; }
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
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public decimal TotalAmount
    {
        get { return _totalAmount; }
        set { _totalAmount = value; }
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
    public decimal grandTotal
    {
        get { return _grandTotal; }
        set { _grandTotal = value; }
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
