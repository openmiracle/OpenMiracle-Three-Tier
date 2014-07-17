using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;

namespace ENTITY
{
    public class RoleInfo
    {
        private decimal _roleId;
        private string _role;
        private string _narration;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public decimal RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
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
