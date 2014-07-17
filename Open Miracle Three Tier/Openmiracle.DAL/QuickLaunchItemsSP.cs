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
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTITY;
namespace OpenMiracle.DAL
{
    public class QuickLaunchItemsSP:DBConnection
    {
        /// <summary>
        /// Function to get all the Non Selected  values from tbl_QuickLaunchItems Table
        /// </summary>
        /// <param name="isSelected"></param>
        /// <returns></returns>
        public List<DataTable> QuickLaunchNonSelectedViewAll(bool isSelected)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DataTable dtbl = new DataTable();
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("QuickLaunchNonSelectedViewAll", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@selected", SqlDbType.Bit).Value = isSelected;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to Update values in tbl_QuickLaunchItems Table
        /// </summary>
        /// <param name="infoQuickLaunchItems"></param>
        public void QuickLaunchItemsEdit(QuickLaunchItemsInfo infoQuickLaunchItems)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("QuickLaunchItemsEdit", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@quickLaunchItemsId", SqlDbType.Decimal).Value = infoQuickLaunchItems.QuickLaunchItemsId;
                sqlcmd.Parameters.Add("@itemsName", SqlDbType.VarChar).Value = infoQuickLaunchItems.ItemsName;
                sqlcmd.Parameters.Add("@status", SqlDbType.Bit).Value = infoQuickLaunchItems.Status;
                sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = infoQuickLaunchItems.Extra1;
                sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = infoQuickLaunchItems.Extra2;
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
