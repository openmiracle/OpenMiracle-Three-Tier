using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
namespace Openmiracle.BLL
{
    public class SalesBillTaxBll
    {
        SalesBillTaxSP SPSalesBillTax = new SalesBillTaxSP();
        SalesBillTaxInfo InfoSalesBillTax = new SalesBillTaxInfo();
        public decimal SalesBillTaxAdd(SalesBillTaxInfo salesbilltaxinfo)
        {
            decimal dcSalesBillTaxId = 0;
            try
            {
                dcSalesBillTaxId = SPSalesBillTax.SalesBillTaxAdd(salesbilltaxinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dcSalesBillTaxId;

        }
    }
}
