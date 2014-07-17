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
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace Open_Miracle
{
    class Common
    {
        #region Function
        /// <summary>
        /// Function for Enterkey validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }
        /// <summary>
        /// Function for decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="isNegativeFiled"></param>
        public static void DecimalValidation(object sender, KeyPressEventArgs e, bool isNegativeFiled)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                if (e.KeyChar == 46)
                {
                    if (txt.Text.Contains(".") && txt.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (txt.Text == "" || txt.SelectionStart == 0)
                        {
                            txt.Clear();
                            txt.Text = "0.";
                            txt.SelectionStart = txt.Text.Length;
                        }
                        else
                        {
                            txt.Text = txt.Text + ".";
                            txt.SelectionStart = txt.Text.Length;
                        }
                    }
                }
                else if (e.KeyChar == 45 && (isNegativeFiled))
                {
                    if (txt.Text.Contains("-") && txt.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        txt.Clear();
                        txt.Text = "-";
                        txt.SelectionStart = txt.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TAX: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for numberonly validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127;
        }
        /// <summary>
        /// Function for Email validation
        /// </summary>
        /// <param name="txtEmail"></param>
        /// <returns></returns>
        public static bool EmailValidation(TextBox txtEmail)
        {
            bool isOk = true;
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    txtEmail.Focus();
                    isOk = false;
                }
            }
            return isOk;
        }
        /// <summary>
        /// For shortcut keys
        /// </summary>
        /// <param name="e"></param>
        /// <param name="btn"></param>
        /// <param name="btnclose"></param>
        public static void ExecuteShortCutKey(KeyEventArgs e, Button btn, Button btnclose)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnclose.PerformClick();
            }
            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
            {
                btn.PerformClick();
            }
        }
        #endregion Function
    }
}
