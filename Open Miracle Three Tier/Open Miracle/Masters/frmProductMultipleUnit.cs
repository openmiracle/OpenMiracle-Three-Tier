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
  
    public partial class frmProductMultipleUnit : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmProductCreation frmProductCreationObj;
        decimal decUnitIdToSend;
        decimal decProductIdForEdit;
        decimal decUnitIdExcludeToFillCombo;
        bool isUnitCheck;
        bool isGridOk = false;
        string strUnitName;
        string strUnitNameForUpdate;
        decimal decRowcount;
        bool isSaveUse = false;
        bool isCheckVariable = false;
        bool isValueChanged = false;
        bool isRemoved = false;
        string[] strArRemove = new string[100];
        int InIdex = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Create an Instance of a frmProductMultipleUnit class
        /// </summary>
        public frmProductMultipleUnit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to generate serialNo
        /// </summary>
        public void SlNo()
        {
            try
            {
                int inRowNo = 1;
                foreach (DataGridViewRow dr in dgvMultipleUnit.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowNo;
                    dr.Cells["dgvtxtequal"].Value = "=";
                    inRowNo++;
                    if (dr.Index == dgvMultipleUnit.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the unit combobox
        /// </summary>
        /// <param name="decId"></param>
        public void UnitComboFill(decimal decId)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                ListObj = bllUnit.UnitViewAllWithoutPerticularId(decId);
                dgvcmbmultipleunit.DataSource = ListObj[0];
                DataRow drow = ListObj[0].NewRow();
                drow["unitName"] = string.Empty;
                drow["unitId"] = 0;
                ListObj[0].Rows.InsertAt(drow, 0);
                dgvcmbmultipleunit.DisplayMember = "unitName";
                dgvcmbmultipleunit.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the grid
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                dgvMultipleUnit.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check invalid entries
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleUnit.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (!dgvMultipleUnit.CurrentRow.IsNewRow && (dgvMultipleUnit.CurrentRow.Cells["dgvtxtqtymultipleunit"].Value == null || dgvMultipleUnit.CurrentRow.Cells["dgvtxtqtymultipleunit"].Value.ToString().Trim() == ""))
                        {
                            isValueChanged = true;
                            dgvMultipleUnit.CurrentRow.HeaderCell.Value = "X";
                            dgvMultipleUnit.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            dgvMultipleUnit.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvMultipleUnit["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (!dgvMultipleUnit.CurrentRow.IsNewRow && (dgvMultipleUnit.CurrentRow.Cells["dgvcmbmultipleunit"].Value == null || dgvMultipleUnit.CurrentRow.Cells["dgvcmbmultipleunit"].Value.ToString().Trim() == ""))
                        {
                            isValueChanged = true;
                            dgvMultipleUnit.CurrentRow.HeaderCell.Value = "X";
                            dgvMultipleUnit.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            dgvMultipleUnit.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvMultipleUnit["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (!dgvMultipleUnit.CurrentRow.IsNewRow && (dgvMultipleUnit.CurrentRow.Cells["dgvtxtqty"].Value == null || dgvMultipleUnit.CurrentRow.Cells["dgvtxtqty"].Value.ToString().Trim() == ""))
                        {
                            isValueChanged = true;
                            dgvMultipleUnit.CurrentRow.HeaderCell.Value = "X";
                            dgvMultipleUnit.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            dgvMultipleUnit.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvMultipleUnit["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvMultipleUnit.CurrentRow.HeaderCell.Value = "";
                            dgvMultipleUnit.CurrentRow.Cells["dgvtxtCheck"].Value = "";
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to do when calling from productcreation form
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        /// <param name="decUnitId"></param>
        /// <param name="strUnit"></param>
        public void CallFromProdutCreation(frmProductCreation frmProduct, string strProductName, decimal decUnitId, string strUnit)
        {
            try
            {
                decUnitIdExcludeToFillCombo = decUnitId;
                decUnitIdToSend = decUnitId;
                UnitComboFill(decUnitId);
                frmProductCreationObj = frmProduct;
                txtProductName.Text = strProductName;
                strUnitName = strUnit;
                isCheckVariable = true;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to do when calling from productcreation form
        /// </summary>
        /// <param name="frmProduct"></param>
        /// <param name="strProductName"></param>
        /// <param name="decUnitId"></param>
        /// <param name="strUnit"></param>
        /// <param name="dtblUnitConvertion"></param>
        public void CallFromProdutCreationAgain(frmProductCreation frmProduct, string strProductName, decimal decUnitId, string strUnit, DataTable dtblUnitConvertion)
        {
            try
            {
                decUnitIdExcludeToFillCombo = decUnitId;
                UnitComboFill(decUnitId);
                frmProductCreationObj = frmProduct;
                txtProductName.Text = strProductName;
                strUnitName = strUnit;
                base.Show();
                for (int inI = 0; inI < dtblUnitConvertion.Rows.Count; inI++)
                {
                    if (dtblUnitConvertion.Rows[inI]["dgvtxtUnitId"].ToString() != "1")
                    {
                        dgvMultipleUnit.Rows.Add();
                        string strQuantity = Convert.ToString(dtblUnitConvertion.Rows[inI]["quantities"]);
                        string[] srtarQuantity = strQuantity.Split('-');
                        string strQuantityOne = srtarQuantity[0];
                        string strQuantityTwo = srtarQuantity[1];
                        dgvMultipleUnit.Rows[inI].Cells["dgvtxtqtymultipleunit"].Value = strQuantityOne;
                        dgvMultipleUnit.Rows[inI].Cells["dgvtxtqty"].Value = strQuantityTwo;
                        dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value = dtblUnitConvertion.Rows[inI]["dgvtxtUnitId"];
                        dgvMultipleUnit.Rows[inI].Cells["dgvtxtunit"].Value = strUnit.ToString();
                        dgvMultipleUnit.Rows[inI].Cells["dgvtxtunitname"].Value = dtblUnitConvertion.Rows[inI]["unitName"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
       /// <summary>
       /// Call from productcreation 
       /// </summary>
       /// <param name="frmProduct"></param>
       /// <param name="strProductName"></param>
       /// <param name="ProductId"></param>
       /// <param name="dtblMulUnit"></param>
       /// <param name="strUnit"></param>
       /// <param name="decUnitIdForCombo"></param>
        public void CallFromProdutCreationForUpadte(frmProductCreation frmProduct, string strProductName, decimal ProductId, DataTable dtblMulUnit, string strUnit, decimal decUnitIdForCombo)
        {
            try
            {
                base.Show();
                decUnitIdExcludeToFillCombo = decUnitIdForCombo;
                frmProductCreationObj = frmProduct;
                txtProductName.Text = strProductName;
                decProductIdForEdit = ProductId;
                strUnitNameForUpdate = strUnit;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isCheckVariable = true;
                GridFillForUpdate(dtblMulUnit);
                UnitComboFill(decUnitIdForCombo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid fill for updating unit
        /// </summary>
        /// <param name="dtbMulUnitForEdit"></param>
        public void GridFillForUpdate(DataTable dtbMulUnitForEdit)
        {
            try
            {
                for (int inI = 0; inI < dtbMulUnitForEdit.Rows.Count; inI++)
                {
                    dgvMultipleUnit.Rows.Add();
                    string strQuantity = Convert.ToString(dtbMulUnitForEdit.Rows[inI]["quantities"]);
                    string[] srtarQuantity = strQuantity.Split('-');
                    string strQuantityOne = srtarQuantity[0];
                    string strQuantityTwo = srtarQuantity[1];
                    dgvMultipleUnit.Rows[inI].Cells["dgvtxtqtymultipleunit"].Value = strQuantityOne;
                    dgvMultipleUnit.Rows[inI].Cells["dgvtxtqty"].Value = strQuantityTwo;
                    dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value = dtbMulUnitForEdit.Rows[inI]["unitId"];
                    dgvMultipleUnit.Rows[inI].Cells["dgvtxtunit"].Value = strUnitNameForUpdate.ToString();
                    dgvMultipleUnit.Rows[inI].Cells["dgvtxtUnitconvertionId"].Value = dtbMulUnitForEdit.Rows[inI]["unitconversionId"];
                    dgvMultipleUnit.Rows[inI].Cells["dgvtxtunitname"].Value = dtbMulUnitForEdit.Rows[inI]["unitName"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill first row in grid
        /// </summary>
        public void FillFirstRow()
        {
            try
            {
                if (btnSave.Text != "Update")
                {
                    dgvMultipleUnit.Rows[0].Cells["dgvtxtunit"].Value = strUnitName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete multiple unit
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
                MessageBox.Show("PMU:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save or edit function 
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
                MessageBox.Show("PMU:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// To Save multiple unit
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
                            GridCheck();
                        }
                    }
                    else
                    {
                        GridCheck();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To edit multiple unit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                
                if (RemoveIncompleteRowsFromGrid())
                {
                    SendUpdatedDataTable();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete multiple unit
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                
                
                Messages.DeletedMessage();
                if (frmProductCreationObj != null)
                {
                    bool isDeleted = true;
                    frmProductCreationObj.ReciveDeleteConfirmationFromMulUnit(isDeleted);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To remove incomplete rows from grid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvMultipleUnit.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvMultipleUnit.Rows)
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
                        for (int inK = 0; inK < dgvMultipleUnit.Rows.Count; inK++)
                        {
                            if (!dgvMultipleUnit.Rows[inK].IsNewRow)
                            {
                                if (dgvMultipleUnit.Rows[inK].HeaderCell.Value != null && dgvMultipleUnit.Rows[inK].HeaderCell.Value.ToString() == "X")// && dgvProductBOM.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "x")
                                {
                                    if (!dgvMultipleUnit.Rows[inK].IsNewRow)
                                    {
                                        if (dgvMultipleUnit.Rows[inK].Cells["dgvtxtUnitconvertionId"].Value != null && Convert.ToDecimal(dgvMultipleUnit.Rows[inK].Cells["dgvtxtUnitconvertionId"].Value) != 0)
                                        {
                                            isRemoved = true;
                                            strArRemove[InIdex] = Convert.ToString(dgvMultipleUnit.Rows[inK].Cells["dgvtxtUnitconvertionId"].Value);
                                            InIdex++;
                                        }
                                        dgvMultipleUnit.Rows.RemoveAt(inK);
                                        inK--;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                       
                        dgvMultipleUnit.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// To send updated table to productcreation
        /// </summary>
        public void SendUpdatedDataTable()
        {
            try
            {
                DataTable dtblsend = new DataTable();
                DataColumn dc = new DataColumn("CnvertionRate", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtUnitId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("quantities", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("unitconvertionId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra1", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra2", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extraDate", typeof(DateTime));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("unitName", typeof(string));
                dtblsend.Columns.Add(dc);
                for (int inI = 0; inI < dgvMultipleUnit.RowCount - 1; inI++)
                {
                    DataRow dr = dtblsend.NewRow();
                    decimal decRate = Convert.ToDecimal(dgvMultipleUnit.Rows[inI].Cells["dgvtxtqtymultipleunit"].Value.ToString());
                    decimal decRateSecond = Convert.ToDecimal(dgvMultipleUnit.Rows[inI].Cells["dgvtxtqty"].Value.ToString());
                    decimal decTot = decRate / decRateSecond;
                    decRowcount = inI;
                    dr[0] = decTot;
                    dr[1] = dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value;
                    dr[2] = decRate + "-" + decRateSecond;
                    if (Convert.ToDecimal(dgvMultipleUnit.Rows[inI].Cells["dgvtxtUnitconvertionId"].Value) == 0)
                    {
                        dr[3] = 0;
                    }
                    else
                    {
                        dr[3] = dgvMultipleUnit.Rows[inI].Cells["dgvtxtUnitconvertionId"].Value.ToString();
                    }
                    dr[4] = string.Empty;
                    dr[5] = string.Empty;
                    dr[6] = DateTime.Now;
                    dr[7] = dgvMultipleUnit.Rows[inI].Cells["dgvtxtunitname"].Value;
                    int inPosition = inI;
                    dtblsend.Rows.InsertAt(dr, inPosition);
                }
                bool isOk = true;
                if (dtblsend.Rows.Count > 0)
                {
                    if (isRemoved)
                    {
                        frmProductCreationObj.RomovedIndexFromMulUnit(strArRemove);
                    }
                    frmProductCreationObj.DataTableForMulUnitUpdate(dtblsend, isOk);
                    Messages.UpdatedMessage();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant save atleast one row", "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMultipleUnit.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for checking grid
        /// </summary>
        public void GridCheck()
        {
            try
            {
                DataTable dtblsend = new DataTable();
                DataColumn dc = new DataColumn("CnvertionRate", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("dgvtxtUnitId", typeof(decimal));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("quantities", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra1", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extra2", typeof(string));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("extraDate", typeof(DateTime));
                dtblsend.Columns.Add(dc);
                dc = new DataColumn("unitName", typeof(string));//New Coloumn For Grid in ProductCreation
                dtblsend.Columns.Add(dc);
                for (int inI = 0; inI < dgvMultipleUnit.RowCount - 1; inI++)
                {
                    DataRow dr = dtblsend.NewRow();
                    decimal decRate = Convert.ToDecimal(dgvMultipleUnit.Rows[inI].Cells["dgvtxtqtymultipleunit"].Value.ToString());
                    decimal decRateSecond = Convert.ToDecimal(dgvMultipleUnit.Rows[inI].Cells["dgvtxtqty"].Value.ToString());
                    decimal decTot = decRate / decRateSecond;
                    decRowcount = inI;
                    dr[0] = decTot;
                    dr[1] = dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value;
                    dr[2] = decRate + "-" + decRateSecond;
                    dr[3] = string.Empty;
                    dr[4] = string.Empty;
                    dr[5] = DateTime.Now;
                    dr[6] = dgvMultipleUnit.Rows[inI].Cells["dgvtxtunitname"].Value;
                    int inPosition = inI;
                    dtblsend.Rows.InsertAt(dr, inPosition);
                }
                isSaveUse = true;
                if (dtblsend.Rows.Count > 0)
                {
                    frmProductCreationObj.DataTableReturnFromMultipleUnit(dtblsend, isSaveUse, decUnitIdToSend);
                    Messages.SavedMessage();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant save atleast one row", "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMultipleUnit.Select();
                    dgvMultipleUnit.CurrentCell = dgvMultipleUnit.Rows[0].Cells["dgvtxtSlNo"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
       /// <summary>
       /// On adding default unit on rows added
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dgvMultipleUnit_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    dgvMultipleUnit.Rows[e.RowIndex].Cells["dgvtxtunit"].Value = strUnitName;
                }
                SlNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductMultipleUnit_Load(object sender, EventArgs e)
        {
            try
            {
                FillFirstRow();
                btnDelete.Enabled = false;
                dgvMultipleUnit.Select();
                dgvMultipleUnit.CurrentCell = dgvMultipleUnit.Rows[0].Cells["dgvtxtSlNo"];
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SaveOrEdit();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cell value change of dgvMultipleUnit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CheckInvalidEntries(e);
                if (btnSave.Text == "Update")
                {
                    dgvMultipleUnit.Rows[e.RowIndex].Cells["dgvtxtunit"].Value = strUnitNameForUpdate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Messages.CloseMessage(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:22" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Delete();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:23" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvMultipleUnit.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:24" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove link button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvMultipleUnit.CurrentRow.Index != -1 && dgvMultipleUnit.CurrentCell.ColumnIndex != 0)
                {
                    if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dgvMultipleUnit.RowCount > 1 && !dgvMultipleUnit.CurrentRow.IsNewRow)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvMultipleUnit.CurrentRow.Cells["dgvtxtUnitconvertionId"].Value != null && dgvMultipleUnit.CurrentRow.Cells["dgvtxtUnitconvertionId"].Value.ToString() != "")
                                {
                                    isRemoved = true;
                                    strArRemove[InIdex] = (dgvMultipleUnit.CurrentRow.Cells["dgvtxtUnitconvertionId"].Value.ToString());
                                    InIdex++;
                                    dgvMultipleUnit.Rows.RemoveAt(dgvMultipleUnit.CurrentRow.Index);
                                    SlNo();
                                }
                            }
                            else
                            {
                                dgvMultipleUnit.Rows.RemoveAt(dgvMultipleUnit.CurrentRow.Index);
                                SlNo();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:25" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut keys
        /// Esc for save 
        /// ctrl+s for save 
        /// ctrl+d for delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductMultipleUnit_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) 
                {
                    btnSave.PerformClick();
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
                MessageBox.Show("PMU:26" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Validation for dgvQty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvQty = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvQty != null)
                {
                    dgvQty.KeyPress += dgvtxtqty_KeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:27" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// decimalvalidation for dgvtxtqty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvMultipleUnit.CurrentCell != null)
                {
                    if (dgvMultipleUnit.Columns[dgvMultipleUnit.CurrentCell.ColumnIndex].Name == "dgvtxtqtymultipleunit" || dgvMultipleUnit.Columns[dgvMultipleUnit.CurrentCell.ColumnIndex].Name == "dgvtxtqty")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:28" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cell begin edit of dgvMultipleUnit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                if (dgvMultipleUnit.CurrentCell.ColumnIndex == dgvMultipleUnit.Columns["dgvcmbmultipleunit"].Index)
                {
                    ListObj = bllUnit.UnitViewAllWithoutPerticularId(decUnitIdExcludeToFillCombo);
                    if (ListObj[0].Rows.Count > 0)
                    {
                        if (dgvMultipleUnit.RowCount > 1)
                        {
                            int inGridRowCount = dgvMultipleUnit.RowCount;
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                if (inI != e.RowIndex)
                                {
                                    int inTableRowcount = ListObj[0].Rows.Count;
                                    for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                    {
                                        if (dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value != null && dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value.ToString() != "")
                                        {
                                            if (ListObj[0].Rows[inJ]["unitId"].ToString() == dgvMultipleUnit.Rows[inI].Cells["dgvcmbmultipleunit"].Value.ToString())
                                            {
                                                ListObj[0].Rows.RemoveAt(inJ);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        DataGridViewComboBoxCell dgvccProductMultipleUnit = (DataGridViewComboBoxCell)dgvMultipleUnit[dgvMultipleUnit.Columns["dgvcmbmultipleunit"].Index, e.RowIndex];
                        DataRow drow = ListObj[0].NewRow();
                        drow["unitName"] = string.Empty;
                        drow["unitId"] = 0;
                        ListObj[0].Rows.InsertAt(drow, 0);
                        dgvccProductMultipleUnit.DataSource = ListObj[0];
                        dgvccProductMultipleUnit.ValueMember = "unitId";
                        dgvccProductMultipleUnit.DisplayMember = "unitName";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:29" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cell end edit of dgvMultipleUnit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleUnit.Columns[e.ColumnIndex].Name == "dgvcmbmultipleunit")
                {
                    UnitBll bllUnit = new UnitBll();
                    dgvMultipleUnit.Rows[e.RowIndex].Cells["dgvtxtunitname"].Value = bllUnit.UnitName(Convert.ToDecimal(dgvMultipleUnit.Rows[e.RowIndex].Cells["dgvcmbmultipleunit"].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:30" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// handling data error event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:31" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enterkey and backspace navigation of dgvMultipleUnit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvMultipleUnit.CurrentCell == dgvMultipleUnit.Rows[dgvMultipleUnit.Rows.Count - 1].Cells["dgvtxtqty"])
                    {
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvMultipleUnit.CurrentCell == dgvMultipleUnit.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        dgvMultipleUnit.Focus();
                        dgvMultipleUnit.CurrentCell = dgvMultipleUnit.Rows[0].Cells["dgvtxtSlNo"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:32" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dgvMultipleUnit.Focus();
                    dgvMultipleUnit.CurrentCell = dgvMultipleUnit.Rows[0].Cells["dgvtxtunit"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMU:33" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
