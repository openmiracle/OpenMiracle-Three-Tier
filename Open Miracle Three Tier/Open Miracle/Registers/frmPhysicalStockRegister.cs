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
    public partial class frmPhysicalStockRegister : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
        PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmPhysicalStockRegister class
        /// </summary>
        public frmPhysicalStockRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtVoucherNo.Text = string.Empty;
                txtFromDate.Select();
                gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void gridfill()
        {
            try
            {
                //DataTable dtbl = new DataTable();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPhysicalStock.PhysicalStockRegisterGridFill(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), txtVoucherNo.Text.Trim());
                dgvPhysicalStockRegister.DataSource = ListObj[0];
                if (dgvPhysicalStockRegister.Columns.Count > 0)
                {
                    dgvPhysicalStockRegister.Columns["dgvtxtAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStockRegister_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on ViewDetails button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                frmPhysicalStock objfrmPhysicalStock = new frmPhysicalStock();
                if (dgvPhysicalStockRegister.CurrentRow != null)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvPhysicalStockRegister.CurrentRow.Cells["dgvtxtPhysicalStockMasterId"].Value.ToString());
                    frmPhysicalStock open = Application.OpenForms["frmPhysicalStock"] as frmPhysicalStock;
                    if (open == null)
                    {
                        objfrmPhysicalStock.WindowState = FormWindowState.Normal;
                        objfrmPhysicalStock.MdiParent = formMDI.MDIObj;
                        objfrmPhysicalStock.View(this, decMasterId);
                    }
                    else
                    {
                        open.View(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//               
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//            
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Fiils txtTodate textbox on dtpTodate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PSR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                        dtpFromDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    dtpFromDate.Value = dt;
                }
                gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStockRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnViewDetails_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStockRegister_KeyDown(object sender, KeyEventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = 0;
                    txtVoucherNo.SelectionLength = 0;
                }
                if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (txtFromDate.SelectionStart == 0)
                        {
                            txtFromDate.Focus();
                            txtFromDate.SelectionStart = 0;
                            txtToDate.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnViewDetails.Focus();
                }
                if (txtVoucherNo.Text.Trim() == string.Empty || txtVoucherNo.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStockRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPhysicalStockRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvPhysicalStockRegister.CurrentCell.ColumnIndex, dgvPhysicalStockRegister.CurrentCell.RowIndex);
                        dgvPhysicalStockRegister_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnViewDetails.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
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
                    txtToDate.SelectionLength = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSR:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
