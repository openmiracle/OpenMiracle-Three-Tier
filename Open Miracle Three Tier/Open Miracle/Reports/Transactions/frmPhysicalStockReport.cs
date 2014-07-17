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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    
    public partial class frmPhysicalStockReport : Form
    {
        #region Functions
        /// <summary>
        /// Create an instance for frmPhysicalStockReport class
        /// </summary>
        public frmPhysicalStockReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill the grid based on the search condition
        /// </summary>
        public void gridfill()
        {
            try
            {
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                List<DataTable> listObj = new List<DataTable>(); 
                //DataTable dtbl = new DataTable();
                listObj = BllPhysicalStock.PhysicalStockReportFill(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), txtVoucherNo.Text.Trim(), txtProductName.Text.Trim(), Convert.ToDecimal(cmbProductCode.SelectedValue), Convert.ToDecimal(cmbVoucherType.SelectedValue));
                dgvPhysicalStockReport.DataSource = listObj[0];
                if (dgvPhysicalStockReport.Columns.Count > 0)
                {
                    dgvPhysicalStockReport.Columns["dgvtxtpurchaseRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPhysicalStockReport.Columns["dgvtxtsalesRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPhysicalStockReport.Columns["dgvtxtmrp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("PSRT1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear function to clear the controls
        /// </summary>
        public void clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                txtVoucherNo.Text = string.Empty;
                ProductCodeComboFill();
                txtProductName.Text = string.Empty;
                txtFromDate.Select();
                VoucherTypeFill();
                gridfill();
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ProductCode combobox
        /// </summary>
        public void ProductCodeComboFill()
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObj = BllProductCreation.ProductCodeViewAll(cmbProductCode, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serial no automatically in grid
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inRowSlNo = 1;
                foreach (DataGridViewRow dr in dgvPhysicalStockReport.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowSlNo;
                    inRowSlNo++;
                    if (dr.Index == dgvPhysicalStockReport.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeFill()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllVoucherType.VoucherTypeSelectionComboFill("Physical Stock");
                DataRow dr = listObj[0].NewRow();
                dr[0] = 0;
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
        #endregion
        #region Events
        /// <summary>
        /// Print button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            try
            {
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP(); 
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                if (dgvPhysicalStockReport.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    frmReport reportobj = new frmReport();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    List<DataTable> listObjPhysicalStockReport = BllPhysicalStock.PhysicalStockReportFill(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), txtVoucherNo.Text.Trim(), txtProductName.Text.Trim(), Convert.ToDecimal(cmbProductCode.SelectedValue), Convert.ToDecimal(cmbVoucherType.SelectedValue));
                    ds.Tables.Add(listObjCompany[0]);
                    ds.Tables.Add(listObjPhysicalStockReport[0]);
                    reportobj.MdiParent = formMDI.MDIObj;
                    reportobj.PhysicalStockReport(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStockReport_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click, call the gridfill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gridfill();            
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     /// <summary>
     /// Date validation , and set the dtp's value as textbox value
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
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }         
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation , and set the dtp's value as textbox value
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
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }             
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Set text box value as dtp's selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Set text box value as dtp's selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {  
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset button click, call the clear function
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
                MessageBox.Show("PSRT:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for updation of selected item in frmPhysicalStock form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStockReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    frmPhysicalStock objfrmPhysicalStock = new frmPhysicalStock(); ;
                    if (e.RowIndex != -1)
                    {
                        decimal decMasterId = Convert.ToDecimal(dgvPhysicalStockReport.Rows[e.RowIndex].Cells["dgvtxtPhysicalStockMasterId"].Value.ToString());
                        frmPhysicalStock open = Application.OpenForms["frmPhysicalStock"] as frmPhysicalStock;
                    if (open == null)
                    {
                        objfrmPhysicalStock.WindowState = FormWindowState.Normal;
                        objfrmPhysicalStock.MdiParent = formMDI.MDIObj;
                        objfrmPhysicalStock.CallFromPhysicalStockReport(this, decMasterId);
                        
                    }
                    else
                    {
                        open.CallFromPhysicalStockReport(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the serial no function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStockReport_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dgvPhysicalStockReport.Rows.Count != 1)
                {
                    SerialNo();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On 'Export' button click to export the report to Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {

            try
            {
                ExportNew ex = new ExportNew();
                ex.ExportExcel(dgvPhysicalStockReport, "Physical Stock Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:25 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
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
                MessageBox.Show("PSRT:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                    txtFromDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = 0;
                    txtVoucherNo.SelectionLength = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductCode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text.Trim() == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        /// For enter key and backspace navigation
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductName.Text.Trim() == string.Empty || txtProductName.SelectionStart == 0)
                    {
                        cmbProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PSRT:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtProductName.Focus();
                    txtProductName.SelectionStart = 0;
                    txtProductName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }     
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStockReport_KeyDown_1(object sender, KeyEventArgs e)
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
                MessageBox.Show("PSRT:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = 0;
                    txtVoucherNo.SelectionLength = 0;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductName.Focus();
                    txtProductName.SelectionStart = 0;
                    txtProductName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSRT:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        #endregion      
            
    }
}
