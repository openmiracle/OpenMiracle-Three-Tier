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
using System.Globalization;
using OpenMiracle.BLL;
using ENTITY;

namespace Open_Miracle
{

    public partial class frmBonusDeduction : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decBonusId;
        decimal decEmployeeIdForEdit = 0;
        DateTime dtMonth;
        int inNarrationCount = 0;
        frmBonusDeductionRegister frmBonusDeductionRegisterObj;

        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmBonusDeduction class
        /// </summary>
        public frmBonusDeduction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill EmployeeCode Combobox
        /// </summary>
        public void EmployeeCodeComboFill()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                List<DataTable> listEmployeeCode = new List<DataTable>();
                listEmployeeCode = BllEmployeeCreation.EmployeeViewAll();
                cmbEmployeeCode.DataSource = listEmployeeCode[0];
                cmbEmployeeCode.ValueMember = "employeeId";
                cmbEmployeeCode.DisplayMember = "employeeCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                BonusDedutionInfo infoBonusDeduction = new BonusDedutionInfo();
                BonusDeductionBll BllBonusDeduction = new BonusDeductionBll();
                infoBonusDeduction.Date = Convert.ToDateTime(dtpDate.Text.ToString());
                infoBonusDeduction.EmployeeId = Convert.ToDecimal(cmbEmployeeCode.SelectedValue.ToString());
                infoBonusDeduction.Month = Convert.ToDateTime(dtpMonth.Text.ToString());
                infoBonusDeduction.BonusAmount = Convert.ToDecimal(txtBonusAmount.Text.ToString());
                infoBonusDeduction.DeductionAmount = Convert.ToDecimal(txtDeductionAmount.Text.ToString());
                infoBonusDeduction.Narration = txtNarration.Text;
                infoBonusDeduction.Extra1 = string.Empty;
                infoBonusDeduction.Extra2 = string.Empty;
                if (BllBonusDeduction.BonusDeductionAddIfNotExist(infoBonusDeduction))
                {
                    Messages.SavedMessage();
                    Clear();
                }
                else
                {
                    Messages.InformationMessage(" Employee bonus deduction already exist");
                    cmbEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                BonusDedutionInfo infoBonusDeduction = new BonusDedutionInfo();
                BonusDeductionBll BllBonusDeduction = new BonusDeductionBll();
                infoBonusDeduction.Date = Convert.ToDateTime(dtpDate.Text.ToString());
                infoBonusDeduction.EmployeeId = Convert.ToDecimal(cmbEmployeeCode.SelectedValue.ToString());
                infoBonusDeduction.Month = Convert.ToDateTime(dtpMonth.Text.ToString());
                infoBonusDeduction.BonusAmount = Convert.ToDecimal(txtBonusAmount.Text.ToString());
                infoBonusDeduction.DeductionAmount = Convert.ToDecimal(txtDeductionAmount.Text.ToString());
                infoBonusDeduction.Narration = txtNarration.Text;
                infoBonusDeduction.Extra1 = string.Empty;
                infoBonusDeduction.Extra2 = string.Empty;
                infoBonusDeduction.BonusDeductionId = decBonusId;
                BllBonusDeduction.BonusDedutionEdit(infoBonusDeduction);
                Messages.UpdatedMessage();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                dtpDate.Focus();
                if (frmBonusDeductionRegisterObj != null)
                {
                    frmBonusDeductionRegisterObj.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to call save or edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (cmbEmployeeCode.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select employee code");
                    cmbEmployeeCode.Focus();
                }
                else if (txtBonusAmount.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter bonus Amount");
                    txtBonusAmount.Focus();
                }
                else if (txtDeductionAmount.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter deduction Amount");
                    txtDeductionAmount.Focus();
                }
                else
                {
                    if (btnSave.Text == "Save")
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                SaveFunction();
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
                            else
                            {
                                txtDate.Focus();
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
                MessageBox.Show("BD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset on load
        /// </summary>
        public void LoadFunction()
        {
            try
            {
                EmployeeCodeComboFill();
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpMonth.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpMonth.MinDate = PublicVariables._dtFromDate;
                dtpMonth.MaxDate = PublicVariables._dtToDate;
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                cmbEmployeeCode.SelectedIndex = -1;
                txtBonusAmount.Clear();
                txtDeductionAmount.Clear();
                txtNarration.Clear();
                txtDate.Focus();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                dtpMonth.Enabled = true;
                cmbEmployeeCode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Call LoadFunction
        /// </summary>
        public void Clear()
        {
            try
            {
                LoadFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("BD6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete
        /// </summary>
        public void Deletefunction()
        {
            try
            {
                BonusDeductionBll BllBonusDeduction = new BonusDeductionBll();
                if ((BllBonusDeduction.BonusDeductionReferenceDelete(decEmployeeIdForEdit, dtMonth)) == -1)
                {
                    MessageBox.Show("Can't delete,reference exist", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Messages.DeletedMessage();
                    btnSave.Text = "Save";
                    btnDelete.Enabled = false;
                    this.Close();
                    if (frmBonusDeductionRegisterObj != null)
                    {
                        frmBonusDeductionRegisterObj.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call delete
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        Deletefunction();
                    }
                }
                else
                {
                    Deletefunction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmBonusDeductionRegister for updation
        /// </summary>
        /// <param name="decBonusDeductionId"></param>
        /// <param name="frm"></param>
        public void CallFromBonusDeductionRegister(decimal decBonusDeductionId, frmBonusDeductionRegister frm)
        {
            try
            {
                base.Show();
                BonusDedutionInfo infoBonusDeduction = new BonusDedutionInfo();
                BonusDeductionBll BllBonusDeduction = new BonusDeductionBll();
                infoBonusDeduction = BllBonusDeduction.BonusDeductionViewForUpdate(decBonusDeductionId);
                dtpDate.Text = infoBonusDeduction.Date.ToString();
                cmbEmployeeCode.SelectedValue = infoBonusDeduction.EmployeeId;
                decEmployeeIdForEdit = infoBonusDeduction.EmployeeId;
                dtpMonth.Text = infoBonusDeduction.Month.ToString();
                dtMonth = infoBonusDeduction.Month;
                txtBonusAmount.Text = infoBonusDeduction.BonusAmount.ToString();
                txtDeductionAmount.Text = infoBonusDeduction.DeductionAmount.ToString();
                txtNarration.Text = infoBonusDeduction.Narration;
                btnSave.Text = "Update";
                dtpMonth.Enabled = false;
                cmbEmployeeCode.Enabled = false;
                btnDelete.Enabled = true;
                txtDate.Focus();
                decBonusId = decBonusDeductionId;
                frmBonusDeductionRegisterObj = frm;
                frm.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBonusDeduction_Load(object sender, EventArgs e)
        {
            try
            {

                LoadFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBonusDeduction_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    if (cmbEmployeeCode.Focused)
                    {
                        cmbEmployeeCode.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbEmployeeCode.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("BD13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("BD14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button Click
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
                MessageBox.Show("BD15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Date textbox on dtpDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Text = this.dtpDate.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation on Date textbox leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objDateValidation = new DateValidation();
                objDateValidation.DateValidationFunction(txtDate);
                if (txtDate.Text == string.Empty)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDeductionAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBonusAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the object of frmBonusDeductionRegister form on formclosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBonusDeduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmBonusDeductionRegisterObj != null)
                {
                    frmBonusDeductionRegisterObj.Clear();
                    frmBonusDeductionRegisterObj.Enabled = true;
                    frmBonusDeductionRegisterObj.GridSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtNarration.Text = txtNarration.Text.Trim();
                if (txtNarration.Text == string.Empty)
                {
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                    txtNarration.Focus();
                }
                else
                {
                    txtNarration.SelectionStart = txtNarration.Text.Length;
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        btnSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtDeductionAmount.Focus();
                        txtDeductionAmount.SelectionStart = 0;
                        txtDeductionAmount.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbEmployeeCode.Enabled)
                    {
                        cmbEmployeeCode.Focus();
                    }
                    else
                    {
                        txtBonusAmount.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpMonth.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbEmployeeCode.Text == string.Empty || cmbEmployeeCode.SelectionStart == 0)
                    {
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                        txtDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBonusAmount.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployeeCode.Focus();
                    cmbEmployeeCode.SelectionStart = 0;
                    cmbEmployeeCode.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBonusAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDeductionAmount.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBonusAmount.Text == string.Empty || txtBonusAmount.SelectionStart == 0)
                    {
                        if (dtpMonth.Enabled)
                        {
                            dtpMonth.Focus();
                        }
                        else if (cmbEmployeeCode.Enabled)
                        {
                            cmbEmployeeCode.SelectionStart = 0;
                            cmbEmployeeCode.SelectionLength = 0;
                            cmbEmployeeCode.Focus();
                        }
                        else
                        {
                            txtDate.SelectionStart = 0;
                            txtDate.SelectionLength = 0;
                            txtDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDeductionAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDeductionAmount.Text == string.Empty || txtDeductionAmount.SelectionStart == 0)
                    {
                        txtBonusAmount.SelectionStart = 0;
                        txtBonusAmount.SelectionLength = 0;
                        txtBonusAmount.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
