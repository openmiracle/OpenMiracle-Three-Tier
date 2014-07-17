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
    public class CompanyPathBll
    {
        CompanyPathSP spCompanyPath = new CompanyPathSP();
        public void CompanyPathAdd(CompanyPathInfo companypathinfo)
        {
            CompanyPathInfo infoCompanyPath = new CompanyPathInfo();
            decimal idCheck = PublicVariables._decCurrentCompanyId;
            try
            {
                spCompanyPath.CompanyPathAdd(companypathinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CP1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CompanyPathEdit(CompanyPathInfo companypathinfo)
        {
            CompanyPathSP spCompanyPath = new CompanyPathSP();
            try
            {
                spCompanyPath.CompanyPathEdit(companypathinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CP2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public CompanyPathInfo CompanyPathView(decimal companyId)
        {
            CompanyPathSP spCompanyPath = new CompanyPathSP();
            CompanyPathInfo infoCompanyPath = new CompanyPathInfo();
            try
            {
                infoCompanyPath = spCompanyPath.CompanyPathView(companyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CP3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoCompanyPath;
        }
        public void CompanyPathDelete(decimal CompanyId)
        {
            CompanyPathSP spCompanyPath = new CompanyPathSP();
            try
            {
                spCompanyPath.CompanyPathDelete(CompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CP4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> CompanyPathViewAll()
        {
            CompanyPathSP spCompanyPath = new CompanyPathSP();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spCompanyPath.CompanyPathViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CP5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal CompanyViewForDefaultCompany()
        {
            CompanyPathSP spCompanyPath = new CompanyPathSP();
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = spCompanyPath.CompanyViewForDefaultCompany();
            }

            catch (Exception ex)
            {
                MessageBox.Show("CP6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
    }
}
