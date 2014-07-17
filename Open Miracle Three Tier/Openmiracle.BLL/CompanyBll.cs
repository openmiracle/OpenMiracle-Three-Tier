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
    public class CompanyBll
    {
        CompanyInfo InfoCompany = new CompanyInfo();
        CompanySP SpCompany = new CompanySP();
         public void CompanyAdd(CompanyInfo InfoCompany)
        {
            try
            {
                SpCompany.CompanyAdd(InfoCompany);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         public void CompanyEdit(CompanyInfo InfoCompany)
         {
            try
            {
                SpCompany.CompanyEdit(InfoCompany);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         public bool CompanyCheckExistence(String strCompanyName, decimal decCompanyId)
         {
             bool isResult = false;
             try
             {
                 isResult = SpCompany.CompanyCheckExistence(strCompanyName, decCompanyId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("CC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return isResult;
         }
         public decimal CompanyAddParticularFeilds(CompanyInfo InfoCompany)
         {
             decimal decId = 0;
             try
             {
                
                 decId = SpCompany.CompanyAddParticularFeilds(InfoCompany);
             }

             catch (Exception ex)
             {
                 MessageBox.Show("CC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return decId;
         }
         public CompanyInfo CompanyView(decimal companyId)
         {
             CompanyInfo InfoCompany = new CompanyInfo();
             try
             {
                 InfoCompany = SpCompany.CompanyView(companyId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("CC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return InfoCompany;
         }
         public void CompanyDelete(decimal CompanyId)
         {
             try
             {
                 SpCompany.CompanyDelete(CompanyId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("CC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public List<DataTable> CompanyViewForDotMatrix()
         {
             List<DataTable> listObj = new List<DataTable>();
             try
             {
                 listObj = SpCompany.CompanyViewForDotMatrix();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("CC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return listObj;
         }


    }
}
