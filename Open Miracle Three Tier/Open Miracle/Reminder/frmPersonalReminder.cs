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
using System.Collections;
using System.Diagnostics;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmPersonalReminder : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaratrion part
        /// </summary>
        decimal decReminderId;
        bool isDeleteStatus;
        int inNarrationCount = 0;
        frmReminderPopUp frmReminderPopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmPersonalReminder class
        /// </summary>
        public frmPersonalReminder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call save or edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtRemindAbout.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter remind About:");
                    txtRemindAbout.Focus();
                }
                else
                {
                    if (btnSave.Text == "Save")
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                if (dtpFromDate.Value <= dtpToDate.Value)
                                {
                                    SaveFunction();
                                }
                                else
                                {
                                    Messages.InformationMessage(" Can't save reminder with from date greater than to date");
                                    txtFromDate.Select();
                                }
                            }
                        }
                        else
                        {
                            SaveFunction();
                        }
                    }
                    else
                    {
                        if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                EditFunction();
                            }
                        }
                        else
                        {
                            EditFunction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                RemainderBll bllRemainder = new RemainderBll();
                ReminderInfo infoReminder = new ReminderInfo();
                infoReminder.FromDate = dtpFromDate.Value;
                infoReminder.ToDate = dtpToDate.Value;
                infoReminder.RemindAbout = txtRemindAbout.Text.Trim();
                infoReminder.Extra1 = PublicVariables._decCurrentUserId.ToString();
                infoReminder.Extra2 = string.Empty;
                infoReminder.ExtraDate = DateTime.Now;
                if (bllRemainder.ReminderAdd(infoReminder))
                {
                    Messages.SavedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Edit
        /// </summary>
        public void EditFunction()
        {
            try
             {
                 RemainderBll bllRemainder = new RemainderBll();
                ReminderInfo infoReminder = new ReminderInfo();
                infoReminder.ReminderId = decReminderId;
                infoReminder.FromDate = dtpFromDate.Value;
                infoReminder.ToDate = dtpToDate.Value;
                infoReminder.RemindAbout = txtRemindAbout.Text.Trim();
                infoReminder.Extra1 = PublicVariables._decCurrentUserId.ToString();
                infoReminder.Extra2 = string.Empty;
                infoReminder.ExtraDate = DateTime.Now;
                if (bllRemainder.RemainderEdit(infoReminder))
                {
                    Messages.UpdatedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void Delete()
        {
            try
            {
               // ReminderSP spReminder = new ReminderSP();
                RemainderBll bllRemainder = new RemainderBll();
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage() == true)
                    {
                        isDeleteStatus = bllRemainder.RemainderDelete(decReminderId);
                        if (isDeleteStatus)
                        {
                            Messages.DeletedMessage();
                            Clear();
                        }
                    }
                }
                else
                {
                    isDeleteStatus = bllRemainder.RemainderDelete(decReminderId);
                    if (isDeleteStatus)
                    {
                        Messages.DeletedMessage();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtFromDateSearch.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                txtToDateSearch.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                txtRemindAbout.Clear();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                ReminderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void ReminderGridFill()
        {
            try
            {
                RemainderBll bllRemainder = new RemainderBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllRemainder.ReminderSearch(txtFromDateSearch.Text, txtToDateSearch.Text);
                dgvRemainder.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmReminderPopUp to view details
        /// </summary>
        /// <param name="frmReminder"></param>
        public void CallFromReminder(frmReminderPopUp frmReminder)
        {
            try
            {
                base.Show();
                this.frmReminderPopupObj = frmReminder;
                frmReminderPopupObj.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Save' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                    {
                        if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                        {
                            MessageBox.Show("From date is greater than to date", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtToDate.Focus();
                        }
                        else
                        {
                            SaveOrEdit();
                            Clear();
                            txtFromDate.Focus();
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    Delete();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDateSearch.Text != string.Empty && txtToDateSearch.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDateSearch.Text) < Convert.ToDateTime(txtFromDateSearch.Text))
                    {
                        MessageBox.Show("From date is greater than to date", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDateSearch.Focus();
                        DateTime dt;
                        DateTime.TryParse(txtToDateSearch.Text, out dt);
                        dtpToDateSearch.Value = dt;
                    }
                    else
                    {
                        ReminderGridFill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPersonalReminder_Load(object sender, EventArgs e)
        {
            try
            {
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                dtpFromDate.MinDate = PublicVariables._dtCurrentDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                dtpToDate.MinDate = PublicVariables._dtCurrentDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                Clear();
                txtFromDate.Select();
                ReminderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills controls for updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRemainder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RemainderBll bllRemainder = new RemainderBll();
            try
            {
                if (dgvRemainder.CurrentRow != null)
                {
                    if (dgvRemainder.CurrentRow.Cells["reminderId"].Value != null)
                    {
                        if (dgvRemainder.CurrentRow.Cells["reminderId"].Value.ToString() != string.Empty)
                        {
                            decReminderId = Convert.ToDecimal(dgvRemainder.CurrentRow.Cells["reminderId"].Value.ToString());
                           
                            ReminderInfo infoReminder = new ReminderInfo();
                            infoReminder = bllRemainder.RemainderView(decReminderId);
                            dtpFromDate.Value = infoReminder.FromDate;
                            dtpToDate.Value = infoReminder.ToDate;
                            txtRemindAbout.Text = infoReminder.RemindAbout;
                            txtFromDate.Focus();
                            btnSave.Text = "Update";
                            btnDelete.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalide = obj.DateValidationFunction(txtFromDate);
                if (!isInvalide)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string fromDt = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                if (Convert.ToDateTime(txtFromDate.Text) < Convert.ToDateTime(fromDt))
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtFromDate.Text;
                dtpFromDate.Value = Convert.ToDateTime(strdate.ToString());
                //------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM14:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalide = obj.DateValidationFunction(txtToDate);
                if (!isInvalide)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string ToDt = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(ToDt))
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM15:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDateSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalide = obj.DateValidationFunction(txtFromDateSearch);
                if (!isInvalide)
                {
                    txtFromDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (txtFromDateSearch.Text == string.Empty)
                {
                    txtFromDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtFromDateSearch.Text;
                dtpFromDateSeach.Value = Convert.ToDateTime(strdate.ToString());
                //------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM16:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDateSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalide = obj.DateValidationFunction(txtToDateSearch);
                if (!isInvalide)
                {
                    txtToDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (txtToDateSearch.Text == string.Empty)
                {
                    txtToDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (Convert.ToDateTime(txtToDateSearch.Text) <= Convert.ToDateTime(txtFromDateSearch.Text))
                {
                    MessageBox.Show("From date is greater than to date", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtToDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    txtFromDateSearch.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    //---for change date in Date time picker----//
                    string strdate = txtToDateSearch.Text;
                    dtpToDateSearch.Value = Convert.ToDateTime(strdate.ToString());
                }
                else
                {
                    string strdate = txtToDateSearch.Text;
                    dtpToDateSearch.Value = Convert.ToDateTime(strdate.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM17:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txtFromDate.SelectAll();
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtTodate textbox on dtpTodate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.SelectAll();
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDateSeach_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFromDateSearch.Text = dtpFromDateSeach.Value.ToString("dd-MMM-yyyy");
                txtFromDateSearch.SelectAll();
                txtFromDateSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtToDateSearch textbox on dtpToDateSearch Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDateSearch_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDateSearch.Text = dtpToDateSearch.Value.ToString("dd-MMM-yyyy");
                txtToDateSearch.SelectAll();
                txtToDateSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageClose == true)
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
                MessageBox.Show("PREM22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables objects of other forms on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPersonalReminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmReminderPopupObj != null)
                {
                    frmReminderPopupObj.Enabled = true;
                    frmReminderPopupObj.Activate();
                    frmReminderPopupObj.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDateSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDateSearch.SelectionLength != 11)
                    {
                        if (txtToDateSearch.Text == string.Empty)
                        {
                            if (txtFromDateSearch.SelectionStart == 0)
                            {
                                txtFromDateSearch.Focus();
                                txtFromDateSearch.SelectionStart = 0;
                                txtFromDateSearch.SelectionLength = 0;
                            }
                        }
                        if (txtToDateSearch.SelectionStart == 0)
                        {
                            txtFromDateSearch.Focus();
                            txtFromDateSearch.SelectionStart = 0;
                            txtFromDateSearch.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPersonalReminder_KeyDown(object sender, KeyEventArgs e)
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
                        this.Close();
                    }
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled == true)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClear.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtRemindAbout.Focus();
                    txtRemindAbout.SelectionStart = 0;
                    txtRemindAbout.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM26:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvRemainder.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dtpToDateSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM27:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRemindAbout_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRemindAbout.Text == string.Empty || txtRemindAbout.SelectionStart == 0)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDateSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtToDateSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
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
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRemindAbout.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.SelectionLength != 11)
                    {
                        if (txtToDate.Text == string.Empty)
                        {
                            if (txtFromDate.SelectionStart == 0)
                            {
                                txtFromDate.Focus();
                                txtFromDate.SelectionStart = 0;
                                txtFromDate.SelectionLength = 0;
                            }
                        }
                        if (txtFromDate.SelectionStart == 0)
                        {
                            txtFromDate.Focus();
                            txtFromDate.SelectionStart = 0;
                            txtFromDate.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM31:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRemindAbout_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtRemindAbout.Text = txtRemindAbout.Text.Trim();
                if (txtRemindAbout.Text == string.Empty)
                {
                    txtRemindAbout.SelectionStart = 0;
                    txtRemindAbout.Focus();
                }
                else
                {
                    txtRemindAbout.SelectionStart = txtRemindAbout.Text.Length;
                    txtRemindAbout.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PREM32:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
