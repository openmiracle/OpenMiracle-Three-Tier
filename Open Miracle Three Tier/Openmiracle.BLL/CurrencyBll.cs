using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;

namespace OpenMiracle.BLL
{
   public class CurrencyBll
    {
       CurrencyInfo infoCurrency = new CurrencyInfo();
       CurrencySP SpCurrency = new CurrencySP();
       public CurrencyInfo CurrencyView(decimal currencyId)
       {
           CurrencyInfo currencyinfo = new CurrencyInfo();
           try
           {
               currencyinfo = SpCurrency.CurrencyView(currencyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("C1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return currencyinfo;
       }
       public bool CurrencyNameCheckExistence(String strName, string strCurrencySymb, decimal decCurrencyId)
       {
           bool isEdit = false;
           try
           {
               isEdit = SpCurrency.CurrencyNameCheckExistence(strName, strCurrencySymb, decCurrencyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("C2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isEdit;
       }
       public decimal CurrencyAddwithIdentity(CurrencyInfo currencyinfo)
       {
           decimal decCurrencyId = 0;
           try
           { 
               decCurrencyId = SpCurrency.CurrencyAddwithIdentity(currencyinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("C3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decCurrencyId;
       }
       public void CurrencyEdit(CurrencyInfo currencyinfo)
       {
           try
           {
               SpCurrency.CurrencyEdit(currencyinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("C4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public List<DataTable> CurrencySearch(String strname, String strsymbol)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpCurrency.CurrencySearch(strname, strsymbol);
           }
           catch (Exception ex)
           {
               MessageBox.Show("C5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> CurrencyViewAllForExchangeRateCombo()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpCurrency.CurrencyViewAllForExchangeRateCombo();
           }
           catch (Exception ex)
           {
               MessageBox.Show("C6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
        public List<DataTable> CurrencyViewAllForCombo()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpCurrency.CurrencyViewAllForCombo(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("C7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public string GetDefaultCurrencySymbol()
        {
            string strCurrencySymbol = string.Empty;
            try
            {
                strCurrencySymbol = SpCurrency.GetDefaultCurrencySymbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCurrencySymbol;
        }
        public bool DefaultCurrencyCheck(decimal decCurrencyId)
        {
            bool isDefault = false;
            try
            {
                isDefault = SpCurrency.DefaultCurrencyCheck(decCurrencyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isDefault;
        }
        public void DefaultCurrencySet(decimal decCurrencyId)
        {
            try
            {
                SpCurrency.DefaultCurrencySet(decCurrencyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal CurrencyCheckReferences(decimal decCurrencyId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SpCurrency.CurrencyCheckReferences(decCurrencyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }

    }
}
