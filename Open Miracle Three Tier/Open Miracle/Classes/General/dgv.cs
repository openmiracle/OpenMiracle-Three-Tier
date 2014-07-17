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
using System.Globalization;
using System.Data;
namespace Open_Miracle
{
    class dgv
    {
        public class DataGridViewEnter : DataGridView
        {
            /// <summary>
            /// This override causes the DataGridView to use the enter key in a similar way as the tab key
            /// </summary>
            /// <param name="keyData"></param>
            /// <returns></returns>
            protected override bool ProcessDialogKey(Keys keyData)
            {
                Keys key = (keyData & Keys.KeyCode);
                if (key == Keys.Enter)
                {
                    return this.ProcessRightKey(keyData);
                }
                else if (key == Keys.Back && base.CurrentCell != null)
                {
                    if (base.CurrentCell.OwningColumn.CellType.ToString() == "System.Windows.Forms.DataGridViewTextBoxCell" && base.CurrentCell.ReadOnly == false)
                    {
                        if (base.CurrentCell.Value == null || base.CurrentCell.Value.ToString() == "")
                        {
                            base.EndEdit();
                            return this.ProcessLeftKey(keyData);
                        }
                        else
                        {
                            base.BeginEdit(true);
                            DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)base.EditingControl;
                            if ((editControl != null) && (editControl.Text.Length == 0 || editControl.SelectionStart == 0))
                            {
                                base.EndEdit();
                                return this.ProcessLeftKey(keyData);
                            }
                            else
                            {
                                string str = base.CurrentCell.Value.ToString();
                                if (editControl == null)
                                    return this.ProcessLeftKey(keyData);
                                else if (str.Length > 0)
                                {
                                }
                                else
                                {
                                    base.EndEdit();
                                    return this.ProcessLeftKey(keyData);
                                }
                            }
                        }
                    }
                    else
                    {
                        base.EndEdit();
                        return this.ProcessLeftKey(keyData);
                    }
                }
                return base.ProcessDialogKey(keyData);
            }
            /// <summary>
            /// This causes the DataGridView to make the Enter key move the focus to the right
            /// </summary>
            /// <param name="keyData"></param>
            /// <returns></returns>
            public new bool ProcessRightKey(Keys keyData)
            {
                try
                {
                    Keys key = (keyData & Keys.KeyCode);
                    if (key == Keys.Enter)
                    {
                        if (base.CurrentCell != null)
                        {
                            int index = base.CurrentCell.ColumnIndex;
                            if (base.Columns[base.Columns.Count - 1].Visible == false && index == base.Columns[base.Columns.Count - 1].Index - 1)
                            {
                                index++;
                            }
                            else if (index == base.Columns.Count - 3 && !(base.Columns[base.Columns.Count - 2].Visible) && (!base.Columns[base.Columns.Count - 1].Visible))
                            {
                                index += 2;
                            }
                            else if (index == base.Columns.Count - 4 && !(base.Columns[base.Columns.Count - 3].Visible) && !(base.Columns[base.Columns.Count - 2].Visible) && (!base.Columns[base.Columns.Count - 1].Visible))
                            {
                                index += 3;
                            }
                            if (index == (base.ColumnCount - 1) && (base.CurrentCell.RowIndex == (base.RowCount - 1)))
                            {
                                //This causes the last cell to be checked for errors
                                base.EndEdit();
                                if (base.DataSource != null)
                                {
                                    ((BindingSource)base.DataSource).AddNew();
                                    base.CurrentCell = base.Rows[base.RowCount - 1].Cells[0];
                                }
                                else
                                {
                                }
                                return true;
                            }
                            if (index == base.Columns.Count - 1)
                            {
                                int inCurrRow = base.CurrentCell.RowIndex + 1;
                                while (!base.Rows[inCurrRow].Visible)
                                {
                                    if (inCurrRow < base.RowCount - 1)
                                    {
                                        inCurrRow++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (inCurrRow < base.RowCount)
                                {
                                    int inCurr = 0;
                                    while (!base.Rows[inCurrRow].Cells[inCurr].Visible || base.Columns[inCurr].Frozen)
                                    {
                                        inCurr++;
                                    }
                                    base.CurrentCell = base.Rows[inCurrRow].Cells[inCurr];
                                    return true;
                                }
                            }
                            return base.ProcessRightKey(keyData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return base.ProcessRightKey(keyData);
                {
                    try
                    {
                        Keys key = (keyData & Keys.KeyCode);
                        if (key == Keys.Enter)
                        {
                            if ((base.CurrentCell.ColumnIndex == (base.ColumnCount - 1)) && (base.CurrentCell.RowIndex == (base.RowCount - 1)))
                            {
                                //This causes the last cell to be checked for errors
                                base.EndEdit();
                                ((BindingSource)base.DataSource).AddNew();
                                base.CurrentCell = base.Rows[base.RowCount - 1].Cells[0];
                                return true;
                            }
                            if (base.CurrentCell.ColumnIndex == base.Columns.Count - 2)
                            {
                                if (base.CurrentCell.RowIndex + 1 < base.RowCount)
                                {
                                    if (base.Rows[base.CurrentCell.RowIndex + 1].Cells[0].Visible)
                                    {
                                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[0];
                                        return true;
                                    }
                                    else if (base.Rows[base.CurrentCell.RowIndex + 1].Cells[1].Visible)
                                    {
                                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[1];
                                        return true;
                                    }
                                    else if (base.Rows[base.CurrentCell.RowIndex + 1].Cells[2].Visible)
                                    {
                                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[2];
                                        return true;
                                    }
                                    else if (base.Rows[base.CurrentCell.RowIndex + 1].Cells[3].Visible)
                                    {
                                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[3];
                                        return true;
                                    }
                                    else if (base.Rows[base.CurrentCell.RowIndex + 1].Cells[4].Visible)
                                    {
                                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[4];
                                        return true;
                                    }
                                }
                            }
                            return base.ProcessRightKey(keyData);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            /// <summary>
            /// This causes the DataGridView to make the Enter key move the focus to the left
            /// </summary>
            /// <param name="keyData"></param>
            /// <returns></returns>
            public new bool ProcessLeftKey(Keys keyData)
            {
                // For back space navigation
                try
                {
                    Keys key = (keyData & Keys.KeyCode);
                    if (key == Keys.Back)
                    {
                        if (base.CurrentCell.ColumnIndex == 0 || (base.CurrentCell.ColumnIndex == 1 && base.Columns[0].Visible && base.Columns[0].Frozen) || (base.CurrentCell.ColumnIndex == 2 && !base.Columns[0].Visible && !base.Columns[1].Visible) || (base.CurrentCell.ColumnIndex == 2 && !base.Columns[1].Visible && base.Columns[0].Frozen) || (base.CurrentCell.ColumnIndex == 3 && !base.Columns[0].Visible && !base.Columns[1].Visible && base.Columns[2].Frozen) || (base.CurrentCell.ColumnIndex == 2 && !base.Columns[0].Visible && base.Columns[1].Frozen))
                        {
                            if (base.CurrentCell.RowIndex > 0)
                            {
                                int inCurrRow = base.CurrentCell.RowIndex - 1;
                                while (!base.Rows[inCurrRow].Visible)
                                {
                                    if (inCurrRow >= 1)
                                    {
                                        inCurrRow--;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (inCurrRow >= 0 && base.Rows[inCurrRow].Visible)
                                {
                                    if (base.Rows[inCurrRow].Cells[base.ColumnCount - 1].Visible)
                                    {
                                        base.CurrentCell = base.Rows[inCurrRow].Cells[base.ColumnCount - 1];
                                        return true;
                                    }
                                    else if (base.Rows[inCurrRow].Cells[base.ColumnCount - 2].Visible)
                                    {
                                        base.CurrentCell = base.Rows[inCurrRow].Cells[base.ColumnCount - 2];
                                        return true;
                                    }
                                    else if (base.Rows[inCurrRow].Cells[base.ColumnCount - 3].Visible)
                                    {
                                        base.CurrentCell = base.Rows[inCurrRow].Cells[base.ColumnCount - 3];
                                        return true;
                                    }
                                    else if (base.Rows[inCurrRow].Cells[base.ColumnCount - 4].Visible)
                                    {
                                        base.CurrentCell = base.Rows[inCurrRow].Cells[base.ColumnCount - 4];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("invisible");
                                    }
                                }
                                else
                                {
                                    if (base.TabIndex != 0)
                                    {
                                        SendKeys.Send("+{Tab}");
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                            }
                            else
                            {
                                if (base.TabIndex != 0)
                                {
                                    SendKeys.Send("+{Tab}");
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            if (base.CurrentCell.ColumnIndex != 0)
                            {
                                int inInvisibleAndFrozen = 0;
                                for (int inI = 0; inI < base.CurrentCell.ColumnIndex; inI++)
                                {
                                    if (!base.Columns[inInvisibleAndFrozen].Visible || base.Columns[inInvisibleAndFrozen].Frozen)
                                    {
                                        inInvisibleAndFrozen++;
                                    }
                                }
                                if (base.CurrentCell.ColumnIndex - inInvisibleAndFrozen == 0)
                                {
                                    if (base.CurrentCell.RowIndex > 0)
                                    {
                                        if (base.Rows[base.CurrentCell.RowIndex - 1].Cells[base.ColumnCount - 1].Visible)
                                        {
                                            base.CurrentCell = base.Rows[base.CurrentCell.RowIndex - 1].Cells[base.ColumnCount - 1];
                                            return true;
                                        }
                                        else if (base.Rows[base.CurrentCell.RowIndex - 1].Cells[base.ColumnCount - 2].Visible)
                                        {
                                            base.CurrentCell = base.Rows[base.CurrentCell.RowIndex - 1].Cells[base.ColumnCount - 2];
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("invisible");
                                        }
                                    }
                                    else
                                    {
                                        if (base.TabIndex != 0)
                                        {
                                            SendKeys.Send("+{Tab}");
                                        }
                                        else
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                        return base.ProcessLeftKey(keyData);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return base.ProcessLeftKey(keyData);
            }
            /// <summary>
            /// This overrides the ProcessDataGridViewKey methods
            /// </summary>
            /// <param name="e"></param>
            /// <returns></returns>
            protected override bool ProcessDataGridViewKey(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    return this.ProcessRightKey(e.KeyData);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    return this.ProcessLeftKey(e.KeyData);
                }
                return base.ProcessDataGridViewKey(e);
            }
        }
    }
}
