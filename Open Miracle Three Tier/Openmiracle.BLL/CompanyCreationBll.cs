using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;


namespace OpenMiracle.BLL
{
  public  class CompanyCreationBll
    {
      public bool CompanyCheckExistence(String strCompanyName, decimal decCompanyId)
      {
          CompanySP spCompany = new CompanySP();
          bool isResult = false;
          try
          {
              isResult = spCompany.CompanyCheckExistence(strCompanyName,decCompanyId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return isResult;
      }
      public decimal CompanyAddParticularFeilds(CompanyInfo infoCompany)
        {
            CompanySP spCompany = new CompanySP();
            decimal decId = 0;
            try
            {
                decId = spCompany.CompanyAddParticularFeilds(infoCompany);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
      public void CompanyEdit(CompanyInfo infoCompany)
        {
            CompanySP spCompany = new CompanySP();
            try
            {
                spCompany.CompanyEdit(infoCompany);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
      public CompanyInfo CompanyView(decimal companyId)
        {
            CompanyInfo infoCompany = new CompanyInfo();
            CompanySP spCompany = new CompanySP();
            try
            {
                infoCompany = spCompany.CompanyView(companyId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoCompany;
        }
       public void CompanyDelete(decimal CompanyId)
        {
            CompanySP spCompany = new CompanySP();
            try
            {
                spCompany.CompanyDelete(CompanyId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public DataTable  CompanyViewForDotMatrix()
       {
           DataTable dtbl = new DataTable();
           CompanySP spCompany = new CompanySP();
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spCompany.CompanyViewForDotMatrix();
               dtbl = listObj[0];
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dtbl;
       }
       public List<DataTable> CompanyViewDataTable(decimal companyId)
       {
           CompanySP spCompany = new CompanySP();
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spCompany.CompanyViewDataTable(companyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> CompanyViewAllForSelectCompany()
       {
           CompanySP spCompany = new CompanySP();
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spCompany.CompanyViewAllForSelectCompany();
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public int CompanyCount()
       {
           CompanySP spCompany = new CompanySP();
           int inCount = 0;
           try
           {
               inCount = spCompany.CompanyCount();
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return inCount;
       }
       public void CompanyCurrentDateEdit(DateTime dtCurrentDate)
       {
           CompanySP spCompany = new CompanySP();
           try
           {
               spCompany.CompanyCurrentDateEdit(dtCurrentDate);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public string StoredProcedureInserter(string strParameter)
       {
           CompanySP spCompany = new CompanySP();
           string error = "";
           try
           {
               error=spCompany.StoredProcedureInserter(strParameter);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return error;
       }
       public List<DataTable> CompanyViewAll()
       {
           CompanySP spCompany = new CompanySP();
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spCompany.CompanyViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public decimal CompanyGetIdIfSingleCompany()
       {
           CompanySP spCompany = new CompanySP();
           decimal decCompanyId = 0;
           try
           {
               decCompanyId = spCompany.CompanyGetIdIfSingleCompany();
           }
           catch (Exception ex)
           {
               MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decCompanyId;
       }
    }
}
