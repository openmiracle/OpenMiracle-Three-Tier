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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmProductBom : Form
    {
        #region Public variables
        frmProductCreation frmProductCreationObj;
        bool isSaveUse;
        bool isValueChanged = false;
        bool isMulProductCheck;
        bool isRemoved = false;
        bool isCallFromProductCreation = false;
        decimal decProductIdForEdit;
        string[] strArRemove = new string[100];
        int InIdex = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Create an Instance for frmProductBom class
        /// </summary>
        public frmProductBom()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call this form from frmProductCreation to view details, Save and updation 
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        public void CallFromProdutCreation(frmProductCreation frmProduct, string strProductName)
        {
            try
            {
                frmProductCreationObj = frmProduct;
                txtProduct.Text = strProductName;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmProductCreation to view details, Save and updation ifthe product was not saved
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        /// <param name="dtblBomAgain"></param>
        public void CallFromProdutCreationAgain(frmProductCreation frmProduct, string strProductName, DataTable dtblBomAgain)
        {
            try
            {
                base.Show();
                frmProductCreationObj = frmProduct;
                txtProduct.Text = strProductName;
                for (int inI = 0; inI < dtblBomAgain.Rows.Count; inI++)
                {
                    dgvProductBOM.Rows.Add();
                    dgvProductBOM.Rows[inI].Cells["dgvtxtQty"].Value = dtblBomAgain.Rows[inI]["dgvtxtQty"];
                    dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value = dtblBomAgain.Rows[inI]["dgvcmbRawMaterial"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// RawMaterialComboFill function
        /// </summary>
        public void RawMaterialComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (isCallFromProductCreation)
                {
                    listObj = BllProductCreation.ProductViewAllWithoutOneProduct(decProductIdForEdit);
                    dgvcmbRawMaterial.DataSource = listObj[0];
                    DataRow drow = listObj[0].NewRow();
                    drow["productName"] = string.Empty;
                    drow["productId"] = 0;
                    listObj[0].Rows.InsertAt(drow, 0);
                    dgvcmbRawMaterial.DisplayMember = "productName";
                    dgvcmbRawMaterial.ValueMember = "productId";
                }
                else
                {
                    listObj = BllProductCreation.ProductViewAll();
                    DataRow drow = listObj[0].NewRow();
                    drow["productName"] = string.Empty;
                    drow["productId"] = 0;
                    listObj[0].Rows.InsertAt(drow, 0);
                    dgvcmbRawMaterial.DataSource = listObj[0];
                    dgvcmbRawMaterial.DisplayMember = "productName";
                    dgvcmbRawMaterial.ValueMember = "productId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial No generation for grid
        /// </summary>
        public void SlNo()
        {
            try
            {
                int inRowNo = 1;
                foreach (DataGridViewRow dr in dgvProductBOM.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvProductBOM.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Check invalid entries in grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductBOM.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (!dgvProductBOM.CurrentRow.IsNewRow && (dgvProductBOM.CurrentRow.Cells["dgvcmbRawMaterial"].Value == null || dgvProductBOM.CurrentRow.Cells["dgvcmbRawMaterial"].Value.ToString().Trim() == ""))
                        {
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.HeaderCell.Value = "X";
                            dgvProductBOM.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.Cells["dgvtxtCheck"].Value = "X";
                            dgvProductBOM["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (!dgvProductBOM.CurrentRow.IsNewRow && (dgvProductBOM.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvProductBOM.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == ""))
                        {
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.HeaderCell.Value = "X";
                            dgvProductBOM.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.Cells["dgvtxtCheck"].Value = "X";
                            dgvProductBOM["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (!dgvProductBOM.CurrentRow.IsNewRow && (dgvProductBOM.CurrentRow.Cells["dgvcmbUnit"].Value == null))
                        {
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.HeaderCell.Value = "X";
                            dgvProductBOM.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.Cells["dgvtxtCheck"].Value = "X";
                            dgvProductBOM["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.HeaderCell.Value = "";
                            isValueChanged = true;
                            dgvProductBOM.CurrentRow.Cells["dgvtxtCheck"].Value = "";
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// SendDataTale To Product Creation
        /// </summary>
        public void DataTableSend()
        {
            try
            {
                DataTable dtblsend = new DataTable();
                DataColumn dc = new DataColumn("dgvcmbRawMaterial", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtQty", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtUnitId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra1", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra2", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extraDate", typeof(DateTime));
                dtblsend.Columns.Add(dc);
                for (int inI = 0; inI < dgvProductBOM.RowCount - 1; inI++)
                {
                    DataRow dr = dtblsend.NewRow();
                    dr[0] = dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value.ToString();
                    dr[1] = dgvProductBOM.Rows[inI].Cells["dgvtxtQty"].Value.ToString();
                    dr[2] = dgvProductBOM.Rows[inI].Cells["dgvcmbUnit"].Value;
                    dr[3] = string.Empty;
                    dr[4] = string.Empty;
                    dr[5] = DateTime.Now;
                    int inPosition = inI;
                    dtblsend.Rows.InsertAt(dr, inPosition);
                    isSaveUse = true;
                }
                if (dtblsend.Rows.Count > 0)
                {
                    frmProductCreationObj.DataTableReturn(dtblsend, isSaveUse);
                    Messages.SavedMessage();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant save atleast one row", "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductBOM.Focus();
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Check the repetation of raw-material
        /// </summary>
        public void GridCheckOfSameRawMaterial()
        {
            isMulProductCheck = false;
            try
            {
                foreach (DataGridViewRow dgvrowOne in dgvProductBOM.Rows)
                {
                    foreach (DataGridViewRow dgvrowTwo in dgvProductBOM.Rows)
                    {
                        if (dgvrowOne.Index != dgvrowTwo.Index)
                        {
                            if (dgvrowOne.Cells["dgvcmbRawMaterial"].Value != null && dgvrowTwo.Cells["dgvcmbRawMaterial"].Value != null)
                                if (dgvrowOne.Cells["dgvcmbRawMaterial"].Value.ToString() == dgvrowTwo.Cells["dgvcmbRawMaterial"].Value.ToString())
                                {
                                    isMulProductCheck = true;
                                    Messages.InformationMessage("Repeatation of same raw-material");
                                    dgvProductBOM.Focus();
                                    dgvProductBOM.CurrentCell = dgvProductBOM.Rows[dgvrowTwo.Index].Cells["dgvcmbRawMaterial"];
                                    dgvProductBOM.BeginEdit(true);
                                    break;
                                }
                        }
                    }
                    if (isMulProductCheck == true)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Sending Updated datatable to frmProduct
        /// </summary>
        public void SendTableForUpdate()
        {
            try
            {
                DataTable dtblsend = new DataTable();
                DataColumn dc = new DataColumn("dgvcmbRawMaterial", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtQty", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtUnitId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra1", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra2", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extraDate", typeof(DateTime));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("bomId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                for (int inI = 0; inI < dgvProductBOM.RowCount - 1; inI++)
                {
                    DataRow dr = dtblsend.NewRow();
                    dr[0] = dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value.ToString();
                    dr[1] = dgvProductBOM.Rows[inI].Cells["dgvtxtQty"].Value.ToString();
                    dr[2] = dgvProductBOM.Rows[inI].Cells["dgvcmbUnit"].Value;
                    dr[3] = string.Empty;
                    dr[4] = string.Empty;
                    dr[5] = DateTime.Now;
                    if (Convert.ToDecimal(dgvProductBOM.Rows[inI].Cells["dgvtxtBomId"].Value) == 0)
                    {
                        dr[6] = 0;
                    }
                    else
                    {
                        dr[6] = dgvProductBOM.Rows[inI].Cells["dgvtxtBomId"].Value.ToString();
                    }
                    int inPosition = inI;
                    dtblsend.Rows.InsertAt(dr, inPosition);
                }
                bool isOk = true;
                if (dtblsend.Rows.Count > 0)
                {
                    if (isRemoved)
                    {
                        frmProductCreationObj.RomovedIndexFromBom(strArRemove);
                    }
                    frmProductCreationObj.DataTableForBomUpdate(dtblsend, isOk);
                    Messages.UpdatedMessage();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant save atleast one row", "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductBOM.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call from frmProduct For Updation
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        /// <param name="ProductId"></param>
        /// <param name="dtblBom"></param>
        public void CallFromProdutCreationForUpadte(frmProductCreation frmProduct, string strProductName, decimal ProductId, DataTable dtblBom)
        {
            try
            {
                decProductIdForEdit = ProductId;
                isCallFromProductCreation = true;
                base.Show();
                frmProductCreationObj = frmProduct;
                txtProduct.Text = strProductName;
                txtProduct.Text = strProductName;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                GridFillForUpdate(dtblBom);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Savefunction
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                if (RemoveIncompleteRowsFromGrid())
                {
                    if (PublicVariables.isMessageAdd)
                    {
                        if (Messages.SaveMessage())
                        {
                            DataTableSend();
                        }
                    }
                    else
                    {
                        DataTableSend();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                if (RemoveIncompleteRowsFromGrid())
                {
                    if (PublicVariables.isMessageEdit)
                    {
                        if (Messages.UpdateMessage())
                        {
                            SendTableForUpdate();
                        }
                    }
                    else
                    {
                        SendTableForUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or Edit and checking invalid entry's
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    if (PublicVariables.isMessageAdd)
                    {
                        SaveFunction();
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
                        EditFunction();
                    }
                    else
                    {
                        EditFunction();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GridFillForUpdate Function
        /// </summary>
        /// <param name="dtbBomForEdit"></param>
        public void GridFillForUpdate(DataTable dtbBomForEdit)
        {
            try
            {
                for (int inI = 0; inI < dtbBomForEdit.Rows.Count; inI++)
                {
                    dgvProductBOM.Rows.Add();
                    dgvProductBOM.Rows[inI].Cells["dgvtxtQty"].Value = dtbBomForEdit.Rows[inI]["quantity"];
                    dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value = dtbBomForEdit.Rows[inI]["rowmaterialId"];
                    dgvProductBOM.Rows[inI].Cells["dgvcmbUnit"].Value = dtbBomForEdit.Rows[inI]["unitId"];
                    dgvProductBOM.Rows[inI].Cells["dgvtxtBomId"].Value = dtbBomForEdit.Rows[inI]["bomId"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete Function
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
                MessageBox.Show("PB:14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DeleteFunction checking conformation
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                ProductBomBll BllProductBom = new ProductBomBll();
                Messages.DeletedMessage();
                if (frmProductCreationObj != null)
                {
                    bool isDeleted = true;
                    frmProductCreationObj.ReciveDeleteConfirmation(isDeleted);
                }
                Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid Clear function 
        /// </summary>
        public void Clear()
        {
            try
            {
                dgvProductBOM.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmProductCreation to view details and for updation 
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        /// <param name="decProductId"></param>
        public void CallFromProdutCreation(frmProductCreation frmProduct, string strProductName, decimal decProductId)
        {
            try
            {
                decProductIdForEdit = decProductId;
                isCallFromProductCreation = true;
                frmProductCreationObj = frmProduct;
                txtProduct.Text = strProductName;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// RemoveIncompleteRowsFromGrid function
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvProductBOM.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvProductBOM.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null && dgvrowCur.HeaderCell.Value.ToString() == "X")
                        {
                            isOk = false;
                            if (inC == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvrowCur.Index + 1);
                                inForFirst = dgvrowCur.Index;
                                inC++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvrowCur.Index + 1);
                            }
                        }
                    }
                    inLastRow++;
                }
                inLastRow = 1;
                if (!isOk)
                {
                    strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvProductBOM.Rows.Count; inK++)
                        {
                            if (!dgvProductBOM.Rows[inK].IsNewRow)
                            {
                                if (dgvProductBOM.Rows[inK].HeaderCell.Value != null && dgvProductBOM.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "X")// && dgvProductBOM.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "x")
                                {
                                    if (!dgvProductBOM.Rows[inK].IsNewRow)
                                    {
                                        if (dgvProductBOM.Rows[inK].Cells["dgvtxtBomId"].Value != null && Convert.ToDecimal(dgvProductBOM.Rows[inK].Cells["dgvtxtBomId"].Value) != 0)
                                        {
                                            isRemoved = true;
                                            strArRemove[InIdex] = Convert.ToString((dgvProductBOM.Rows[inK].Cells["dgvtxtBomId"].Value));
                                            InIdex++;
                                        }
                                        dgvProductBOM.Rows.RemoveAt(inK);
                                        inK--;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvProductBOM.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PM:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// DecimalValidation In data gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProductBOM.CurrentCell != null)
                {
                    if (dgvProductBOM.Columns[dgvProductBOM.CurrentCell.ColumnIndex].Name == "dgvtxtQty")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// When form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductBom_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProductBOM.Rows.Clear();
                dgvProductBOM.Focus();
                RawMaterialComboFill();
                btnDelete.Enabled = false;
                dgvProductBOM.Select();
                dgvProductBOM.CurrentCell = dgvProductBOM.Rows[0].Cells["dgvtxtSlNo"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid CellValueChanged for do the basic calculation and unit selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductBOM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CheckInvalidEntries(e);
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                TransactionsGeneralFillBll trstGnFill = new TransactionsGeneralFillBll();
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == dgvProductBOM.Columns["dgvcmbRawMaterial"].Index)
                    {
                        if (dgvProductBOM.Rows[e.RowIndex].Cells["dgvcmbRawMaterial"] != null)
                        {
                            dgvProductBOM.Rows[e.RowIndex].Cells["dgvtxtUnit"].Value = BllProductCreation.ProductUnit(Convert.ToDecimal(dgvProductBOM.Rows[e.RowIndex].Cells[1].Value));
                            List<DataTable> listObj = new List<DataTable>();
                            decimal decProductId = Convert.ToDecimal(dgvProductBOM.Rows[e.RowIndex].Cells["dgvcmbRawMaterial"].Value);
                            listObj = trstGnFill.UnitViewAllByProductId(dgvProductBOM, decProductId.ToString(), e.RowIndex);
                            DataRow drow = listObj[0].NewRow();
                            drow["unitName"] = string.Empty;
                            drow["unitId"] = 0;
                            listObj[0].Rows.InsertAt(drow, 0);
                            DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(dgvProductBOM.Rows[e.RowIndex].Cells["dgvcmbUnit"]);
                            cell.DataSource = listObj[0];
                            cell.ValueMember = "unitId";
                            cell.DisplayMember = "unitName";
                            if (listObj[0].Rows[0][4] != null && listObj[0].Rows[0][4] != DBNull.Value)
                            {
                                dgvProductBOM.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(listObj[0].Rows[0][4].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveOrEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:22" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid rowsadded event for call the Serial no generation function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductBOM_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SlNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:23" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// linkbuttonRemove to remove one row from gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkbtnRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvProductBOM.RowCount > 1 && !dgvProductBOM.CurrentRow.IsNewRow)
                {
                    if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (btnSave.Text == "Update")
                        {
                            if (dgvProductBOM.CurrentRow.Cells["dgvtxtBomId"].Value != null && dgvProductBOM.CurrentRow.Cells["dgvtxtBomId"].Value.ToString() != "")
                            {
                                isRemoved = true;
                                strArRemove[InIdex] = (dgvProductBOM.CurrentRow.Cells["dgvtxtBomId"].Value.ToString());
                                InIdex++;
                                dgvProductBOM.Rows.RemoveAt(dgvProductBOM.CurrentRow.Index);
                                SlNo();
                            }
                        }
                        else
                        {
                            dgvProductBOM.Rows.RemoveAt(dgvProductBOM.CurrentRow.Index);
                            SlNo();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:24" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// close button click, to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.CloseConfirmation())
                {
                    this.Close();
                }
                frmProductCreationObj.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:25" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click, call the grid clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductBOM.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:26" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click, to delete the items
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
                MessageBox.Show("PB:27" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To remove the selected product from the list in combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductBOM_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (dgvProductBOM.CurrentCell.ColumnIndex == dgvProductBOM.Columns["dgvcmbRawMaterial"].Index)
                {
                    if (isCallFromProductCreation)
                    {
                        listObj = BllProductCreation.ProductViewAllWithoutOneProduct(decProductIdForEdit);
                    }
                    else
                    {
                        listObj = BllProductCreation.ProductViewAll();
                    }
                    if (listObj[0].Rows.Count > 0)
                    {
                        if (dgvProductBOM.RowCount > 1)
                        {
                            int inGridRowCount = dgvProductBOM.RowCount;
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                if (inI != e.RowIndex)
                                {
                                    int inTableRowcount = listObj[0].Rows.Count;
                                    for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                    {
                                        if (dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value != null && dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value.ToString() != "")
                                        {
                                            if (listObj[0].Rows[inJ]["productId"].ToString() == dgvProductBOM.Rows[inI].Cells["dgvcmbRawMaterial"].Value.ToString())
                                            {
                                                listObj[0].Rows.RemoveAt(inJ);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        DataGridViewComboBoxCell dgvccProductBom = (DataGridViewComboBoxCell)dgvProductBOM[dgvProductBOM.Columns["dgvcmbRawMaterial"].Index, e.RowIndex];
                        dgvccProductBom.DataSource = listObj[0];
                        DataRow drow = listObj[0].NewRow();
                        drow["productName"] = string.Empty;
                        drow["productId"] = 0;
                        listObj[0].Rows.InsertAt(drow, 0);
                        dgvccProductBom.ValueMember = "productId";
                        dgvccProductBom.DisplayMember = "productName";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:28" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// From closing event, to activate the product creation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductBom_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmProductCreationObj.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:29" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to check the grid columns validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductBOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.EnterKeyPress(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:30" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// calling the keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dgvProductBOM_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvtxtqty = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvtxtqty != null)
                {
                    dgvtxtqty.KeyPress += dgvtxtQty_KeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:31" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductBOM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductBom_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                        frmProductCreationObj.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save Ctrl + S
                {
                    //if (dgvProductBOM.Columns["dgvcmbRawMaterial"].Selected)
                    //{
                        btnSave.Focus();
                    //}
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Save Ctrl + D
                {
                    btnDelete_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:32" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductBOM_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductBOM.CurrentCell == dgvProductBOM.Rows[dgvProductBOM.Rows.Count - 1].Cells["dgvtxtUnit"])
                    {
                        btnSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:33" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dgvProductBOM.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
