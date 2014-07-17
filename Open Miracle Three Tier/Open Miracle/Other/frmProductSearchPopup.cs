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
    public partial class frmProductSearchPopup : Form
    {


        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strGroupName = string.Empty;
        string strProductCode = string.Empty;
        string strProductName = string.Empty;
        decimal decSizeId = 0;
        decimal decModelNoId = 0;
        decimal decCurrentRowIndex = 0;
        frmPurchaseOrder frmPurchaseOrderObj;
        frmSalesOrder frmSalesOrderObj;
        frmDeliveryNote frmDeliveryNoteObj;
        frmSalesReturn frmSalesReturnObj;
        frmSalesQuotation frmSalesQuotationObj;
        frmRejectionOut frmRejectionOutObj;
        frmMaterialReceipt frmMaterialReceiptObj;
        frmPurchaseInvoice frmPurchaseInvoiceObj;
        frmSalesInvoice frmSalesInvoiceObj;
        frmPurchaseReturn frmPurchaseReturnObj;
        frmPOS frmPOSObj;
        frmPhysicalStock frmPhysicalStockObj;
        frmStockJournal frmStockJournalObj;
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmProductSearchPopup
        /// </summary>
        public frmProductSearchPopup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill the Datagridview based on productGroup
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listObjProductSearchPopup = new List<DataTable>();
                if (cmbProductGroup.SelectedIndex == 0)
                {
                    strGroupName = "All";
                }
                else
                {
                    strGroupName = cmbProductGroup.SelectedValue.ToString();
                }
                if (cmbSize.SelectedIndex == 0 || cmbSize.SelectedIndex == -1)
                {
                    decSizeId = -1;
                }
                else
                {
                    decSizeId = Convert.ToDecimal(cmbSize.SelectedValue.ToString());
                }
                if (cmbModelNo.SelectedIndex == 0 || cmbModelNo.SelectedIndex == -1)
                {
                    decModelNoId = -1;
                }
                else
                {
                    decModelNoId = Convert.ToDecimal(cmbModelNo.SelectedValue.ToString());
                }
                strProductCode = txtProductCode.Text;
                strProductName = txtProductName.Text;
                listObjProductSearchPopup = BllProductCreation.ProductSearchPopupViewAll(strGroupName, strProductCode, strProductName, decSizeId, decModelNoId);
                dgvProductSearchPopup.DataSource = listObjProductSearchPopup[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to fill the ProductGroup combobox
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                ProductGroupBll BllProductGroup = new ProductGroupBll();
                List<DataTable> listObjProductGroup = new List<DataTable>();
                listObjProductGroup = BllProductGroup.ProductGroupViewAll();
                DataRow dr = listObjProductGroup[0].NewRow();
                dr[2] = "All";
                listObjProductGroup[0].Rows.InsertAt(dr, 0);
                cmbProductGroup.DataSource = listObjProductGroup[0];
                cmbProductGroup.ValueMember = "groupId";
                cmbProductGroup.DisplayMember = "groupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        /// <summary>
        /// Function to fill the Size combobox
        /// </summary>
        public void SizeComboFill()
        {
            try
            {
                SizeBll BllSize = new SizeBll();
                List<DataTable> listObjSize = new List<DataTable>();
                listObjSize = BllSize.SizeViewAll();
                DataRow dr = listObjSize[0].NewRow();
                dr[1] = "All";
                listObjSize[0].Rows.InsertAt(dr, 0);
                cmbSize.DataSource = listObjSize[0];
                cmbSize.ValueMember = "sizeId";
                cmbSize.DisplayMember = "size";

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to fill the ModelNo combobox
        /// </summary>
        public void ModelComboFill()
        {
            try
            {
                ModelNoBll BllModelNo = new ModelNoBll();
                List<DataTable> listModelNo = new List<DataTable>();
                listModelNo = BllModelNo.ModelNoViewAll();
                DataRow dr = listModelNo[0].NewRow();
                dr[1] = "All";
                listModelNo[0].Rows.InsertAt(dr, 0);
                cmbModelNo.DataSource = listModelNo[0];
                cmbModelNo.ValueMember = "modelNoId";
                cmbModelNo.DisplayMember = "modelNo";

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPurchaseOrder to view and select the products.
        /// </summary>
        /// <param name="frmPurchaseOrder"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromPurchaseOrder(frmPurchaseOrder frmPurchaseOrder, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmPurchaseOrderObj = frmPurchaseOrder;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmSalesReturn to view and select the products.
        /// </summary>

        public void CallFromSalesReturn(frmSalesReturn frmSalesReturn, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmSalesReturnObj = frmSalesReturn;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                   
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmSalesOrder to view and select the products.
        /// </summary>
        /// <param name="frmSalesOrder"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromSalesOrder(frmSalesOrder frmSalesOrder, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmSalesOrderObj = frmSalesOrder;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmRejectionOut to view and select the products.
        /// </summary>
        /// <param name="frmRejectionOut"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromRejectionOut(frmRejectionOut frmRejectionOut, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmRejectionOutObj = frmRejectionOut;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmSalesQuotation to view and select the products.
        /// </summary>
        /// <param name="frmSalesQuotation"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromSalesQuotation(frmSalesQuotation frmSalesQuotation, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmSalesQuotationObj = frmSalesQuotation;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmMaterialReceipt to view and select the products.
        /// </summary>
        /// <param name="frmMaterialReceipt"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromMaterialReceipt(frmMaterialReceipt frmMaterialReceipt, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();

                this.frmMaterialReceiptObj = frmMaterialReceipt;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmPurchaseReturn to view and select the products.
        /// </summary>
        /// <param name="frmPurchaseReturn"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromPurchaseReturn(frmPurchaseReturn frmPurchaseReturn, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();

                this.frmPurchaseReturnObj = frmPurchaseReturn;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtproductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmDeliveryNote to view and select the products.
        /// </summary>
        /// <param name="frmDeliveryNote"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromDeliveryNote(frmDeliveryNote frmDeliveryNote, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmDeliveryNoteObj = frmDeliveryNote;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
/// <summary>
        ///  Function to call this form from frmPurchaseInvoice to view and select the products.
/// </summary>
/// <param name="frmPurchaseInvoiceObj"></param>
/// <param name="decIndex"></param>
/// <param name="strProductCode"></param>
        public void CallFromPurchaseInvoice(frmPurchaseInvoice frmPurchaseInvoiceObj, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();

                this.frmPurchaseInvoiceObj = frmPurchaseInvoiceObj;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        /// <summary>
        ///  Function to call this form from frmSalesInvoice to view and select the products.
        /// </summary>
        /// <param name="frmSalesInvoice"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>

        public void CallFromSalesInvoice(frmSalesInvoice frmSalesInvoice, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmSalesInvoiceObj = frmSalesInvoice;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CallFromStockJournal(frmStockJournal frmStockJournal, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmStockJournalObj = frmStockJournal;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    
        /// <summary>
        ///  Function to call this form from frmPOS to view and select the products.
        /// </summary>
        /// <param name="frmPOS"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromPOS(frmPOS frmPOS, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmPOSObj = frmPOS;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
   
        /// <summary>
        ///  Function to call this form from frmPhysicalStock to view and select the products.
        /// </summary>
        /// <param name="frmPhysicalStock"></param>
        /// <param name="decIndex"></param>
        /// <param name="strProductCode"></param>
        public void CallFromPhysicalStock(frmPhysicalStock frmPhysicalStock, decimal decIndex, string strProductCode)
        {
            try
            {

                decCurrentRowIndex = decIndex;
                base.Show();
                this.frmPhysicalStockObj = frmPhysicalStock;
                int inRowCount = dgvProductSearchPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProductSearchPopup.Rows[i].Cells["dgvtxtProductCode"].Value.ToString() == strProductCode)
                    {
                        dgvProductSearchPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductSearchPopup_Load(object sender, EventArgs e)
        {
            try
            {
                ProductGroupComboFill();
                SizeComboFill();
                ModelComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills DatagridView on ProductName textbox text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills DatagridView on ProductGroup combobox SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills DatagridView on ProductCode textbox text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills DatagridView on Size combobox SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills DatagridView on ModelNo combobox SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// Fills the selected product to the control to corresponding form
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dgvProductSearchPopup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (frmPurchaseOrderObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmPurchaseOrderObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                        }
                    }
                    if (frmSalesOrderObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmSalesOrderObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                        }
                    }
                    if (frmSalesQuotationObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmSalesQuotationObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                        }
                    }
                  
                    if (frmPurchaseReturnObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmPurchaseReturnObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);

                        }
                    }
                    if (frmMaterialReceiptObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmMaterialReceiptObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                        }
                    }
                    if (frmDeliveryNoteObj != null)
                    {
                        if (dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Selected)
                        {
                            frmDeliveryNoteObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                        }
                    }
                  
                    if (frmPurchaseInvoiceObj != null)
                    {
                        frmPurchaseInvoiceObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                 
                    if (frmSalesInvoiceObj != null)
                    {
                        frmSalesInvoiceObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                   
                    if (frmSalesReturnObj != null)
                    {
                        frmSalesReturnObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                    if (frmStockJournalObj != null)
                    {

                        frmStockJournalObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                    if (frmPhysicalStockObj != null)
                    {

                        frmPhysicalStockObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                    if (frmPOSObj != null)
                    {
                        frmPOSObj.CallFromProductSearchPopup(this, Convert.ToDecimal(dgvProductSearchPopup.CurrentRow.Cells["dgvtxtProductId"].Value.ToString()), decCurrentRowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Navigations
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtProductCode.Enabled == true)
                    {
                        txtProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbProductGroup.Enabled == true)
                    {
                        cmbProductGroup.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductName.Enabled == true)
                    {
                        if (txtProductCode.Text == string.Empty || txtProductCode.SelectionStart == 0)
                        {
                            txtProductName.SelectionLength = 0;
                            txtProductName.SelectionStart = 0;
                            txtProductName.Focus();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSize.Enabled == true)
                    {
                        cmbSize.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Enabled == true)
                    {
                        txtProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSize_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbModelNo.Enabled == true)
                    {
                        cmbModelNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbProductGroup.Enabled == true)
                    {
                        cmbProductGroup.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductSearchPopup.Enabled == true)
                    {
                        dgvProductSearchPopup.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSize.Enabled == true)
                    {
                        cmbSize.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the selected product to corresponding form on cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductSearchPopup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductSearchPopup.CurrentRow != null)
                    {
                        
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvProductSearchPopup.CurrentCell.ColumnIndex, dgvProductSearchPopup.CurrentCell.RowIndex);
                        dgvProductSearchPopup_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PSP29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductSearchPopup_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PSP30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
