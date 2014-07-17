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
    public partial class frmPayHeadReport : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmPayHeadReport class
        /// </summary>
        public frmPayHeadReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill PayHead combobox
        /// </summary>
        public void PayHeadComboFill()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                List<DataTable> listPayHead = BllPayHead.PayHeadViewAll();
                DataRow dr = listPayHead[0].NewRow();
                dr[2] = "All";
                listPayHead[0].Rows.InsertAt(dr, 0);
                cmbPayHead.DataSource = listPayHead[0];
                cmbPayHead.ValueMember = "payHeadId";
                cmbPayHead.DisplayMember = "payHeadName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:1 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                List<DataTable> listObj = BllPayHead.PayHeadViewAllForPayHeadReport(cmbPayHead.Text, cmbType.Text);
                dgvPayHead.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:2 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbPayHead.SelectedIndex = 0;
                cmbType.SelectedIndex = 0;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:3 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPayHeadReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPayHead.Focus();
                cmbType.SelectedIndex = 0;
                PayHeadComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:4 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:5 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:6 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPayHead.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    PayHeadBll BllPayHead = new PayHeadBll();
                    List<DataTable> listObj = BllPayHead.PayHeadViewAllForPayHeadReport(cmbPayHead.Text, cmbType.Text);
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    frmReport frmreport = new frmReport();
                    frmreport.MdiParent = formMDI.MDIObj;
                    ds.Tables.Add(listObj[0]);
                    ds.Tables.Add(listObjCompany[0]);
                    frmreport.PayHeadReport(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:7 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvPayHead, "Pay Head Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// EScape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPayHeadReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PHR:8 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPayHead_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:9 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbPayHead.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:10 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PHR:11 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
     
    }
}
