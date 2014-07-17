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
    public partial class frmAgainstBillDetails : Form
    {

        #region publicvariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmPartyBalance frmPartyBalanceObj;      
        decimal decledgerId = 0;
        string strDebitOrCredit = string.Empty;
        #endregion

        #region fuctions
        /// <summary>
        /// Creates an instance of frmAgainstBillDetails class
        /// </summary>
        public frmAgainstBillDetails()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill vouchertype combobox
        /// </summary>
        public void VoucherComboFill()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllVoucherType.VoucherTypeViewAllForAgainstBillDetails();
                DataRow dr = listObj[0].NewRow();
                dr[0] = 0;
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);                             
                cmbVoucherType.DisplayMember = "typeOfVoucher";
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DataSource = listObj[0];  
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType name combobox
        /// </summary>
        public void VoucherTypeNameComboFill()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObj = new List<DataTable>();
                decimal decVoucherTypeId = 0;             
                decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                listObj = BllVoucherType.VoucherTypeNameViewAllForComboFill(decVoucherTypeId);
                DataRow dr = listObj[0].NewRow();
                dr[0] = 0;
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
              
                cmbVoucherTypeName.DisplayMember = "voucherTypeName";
                cmbVoucherTypeName.ValueMember = "voucherTypeId";
                cmbVoucherTypeName.DataSource = listObj[0];
                cmbVoucherTypeName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                List<DataTable> listObj = new List<DataTable>();
                decimal decVoucherTypeId =0;
                decimal decVoucherTypeNameId=0;
                decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                decVoucherTypeNameId = Convert.ToDecimal(cmbVoucherTypeName.SelectedValue.ToString());
                listObj = BllPartyBalance.AgainstBillDetailsGridViewByLedgerId(decledgerId, strDebitOrCredit, decVoucherTypeId, decVoucherTypeNameId);
                dgvAgainstBillDetails.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form frmPartyBalance
        /// </summary>
        /// <param name="frmPartyBalance"></param>
        /// <param name="decId"></param>
        /// <param name="strDrCr"></param>
        public void CallFromPartyBalance(frmPartyBalance frmPartyBalance, decimal decId,string strDrCr) 
        {
            try
            {
                decledgerId = decId;
                strDebitOrCredit = strDrCr;
                base.Show();
                this.frmPartyBalanceObj = frmPartyBalance;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
        #endregion

        #region events
        /// <summary>
        /// Closes this forms
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgainstBillDetails_Load(object sender, EventArgs e)
        {
            try
            {
                VoucherComboFill();
                VoucherTypeNameComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills datagridview and VoucherType name combobox on VoucherType combobox Selected Index Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoucherTypeNameComboFill();
            GridFill();
        }
        /// <summary>
        /// Calls frmPartyBalance form on datagridView cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAgainstBillDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAgainstBillDetails.Rows[e.RowIndex].Cells["dgvtxtVoucherTypeId"].Value != null && dgvAgainstBillDetails.Rows[e.RowIndex].Cells["dgvtxtVoucherTypeId"].Value.ToString() != string.Empty)
                {
                    if (dgvAgainstBillDetails.Rows[e.RowIndex].Cells["dgvtxtVoucherNo"].Value != null && dgvAgainstBillDetails.Rows[e.RowIndex].Cells["dgvtxtVoucherNo"].Value.ToString() != string.Empty)
                    {
                        frmPartyBalanceObj.MdiParent = formMDI.MDIObj;
                        string strId = dgvAgainstBillDetails.CurrentRow.Cells["dgvtxtVoucherTypeId"].Value.ToString() + '_' + dgvAgainstBillDetails.CurrentRow.Cells["dgvtxtVoucherNo"].Value.ToString();
                        frmPartyBalanceObj.CallFromAgainstBillDetails(this, strId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }     
        #endregion

        #region navigation
        /// <summary>
        /// Closes form on 'Escape' key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgainstBillDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AB8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
