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
using System.Text.RegularExpressions;
using ENTITY;
using OpenMiracle.BLL;

namespace Open_Miracle
{
    public partial class frmEmployeeCreation : Form
    {
        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strEmployeeCode;
        frmAdvancePayment frmAdvancePaymentobj;
        decimal decEmployeeId;
        decimal decIdForOtherForms = 0;
        frmEmployeeRegister frmEmployeeRegisterObj;
        frmSalesInvoice frmSalesInvoiceObj;
        string strDesignationName;
        string strSalaryPackage;
        int inNarrationcount = 0;

        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmEmployeeCreation class
        /// </summary>
        public frmEmployeeCreation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function for save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                EmployeeInfo infoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                infoEmployee.EmployeeCode = txtEmployeeCode.Text.Trim();
                infoEmployee.EmployeeName = txtEmployeeName.Text.Trim();
                infoEmployee.DesignationId = Convert.ToDecimal(cmbDesignation.SelectedValue.ToString());
                infoEmployee.Dob = Convert.ToDateTime(dtpDob.Text.ToString());
                infoEmployee.MaritalStatus = (cmbMaritalStatus.Text.ToString()).TrimEnd();
                if (cmbGender.Text != string.Empty)
                {
                    infoEmployee.Gender = (cmbGender.SelectedItem.ToString()).TrimEnd();
                }
                else
                {
                    infoEmployee.Gender = cmbGender.Text.ToString();
                }
                infoEmployee.Qualification = txtQualification.Text.Trim();
                infoEmployee.Address = txtAddress.Text.Trim();
                infoEmployee.PhoneNumber = txtPhoneNumber.Text.Trim();
                infoEmployee.MobileNumber = txtMobileNumber.Text.Trim();
                infoEmployee.Email = txtEmail.Text.Trim();
                infoEmployee.JoiningDate = Convert.ToDateTime(txtJoiningDate.Text.ToString());
                infoEmployee.TerminationDate = Convert.ToDateTime(txtTerminationDate.Text.ToString());
                if (cbxActive.Checked)
                {
                    infoEmployee.IsActive = true;
                }
                else
                {
                    infoEmployee.IsActive = false;
                }
                infoEmployee.Narration = txtNarration.Text.Trim();
                infoEmployee.BloodGroup = (cmbBloodGroup.Text.ToString()).TrimEnd();
                infoEmployee.PassportNo = txtPassportNumber.Text.Trim();
                infoEmployee.PassportExpiryDate = Convert.ToDateTime(dtpPassportExpiryDate.Text.ToString());
                infoEmployee.VisaNumber = txtVisaNumber.Text.Trim();
                infoEmployee.VisaExpiryDate = Convert.ToDateTime(dtpVisaExpiryDate.Text.ToString());
                infoEmployee.LabourCardNumber = txtlabourCardNumber.Text.Trim();
                infoEmployee.LabourCardExpiryDate = Convert.ToDateTime(dtpLabourCardExpiryDate.Text.ToString());
                infoEmployee.SalaryType = (cmbSalaryType.SelectedItem.ToString()).TrimEnd();
                if (cmbSalaryType.SelectedItem.ToString() == "Daily wage")
                {
                    if (txtDailyWage.Text.Trim() != string.Empty)
                    {
                        infoEmployee.DailyWage = Convert.ToDecimal(txtDailyWage.Text.ToString());
                    }

                }
                else
                {
                    if (cmbDefaultPackage.Text != string.Empty)
                    {
                        infoEmployee.DefaultPackageId = Convert.ToDecimal(cmbDefaultPackage.SelectedValue.ToString());
                    }
                }
                infoEmployee.BankName = txtBankName.Text.Trim();
                infoEmployee.BankAccountNumber = txtBankAccountNumber.Text.Trim();
                infoEmployee.BranchName = txtBranch.Text.Trim();
                infoEmployee.BranchCode = txtBranchCode.Text.Trim();
                infoEmployee.PanNumber = txtPanNumber.Text.Trim();
                infoEmployee.PfNumber = txtPfNumber.Text.Trim();
                infoEmployee.EsiNumber = txtEsiNumber.Text.Trim();
                infoEmployee.ExtraDate = DateTime.Now;
                infoEmployee.Extra1 = string.Empty;
                infoEmployee.Extra2 = string.Empty;
                if (BllEmployeeCreation.EmployeeCodeCheckExistance(txtEmployeeCode.Text.Trim(), 0) == false)
                {
                    decEmployeeId = BllEmployeeCreation.EmployeeAddWithReturnIdentity(infoEmployee);
                    Messages.SavedMessage();
                    ClearFunction();
                    decIdForOtherForms = decEmployeeId;
                    if (frmSalesInvoiceObj != null)
                    {
                        if (decIdForOtherForms != 0)
                        {
                            this.Close();
                        }
                    }

                }
                else
                {
                    Messages.InformationMessage("Employee code already exist");
                    txtEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                EmployeeInfo infoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                infoEmployee.EmployeeCode = txtEmployeeCode.Text.Trim();
                infoEmployee.EmployeeName = txtEmployeeName.Text.Trim();
                infoEmployee.DesignationId = Convert.ToDecimal(cmbDesignation.SelectedValue.ToString());
                infoEmployee.Dob = Convert.ToDateTime(dtpDob.Text.ToString());
                infoEmployee.MaritalStatus = (cmbMaritalStatus.Text.ToString()).TrimEnd();
                if (cmbGender.Text != string.Empty)
                {
                    infoEmployee.Gender = (cmbGender.SelectedItem.ToString()).TrimEnd();
                }
                else
                {
                    infoEmployee.Gender = cmbGender.Text.ToString();
                }
                infoEmployee.Qualification = txtQualification.Text.Trim();
                infoEmployee.Address = txtAddress.Text.Trim();
                infoEmployee.PhoneNumber = txtPhoneNumber.Text.Trim();
                infoEmployee.MobileNumber = txtMobileNumber.Text.Trim();
                infoEmployee.Email = txtEmail.Text.Trim();
                infoEmployee.JoiningDate = Convert.ToDateTime(txtJoiningDate.Text.ToString());
                infoEmployee.TerminationDate = Convert.ToDateTime(txtTerminationDate.Text.ToString());
                if (cbxActive.Checked)
                {
                    infoEmployee.IsActive = true;
                }
                else
                {
                    infoEmployee.IsActive = false;
                }
                infoEmployee.Narration = txtNarration.Text.Trim();
                infoEmployee.BloodGroup = (cmbBloodGroup.Text.ToString()).TrimEnd();
                infoEmployee.PassportNo = txtPassportNumber.Text.Trim();
                infoEmployee.PassportExpiryDate = Convert.ToDateTime(dtpPassportExpiryDate.Text.ToString());
                infoEmployee.VisaNumber = txtVisaNumber.Text.Trim();
                infoEmployee.VisaExpiryDate = Convert.ToDateTime(dtpVisaExpiryDate.Text.ToString());
                infoEmployee.LabourCardNumber = txtlabourCardNumber.Text.Trim();
                infoEmployee.LabourCardExpiryDate = Convert.ToDateTime(dtpLabourCardExpiryDate.Text.ToString());
                infoEmployee.SalaryType = (cmbSalaryType.SelectedItem.ToString()).TrimEnd();
                if (cmbSalaryType.SelectedItem.ToString() == "Daily wage")
                {
                    if (txtDailyWage.Text.Trim() != string.Empty)
                    {
                        infoEmployee.DailyWage = Convert.ToDecimal(txtDailyWage.Text.ToString());
                    }
                }
                else
                {
                    if (cmbDefaultPackage.Text != string.Empty)
                    {
                        infoEmployee.DefaultPackageId = Convert.ToDecimal(cmbDefaultPackage.SelectedValue.ToString());
                    }
                }
                infoEmployee.BankName = txtBankName.Text.Trim();
                infoEmployee.BankAccountNumber = txtBankAccountNumber.Text.Trim();
                infoEmployee.BranchName = txtBranch.Text.Trim();
                infoEmployee.BranchCode = txtBranchCode.Text.Trim();
                infoEmployee.PanNumber = txtPanNumber.Text.Trim();
                infoEmployee.PfNumber = txtPfNumber.Text.Trim();
                infoEmployee.EsiNumber = txtEsiNumber.Text.Trim();
                infoEmployee.ExtraDate = DateTime.Now;
                infoEmployee.Extra1 = string.Empty;
                infoEmployee.Extra2 = string.Empty;
                infoEmployee.EmployeeId = Convert.ToDecimal(lblEmployeeId.Text.ToString());
                if ((BllEmployeeCreation.EmployeeCodeCheckExistance(txtEmployeeCode.Text.ToString(), infoEmployee.EmployeeId) == false))
                {
                    if (BllEmployeeCreation.EmployeeEdit(infoEmployee))
                    {
                        Messages.UpdatedMessage();

                    }
                }
                else
                {
                    Messages.InformationMessage("Employee code already Exist");
                    txtEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {

                if (txtEmployeeCode.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter employee code");
                    txtEmployeeCode.Focus();
                }
                else if (txtEmployeeName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter employee name");
                    txtEmployeeName.Focus();
                }
                else if (cmbDesignation.Text == string.Empty)
                {
                    Messages.InformationMessage("Select designation");
                    cmbDesignation.Focus();
                }
                else if (cmbSalaryType.Text == string.Empty)
                {
                    Messages.InformationMessage("Select salary type");
                    cmbSalaryType.Focus();
                }
                else if (cmbSalaryType.SelectedItem.ToString() == "Daily wage" && txtDailyWage.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter daily wage");
                    txtDailyWage.Focus();
                }
                else if (cmbSalaryType.SelectedItem.ToString() == "Monthly" && cmbDefaultPackage.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select salary package");
                    cmbDefaultPackage.Focus();
                }
                else if (txtEmail.Text.Trim() != string.Empty && ValidateEmail())
                {
                    Messages.InformationMessage("Email address not in correct format ");
                    txtEmail.Focus();

                }

                else if (Convert.ToDateTime(txtTerminationDate.Text) < Convert.ToDateTime(txtJoiningDate.Text))
                {
                    Messages.InformationMessage("Joining date should not be greater than termination date ");
                    txtJoiningDate.Focus();

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
                        if (frmAdvancePaymentobj != null)
                        {
                            decIdForOtherForms = decEmployeeId;
                            this.Close();
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
                        if (frmEmployeeRegisterObj != null)
                        {
                            frmEmployeeRegisterObj.Show();
                            frmEmployeeRegisterObj.Gridfill();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check and validate Email address
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail()
        {
            bool isOk = false;
            try
            {
                Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                        + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                        + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                        + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                        + @"[a-zA-Z]{2,}))$",
                                        RegexOptions.Compiled);

                if (!regEmail.IsMatch(txtEmail.Text))
                {
                    isOk = true;
                }
                else
                {
                    isOk = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to call this form from frmAdvancePayment to create a new employee
        /// </summary>
        /// <param name="frmadvancepayment"></param>
        public void CallFromAdvancePayment(frmAdvancePayment frmadvancepayment)
        {
            try
            {
                this.frmAdvancePaymentobj = frmadvancepayment;
                base.Show();
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Designation combobox
        /// </summary>
        public void DesignationComboFill()
        {
            try
            {
                //DesignationSP SpDesignation = new DesignationSP();
                DesiginationBll bllDesigination = new DesiginationBll();
                List<DataTable> listObjDesignation = new List<DataTable>();
                listObjDesignation = bllDesigination.DesignationViewAll();
                cmbDesignation.DataSource = listObjDesignation[0];
                cmbDesignation.ValueMember = "designationId";
                cmbDesignation.DisplayMember = "designationName";
                cmbDesignation.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Defaultpackage combobox 
        /// </summary>
        public void DefaultPackageComboFill()
        {
            try
            {
                SalaryPackageCreationBll bllSalaryPackage = new SalaryPackageCreationBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalaryPackage.SalaryPackageViewAllForActive();
                cmbDefaultPackage.DataSource = ListObj[0];
                cmbDefaultPackage.ValueMember = "salaryPackageId";
                cmbDefaultPackage.DisplayMember = "salaryPackageName";
                cmbDefaultPackage.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtAddress.Clear();
                txtBankAccountNumber.Clear();
                txtBankName.Clear();
                txtBranch.Clear();
                txtDailyWage.Clear();
                txtEmail.Clear();
                txtEmployeeCode.Clear();
                txtEmployeeName.Clear();
                txtEsiNumber.Clear();
                txtlabourCardNumber.Clear();
                txtBranchCode.Clear();
                txtMobileNumber.Clear();
                txtNarration.Clear();
                txtPanNumber.Clear();
                txtPassportNumber.Clear();
                txtPfNumber.Clear();
                txtPhoneNumber.Clear();
                txtQualification.Clear();
                txtVisaNumber.Clear();
                cmbBloodGroup.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbMaritalStatus.SelectedIndex = -1;
                cmbSalaryType.SelectedIndex = -1;
                dtpDob.Value = PublicVariables._dtCurrentDate;
                txtJoiningDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtTerminationDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpLabourCardExpiryDate.Value = PublicVariables._dtCurrentDate;
                dtpPassportExpiryDate.Value = PublicVariables._dtCurrentDate;
                dtpVisaExpiryDate.Value = PublicVariables._dtCurrentDate;
                txtEmployeeCode.Focus();
                cbxActive.Checked = true;
                cmbDefaultPackage.SelectedIndex = -1;
                lblEmployeeId.Text = string.Empty;
                strEmployeeCode = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                Clear();
                if (frmEmployeeRegisterObj != null)
                {
                    frmEmployeeRegisterObj.Close();
                    frmEmployeeRegisterObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void Delete()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                if (BllEmployeeCreation.EmployeeCheckReferences(Convert.ToDecimal(lblEmployeeId.Text.ToString())) == -1)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    Messages.DeletedMessage();
                    this.Close();
                }
                if (frmEmployeeRegisterObj != null)
                {
                    frmEmployeeRegisterObj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage() == true)
                    {
                        Delete();
                    }
                }
                else
                {
                    Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls when cell double click in frmEmployeeRegister for updation
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="frm"></param>
        public void CallFromEmployeeRegister(decimal decEmployeeId, frmEmployeeRegister frm)
        {
            try
            {
                base.Show();
                frmEmployeeRegisterObj = frm;
                EmployeeInfo infoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                infoEmployee = BllEmployeeCreation.EmployeeView(decEmployeeId);
                lblEmployeeId.Text = infoEmployee.EmployeeId.ToString();
                txtEmployeeCode.Text = infoEmployee.EmployeeCode.ToString();
                strEmployeeCode = infoEmployee.EmployeeCode.ToString();
                txtEmployeeName.Text = infoEmployee.EmployeeName.ToString();
                cmbDesignation.SelectedValue = infoEmployee.DesignationId;
                dtpDob.Text = infoEmployee.Dob.ToString("dd-MMM-yyyy");
                cmbMaritalStatus.SelectedItem = infoEmployee.MaritalStatus.ToString();
                cmbGender.SelectedItem = infoEmployee.Gender.ToString();
                txtQualification.Text = infoEmployee.Qualification;
                cmbBloodGroup.SelectedItem = infoEmployee.BloodGroup.ToString();
                txtAddress.Text = infoEmployee.Address;
                txtBankAccountNumber.Text = infoEmployee.BankAccountNumber;
                txtBankName.Text = infoEmployee.BankName;
                txtBranch.Text = infoEmployee.BranchName;
                txtEmail.Text = infoEmployee.Email;
                txtEsiNumber.Text = infoEmployee.EsiNumber;
                txtlabourCardNumber.Text = infoEmployee.LabourCardNumber;
                txtBranchCode.Text = infoEmployee.BranchCode;
                txtMobileNumber.Text = infoEmployee.MobileNumber;
                txtNarration.Text = infoEmployee.Narration;
                txtPanNumber.Text = infoEmployee.PanNumber;
                txtPassportNumber.Text = infoEmployee.PassportNo;
                txtPfNumber.Text = infoEmployee.PfNumber;
                txtPhoneNumber.Text = infoEmployee.PhoneNumber;
                txtVisaNumber.Text = infoEmployee.VisaNumber;
                cmbSalaryType.SelectedItem = infoEmployee.SalaryType;
                if (cmbSalaryType.SelectedItem.ToString() == "Daily wage")
                {
                    txtDailyWage.Text = infoEmployee.DailyWage.ToString();
                }
                else
                {
                    cmbDefaultPackage.SelectedValue = int.Parse(infoEmployee.DefaultPackageId.ToString());
                }
                txtJoiningDate.Text = infoEmployee.JoiningDate.ToString("dd-MMM-yyyy");
                dtpLabourCardExpiryDate.Value = infoEmployee.LabourCardExpiryDate;
                dtpPassportExpiryDate.Value = infoEmployee.PassportExpiryDate;
                txtTerminationDate.Text = infoEmployee.TerminationDate.ToString("dd-MMM-yyyy");
                dtpVisaExpiryDate.Value = infoEmployee.VisaExpiryDate;
                txtEmployeeCode.Focus();
                if (infoEmployee.IsActive)
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtEmployeeCode.Select();

            }
            catch (Exception ex)
            {
                MessageBox.Show("EC12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Designation combobox while return from Designation when creating new Designation 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromDesignationForm(decimal decId)//Form Designation
        {
            try
            {
                DesignationComboFill();
                if (decId.ToString() != "0")
                {
                    cmbDesignation.SelectedValue = decId;
                }
                else if (strDesignationName != string.Empty)
                {
                    cmbDesignation.SelectedValue = strDesignationName;
                }
                else
                {
                    cmbDesignation.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbDesignation.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DefaultPackage combobox while return from SalaryPackageCreation when creating new Package 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromSalaryPackageForm(decimal decId)
        {
            try
            {
                DefaultPackageComboFill();
                if (decId.ToString() != "0")
                {
                    cmbDefaultPackage.SelectedValue = decId;
                }
                else if (strSalaryPackage != string.Empty)
                {
                    cmbDefaultPackage.SelectedValue = strSalaryPackage;
                }
                else
                {
                    cmbDefaultPackage.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbDefaultPackage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeCreation_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                DesignationComboFill();
                DefaultPackageComboFill();
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("EC16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Create a  new Designation using btnDesignationAdd Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesignationAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDesignation.SelectedValue != null)
                {
                    strDesignationName = cmbDesignation.SelectedValue.ToString();
                }
                else
                {
                    strDesignationName = string.Empty;
                }
                frmDesignation frmDesignation = new frmDesignation();
                frmDesignation.MdiParent = formMDI.MDIObj;

                frmDesignation open = Application.OpenForms["frmDesignation"] as frmDesignation;
                if (open == null)
                {
                    frmDesignation.WindowState = FormWindowState.Normal;
                    frmDesignation.MdiParent = formMDI.MDIObj;
                    frmDesignation.CallFromEmployee(this); ;
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromEmployee(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }

                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Create a  new SalaryPackage using btnSalaryPakageAdd Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalaryPakageAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDefaultPackage.SelectedValue != null)
                {
                    strSalaryPackage = cmbDefaultPackage.SelectedValue.ToString();
                }
                else
                {
                    strSalaryPackage = string.Empty;
                }
                frmSalaryPackageCreation frmSalaryPackageCreation = new frmSalaryPackageCreation();
                frmSalaryPackageCreation.MdiParent = formMDI.MDIObj;

                frmSalaryPackageCreation open = Application.OpenForms["frmSalaryPackageCreation"] as frmSalaryPackageCreation;
                if (open == null)
                {
                    frmSalaryPackageCreation.WindowState = FormWindowState.Normal;
                    frmSalaryPackageCreation.MdiParent = formMDI.MDIObj;
                    frmSalaryPackageCreation.CallFromEmployee(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromEmployee(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }

                this.Enabled = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show("EC:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("EC19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, "Delete"))
                {
                    DeleteFunction();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ClearFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDailyWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checks whether Employee is active or not 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxActive.Checked == true)
                {
                    txtTerminationDate.ReadOnly = true;
                    dtpTerminationDate.Enabled = false;
                }
                else
                {
                    txtTerminationDate.ReadOnly = false;
                    dtpTerminationDate.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enabling DefaultPackage combobox on cmbSalaryType SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalaryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalaryType.Text == "Daily wage")
                {
                    lblDefaultPackage.Visible = false;
                    cmbDefaultPackage.Visible = false;
                    lblDailyWage.Visible = true;
                    txtDailyWage.Visible = true;
                    btnSalaryPakageAdd.Visible = false;
                }
                else
                {
                    lblDefaultPackage.Visible = true;
                    cmbDefaultPackage.Visible = true;
                    lblDailyWage.Visible = false;
                    txtDailyWage.Visible = false;
                    btnSalaryPakageAdd.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enabling other forms obj on FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (frmAdvancePaymentobj != null)
                {
                    frmAdvancePaymentobj.Enabled = true;
                    frmAdvancePaymentobj.ReturnFromEmployeeCreation(decIdForOtherForms);
                }
                if (frmEmployeeRegisterObj != null)
                {
                    frmEmployeeRegisterObj.Enabled = true;
                    frmEmployeeRegisterObj.Gridfill();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("EC25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtJoiningDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objDateValidation = new DateValidation();
                objDateValidation.DateValidationFunction(txtJoiningDate);
                if (txtJoiningDate.Text == string.Empty)
                {
                    txtJoiningDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTerminationDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objDateValidation = new DateValidation();
                objDateValidation.DateValidationFunction(txtTerminationDate);
                if (txtTerminationDate.Text == string.Empty)
                {
                    txtTerminationDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the text on dtpJoiningDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpJoiningDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtJoiningDate.Text = this.dtpJoiningDate.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the text on dtpTerminationDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTerminationDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtTerminationDate.Text = this.dtpTerminationDate.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationcount = 0;
                txtAddress.Text = txtAddress.Text.Trim();
                if (txtAddress.Text == string.Empty)
                {
                    txtAddress.SelectionStart = 0;
                    txtAddress.Focus();
                }
                else
                {
                    txtAddress.SelectionStart = txtAddress.Text.Length;
                    txtAddress.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationcount = 0;
                txtNarration.Text = txtNarration.Text.Trim();
                if (txtNarration.Text == string.Empty)
                {
                    txtNarration.SelectionStart = 0;
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
                MessageBox.Show("EC31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Escape key navigation and Quick access 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeCreation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
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
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled == true)
                    {
                        if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                        {
                            DeleteFunction();
                        }
                        else
                        {
                            Messages.NoPrivillageMessage();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmployeeName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDesignation.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmployeeName.Text == string.Empty || txtEmployeeName.SelectionStart == 0)
                    {
                        txtEmployeeCode.Focus();
                        txtEmployeeCode.SelectionLength = 0;
                        txtEmployeeCode.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation and Quick Access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpDob.Select();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbDesignation.Text == string.Empty || cmbDesignation.SelectionStart == 0)
                    {
                        txtEmployeeName.Focus();
                        txtEmployeeName.SelectionStart = 0;
                        txtEmployeeName.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnDesignationAdd_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    SendKeys.Send("{F10}");
                    btnDesignationAdd_Click(sender, e);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("EC35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbMaritalStatus.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbDesignation.Focus();
                    cmbDesignation.SelectionStart = 0;
                    cmbDesignation.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMaritalStatus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbGender.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbMaritalStatus.Text == string.Empty || cmbMaritalStatus.SelectionStart == 0)
                    {
                        dtpDob.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGender_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtQualification.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbGender.Text == string.Empty || cmbGender.SelectionStart == 0)
                    {
                        cmbMaritalStatus.Focus();
                        cmbMaritalStatus.SelectionStart = 0;
                        cmbMaritalStatus.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQualification_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbBloodGroup.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtQualification.Text == string.Empty || txtQualification.SelectionStart == 0)
                    {
                        cmbGender.Focus();
                        cmbGender.SelectionStart = 0;
                        cmbGender.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBloodGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtJoiningDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbBloodGroup.Text == string.Empty || cmbBloodGroup.SelectionStart == 0)
                    {
                        txtQualification.Focus();
                        txtQualification.SelectionStart = 0;
                        txtQualification.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtJoiningDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtTerminationDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtJoiningDate.Text == string.Empty || txtJoiningDate.SelectionStart == 0)
                    {
                        cmbBloodGroup.Focus();
                        cmbBloodGroup.SelectionStart = 0;
                        cmbBloodGroup.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTerminationDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalaryType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTerminationDate.Text == string.Empty || txtTerminationDate.SelectionStart == 0)
                    {
                        txtJoiningDate.Focus();
                        txtJoiningDate.SelectionStart = 0;
                        txtJoiningDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalaryType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbDefaultPackage.Visible)
                    {
                        cmbDefaultPackage.Focus();
                    }
                    else
                    {
                        txtDailyWage.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalaryType.Text == string.Empty || cmbSalaryType.SelectionStart == 0)
                    {
                        txtTerminationDate.Focus();
                        txtTerminationDate.SelectionStart = 0;
                        txtTerminationDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation and Quick Access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDefaultPackage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAddress.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbDefaultPackage.Text == string.Empty || cmbDefaultPackage.SelectionStart == 0)
                    {
                        cmbSalaryType.Focus();
                        cmbSalaryType.SelectionStart = 0;
                        cmbSalaryType.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnSalaryPakageAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationcount++;
                    if (inNarrationcount == 2)
                    {
                        inNarrationcount = 0;
                        txtPhoneNumber.Focus();
                    }
                }
                else
                {
                    inNarrationcount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtAddress.Text == string.Empty || txtAddress.SelectionStart == 0)
                    {
                        cmbDefaultPackage.Focus();
                        cmbDefaultPackage.SelectionStart = 0;
                        cmbDefaultPackage.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobileNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPhoneNumber.Text == string.Empty || txtPhoneNumber.SelectionStart == 0)
                    {
                        txtAddress.Focus();
                        txtAddress.SelectionStart = 0;
                        txtAddress.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmail.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMobileNumber.Text == string.Empty || txtMobileNumber.SelectionStart == 0)
                    {
                        txtPhoneNumber.Focus();
                        txtPhoneNumber.SelectionStart = 0;
                        txtPhoneNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxActive.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmail.Text == string.Empty || txtEmail.SelectionStart == 0)
                    {
                        txtMobileNumber.Focus();
                        txtMobileNumber.SelectionStart = 0;
                        txtMobileNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtEmail.Focus();
                    txtEmail.SelectionStart = 0;
                    txtEmail.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationcount++;
                    if (inNarrationcount == 2)
                    {
                        inNarrationcount = 0;
                        txtBankName.Focus();
                    }
                }
                else
                {
                    inNarrationcount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        cbxActive.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBankAccountNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBankName.Text == string.Empty || txtBankName.SelectionStart == 0)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBranch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBankAccountNumber.Text == string.Empty || txtBankAccountNumber.SelectionStart == 0)
                    {
                        txtBankName.Focus();
                        txtBankName.SelectionStart = 0;
                        txtBankName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBranch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBranchCode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBranch.Text == string.Empty || txtBranch.SelectionStart == 0)
                    {
                        txtBankAccountNumber.Focus();
                        txtBankAccountNumber.SelectionStart = 0;
                        txtBankAccountNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBranchCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPanNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBranchCode.Text == string.Empty || txtBranchCode.SelectionStart == 0)
                    {
                        txtBranch.Focus();
                        txtBranch.SelectionStart = 0;
                        txtBranch.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPanNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPfNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPanNumber.Text == string.Empty || txtPanNumber.SelectionStart == 0)
                    {
                        txtBranchCode.Focus();
                        txtBranchCode.SelectionStart = 0;
                        txtBranchCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPfNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEsiNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPfNumber.Text == string.Empty || txtPfNumber.SelectionStart == 0)
                    {
                        txtPanNumber.Focus();
                        txtPanNumber.SelectionStart = 0;
                        txtPanNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEsiNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassportNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEsiNumber.Text == string.Empty || txtEsiNumber.SelectionStart == 0)
                    {
                        txtPfNumber.Focus();
                        txtPfNumber.SelectionStart = 0;
                        txtPfNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassportNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpPassportExpiryDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPassportNumber.Text == string.Empty || txtPassportNumber.SelectionStart == 0)
                    {
                        txtEsiNumber.Focus();
                        txtEsiNumber.SelectionStart = 0;
                        txtEsiNumber.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPassportExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtlabourCardNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtPassportNumber.Focus();
                    txtPassportNumber.SelectionStart = 0;
                    txtPassportNumber.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtlabourCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpLabourCardExpiryDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtlabourCardNumber.Text == string.Empty || txtlabourCardNumber.SelectionStart == 0)
                    {
                        dtpPassportExpiryDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpLabourCardExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVisaNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtlabourCardNumber.Focus();
                    txtlabourCardNumber.SelectionLength = 0;
                    txtlabourCardNumber.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVisaNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpVisaExpiryDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVisaNumber.Text == string.Empty || txtVisaNumber.SelectionStart == 0)
                    {
                        dtpLabourCardExpiryDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpVisaExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtVisaNumber.Focus();
                    txtVisaNumber.SelectionStart = 0;
                    txtVisaNumber.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dtpVisaExpiryDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDailyWage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAddress.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

    }
}
