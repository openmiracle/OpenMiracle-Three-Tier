using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using OpenMiracle.BLL;
using System.Windows.Forms;
using System.Data;

namespace OpenMiracle.BLL
{
    public class TransactionsGeneralFillBll
    {

        public void CashOrBankComboFill(ComboBox cmbCashOrBank, bool isAll)
        {
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                spTransactionGeneralFill.CashOrBankComboFill(cmbCashOrBank, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CashOrPartyComboFill(ComboBox cmbCashOrParty, bool isAll)
        {
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                spTransactionGeneralFill.CashOrPartyComboFill(cmbCashOrParty, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string VoucherNumberAutomaicGeneration(decimal VoucherTypeId, decimal txtBox, DateTime date, string tableName)
        {
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            string strVoucherNo = string.Empty;
            try
            {
                strVoucherNo = spTransactionGeneralFill.VoucherNumberAutomaicGeneration(VoucherTypeId, txtBox, date, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strVoucherNo;
        }
        public List<DataTable> VoucherTypeComboFill(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.VoucherTypeComboFill(cmbVoucherType, strVoucherType, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> CurrencyComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AccountLedgerUnderExpenses(ComboBox cmbType, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.AccountLedgerUnderExpenses(cmbType, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public List<DataTable> UnitViewAllByProductId(DataGridView dgvCurrent, string strProductId, int inRowIndex)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.UnitViewAllByProductId(dgvCurrent, strProductId, inRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public List<DataTable> AccountLedgerComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                AccountLedgerSP spAccountLedger = new AccountLedgerSP();
                ListObj = spAccountLedger.AccountLedgerViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> BankOrCashComboFill(bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.BankOrCashComboFill(isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool StatusOfPrintAfterSave()
        {
            bool isTrue = false;
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                isTrue = spTransactionGeneralFill.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
        public bool TaxStatus()
        {
            bool isTrue = false;
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                isTrue = spTransactionGeneralFill.TaxStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
        public bool GodownStatus()
        {
            bool isTrue = false;
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                isTrue = spTransactionGeneralFill.GodownStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
        public List<DataTable> CurrencyComboByDate(DateTime date)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj=spTransactionGeneralFill.CurrencyComboByDate(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesmanViewAllForComboFill(ComboBox cmbSalesMan, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.SalesmanViewAllForComboFill(cmbSalesMan, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public void CashOrPartyUnderSundryDrComboFill(ComboBox cmbCashOrParty, bool isAll)
        {
            DataTable dtblCashOrParty = new DataTable();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                spTransactionGeneralFill.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> PricingLevelViewAll(ComboBox cmbPricingLevel, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                spTransactionGeneralFill.PricingLevelViewAll(cmbPricingLevel, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public void SalesAccountComboFill(ComboBox cmbSalesAccount, bool isAll)
        {
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                spTransactionGeneralFill.SalesAccountComboFill(cmbSalesAccount, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> ProductGroupViewAll(ComboBox cmbProductGroup, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
               listObj= spTransactionGeneralFill.ProductGroupViewAll(cmbProductGroup, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> UnitViewAll(ComboBox cmbUnit, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj=spTransactionGeneralFill.UnitViewAll(cmbUnit, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> TaxViewAll(ComboBox cmbTax, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
              listObj= spTransactionGeneralFill.TaxViewAll(cmbTax, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BrandViewAll(ComboBox cmbBrand, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
               listObj= spTransactionGeneralFill.BrandViewAll(cmbBrand, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ModelNoViewAll(ComboBox cmbModelNo, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.ModelNoViewAll(cmbModelNo, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SizeViewAll(ComboBox cmbSize, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.SizeViewAll(cmbSize, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BankComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.BankComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> RouteViewAll(ComboBox cmbSize, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.RouteViewAll(cmbSize,isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AreaViewAll(ComboBox cmbSize, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            TransactionsGeneralFillSP spTransactionGeneralFill = new TransactionsGeneralFillSP();
            try
            {
                listObj = spTransactionGeneralFill.AreaViewAll(cmbSize, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGFBll:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}
