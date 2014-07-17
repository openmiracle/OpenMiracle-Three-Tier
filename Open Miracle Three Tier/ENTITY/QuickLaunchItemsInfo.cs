using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;

namespace ENTITY
{
    public class QuickLaunchItemsInfo
    {
        private decimal _quickLaunchItemsId;
        private string _itemsName;
        private bool _status;
        private string _extra2;
        private string _extra1;
        private DateTime _extraDate;

        public decimal QuickLaunchItemsId
        {
            get { return _quickLaunchItemsId; }
            set { _quickLaunchItemsId = value; }
        }

        public string ItemsName
        {
            get { return _itemsName; }
            set { _itemsName = value; }
        }


        public bool Status
        {
            get { return _status; }
            set { _status = value; }
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
