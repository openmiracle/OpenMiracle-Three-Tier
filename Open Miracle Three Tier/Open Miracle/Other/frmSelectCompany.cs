//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.BLL;

namespace Open_Miracle
{

    public partial class frmSelectCompany : Form
    {
        /// <summary>
        /// Creates an instance of frmSelectCompany class
        /// </summary>
        public frmSelectCompany()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void CompanyGridFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                //CompanySP spComapny = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                listObj = bllCompanyCreation.CompanyViewAllForSelectCompany();
                dgvSelectCompany.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY : 1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Get the Current Date
        /// </summary>
        public void CurrentDate()
        {
            try
            {
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                FinancialYearBll bllFinancialYear = new FinancialYearBll();

                infoComapany = bllCompanyCreation.CompanyView(1);
                PublicVariables._dtCurrentDate = infoComapany.CurrentDate;
                infoFinancialYear = bllFinancialYear.FinancialYearView(1);
                PublicVariables._dtFromDate = infoFinancialYear.FromDate;
                PublicVariables._dtToDate = infoFinancialYear.ToDate;

            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY :2 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from MDI page
        /// </summary>
        public void CallFromMdi()
        {
            try
            {
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY :3 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelectCompany_Load(object sender, EventArgs e)
        {
            try
            {
                PublicVariables._decCurrentCompanyId = 0;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmLogin))
                    {

                        frm.Close();
                        break;
                    }
                }
                PublicVariables._decCurrentCompanyId = 0;
                CompanyGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY : 4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On Datagridview cell double click enables to loginto that company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSelectCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSelectCompany.CurrentRow.Index == e.RowIndex)
                {
                    PublicVariables._decCurrentCompanyId = Convert.ToDecimal(dgvSelectCompany.Rows[e.RowIndex].Cells["dgvtxtCompanyId"].Value.ToString());
                    CurrentDate();
                    frmLogin frmLoginObj = new frmLogin();
                    frmLoginObj.MdiParent = formMDI.MDIObj;
                    frmLoginObj.CallFromSelectCompany(this);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY :5 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Logs into selected company on Enter key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSelectCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSelectCompany.CurrentRow.Index != -1)
                    {
                        PublicVariables._decCurrentCompanyId = Convert.ToDecimal(dgvSelectCompany.SelectedRows[0].Cells["dgvtxtCompanyId"].Value.ToString());
                        CurrentDate();
                        frmLogin frmLoginObj = new frmLogin();
                        frmLoginObj.MdiParent = formMDI.MDIObj;
                        frmLoginObj.CallFromSelectCompany(this);
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY :6 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmSelectCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELCMPNY :6 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
