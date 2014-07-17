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
    public partial class frmCurrency : Form
    {
        #region Public Variables
        /// <summary>
        /// Public varaible declaration part
        /// </summary>
        decimal decCurrencyId;
        decimal decCurrency;
        int inNarrationCount = 0;
        decimal decIdForOtherForms = 0;
        frmExchangeRate frmExchangeRateObj;
        decimal decId;
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmCurrency class
        /// </summary>
        public frmCurrency()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                CurrencyInfo infoCurrency = new CurrencyInfo();
                CurrencyBll BllCurrency = new CurrencyBll();
                infoCurrency.CurrencySymbol = txtSymbol.Text.Trim();
                infoCurrency.CurrencyName = txtName.Text.Trim();
                infoCurrency.SubunitName = txtSubUnit.Text.Trim();
                infoCurrency.NoOfDecimalPlaces = Convert.ToInt32(txtDecimalPlaces.Text.Trim());
                infoCurrency.Narration = txtNarration.Text.Trim();
                infoCurrency.IsDefault = false;
                infoCurrency.Extra1 = string.Empty;
                infoCurrency.Extra2 = string.Empty;
                if (BllCurrency.CurrencyNameCheckExistence(txtName.Text.Trim(), txtSymbol.Text.Trim(), 0) == false)
                {
                    decCurrency = BllCurrency.CurrencyAddwithIdentity(infoCurrency);
                    Messages.SavedMessage();
                    Clear();
                    decIdForOtherForms = decCurrency;
                    if (frmExchangeRateObj != null)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Messages.InformationMessage("Currency name already exist");
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                CurrencyInfo infoCurrency = new CurrencyInfo();
                CurrencyBll BllCurrency = new CurrencyBll();
                infoCurrency.CurrencySymbol = txtSymbol.Text.Trim();
                infoCurrency.CurrencyName = txtName.Text.Trim();
                infoCurrency.SubunitName = txtSubUnit.Text.Trim();
                infoCurrency.NoOfDecimalPlaces = Convert.ToInt32(txtDecimalPlaces.Text.Trim());
                infoCurrency.Narration = txtNarration.Text.Trim();
                infoCurrency.IsDefault = false;
                infoCurrency.Extra1 = String.Empty;
                infoCurrency.Extra2 = String.Empty;
                infoCurrency.CurrencyId = decId;
                if (BllCurrency.CurrencyNameCheckExistence(txtName.Text.Trim(), txtSymbol.Text.Trim(), decCurrencyId) == false)
                {
                    BllCurrency.CurrencyEdit(infoCurrency);
                    Messages.UpdatedMessage();
                    SearchClear();
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Currency name already exist");
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FUNCTION TO CALL SAVE OR EDIT
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter currency name");
                    txtName.Focus();
                }
                else if (txtSymbol.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter symbol");
                    txtSymbol.Focus();
                }
                else if (txtDecimalPlaces.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter decimal places");
                    txtDecimalPlaces.Focus();
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
                MessageBox.Show("C3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls for update
        /// </summary>
        public void FillControls()
        {
            try
            {
                CurrencyInfo infoCurrency = new CurrencyInfo();
                CurrencyBll BllCurrency = new CurrencyBll();
                infoCurrency = BllCurrency.CurrencyView(decId);
                txtName.Text = infoCurrency.CurrencyName;
                txtSymbol.Text = infoCurrency.CurrencySymbol;
                txtSubUnit.Text = infoCurrency.SubunitName;
                txtDecimalPlaces.Text = infoCurrency.NoOfDecimalPlaces.ToString();
                txtNarration.Text = infoCurrency.Narration;
                decCurrencyId = infoCurrency.CurrencyId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("C4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear controls
        /// </summary>
        public void Clear()
        {
            try
            {
                txtDecimalPlaces.Clear();
                txtName.Clear();
                txtNarration.Clear();
                txtSubUnit.Clear();
                txtSymbol.Clear();
                txtName.Focus();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("C5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear
        /// </summary>
        public void SearchClear()
        {
            try
            {
                txtNameSearch.Clear();
                txtSymbolSearch.Clear();
                txtNameSearch.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                List<DataTable> listCurrency = new List<DataTable>();
                listCurrency = BllCurrency.CurrencySearch(txtNameSearch.Text.Trim(), txtSymbolSearch.Text.Trim());
                dgvCurrency.DataSource = listCurrency[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("C7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                if (BllCurrency.CurrencyCheckReferences(decId) == -1)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    Messages.DeletedMessage();
                    Clear();
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("C9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from Exchangerate
        /// </summary>
        /// <param name="frmExchangeRate"></param>
        public void CallFromExchangerate(frmExchangeRate frmExchangeRate)
        {
            try
            {
                groupBox2.Enabled = false;
                this.frmExchangeRateObj = frmExchangeRate;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrency_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    GridFill();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("C13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("C14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("C15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("C16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On datagridview cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyBll BllCurrency = new CurrencyBll();
            try
            {
                if (e.RowIndex != -1)
                {
                    decId = Convert.ToDecimal(dgvCurrency.Rows[e.RowIndex].Cells["dgvtxtCurrencyId"].Value.ToString());
                    if (!BllCurrency.DefaultCurrencyCheck(decId))
                    {
                        FillControls();
                        btnDelete.Enabled = true;
                        btnSave.Text = "Update";
                        txtName.Focus();
                    }
                    else
                    {
                        Messages.InformationMessage("Default currency cannot update or delete");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvCurrency.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Serach' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("C20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Narration' textbox key enter
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
                MessageBox.Show("C21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Decimal places' textbox key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDecimalPlaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.NumberOnly(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrency_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmExchangeRateObj != null)
                {
                    frmExchangeRateObj.ReturnFromCurrencyForm(decIdForOtherForms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// On form keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) 
                {
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) 
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Name' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSymbol.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Symbol' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSubUnit.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSymbol.Text == string.Empty || txtSymbol.SelectionStart == 0)
                    {
                        txtName.Focus();
                        txtName.SelectionStart = 0;
                        txtName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'SubUnit' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSubUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDecimalPlaces.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSubUnit.Text == string.Empty || txtSubUnit.SelectionStart == 0)
                    {
                        txtSymbol.Focus();
                        txtSymbol.SelectionStart = 0;
                        txtSymbol.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'DecimalPlaces' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDecimalPlaces_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDecimalPlaces.Text == string.Empty || txtDecimalPlaces.SelectionStart == 0)
                    {
                        txtSubUnit.Focus();
                        txtSubUnit.SelectionStart = 0;
                        txtSubUnit.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Narration' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
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
                else
                {
                    inNarrationCount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtDecimalPlaces.Focus();
                        txtDecimalPlaces.SelectionStart = 0;
                        txtDecimalPlaces.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  On 'NameSearch' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSymbolSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Symbol' textbox key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSymbolSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSymbolSearch.Text == string.Empty || txtSymbolSearch.SelectionStart == 0)
                    {
                        txtNameSearch.Focus();
                        txtNameSearch.SelectionStart = 0;
                        txtNameSearch.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save' button key down
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
                MessageBox.Show("C32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtSymbolSearch.Focus();
                    txtSymbolSearch.SelectionLength = 0;
                    txtSymbolSearch.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On datagridview keyup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (dgvCurrency.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvCurrency.CurrentCell.ColumnIndex, dgvCurrency.CurrentCell.RowIndex);
                        dgvCurrency_CellDoubleClick(sender, ex);
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtSymbolSearch.Focus();
                    txtSymbolSearch.SelectionLength = 0;
                    txtSymbolSearch.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("C35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
