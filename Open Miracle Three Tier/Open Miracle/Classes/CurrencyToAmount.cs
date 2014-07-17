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
namespace Open_Miracle.Classes.General
{
    class CurrencyToAmount
    {
        /// <summary>
        /// Function to return amount in words
        /// </summary>
        /// <param name="decAmount"></param>
        /// <param name="decCurrId"></param>
        /// <returns></returns>
        public string AmountWords(decimal decAmount, decimal decCurrId)
        {
            string AountInWords = ""; // To return the amount in words
            CurrencyInfo currencyInfo = new CurrencySP().CurrencyView(decCurrId);
            decAmount = Math.Round(decAmount, currencyInfo.NoOfDecimalPlaces); //Rounding according to decimal places of currency
            string strAmount = decAmount.ToString(); // Just keeping the whole amount as string for performing split operation on it
            string strAmountinwordsOfIntiger = "";  // To hold amount in words of intiger
            string strAmountInWordsOfDecimal = ""; // To hold amoutn in words of decimal part
            string[] strPartsArray = strAmount.Split('.'); // Splitting with "." to get intiger part and decimal part seperately
            string strDecimaPart = "";                     // To hold decimal part
            if (strPartsArray.Length > 1)
                if (strPartsArray[1] != null)
                    strDecimaPart = strPartsArray[1]; // Holding decimal portion if any
            if (strPartsArray[0] != null)
                strAmount = strPartsArray[0];    // Holding intiger part of amount
            else
                strAmount = "";
            if (strAmount.Trim() != "" && decimal.Parse(strAmount) != 0)
                strAmountinwordsOfIntiger = NumberToText(int.Parse(strAmount));
            if (strDecimaPart.Trim() != "" && decimal.Parse(strDecimaPart) != 0)
                strAmountInWordsOfDecimal = NumberToText(int.Parse(strDecimaPart));
            else
            {
                // Showing currency as prefix
                if (strAmountinwordsOfIntiger != "")
                    AountInWords = currencyInfo.CurrencyName + " " + strAmountinwordsOfIntiger;
                if (strAmountInWordsOfDecimal != "")
                    AountInWords = AountInWords + " and " + currencyInfo.SubunitName + " " + strAmountInWordsOfDecimal;
                AountInWords = AountInWords + " only";
            }
            return AountInWords;
        }
        /// <summary>
        /// Function to convert number to text
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string NumberToText(int number)
        {
            // Converting the number to words
            if (number == 0) return "Zero";
            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };
            num[0] = number % 1000; // units 
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands 
            num[3] = number / 10000000; // crores 
            num[2] = num[2] - 100 * num[3]; // lakhs 
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10; // ones 
                t = num[i] / 10;
                h = num[i] / 100; // hundreds 
                t = t - 10 * h; // tens 
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append(" ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
