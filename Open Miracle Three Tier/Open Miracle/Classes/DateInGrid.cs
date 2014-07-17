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
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Open_Miracle
{
    /// <summary>
    /// Function for date validation in grid
    /// </summary>
    class DateInGrid
    {
        public static bool isValue = false;
        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn()
                : base(new CalendarCell())
            {
            }
            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }
        /// <summary>
        /// Function for calendercell in grid
        /// </summary>
        public class CalendarCell : DataGridViewTextBoxCell
        {
            public CalendarCell()
                : base()
            {
                this.Style.Format = "dd-MMM-yyyy";
            }
            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                DateTime d;
                ctl.Value = DateTime.TryParse((Value ?? "").ToString(), out d) ? d : DateTime.Now;
                if (this.Value != null)
                {
                    if (this.Value.ToString() != "")
                    {
                        DateInGrid.isValue = true;
                        ctl.Checked = true;
                    }
                    else
                    {
                        DateInGrid.isValue = false;
                        ctl.Checked = false;
                    }
                }
            }
            public override Type EditType
            {
                get
                {
                    // Return the type of the editing contol that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }
            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.
                    return typeof(DateTime);
                }
            }
            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return "";
                }
            }
        }
        /// <summary>
        /// Class for calender edit in grid
        /// </summary>
        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;
            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }
            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    if (value is String)
                    {
                        this.Value = DateTime.Parse((String)value);
                    }
                }
            }
            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                if (this.Checked == true)
                {
                    return EditingControlFormattedValue;
                }
                else
                {
                    return "";
                }
            }
            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
                this.Format = DateTimePickerFormat.Custom;
                this.CustomFormat = "dd-MMM-yyyy";
                this.ShowUpDown = true;
                if (DateInGrid.isValue == false)
                {
                    this.Checked = false;
                }
            }
            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }
            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.NumPad0:
                    case Keys.NumPad1:
                    case Keys.NumPad2:
                    case Keys.NumPad3:
                    case Keys.NumPad4:
                    case Keys.NumPad5:
                    case Keys.NumPad6:
                    case Keys.NumPad7:
                    case Keys.NumPad8:
                    case Keys.NumPad9:
                    case Keys.Enter:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }
            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }
            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }
            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }
            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }
            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }
            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }
    }
}
