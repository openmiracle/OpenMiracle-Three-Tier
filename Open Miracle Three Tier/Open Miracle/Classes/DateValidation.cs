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
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using Openmiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    class DateValidation
    {
        string format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        FinancialYearInfo InfoFinace = new FinancialYearInfo();
        DateTime CurrDate;
        TextBox text;
        /// <summary>
        /// Function for date validation
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool DateValidationFunction(TextBox txt)
        {
            bool isValid = true;
            string option = string.Empty;
            string[] date = new string[50];
            this.text = txt;
            try
            {
                foreach (char ch in txt.Text)
                {
                    if (ch == '.')
                    {
                        option = ".";
                    }
                    else if (ch == ',')
                    {
                        option = ",";
                    }
                    else if (ch == '-')
                    {
                        option = "-";
                    }
                    else if (ch == '+')
                    {
                        option = "+";
                    }
                    else if (ch == '*')
                    {
                        option = "*";
                    }
                    else if (ch == '/')
                    {
                        option = "/";
                    }
                    else if (ch == ' ')
                    {
                        option = " ";
                    }
                }
                if (option == "")
                {
                    string s = txt.Text + "/";
                    date = s.Split('/');
                }
                if (option == ".")
                {
                    date = txt.Text.Split('.');
                }
                else if (option == ",")
                {
                    date = txt.Text.Split(',');
                }
                else if (option == "-")
                {
                    date = txt.Text.Split('-');
                }
                else if (option == "+")
                {
                    date = txt.Text.Split('+');
                }
                else if (option == "*")
                {
                    date = txt.Text.Split('*');
                }
                else if (option == "/")
                {
                    date = txt.Text.Split('/');
                }
                else if (option == " ")
                {
                    date = txt.Text.Split(' ');
                }
                if (date.Length == 1)
                {
                    string formatoption = SystemFormat();
                    if (formatoption == "M")
                    {
                        CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                    }
                    else if (formatoption == "d")
                    {
                        CurrDate = DateTime.Parse(date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + PublicVariables._dtCurrentDate.Date.Year);
                    }
                    else if (formatoption == "y")
                    {
                        CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString());
                    }
                    isValid = isToday(isValid);
                }
                else if (date.Length == 2)
                {
                    if (date[1].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString());
                        }
                        isValid = isToday(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        } isValid = isToday(isValid);
                    }
                }
                else if (date.Length == 3)
                {
                    if (date[2].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isValid = isToday(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(date[2].ToString() + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isValid = isToday(isValid);
                    }
                }
                else
                {
                    isValid = false;
                    txt.Text = "";
                }
            }
            catch (Exception)
            {
                isValid = false;
                txt.Text = "";
            }
            return isValid;
        }
        /// <summary>
        /// Public to check current date format
        /// </summary>
        /// <param name="isValid"></param>
        /// <returns></returns>
        public bool isToday(bool isValid)
        {
            if (CurrDate >= PublicVariables._dtFromDate.Date && CurrDate <= PublicVariables._dtToDate.Date)
            {
                if (CurrDate == PublicVariables._dtCurrentDate.Date)
                {
                    text.ForeColor = Color.IndianRed;
                    text.Text = CurrDate.ToString("dd-MMM-yyyy");
                }
                else
                {
                    text.ForeColor = Color.Black;
                    text.Text = CurrDate.ToString("dd-MMM-yyyy");
                }
            }
            else
            {
                isValid = false;
                text.Text = "";
            }
            return isValid;
        }
        /// <summary>
        /// Date validation for manufacturing and expiry date
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool DateValidationFunctionMFDEXPD(TextBox txt)
        {
            bool isValid = true;
            string option = string.Empty;
            string[] date = new string[50];
            this.text = txt;
            try
            {
                foreach (char ch in txt.Text)
                {
                    if (ch == '.')
                    {
                        option = ".";
                    }
                    else if (ch == ',')
                    {
                        option = ",";
                    }
                    else if (ch == '-')
                    {
                        option = "-";
                    }
                    else if (ch == '+')
                    {
                        option = "+";
                    }
                    else if (ch == '*')
                    {
                        option = "*";
                    }
                    else if (ch == '/')
                    {
                        option = "/";
                    }
                    else if (ch == ' ')
                    {
                        option = " ";
                    }
                }
                if (option == "")
                {
                    string s = txt.Text + "/";
                    date = s.Split('/');
                }
                if (option == ".")
                {
                    date = txt.Text.Split('.');
                }
                else if (option == ",")
                {
                    date = txt.Text.Split(',');
                }
                else if (option == "-")
                {
                    date = txt.Text.Split('-');
                }
                else if (option == "+")
                {
                    date = txt.Text.Split('+');
                }
                else if (option == "*")
                {
                    date = txt.Text.Split('*');
                }
                else if (option == "/")
                {
                    date = txt.Text.Split('/');
                }
                else if (option == " ")
                {
                    date = txt.Text.Split(' ');
                }
                if (date.Length == 1)
                {
                    string formatoption = SystemFormat();
                    if (formatoption == "M")
                    {
                        CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                    }
                    else if (formatoption == "d")
                    {
                        CurrDate = DateTime.Parse(date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + PublicVariables._dtCurrentDate.Date.Year);
                    }
                    else if (formatoption == "y")
                    {
                        CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString());
                    }
                    isValid = isTodaY(isValid);
                }
                else if (date.Length == 2)
                {
                    if (date[1].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + PublicVariables._dtCurrentDate.Date.Month + " / " + date[0].ToString());
                        }
                        isValid = isTodaY(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        } isValid = isTodaY(isValid);
                    }
                }
                else if (date.Length == 3)
                {
                    if (date[2].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + PublicVariables._dtCurrentDate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(PublicVariables._dtCurrentDate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isValid = isTodaY(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(date[2].ToString() + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isValid = isTodaY(isValid);
                    }
                }
                else
                {
                    isValid = false;
                    txt.Text = "";
                }
            }
            catch (Exception)
            {
                isValid = false;
                txt.Text = "";
            }
            return isValid;
        }
        /// <summary>
        /// Function to check current date
        /// </summary>
        /// <param name="isValid"></param>
        /// <returns></returns>
        public bool isTodaY(bool isValid)
        {
            if (CurrDate == PublicVariables._dtCurrentDate.Date)
            {
                text.ForeColor = Color.IndianRed;
                text.Text = CurrDate.ToString("dd-MMM-yyyy");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.Text = CurrDate.ToString("dd-MMM-yyyy");
            }
            return isValid;
        }
        /// <summary>
        /// Function for system format date
        /// </summary>
        /// <returns></returns>
        public string SystemFormat()
        {
            string formatoption = string.Empty;
            foreach (char ch in format)
            {
                if (ch == 'M')
                {
                    formatoption = "M";
                    break;
                }
                else if (ch == 'd')
                {
                    formatoption = "d";
                    break;
                }
                else if (ch == 'y')
                {
                    formatoption = "y";
                    break;
                }
            }
            return formatoption;
        }
    }
}
