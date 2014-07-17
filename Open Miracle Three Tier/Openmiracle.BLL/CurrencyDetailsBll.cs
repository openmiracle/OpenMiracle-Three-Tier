using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
using System.Data;

namespace Openmiracle.BLL
{
    public class CurrencyDetailsBll
    {
        CurrencyInfo InfoCurrenct = new CurrencyInfo();
        CurrencySP SpCurrency = new CurrencySP();
        public List<DataTable> CurrencySearch(String strname, String strsymbol)
        {
            List<DataTable> listdtbl = new List<DataTable>();
            try
            {
                listdtbl = SpCurrency.CurrencySearch(strname, strsymbol);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listdtbl;
        }
    }
}
