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
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmSalesman : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strSalesmanId;
        decimal decSalesManId;
        decimal decIdforOtherForms = 0;
        decimal decIdForOtherForm = 0;
        int inNarrationCount = 0;
        frmServiceVoucher frmServiceVoucherObj;
        frmSalesOrder frmSalesOrderObj;
        frmSalesQuotation frmSalesQuotationObj;
        frmDeliveryNote frmDeliveryNoteObj;
        frmSalesReturn frmSalesReturnObj;
        frmRejectionIn frmRejectionInObj;
        frmSalesInvoice frmSalesInvoiceObj;
        frmPOS frmPOSObj;
        bool isFromPOSSalesManCombo = false;
        #endregion
        #region Functions
        /// <summary>
        /// Create instance of frmSalesman
        /// </summary>
        public frmSalesman()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill grid according to search keys
        /// </summary>
        public void Gridfill()
        {
            try
            {
                List<DataTable> listEmployeeSearch = new List<DataTable>();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                string strIsActive = "All";
                if (cmbIsActive.Text == "Yes")
                {
                    strIsActive = "True";
                }
                else if (cmbIsActive.Text == "No")
                {
                    strIsActive = "False";
                }
                else
                {
                    cmbIsActive.SelectedIndex = 0;
                }
                listEmployeeSearch = BllEmployeeCreation.SalesmanSearch(txtCode.Text, txtNameSearch.Text, txtPhoneSearch.Text, txtMobileSearch.Text, strIsActive);
                dgvSalesman.DataSource = listEmployeeSearch[0];
                if (strIsActive == "True")
                {
                    cmbIsActive.Text = "Yes";
                }
                else if (strIsActive == "False")
                {
                    cmbIsActive.Text = "No";
                }
                else
                {
                    cmbIsActive.SelectedIndex = 0;
                }
                int inRowCount = dgvSalesman.RowCount;
                for (int i = 0; i <= inRowCount - 1; i++)
                {
                    if (dgvSalesman.Rows[i].Cells["dgvtxtactive"].Value.ToString() == "1")
                    {
                        dgvSalesman.Rows[i].Cells["dgvtxtactive"].Value = "Yes";
                    }
                    if (dgvSalesman.Rows[i].Cells["dgvtxtactive"].Value.ToString() == "0")
                    {
                        dgvSalesman.Rows[i].Cells["dgvtxtactive"].Value = "No";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                txtSalesmanCode.Text = string.Empty;
                txtName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtMobile.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtNarration.Text = string.Empty;
                cbxActive.Checked = true;
                txtSalesmanCode.Focus();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the controlls for edit or delete
        /// </summary>
        public void FillControls()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                EmployeeInfo infoEmployee = new EmployeeInfo();
                infoEmployee = BllEmployeeCreation.SalesmanViewSpecificFeilds(Convert.ToDecimal(strSalesmanId.ToString()));
                txtSalesmanCode.Text = infoEmployee.EmployeeCode;
                txtName.Text = infoEmployee.EmployeeName;
                txtEmail.Text = infoEmployee.Email;
                txtPhone.Text = infoEmployee.PhoneNumber;
                txtMobile.Text = infoEmployee.MobileNumber;
                txtAddress.Text = infoEmployee.Address;
                txtNarration.Text = infoEmployee.Narration;
                if (infoEmployee.IsActive)
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }
                decSalesManId = infoEmployee.EmployeeId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the fields for search
        /// </summary>
        public void ClearSearch()
        {
            try
            {
                txtCode.Text = string.Empty;
                txtNameSearch.Text = string.Empty;
                txtMobileSearch.Text = string.Empty;
                txtPhoneSearch.Text = string.Empty;
                cmbIsActive.SelectedIndex = 0;
                txtCode.Focus();
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save a salesman
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                EmployeeInfo InfoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                InfoEmployee.EmployeeCode = txtSalesmanCode.Text.Trim();
                InfoEmployee.DesignationId = Convert.ToDecimal(BllEmployeeCreation.SalesmanGetDesignationId());
                InfoEmployee.EmployeeName = txtName.Text.Trim();
                InfoEmployee.Email = txtEmail.Text.Trim();
                InfoEmployee.PhoneNumber = txtPhone.Text.Trim();
                InfoEmployee.MobileNumber = txtMobile.Text.Trim();
                InfoEmployee.Address = txtAddress.Text.Trim();
                InfoEmployee.Narration = txtNarration.Text.Trim();
                InfoEmployee.Dob = DateTime.Now;
                InfoEmployee.MaritalStatus = "Single";
                InfoEmployee.Gender = "Male";
                InfoEmployee.Qualification = string.Empty;
                InfoEmployee.BloodGroup = string.Empty;
                InfoEmployee.JoiningDate = PublicVariables._dtCurrentDate;
                InfoEmployee.TerminationDate = DateTime.Now;
                if (cbxActive.Checked)
                {
                    InfoEmployee.IsActive = true;
                }
                else
                {
                    InfoEmployee.IsActive = false;
                }
                InfoEmployee.SalaryType = "Monthly";
                InfoEmployee.DefaultPackageId = 1;
                InfoEmployee.BankName = string.Empty;
                InfoEmployee.BankAccountNumber = string.Empty;
                InfoEmployee.BranchName = string.Empty;
                InfoEmployee.BranchCode = string.Empty;
                InfoEmployee.PanNumber = string.Empty;
                InfoEmployee.PfNumber = string.Empty;
                InfoEmployee.EsiNumber = string.Empty;
                InfoEmployee.PassportNo = string.Empty;
                InfoEmployee.PassportExpiryDate = DateTime.Now;
                InfoEmployee.VisaNumber = string.Empty;
                InfoEmployee.VisaExpiryDate = DateTime.Now;
                InfoEmployee.LabourCardNumber = string.Empty;
                InfoEmployee.LabourCardExpiryDate = DateTime.Now;
                InfoEmployee.Extra1 = string.Empty;
                InfoEmployee.Extra2 = string.Empty;
                if (BllEmployeeCreation.EmployeeCodeCheckExistance(txtSalesmanCode.Text.Trim().ToString(), 0) == false)
                {
                    decSalesManId = BllEmployeeCreation.EmployeeAddWithReturnIdentity(InfoEmployee);
                    Messages.SavedMessage();
                    Clear();
                    Gridfill();
                    if (frmRejectionInObj != null)
                    {
                        this.Close();
                    }
                    if (frmSalesQuotationObj != null)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Messages.InformationMessage("Salesman code already exist");
                    txtSalesmanCode.Focus();
                }
                if (frmSalesReturnObj != null)
                {
                    this.Close();
                }
                if (frmSalesOrderObj != null)
                {
                    this.Close();
                }
                if (frmSalesInvoiceObj != null)
                {
                    this.Close();
                }
                if (frmPOSObj != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit a salesman
        /// </summary>
        public void EditFunction()
        {
            try
            {
                EmployeeInfo InfoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                InfoEmployee.EmployeeId = decSalesManId;
                InfoEmployee.EmployeeCode = txtSalesmanCode.Text.Trim();
                InfoEmployee.EmployeeName = txtName.Text.Trim();
                InfoEmployee.Email = txtEmail.Text.Trim();
                InfoEmployee.PhoneNumber = txtPhone.Text.Trim();
                InfoEmployee.MobileNumber = txtMobile.Text.Trim();
                InfoEmployee.Address = txtAddress.Text.Trim();
                InfoEmployee.Narration = txtNarration.Text.Trim();
                if (cbxActive.Checked)
                {
                    InfoEmployee.IsActive = true;
                }
                else
                {
                    InfoEmployee.IsActive = false;
                }
                if (BllEmployeeCreation.EmployeeCodeCheckExistance(txtSalesmanCode.Text.Trim().ToString(), decSalesManId) == false)
                {
                    BllEmployeeCreation.SalesmanEdit(InfoEmployee);
                    Messages.UpdatedMessage();
                    ClearSearch();
                    Clear();
                    Gridfill();
                }
                else
                {
                    Messages.InformationMessage("Salesman code already exist");
                    txtSalesmanCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save or edit function after user confirmation and also checks invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                EmployeeInfo infoEmployee = new EmployeeInfo();
                if (txtSalesmanCode.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter salesman code");
                    txtSalesmanCode.Focus();
                }
                else if (txtName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter salesman name");
                    txtName.Focus();
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
                        decIdForOtherForm = decSalesManId;
                        if (frmServiceVoucherObj != null)
                        {
                            if (decIdForOtherForm != 0)
                            {
                                this.Close();
                            }
                            else
                            {
                                txtName.Focus();
                            }
                        }
                        if (frmDeliveryNoteObj != null)
                        {
                            if (decIdForOtherForm != 0)
                            {
                                this.Close();
                            }
                            else
                            {
                                txtName.Focus();
                            }
                        }
                        if (frmPOSObj != null)
                        {
                            if (decIdForOtherForm != 0)
                            {
                                this.Close();
                            }
                            else
                            {
                                txtName.Focus();
                            }
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
                MessageBox.Show("S7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete a salesman
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                if (BllEmployeeCreation.SalesmanCheckReferenceAndDelete(decSalesManId) == -1)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    BllEmployeeCreation.EmployeeDeleteCheck(decSalesManId);
                    Messages.DeletedMessage();
                    ClearSearch();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call the delete function after user confirmation
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    DeleteFunction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the ServiceVoucher form to add new salesman
        /// </summary>
        /// <param name="frmServiceVoucherObjfromServiceVoucher"></param>
        public void CallFromServiceVoucher(frmServiceVoucher frmServiceVoucherObjfromServiceVoucher)
        {
            try
            {
                this.frmServiceVoucherObj = frmServiceVoucherObjfromServiceVoucher;
                frmServiceVoucherObj.Enabled = false;
                base.Show();
                gbxSearch.Enabled = false;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("S10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the SalesOrder form to add new salesman
        /// </summary>
        /// <param name="frmSalesOrder"></param>
        public void CallFromSalesOrder(frmSalesOrder frmSalesOrder)
        {
            try
            {
                this.frmSalesOrderObj = frmSalesOrder;
                frmSalesOrderObj.Enabled = false;
                base.Show();
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the RejectionIn form to add new salesman
        /// </summary>
        /// <param name="frmrejectionin"></param>
        public void CallFromRejectionIn(frmRejectionIn frmrejectionin)
        {
            try
            {
                this.frmRejectionInObj = frmrejectionin;
                frmRejectionInObj.Enabled = false;
                base.Show();
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the SalesQuatation form to add new salesman
        /// </summary>
        /// <param name="frmSalesQuotaion"></param>
        public void CallFromSalesQuotation(frmSalesQuotation frmSalesQuotaion)
        {
            try
            {
                this.frmSalesQuotationObj = frmSalesQuotaion;
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the DeliveryNote form to add new salesman
        /// </summary>
        /// <param name="frmDeliveryNoteObj"></param>
        public void CallFromDeliveryNote(frmDeliveryNote frmDeliveryNoteObj)
        {
            try
            {
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
                this.frmDeliveryNoteObj = frmDeliveryNoteObj;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S13: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the SalesReturn form to add new salesman
        /// </summary>
        /// <param name="frmSalesReturn"></param>
        public void CallFromSalesReturn(frmSalesReturn frmSalesReturn)
        {
            try
            {
                dgvSalesman.Enabled = false;
                lblCode.Enabled = false;
                txtCode.Enabled = false;
                lblNameSearch.Enabled = false;
                txtNameSearch.Enabled = false;
                lblMobileSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                lblPhoneSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                lblActive.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
                this.frmSalesReturnObj = frmSalesReturn;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the SalesInvoice form to add new salesman
        /// </summary>
        /// <param name="frmSalesInvoice"></param>
        public void callFromSalesInvoice(frmSalesInvoice frmSalesInvoice)
        {
            try
            {
                this.frmSalesInvoiceObj = frmSalesInvoice;
                base.Show();
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from the POS form to add new salesman
        /// </summary>
        /// <param name="frmPOS"></param>
        public void callFromPOS(frmPOS frmPOS)
        {
            try
            {
                this.frmPOSObj = frmPOS;
                base.Show();
                dgvSalesman.Enabled = false;
                txtCode.Enabled = false;
                txtNameSearch.Enabled = false;
                txtMobileSearch.Enabled = false;
                txtPhoneSearch.Enabled = false;
                cmbIsActive.Enabled = false;
                btnSearch.Enabled = false;
                btnClearSearch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S :16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On close button click
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
                MessageBox.Show("S18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On clear button click
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
                MessageBox.Show("S19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On delete button click
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
                MessageBox.Show("S20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On save button click
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
                MessageBox.Show("S21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On clear button for Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// On search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesman_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On doubleClicking on the grid, It Fill the controlls to edit or delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (Convert.ToDecimal(dgvSalesman.CurrentRow.Cells["dgvtxtemployeeId"].Value) != 1)
                    {
                        EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                        EmployeeInfo infoEmployee = new EmployeeInfo();
                        strSalesmanId = dgvSalesman.CurrentRow.Cells["dgvtxtemployeeId"].Value.ToString();
                        FillControls();
                        btnSave.Text = "Update";
                        btnDelete.Enabled = true;
                        txtSalesmanCode.Focus();
                    }
                    else
                    {
                        Messages.InformationMessage("Default employee cannot update or delete");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesman_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmRejectionInObj != null)
            {
                frmRejectionInObj.ReturnFromSalesMan(decSalesManId);
                frmRejectionInObj.Enabled = true;
                frmRejectionInObj.Activate();
            }
            if (frmDeliveryNoteObj != null)
            {
                frmDeliveryNoteObj.ReturnFromSalesManForm(decSalesManId);
            }
            if (frmSalesOrderObj != null)
            {
                frmSalesOrderObj.ReturnFromSalesManForm(decSalesManId);
                frmSalesOrderObj.Enabled = true;
                frmSalesOrderObj.Activate();
            }
            if (frmSalesReturnObj != null)
            {
                frmSalesReturnObj.ReturnFromSalesMan(decSalesManId);
            }
            if (frmSalesInvoiceObj != null)
            {
                frmSalesInvoiceObj.ReturnFromSalesManCreation(decSalesManId);
            }
            if (frmSalesQuotationObj != null)
            {
                frmSalesQuotationObj.ReturnFromSalesMan(decSalesManId);
            }
            if (frmServiceVoucherObj != null)
            {
                frmServiceVoucherObj.ReturnFromSalesman(decSalesManId);
            }
            if (frmPOSObj != null)
            {
                frmPOSObj.ReturnFromSalesman(decSalesManId);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enter key navigation Salesmancode textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalesmanCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmail.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtName.Text == string.Empty || txtName.SelectionStart == 0)
                    {
                        txtSalesmanCode.Focus();
                        txtSalesmanCode.SelectionStart = 0;
                        txtSalesmanCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtEmail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPhone.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmail.Text == string.Empty || txtEmail.SelectionStart == 0)
                    {
                        txtName.Focus();
                        txtName.SelectionStart = 0;
                        txtName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtPhone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobile.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPhone.Text == string.Empty || txtPhone.SelectionStart == 0)
                    {
                        txtEmail.Focus();
                        txtEmail.SelectionStart = 0;
                        txtEmail.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtMobile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAddress.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMobile.Text == string.Empty || txtMobile.SelectionStart == 0)
                    {
                        txtPhone.Focus();
                        txtPhone.SelectionStart = 0;
                        txtPhone.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of txtAddress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtAddress.Text == string.Empty || txtAddress.SelectionStart == 0)
                    {
                        txtMobile.Focus();
                        txtMobile.SelectionStart = 0;
                        txtMobile.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace Navigation of txtNarration
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
                        txtAddress.Focus();
                        txtAddress.SelectionStart = 0;
                        txtAddress.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxActive.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of btnClear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("S35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of Close button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (btnDelete.Enabled == false)
                    {
                        btnClear.Focus();
                    }
                    else
                    {
                        btnDelete.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtcode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNameSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCode.Text == string.Empty || txtCode.SelectionStart == 0)
                    {
                        btnClose.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtNameSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobileSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNameSearch.Text == string.Empty || txtNameSearch.SelectionStart == 0)
                    {
                        txtCode.Focus();
                        txtCode.SelectionStart = 0;
                        txtCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtMobileSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobileSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPhoneSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMobileSearch.Text == string.Empty || txtMobileSearch.SelectionStart == 0)
                    {
                        txtNameSearch.Focus();
                        txtNameSearch.SelectionStart = 0;
                        txtNameSearch.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtPhoneSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhoneSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbIsActive.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPhoneSearch.Text == string.Empty || txtPhoneSearch.SelectionStart == 0)
                    {
                        txtMobileSearch.Focus();
                        txtMobileSearch.SelectionStart = 0;
                        txtMobileSearch.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of cmbIsactive combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbIsActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbIsActive.Text == string.Empty || cmbIsActive.SelectionStart == 0)
                    {
                        txtPhoneSearch.Focus();
                        txtPhoneSearch.SelectionStart = 0;
                        txtPhoneSearch.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation of btnSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbIsActive.Focus();
                    cmbIsActive.SelectionStart = 0;
                    cmbIsActive.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of txtAddress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        txtNarration.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of txtNarration
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
                        cbxActive.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On enter key in grid, It performs celldoubleclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesman_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesman.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalesman.CurrentCell.ColumnIndex, dgvSalesman.CurrentCell.RowIndex);
                        dgvSalesman_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut keys
        /// Esc for formclosing
        /// ctrl+s for Save
        /// ctrl+d for delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesman_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    if (cbxActive.Focused)
                    {
                        btnSave.Focus();
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
                MessageBox.Show("S51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation for grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesman_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbIsActive.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation of cbxActive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
