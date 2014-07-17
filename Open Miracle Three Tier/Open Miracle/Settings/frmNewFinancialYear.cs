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
    public partial class frmNewFinancialYear : Form
    {
        #region Public Vraiables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmCompanyCreation frmCompanyCreationObj;
        string strFromDateToKeep = string.Empty;
        string strToDateToKeep = string.Empty;
        bool isSave = false;
        #endregion
        #region Functions
        /// <summary>
        /// Checking given string is date format or not
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        private bool IsDate(string strDate)
        {
            bool IsDate = true;
            try
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(strDate);
                }
                catch (Exception)
                {
                    IsDate = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 1 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return IsDate;
        }
        /// <summary>
        /// Function to save the items to database
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                decimal decIdentity = 0;
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                FinancialYearBll bllFinancialYear = new FinancialYearBll();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoFinancialYear.FromDate = Convert.ToDateTime(txtFromDate.Text);
                infoFinancialYear.ToDate = Convert.ToDateTime(txtToDate.Text);
                infoFinancialYear.ExtraDate = System.DateTime.Now;
                infoFinancialYear.Extra1 = string.Empty;
                infoFinancialYear.Extra2 = string.Empty;
                decIdentity = bllFinancialYear.FinancialYearAddWithReturnIdentity(infoFinancialYear);
                infoFinancialYear = bllFinancialYear.FinancialYearView(decIdentity);
                PublicVariables._decCurrentFinancialYearId = infoFinancialYear.FinancialYearId;
                PublicVariables._dtFromDate = infoFinancialYear.FromDate;
                PublicVariables._dtToDate = infoFinancialYear.ToDate;
                PublicVariables._dtCurrentDate = infoFinancialYear.FromDate;
                bllCompanyCreation.CompanyCurrentDateEdit(PublicVariables._dtCurrentDate);
                formMDI.MDIObj.ShowCurrentDate();
                isSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 2 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or edit function to check the references and invalid entries
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                FinancialYearBll bllFinancialYear = new FinancialYearBll();
                if (PublicVariables.isMessageAdd)
                {
                    if (Messages.SaveMessage())
                    {
                        if (bllFinancialYear.FinancialYearExistenceCheck(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text)))
                        {
                            SaveFunction();
                        }
                        else
                        {
                            Messages.InformationMessage("Financial year already exist.");
                            txtFromDate.Focus();
                        }
                    }
                }
                else
                {
                    SaveFunction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 3 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmCompanyCreation to view details and for updation
        /// </summary>
        /// <param name="frmCompanyCreation"></param>
        public void CallFromCompanyCreation(frmCompanyCreation frmCompanyCreation)
        {
            try
            {
                frmCompanyCreationObj = frmCompanyCreation;
                base.Show();
                frmCompanyCreationObj = frmCompanyCreation;
                btnClose.Enabled = false;
                isSave = false;
                dtpFromDate.Enabled = true;
                txtFromDate.Enabled = true;
                DateTime dtFromDate = dtpFromDate.Value;
                DateTime dtToDate = dtpToDate.Value;
                //dtpFromDate.MinDate = dtFromDate;
                //dtpFromDate.MaxDate = dtToDate;
                //dtpToDate.MinDate = dtFromDate;
                //dtpToDate.MaxDate = dtToDate;
                txtFromDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
                txtToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 4 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Create an instance for frmNewFinancialYear class
        /// </summary>
        public frmNewFinancialYear()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 5 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to create new financial year
        /// </summary>
        public void NewFinancialYear()
        {
            FinancialYearBll bllFinancialYear = new FinancialYearBll();
            //DateTime dtFromDate = System.DateTime.Now;
            //DateTime dtToDate = System.DateTime.Now;
            DateTime dtFromDate;
            DateTime dtToDate;
            try
            {
                if (frmCompanyCreationObj != null)
                {
                    DateTime dtCurrentDate = System.DateTime.Now;
                    int inMonth = dtCurrentDate.Month;
                    int inYear = dtCurrentDate.Year;
                    int inDay = dtCurrentDate.Day;
                    if (inMonth < 4 && inDay < 31)
                    {
                        string strFromDateDate = "1-Apr-" + (inYear - 1);
                        string strToDate = "31-Mar-" + inYear;
                        dtFromDate = Convert.ToDateTime(strFromDateDate);
                        dtToDate = Convert.ToDateTime(strToDate);
                    }
                    else
                    {
                        string strFromDateDate = "1-Apr-" + inYear;
                        string strToDate = "31-Mar-" + (inYear + 1);
                        dtFromDate = Convert.ToDateTime(strFromDateDate);
                        dtToDate = Convert.ToDateTime(strToDate);
                    }
                    //dtpFromDate.MinDate = dtFromDate;
                    //dtpToDate.MaxDate = dtToDate;
                    dtpFromDate.Value = dtFromDate;
                    dtpToDate.Value = dtToDate;
                    strFromDateToKeep = dtFromDate.ToString("dd-MMM-yyyy");
                    strToDateToKeep = dtToDate.ToString("dd-MMM-yyyy");
                }
                else
                {
                    string strFromDate = bllFinancialYear.FinancialYearGetMax();
                    string strToDate = string.Empty;
                    dtFromDate = Convert.ToDateTime(strFromDate);
                    dtFromDate = dtFromDate.AddDays(1);
                    dtpFromDate.Value = dtFromDate;
                    txtFromDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                    int inMonth = dtFromDate.Month;
                    int inYear = dtFromDate.Year;
                    int inDay = dtFromDate.Day;
                    if (inMonth >= 4)
                    {
                        strToDate = "31-Mar-" + (inYear + 1);
                    }
                    else
                    {
                        strToDate = "31-Mar-" + (inYear);
                    }
                    dtToDate = Convert.ToDateTime(strToDate);
                    dtpToDate.Value = dtToDate;
                    txtToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                    //dtpToDate.MaxDate = dtToDate;
                    dtpToDate.MinDate = dtFromDate;
                    strFromDateToKeep = dtFromDate.ToString("dd-MMM-yyyy");
                    strToDateToKeep = dtToDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 6 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to checking status of form close
        /// </summary>
        public void FormClose()
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
                MessageBox.Show("NFY 7 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set textbox value as dtp's date
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="dtp"></param>
        public void dtpCloseUpEventFunction(TextBox txt, DateTimePicker dtp)
        {
            try
            {
                txt.Text = dtp.Value.ToString("dd-MMM-yyyy");
                txt.Focus();
                txt.SelectionStart = 0;
                txt.SelectionLength = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 8 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                FormClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 9 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewFinancialYear_Load(object sender, EventArgs e)
        {
            try
            {
                NewFinancialYear();
                if (frmCompanyCreationObj == null)
                {
                    btnClose.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 10 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        ///// <summary>
        ///// Validate the fromdate date formate
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dtpFromDate_CloseUp(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dtpCloseUpEventFunction(txtFromDate, dtpFromDate);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("NFY 11 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        ///// <summary>
        ///// Validate the todate date formate
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dtpToDate_CloseUp(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dtpCloseUpEventFunction(txtToDate, dtpToDate);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("NFY 12 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        /// <summary>
        /// Reset the form in Reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                NewFinancialYear();
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 13 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click, to save the Items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (IsDate(txtToDate.Text))
                    {
                        if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                        {
                            Messages.InformationMessage("Invalid date. Please enter a date which is after " + txtFromDate.Text);
                            txtToDate.Focus();
                            txtToDate.SelectionStart = 0;
                            txtToDate.SelectionLength = txtToDate.TextLength;
                        }
                        else
                        {
                            SaveOrEditFunction();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Date you provide is not in correct format");
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = txtToDate.TextLength;
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 14 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewFinancialYear_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmCompanyCreationObj != null)
                {
                    if (isSave)
                    {
                        frmChangeCurrentDate frmChangeCurrenttDateObj = new frmChangeCurrentDate();
                        frmChangeCurrenttDateObj.MdiParent = formMDI.MDIObj;
                        frmCompanyCreation CompanyCreationObj = new frmCompanyCreation();
                        CompanyCreationObj = frmCompanyCreationObj;
                        frmCompanyCreationObj = null;
                        frmChangeCurrenttDateObj.CallFromNewFinancialYear(CompanyCreationObj);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 15 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For date validation and set the date as text box date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = strFromDateToKeep;
                }
                else
                {
                    string date = txtFromDate.Text;
                    dtpFromDate.Value = Convert.ToDateTime(date);
                }
                dtpToDate.MinDate = Convert.ToDateTime(txtFromDate.Text);
                //dtpToDate.Value = dtpFromDate.Value;
                //txtToDate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 16 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For date validation and set the date as text box date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = strToDateToKeep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 17 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On changing the date from dtpFromDate, sets the txtFromDate with the new date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");


            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 18 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On changing the date from dtpToDate, sets the txtToDate with the new date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");


            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 19 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On closeup event of dtpFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 20 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewFinancialYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FormClose();
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 21 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 22 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text.Trim() == string.Empty || txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 23 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 24 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 25 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NFY 26 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        
    }
}
