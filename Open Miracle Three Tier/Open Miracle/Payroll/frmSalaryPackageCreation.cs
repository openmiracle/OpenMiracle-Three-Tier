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
    
    public partial class frmSalaryPackageCreation : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        SalaryPackageInfo infoSalaryPackage = new SalaryPackageInfo();
        SalaryPackageCreationBll BllSalaryPackageCreation = new SalaryPackageCreationBll();
        SalaryPackageDetailsInfo infoSalaryPackageDetails = new SalaryPackageDetailsInfo();
        SalaryPackageCreationBll BllSalaryPackageDetails = new SalaryPackageCreationBll();
        public decimal decSalaryPackageId;
        public string strSalaryPackageName = string.Empty;
        public DataTable dtblCheck = new DataTable();
        frmSalaryPackageRegister frmSalaryPackageRegisterObj;
        frmEmployeeCreation frmEmployeeCreationObj;
        int inNarrationCount = 0;
        int q = 0;

        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmSalaryPackageCreation class
        /// </summary>
        public frmSalaryPackageCreation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtPackageName.Clear();
                txtPackageName.Focus();
                txtNarration.Clear();
                cmbActive.SelectedIndex = 0;
                dgvSalaryPackage.Rows.Clear();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                decSalaryPackageId = -1;
                lblSalaryAmount.Text = "0.00";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmEmployeeCreation to create new SalaryPackage
        /// </summary>
        /// <param name="frmEmployeeCreation"></param>
        public void CallFromEmployee(frmEmployeeCreation frmEmployeeCreation)
        {
            try
            {
                base.Show();
                this.frmEmployeeCreationObj = frmEmployeeCreation;               
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalaryPackageRegister for updation
        /// </summary>
        /// <param name="decSalaryPackageIdFromRegister"></param>
        /// <param name="frm"></param>
        public void CallFromSalaryPackageRegister(decimal decSalaryPackageIdFromRegister, frmSalaryPackageRegister frm)
        {
            try
            {
                frmSalaryPackageRegisterObj = frm;
                List<DataTable> listObjSalaryPackageDetails = new List<DataTable>();
                infoSalaryPackage = BllSalaryPackageCreation.SalaryPackageView(decSalaryPackageIdFromRegister);
                decSalaryPackageId = infoSalaryPackage.SalaryPackageId;
                txtPackageName.Text = infoSalaryPackage.SalaryPackageName;
                strSalaryPackageName = infoSalaryPackage.SalaryPackageName;
                
                txtNarration.Text = infoSalaryPackage.Narration;
                listObjSalaryPackageDetails = BllSalaryPackageDetails.SalaryPackageDetailsViewWithSalaryPackageId(decSalaryPackageIdFromRegister);
                foreach (DataRow dtblRow in listObjSalaryPackageDetails[0].Rows)
                {
                    if (dtblRow != null)
                    {
                        dgvSalaryPackage.Rows.Add();

                        dgvSalaryPackage.Rows[dgvSalaryPackage.NewRowIndex - 1].Cells["dgvtxtSlNo"].Value = dtblRow["SL.NO"];
                        dgvSalaryPackage.Rows[dgvSalaryPackage.NewRowIndex - 1].Cells["dgvcmbPayHead"].Value = dtblRow["payHeadId"];
                        dgvSalaryPackage.Rows[dgvSalaryPackage.NewRowIndex - 1].Cells["dgvtxtAmount"].Value = dtblRow["amount"];
                        dgvSalaryPackage.Rows[dgvSalaryPackage.NewRowIndex - 1].Cells["dgvtxtStatus"].Value = "Complete";
                    }
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                base.Show();
                if (infoSalaryPackage.IsActive)
                {
                    cmbActive.SelectedIndex = 0;
                }
                else 
                {
                    cmbActive.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                        Messages.DeletedMessage();
                        Clear();
                        this.Close();
                        if (frmSalaryPackageRegisterObj != null)
                        {
                            frmSalaryPackageRegisterObj.Show();
                        }
                    }
                }
                else
                {
                    BllSalaryPackageCreation.SalaryPackageDelete(decSalaryPackageId);
                    this.Close();
                    if (frmSalaryPackageRegisterObj != null)
                    {
                        frmSalaryPackageRegisterObj.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove incomplete rows in Datagridview
        /// </summary>
        public void RemoveIncompleteRowsFromGrid()
        {
            try
            {
            xxx:
                foreach (DataGridViewRow drRow in dgvSalaryPackage.Rows)
                {
                    if (!drRow.IsNewRow)
                    {
                        if (drRow.Cells["dgvtxtStatus"].Value != null && drRow.Cells["dgvtxtStatus"].Value.ToString() != "Complete")//dgvtxtStatus is column in dgvSalaryPackage,it has "Complete" if that row is completly filled
                        {
                            dgvSalaryPackage.Rows.RemoveAt(drRow.Index);
                            goto xxx;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check whether the Datagridview values is incomplete or not
        /// </summary>
        /// <returns></returns>
        public bool SalaryPackageCheckGridCompleteCheck()
        {
            bool isCheck = true;
            int inIncompleteRows = 0;
            try
            {
                foreach (DataGridViewRow drRow in dgvSalaryPackage.Rows)
                {
                    if (drRow != null)
                    {
                        if (!drRow.IsNewRow)
                        {
                            if (drRow.Cells["dgvtxtStatus"].Value.ToString() == string.Empty)
                            {
                                inIncompleteRows++;
                            }
                        }
                    }
                }
                if (inIncompleteRows > 0)
                {
                    isCheck = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isCheck;
        }
        /// <summary>
        /// Function to fill PayHead combobox
        /// </summary>
        public void GridPayHeadFill()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllPayHead.PayHeadViewAll();
                DataRow drrow = listObj[0].NewRow();
                listObj[0].Rows.InsertAt(drrow, 0);
                dgvcmbPayHead.DataSource = listObj[0];
                dgvcmbPayHead.ValueMember = "payHeadId";
                dgvcmbPayHead.DisplayMember = "payHeadName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for save
        /// </summary>
        /// <returns></returns>
        public bool SavePayHeadDetails()
        {
            bool isSave = false;
            try
            {
                int inRowCount = dgvSalaryPackage.Rows.Count;
                for (int i = 0; i < inRowCount - 1; i++)
                {
                    if (dgvSalaryPackage.Rows[i].Cells["dgvcmbPayHead"].Value != null && dgvSalaryPackage.Rows[i].Cells["dgvcmbPayHead"].Value.ToString() != "")
                    {
                        infoSalaryPackageDetails.PayHeadId = Convert.ToDecimal(dgvSalaryPackage.Rows[i].Cells["dgvcmbPayHead"].Value.ToString());
                        if (dgvSalaryPackage.Rows[i].Cells["dgvtxtAmount"].Value != null && dgvSalaryPackage.Rows[i].Cells["dgvtxtAmount"].Value.ToString() != "")
                        {
                            infoSalaryPackageDetails.Amount = Convert.ToDecimal(dgvSalaryPackage.Rows[i].Cells["dgvtxtAmount"].Value.ToString());
                            infoSalaryPackageDetails.Narration = txtNarration.Text;
                            infoSalaryPackageDetails.SalaryPackageId = decSalaryPackageId;
                            infoSalaryPackageDetails.Extra1 = string.Empty;
                            infoSalaryPackageDetails.Extra2 = string.Empty;
                            if (BllSalaryPackageCreation.SalaryPackageDetailsAdd(infoSalaryPackageDetails))
                            {
                                isSave = true;
                            }
                            else
                            {
                                isSave = false;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        /// <summary>
        /// Function to generate serial number in Datagridview
        /// </summary>
        public void SerialNumberGeneration()
        {
            try
            {
                int inRowSlNo = 1;
                int i = dgvSalaryPackage.Rows.Count;
                foreach (DataGridViewRow dr in dgvSalaryPackage.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowSlNo;
                    inRowSlNo++;
                    if (dr.Index == dgvSalaryPackage.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function for Save or Edit
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                bool isSave = false;
                infoSalaryPackage.SalaryPackageName = txtPackageName.Text;
                if (cmbActive.Text == "Yes")
                {
                    infoSalaryPackage.IsActive = true;
                }
                else
                {
                    infoSalaryPackage.IsActive = false;
                }
                infoSalaryPackage.Narration = txtNarration.Text;
                infoSalaryPackage.Extra1 = string.Empty;
                infoSalaryPackage.Extra2 = string.Empty;
                infoSalaryPackage.TotalAmount = Convert.ToDecimal(lblSalaryAmount.Text.ToString());
                if (btnSave.Text == "Save")
                {
                    if (PublicVariables.isMessageAdd)
                    {
                        if (Messages.SaveMessage())
                        {
                            decSalaryPackageId = BllSalaryPackageCreation.SalaryPackageAdd(infoSalaryPackage);
                            if (decSalaryPackageId != -1)
                            {
                                isSave = SavePayHeadDetails();
                                if (isSave)
                                {
                                    Messages.SavedMessage();
                                    if (frmEmployeeCreationObj != null)
                                    {
                                        this.Close();
                                    }
                                    Clear();
                                    
                                }
                                else
                                {
                                    BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                                }
                            }
                            else
                            {
                                Messages.InformationMessage("Package name already exists");
                                txtPackageName.Focus();
                            }
                        }
                    }
                    else
                    {
                        decSalaryPackageId = BllSalaryPackageCreation.SalaryPackageAdd(infoSalaryPackage);
                        if (decSalaryPackageId != -1)
                        {
                            isSave = SavePayHeadDetails();
                            if (isSave)
                            {
                                Messages.SavedMessage();
                                if (frmEmployeeCreationObj != null)
                                {
                                    this.Close();
                                }
                                Clear();
                                
                            }
                            else
                            {
                                BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Package name already exists");
                            txtPackageName.Focus();
                        }
                    }
                }
                else
                {
                    if (PublicVariables.isMessageEdit)
                    {
                        if (Messages.UpdateMessage())
                        {
                            if (txtPackageName.Text != strSalaryPackageName)
                            {
                                if (!BllSalaryPackageCreation.SalaryPackageNameCheckExistance(txtPackageName.Text))
                                {
                                    BllSalaryPackageCreation.SalaryPackageEdit(infoSalaryPackage);
                                    BllSalaryPackageCreation.SalaryPackageDetailsDeleteWithSalaryPackageId(decSalaryPackageId);
                                    isSave = SavePayHeadDetails();
                                    if (isSave)
                                    {
                                        Messages.UpdatedMessage();
                                       
                                        this.Close();
                                    }
                                    else
                                    {
                                        BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                                    }
                                }
                                else
                                {
                                    Messages.InformationMessage("Package name already exist");
                                    txtPackageName.Focus();
                                }
                            }
                            else
                            {
                                BllSalaryPackageCreation.SalaryPackageEdit(infoSalaryPackage);
                                BllSalaryPackageCreation.SalaryPackageDetailsDeleteWithSalaryPackageId(decSalaryPackageId);
                                isSave = SavePayHeadDetails();
                                if (isSave)
                                {
                                    Messages.UpdatedMessage();
                                    
                                    this.Close();
                                }
                                else
                                {
                                    BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (txtPackageName.Text != strSalaryPackageName)
                        {
                            if (!BllSalaryPackageCreation.SalaryPackageNameCheckExistance(txtPackageName.Text))
                            {
                                BllSalaryPackageCreation.SalaryPackageEdit(infoSalaryPackage);
                                BllSalaryPackageCreation.SalaryPackageDetailsDeleteWithSalaryPackageId(decSalaryPackageId);
                                isSave = SavePayHeadDetails();
                                if (isSave)
                                {
                                    Messages.UpdatedMessage();
                                  
                                    this.Close();
                                }
                                else
                                {
                                    BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                                }
                            }
                            else
                            {
                                Messages.InformationMessage("Package name already exist");
                                txtPackageName.Focus();
                            }
                        }
                        else
                        {
                            BllSalaryPackageCreation.SalaryPackageEdit(infoSalaryPackage);
                            BllSalaryPackageCreation.SalaryPackageDetailsDeleteWithSalaryPackageId(decSalaryPackageId);
                            isSave = SavePayHeadDetails();
                            if (isSave)
                            {
                                Messages.UpdatedMessage();
                               
                                this.Close();
                            }
                            else
                            {
                                BllSalaryPackageCreation.SalaryPackageDeleteAll(decSalaryPackageId);
                            }
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (txtPackageName.Text.Trim() != string.Empty)
                    {
                        if (cmbActive.Text.Trim() != string.Empty)
                        {
                            if (dgvSalaryPackage.Rows.Count > 1)
                            {
                                if (SalaryPackageCheckGridCompleteCheck())
                                {
                                    SaveOrEditFunction();
                                }
                                else
                                {
                                    if (MessageBox.Show("Pay head details are incomplete for salary package.Do you want to continue?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        RemoveIncompleteRowsFromGrid();
                                       
                                        
                                    }
                                }
                            }
                            else
                            {
                                Messages.InformationMessage("Select any payhead");
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Select isActive or Not");
                            cmbActive.Focus();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Enter package name");
                        txtPackageName.Focus();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        #endregion

        #region Events
        /// <summary>
        /// Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtAmountCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvSalaryPackage.CurrentCell != null)
                {
                    if (dgvSalaryPackage.Columns[dgvSalaryPackage.CurrentCell.ColumnIndex].Name == "dgvtxtAmount")
                    {
                        Common.DecimalValidation(sender,e,false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      /// <summary>
      /// Enables the objects of other forms on form closing
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void frmSalaryPackageCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmSalaryPackageRegisterObj != null)
                {
                    frmSalaryPackageRegisterObj.Enabled = true;
                    frmSalaryPackageRegisterObj.Clear();
                }
                if (frmEmployeeCreationObj != null)
                {
                    frmEmployeeCreationObj.ReturnFromSalaryPackageForm(decSalaryPackageId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial number generation on rows added in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNumberGeneration();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the PayHead type and calculates the salary amount on cellvalue changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SalaryPackageCreationBll BllSalaryPackageCreation = new SalaryPackageCreationBll();
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (e.ColumnIndex == dgvSalaryPackage.Columns["dgvcmbPayHead"].Index)
                    {
                        if (dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvcmbPayHead"].Value != null && dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvcmbPayHead"].Value.ToString() != string.Empty)
                        {
                            string strPayHeadType = BllSalaryPackageCreation.PayHeadTypeView(Convert.ToDecimal(dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvcmbPayHead"].Value.ToString()));
                            if (strPayHeadType != string.Empty)
                            {
                                dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtType"].Value = strPayHeadType;
                            }
                        }
                    }
                    bool isStatus = true;
                    if (dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtSlNo"].Value != null && dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtSlNo"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvcmbPayHead"].Value != null && dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvcmbPayHead"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value != null && dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                            {
                                isStatus = true;
                            }
                            else
                            {
                                isStatus = false;
                            }
                        }
                        else
                        {
                            isStatus = false;
                        }
                    }
                    else
                    {
                        isStatus = false;
                    }

                    if (isStatus)
                    {

                        dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtStatus"].Value = "Complete";
                    }
                    else
                    {
                        dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtStatus"].Value = string.Empty;
                    }
                    decimal decGrandTotal = 0;
                    if (dgvSalaryPackage.RowCount > 1)
                    {
                        if (dgvSalaryPackage.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value != null)
                        {
                            foreach (DataGridViewRow drRow in dgvSalaryPackage.Rows)
                            {
                                if (!dgvSalaryPackage.CurrentRow.IsNewRow)
                                {
                                    if (!drRow.IsNewRow)
                                    {
                                        if (drRow.Cells["dgvtxtAmount"].Value != null && drRow.Cells["dgvtxtType"].Value != null)
                                        {

                                            if (drRow.Cells["dgvtxtType"].Value.ToString() != "Deduction")
                                            {
                                                decGrandTotal += Convert.ToDecimal(drRow.Cells["dgvtxtAmount"].Value.ToString());
                                                lblSalaryAmount.Text = decGrandTotal.ToString();
                                            }
                                            else
                                            {
                                                decGrandTotal -= Convert.ToDecimal(drRow.Cells["dgvtxtAmount"].Value.ToString());
                                                lblSalaryAmount.Text = decGrandTotal.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalaryPackageCreation_Load(object sender, EventArgs e)
        {
            try
            {
                GridPayHeadFill();
                txtPackageName.Focus();
                cmbActive.SelectedIndex = 0;
                this.dgvSalaryPackage.Columns["dgvtxtAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Commits Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaryPackage.IsCurrentCellDirty)
                {
                    dgvSalaryPackage.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(lblSalaryAmount.Text.ToString()) > 0)
                {
                    SaveOrEdit();
                }
                else
                {
                    Messages.InformationMessage("Total salary amount should be greater than zero. Unable to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
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
                MessageBox.Show("SPC19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection on databind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvSalaryPackage.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Delete();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvtxtAmountCell = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvtxtAmountCell != null)
                {
                    dgvtxtAmountCell.KeyPress += dgvtxtAmountCell_KeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Removes the selected row on Remove link clicked and calculates salary amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvSalaryPackage.SelectedCells.Count > 0)
                {

                    if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtType"].Value != null)
                    {
                        if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtType"].Value.ToString() != string.Empty)
                        {
                            if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                decimal decAmount = 0;
                                if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtAmount"].Value != null && dgvSalaryPackage.CurrentRow.Cells["dgvtxtAmount"].Value.ToString() != "")
                                {
                                    if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtType"].Value != null)
                                    {

                                        if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtType"].Value.ToString() == "Deduction")
                                        {
                                            decAmount = -Convert.ToDecimal(dgvSalaryPackage.CurrentRow.Cells["dgvtxtAmount"].Value.ToString());
                                        }
                                        else if (dgvSalaryPackage.CurrentRow.Cells["dgvtxtType"].Value.ToString() == "Addition")
                                        {
                                            decAmount = Convert.ToDecimal(dgvSalaryPackage.CurrentRow.Cells["dgvtxtAmount"].Value.ToString());
                                        }

                                    }
                                }
                                DataGridViewRow delrow = dgvSalaryPackage.CurrentRow;
                                if (!delrow.IsNewRow)
                                {
                                    dgvSalaryPackage.Rows.RemoveAt(dgvSalaryPackage.CurrentRow.Index);
                                }
                                decimal decSalary = Convert.ToDecimal(lblSalaryAmount.Text.ToString());
                                decimal decTotal = decSalary - decAmount;
                                lblSalaryAmount.Text = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces).ToString();
                                SerialNumberGeneration();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills PayHead in datagridview on cell begin edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                List<DataTable> listObj = new List<DataTable>();

                if (dgvSalaryPackage.CurrentCell.ColumnIndex == dgvSalaryPackage.Columns["dgvcmbPayHead"].Index)
                {
                    listObj = BllPayHead.PayHeadViewAll();
                    if (listObj[0].Rows.Count < 2)
                    {
                        DataRow dr = listObj[0].NewRow();
                        dr[0] = 0;
                        dr[1] = 0;
                        listObj[0].Rows.InsertAt(dr, 0);
                    }
                    if (dgvSalaryPackage.RowCount > 1)
                    {
                        int inGridRowCount = dgvSalaryPackage.RowCount;
                        for (int inI = 0; inI < inGridRowCount - 1; inI++)
                        {
                            if (inI != e.RowIndex)
                            {
                                int inTableRowcount = listObj[0].Rows.Count;
                                for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                {
                                    if (dgvSalaryPackage.Rows[inI].Cells["dgvcmbPayHead"].Value != null && dgvSalaryPackage.Rows[inI].Cells["dgvcmbPayHead"].Value.ToString() != string.Empty)
                                    {
                                        if (listObj[0].Rows[inJ]["payHeadId"].ToString() == dgvSalaryPackage.Rows[inI].Cells["dgvcmbPayHead"].Value.ToString())
                                        {
                                            listObj[0].Rows.RemoveAt(inJ);
                                            break;
                                        }
                                    }
                                }

                            }
                        }
                    }

                    DataGridViewComboBoxCell dgvccPayHead = (DataGridViewComboBoxCell)dgvSalaryPackage[dgvSalaryPackage.Columns["dgvcmbPayHead"].Index, e.RowIndex];
                    dgvccPayHead.DataSource = listObj[0];
                    dgvccPayHead.ValueMember = "payHeadId";
                    dgvccPayHead.DisplayMember = "payHeadName";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enables the Edit mode on Enter key in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalaryPackage.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvSalaryPackage.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvSalaryPackage.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// escape key navigation and Form Quick Access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalaryPackageCreation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnclose_Click(sender, e);
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
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                    {
                        if (btnDelete.Enabled)
                        {
                            btnDelete_Click(sender, e);
                        }

                    }
                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPackageName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbActive.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtPackageName.Focus();
                    txtPackageName.SelectionStart = 0;
                    txtPackageName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Backspace navigation
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
                        cmbActive.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        dgvSalaryPackage.Focus();
                        dgvSalaryPackage.CurrentCell = dgvSalaryPackage.Rows[dgvSalaryPackage.Rows.Count - 1].Cells[1];
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show("SPC31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (dgvSalaryPackage.CurrentCell == dgvSalaryPackage.Rows[dgvSalaryPackage.Rows.Count - 1].Cells["dgvtxtAmount"])
                    {
                        btnSave.Focus();
                        dgvSalaryPackage.ClearSelection();
                        e.Handled = true;
                    }


                }
                if (e.KeyCode == Keys.Back)
                {

                    if (dgvSalaryPackage.CurrentCell == dgvSalaryPackage.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        dgvSalaryPackage.Focus();
                        dgvSalaryPackage.ClearSelection();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dgvSalaryPackage.Focus();
                    dgvSalaryPackage.CurrentCell = dgvSalaryPackage.Rows[dgvSalaryPackage.Rows.Count - 1].Cells["dgvtxtAmount"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPC33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
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
                MessageBox.Show("SPC34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
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
                MessageBox.Show("SPC35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
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
                MessageBox.Show("SPC36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

      

       
    }
}
