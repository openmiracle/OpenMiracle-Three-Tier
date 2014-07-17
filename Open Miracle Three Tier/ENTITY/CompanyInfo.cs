using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for CompanyInfo    
//</summary>    
namespace ENTITY    
{
    public class CompanyInfo
    {
        private decimal _companyId;
        private string _companyName;
        private string _mailingName;
        private string _address;
        private string _phone;
        private string _mobile;
        private string _emailId;
        private string _web;
        private string _country;
        private string _state;
        private string _pin;
        private decimal _currencyId;
        private DateTime _financialYearFrom;
        private DateTime _booksBeginingFrom;
        private string _tin;
        private string _cst;
        private string _pan;
        private DateTime _currentDate;
        private byte[] _logo;
        private string _extra1;
        private string _extra2;
        private DateTime _extraDate;

        public decimal CompanyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public string MailingName
        {
            get { return _mailingName; }
            set { _mailingName = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }
        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }
        public decimal CurrencyId
        {
            get { return _currencyId; }
            set { _currencyId = value; }
        }
        public DateTime FinancialYearFrom
        {
            get { return _financialYearFrom; }
            set { _financialYearFrom = value; }
        }
        public DateTime BooksBeginingFrom
        {
            get { return _booksBeginingFrom; }
            set { _booksBeginingFrom = value; }
        }
        public string Tin
        {
            get { return _tin; }
            set { _tin = value; }
        }
        public string Cst
        {
            get { return _cst; }
            set { _cst = value; }
        }
        public string Pan
        {
            get { return _pan; }
            set { _pan = value; }
        }
        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set { _currentDate = value; }
        }
        public byte[] Logo
        {
            get { return _logo; }
            set { _logo = value; }
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
