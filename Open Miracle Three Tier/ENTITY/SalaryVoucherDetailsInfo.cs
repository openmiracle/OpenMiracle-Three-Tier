using System;
using System.Collections.Generic;
using System.Text;
using ENTITY;
//<summary>    
//Summary description for SalaryVoucherDetailsInfo    
//</summary>    
namespace ENTITY
{
    public class SalaryVoucherDetailsInfo
    {
        private decimal _salaryVoucherDetailsId;
        private decimal _salaryVoucherMasterId;
        private decimal _employeeId;
        private decimal _bonus;
        private decimal _deduction;
        private decimal _advance;
        private decimal _lop;
        private decimal _salary;
        private string _status;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public decimal SalaryVoucherDetailsId
        {
            get { return _salaryVoucherDetailsId; }
            set { _salaryVoucherDetailsId = value; }
        }
        public decimal SalaryVoucherMasterId
        {
            get { return _salaryVoucherMasterId; }
            set { _salaryVoucherMasterId = value; }
        }
        public decimal EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public decimal Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        public decimal Deduction
        {
            get { return _deduction; }
            set { _deduction = value; }
        }
        public decimal Advance
        {
            get { return _advance; }
            set { _advance = value; }
        }
        public decimal Lop
        {
            get { return _lop; }
            set { _lop = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
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
