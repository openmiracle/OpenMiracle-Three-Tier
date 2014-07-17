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

    public partial class frmChangeFinancialYear : Form
    {
      

        #region Functions
        /// <summary>
        /// Create An Instance for frmChangeFinancialYear Class
        /// </summary>
        public frmChangeFinancialYear()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to Fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                FinancialYearBll bllFinancialYear = new FinancialYearBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllFinancialYear.FinancialYearViewAll();
                dgvChangeFinancialYear.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Form Load call the grid fill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmChangeFinancialYear_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Form child in this.MdiParent.MdiChildren)
                {
                        if (this != child)
                        {
                            child.Close();
                        }
                        GridFill();
                }
                formMDI.MDIObj.ShowQuickLaunchMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid cell double click, call the Select button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvChangeFinancialYear_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    btnSelect_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Changing company's  financial year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to change the financial year?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                    FinancialYearBll bllFinancialYear = new FinancialYearBll();
                    decimal decFinacialId = Convert.ToDecimal(dgvChangeFinancialYear.CurrentRow.Cells["dgvtxtfinancialYearId"].Value);
                    DateTime dtmFromDate = Convert.ToDateTime(dgvChangeFinancialYear.CurrentRow.Cells["dgvtxtFromDate"].Value);
                    DateTime dtmToDate = Convert.ToDateTime(dgvChangeFinancialYear.CurrentRow.Cells["dgvtxtToDate"].Value);
                    PublicVariables._decCurrentFinancialYearId = decFinacialId;
                    PublicVariables._dtFromDate = dtmFromDate;
                    PublicVariables._dtToDate = dtmToDate;
                    DateTime dtGetCurrentdate = DateTime.Now;
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    bllCompanyCreation.CompanyCurrentDateEdit(dtmFromDate); 
                    if (dtGetCurrentdate < dtmFromDate)
                    {
                        PublicVariables._dtCurrentDate = dtmFromDate;
                        bllCompanyCreation.CompanyCurrentDateEdit(dtmFromDate); 
                        formMDI.MDIObj.ShowCurrentDate();
                    }
                    else
                    {

                        PublicVariables._dtCurrentDate = dtGetCurrentdate;
                        bllCompanyCreation.CompanyCurrentDateEdit(dtmFromDate); 
                        formMDI.MDIObj.ShowCurrentDate();
                    }
                    CompanyInfo infoCompany = new CompanyInfo();
                    infoCompany = bllCompanyCreation.CompanyView(1);
                    formMDI.MDIObj.Text = "OpenMiracle " + infoCompany.CompanyName + " [ " + PublicVariables._dtFromDate.ToString("dd-MMM-yyyy") + " To " + PublicVariables._dtToDate.ToString("dd-MMM-yyyy") + " ]";
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Form keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangeFinancialYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose == true)
                    {
                        Messages.CloseMessage(this);
                    }
                    else
                    {
                        btnClose_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CHGFINYR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

      
    }
}
