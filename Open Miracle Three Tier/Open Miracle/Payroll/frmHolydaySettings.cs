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
    public partial class frmHolydaySettings : Form
    {
       
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        HolidayInfo infoHoliday = new HolidayInfo();
        HolidaySettingsBll BllHolidaySettings = new HolidaySettingsBll();
      
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmHolydaySettings class
        /// </summary>
        public frmHolydaySettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void CalenderFill()
        {
            try
            {
                dgvCalender.Rows.Clear();
                dgvCalender.Rows.Add(7);
                DataGridViewTextBoxCell c0 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c4 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c5 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c6 = new DataGridViewTextBoxCell();
                dgvCalender[0, 0] = c0;
                dgvCalender[1, 0] = c1;
                dgvCalender[2, 0] = c2;
                dgvCalender[3, 0] = c3;
                dgvCalender[4, 0] = c4;
                dgvCalender[5, 0] = c5;
                dgvCalender[6, 0] = c6;
                dgvCalender[0, 0].Value = "Sun";
                dgvCalender[1, 0].Value = "Mon";
                dgvCalender[2, 0].Value = "Tue";
                dgvCalender[3, 0].Value = "Wed";
                dgvCalender[4, 0].Value = "Thu";
                dgvCalender[5, 0].Value = "Fri";
                dgvCalender[6, 0].Value = "Sat";
                dgvCalender.Rows[0].DefaultCellStyle.BackColor = Color.Green;
                dgvCalender.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                int inNoOfDays = 0;
                string strDay;
                int inColumnNumber = 0, inRowNumber = 1;
                DateTime dtDate = new DateTime(dtpYear.Value.Year, dtpMonth.Value.Month, 1);
                strDay = dtDate.DayOfWeek.ToString();
                switch (strDay)
                {
                    case "Sunday": inColumnNumber = 0;
                        break;
                    case "Monday": inColumnNumber = 1;
                        break;
                    case "Tuesday": inColumnNumber = 2;
                        break;
                    case "Wednesday": inColumnNumber = 3;
                        break;
                    case "Thursday": inColumnNumber = 4;
                        break;
                    case "Friday": inColumnNumber = 5;
                        break;
                    case "Saturday": inColumnNumber = 6;
                        break;
                }
                inNoOfDays = DateTime.DaysInMonth(dtpYear.Value.Year, dtpMonth.Value.Month);
                for (int i = 1; i <= inNoOfDays; i++)
                {
                    if (inColumnNumber > 6)
                    {
                        inColumnNumber = 0;
                        inRowNumber++;
                    }
                    dgvCalender[inColumnNumber, inRowNumber].Value = i;
                    dtDate = new DateTime(dtpYear.Value.Year, dtpMonth.Value.Month, i);
                    int inDay = int.Parse(dtDate.Month.ToString());
                    if (dtDate <= PublicVariables._dtFromDate || dtDate >= PublicVariables._dtToDate)
                    {
                        dgvCalender[inColumnNumber, inRowNumber].Style.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        dgvCalender[inColumnNumber, inRowNumber].Style.BackColor = Color.FromArgb(209, 238, 218);
                    }
                    inColumnNumber++;
                }
                List<DataTable> listHolidaySettings = new List<DataTable>();
                listHolidaySettings = BllHolidaySettings.HoildaySettingsViewAllLimited(dtpMonth.Text.ToString(), dtpYear.Text.ToString());
                if (listHolidaySettings[0].Rows.Count > 0)
                {
                    for (int i = 0; i < listHolidaySettings[0].Rows.Count; i++)
                    {
                        string strHoliday = DateTime.Parse(listHolidaySettings[0].Rows[i]["date"].ToString()).Day.ToString();
                        foreach (DataGridViewRow dgvRow in dgvCalender.Rows)
                        {
                            if (dgvRow.Index != 0)
                            {
                                for (int j = 0; j <= dgvCalender.ColumnCount - 1; j++)
                                {
                                    if (dgvRow.Cells[j].Value != null && dgvRow.Cells[j].Value.ToString() != "")
                                    {
                                        if (dgvRow.Cells[j].Value.ToString() == strHoliday)
                                        {
                                            dgvRow.Cells[j].Style.BackColor = Color.DeepPink;
                                            dgvRow.Cells[j].ToolTipText = listHolidaySettings[0].Rows[i]["narration"].ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                dgvCalender.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                btnSave.Text = "Save";
                dtpYear.MinDate = PublicVariables._dtFromDate;
                dtpYear.MaxDate = PublicVariables._dtToDate;
                dtpMonth.Value = PublicVariables._dtCurrentDate;
                dtpYear.Value = PublicVariables._dtCurrentDate;
                CalenderFill();
                dgvHolidayRegisterFill();
                dgvCalender.ClearSelection();
                dgvHolidayRegister.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview to display the holiday lists
        /// </summary>
        public void dgvHolidayRegisterFill()
        {
            try
            {
                dgvHolidayRegister.Rows.Clear();
                List<DataTable> listHolidayRegister = new List<DataTable>();
                listHolidayRegister = BllHolidaySettings.HoildaySettingsViewAllLimited(dtpMonth.Text.ToString(), dtpYear.Text.ToString());
                if (listHolidayRegister[0].Rows.Count > 0)
                {
                    foreach (DataRow drRow in listHolidayRegister[0].Rows)
                    {
                        dgvHolidayRegister.Rows.Add();
                        dgvHolidayRegister.Rows[dgvHolidayRegister.Rows.Count - 1].Cells[0].Value = drRow["date"].ToString();
                        dgvHolidayRegister.Rows[dgvHolidayRegister.Rows.Count - 1].Cells[1].Value = drRow["narration"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                BllHolidaySettings.HolidaySettingsDeleteByMonth(dtpMonth.Text.ToString(), dtpYear.Text.ToString());
                if (dgvHolidayRegister.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dgvRow in dgvHolidayRegister.Rows)
                    {
                        infoHoliday.Date = DateTime.Parse(dgvRow.Cells[0].Value.ToString());
                        if (dgvRow.Cells["dgvtxtNarration"].Value != null)
                        {
                            string strNarration = dgvRow.Cells["dgvtxtNarration"].Value.ToString();
                            infoHoliday.Narration = strNarration.Trim();
                        }
                        else
                        {
                            infoHoliday.Narration = string.Empty;
                        }
                        infoHoliday.HolidayName = string.Empty;
                        infoHoliday.Extra1 = string.Empty;
                        infoHoliday.Extra2 = string.Empty;
                        BllHolidaySettings.HolidayAddWithIdentity(infoHoliday);
                    }
                }
                Messages.SavedMessage();
                Clear();
                CalenderFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events

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
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("HO6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (PublicVariables.isMessageClose == true)
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
                MessageBox.Show("HO7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHolydaySettings_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                CalenderFill();
                dgvHolidayRegisterFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on dtpMonth datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalenderFill();
                dgvHolidayRegisterFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to highlight the selected date on cell click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCalender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool isFlag = false;
                int inRowIndex = 0;
                if (dgvCalender.CurrentRow != null && dgvCalender.CurrentRow.Index != 0)
                {
                    if (dgvCalender.CurrentCell != null && dgvCalender.CurrentCell.Value != null)
                    {
                        DateTime dtClicked = new DateTime(dtpYear.Value.Year, dtpMonth.Value.Month, int.Parse(dgvCalender.CurrentCell.Value.ToString()));
                        string strClickedDate = dtClicked.ToString("dd-MMM-yyyy");
                        foreach (DataGridViewRow dgvRow in dgvHolidayRegister.Rows)
                        {
                            if (dgvRow.Cells["dgvtxtDate"].Value != null)
                            {
                                if (dgvRow.Cells["dgvtxtDate"].Value.ToString() == strClickedDate)
                                {
                                    isFlag = true;
                                    inRowIndex = dgvRow.Index;
                                    break;
                                }
                            }
                        }
                        if (isFlag)
                        {
                            dgvHolidayRegister.Rows.RemoveAt(inRowIndex);
                            dgvCalender.CurrentCell.Style.BackColor = Color.FromArgb(209, 238, 218);
                        }
                        else
                        {
                            dgvCalender.CurrentCell.Style.BackColor = Color.DeepPink;
                            dgvHolidayRegister.Rows.Add();
                            dgvHolidayRegister.Rows[dgvHolidayRegister.Rows.Count - 1].Cells[0].Value = strClickedDate;
                            dgvHolidayRegister.Rows[0].Selected = false;
                            dgvHolidayRegister.CurrentCell = dgvHolidayRegister.Rows[dgvHolidayRegister.Rows.Count - 1].Cells[1];
                            dgvCalender.CurrentCell.Selected = true;
                            dgvHolidayRegister.CurrentCell.Selected = true;
                        }
                    }
                }
                dgvCalender.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCalender_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvCalender.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHolidayRegister_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvHolidayRegister.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Shows tool tip on mouse enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCalender_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvCalender.ShowCellToolTips = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Hides tool tip on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCalender_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dgvCalender.ShowCellToolTips = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Backspace key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dtpYear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and back space navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    dtpMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpYear.Select();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("HO17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        /// <summary>
        /// Quick access on form keydown and escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHolydaySettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }

                //-----------------------CTRL+S Save-----------------------------//
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave_Click(sender, e);
                }
               
            }
            catch (Exception ex)
            {
               MessageBox.Show("HO18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }

}
