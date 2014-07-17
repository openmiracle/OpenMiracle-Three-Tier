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
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Open_Miracle.Classes.General;
namespace Open_Miracle
{
    class BackupRestore : DBConnection
    {
        /// <summary>
        /// Function to take backup
        /// </summary>
        public void TakeBackUp()
        {
            try
            {
                if (MessageBox.Show("Do you want to take back up?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sqlcon.State == ConnectionState.Closed)
                    {
                        sqlcon.Open();
                    }
                    string strPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId + "\\DBOpenMiracle.mdf";
                    SaveFileDialog saveBackupDialog = new SaveFileDialog();
                    string strDestinationPath = string.Empty;
                    string strFname = "DBOpenMiracle" + DateTime.Now.ToString("ddMMyyyhhmmss");
                    saveBackupDialog.FileName = strFname;
                    if (saveBackupDialog.ShowDialog() == DialogResult.OK)
                    {
                        strDestinationPath = saveBackupDialog.FileName;
                        strDestinationPath = "'" + strDestinationPath + ".bak'";
                        SqlCommand sccmd = new SqlCommand("CompanyBackUpDb", sqlcon);
                        sccmd.CommandType = CommandType.StoredProcedure;
                        sccmd.Parameters.Add("@path", SqlDbType.VarChar).Value = strPath;
                        sccmd.Parameters.Add("@name", SqlDbType.VarChar).Value = strDestinationPath;
                        decimal decEffect = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
                        MessageBox.Show("The backup of database  completed successfully", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR 1 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to restore DB
        /// </summary>
        public void ReStoreDB()
        {
            string currDBName = sqlcon.Database;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string DBName = "";// DB name
                DBName = sqlcon.Database;
                currDBName = sqlcon.Database;
                string[] arr = DBName.Split('\\');
                DBName = arr[arr.Length - 1].Replace(".MDF", "");
                string DBFolder = ""; // Folder name (company id)
                DBFolder = arr[arr.Length - 2];
                OpenFileDialog opDialog = new OpenFileDialog();
                opDialog.Filter = "BackUp Files (*.bak)|*.bak";
                opDialog.Title = "Select your .bak file for restore the database OpenMiracle";
                string path = "";
                path = Application.StartupPath + "\\Data\\" + DBFolder + "\\" + DBName + ".MDF";
                if (opDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = Path.GetFullPath(opDialog.FileName);
                    {
                        string fileName = filePath;
                        string databaseName = DBName;
                        string dataFilePath = Application.StartupPath + "\\Data\\" + DBFolder;
                        String dataFileLocation = dataFilePath + @"\" + DBName + ".mdf";
                        String logFileLocation = dataFilePath + @"\" + DBName + "_log.ldf";
                        string strSqlFirst = "RESTORE FILELISTONLY FROM DISK = '" + fileName + "'";
                        string strSql = "ALTER DATABASE [" + sqlcon.Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        string strSqlRestore = "RESTORE DATABASE [" + sqlcon.Database + "] FROM DISK = '" + fileName + "' WITH MOVE '" + "DBOpenMiracle" + "' TO '" + dataFileLocation + "', MOVE '" + "DBOpenMiracle_log" + "' TO '" + logFileLocation + "'";
                        string strAlter = "ALTER DATABASE [" + sqlcon.Database + "] SET MULTI_USER";
                        sqlcon.ChangeDatabase("master");
                        SqlCommand sqlCmd1 = new SqlCommand(strSqlFirst + "\n" + strSql + "\n" + strSqlRestore + "\n" + strAlter, sqlcon);
                        sqlCmd1.CommandType = CommandType.Text;
                        sqlCmd1.ExecuteNonQuery();
                        MessageBox.Show("Restore of " + databaseName +
                        " Complete!", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            sqlcon.ChangeDatabase(currDBName);
                        }
                        catch
                        {
                            //catches Exception during DataBase change
                        }
                        //After Restore Checking whether the Database is ok or not [if 'ChangeDatabase' fails, its required to restart application for reseting the db connection]
                        DataTable dtbl = new DataTable();
                        try
                        {
                            if (sqlcon.State == ConnectionState.Closed)
                            {
                                sqlcon.Open();
                            }
                            SqlDataAdapter sdaadapter = new SqlDataAdapter("CompanyViewAll", sqlcon);
                            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sdaadapter.Fill(dtbl);
                        }
                        catch
                        {
                            ///cathes any error due to DataBase Restore
                            Messages.InformationMessage("Please close and re-open your application");
                            Application.Exit();
                        }
                        finally
                        {
                            sqlcon.Close();
                        }
                    }
                }
            }
            catch
            {
                Messages.ErrorMessage("Restore failed for database");
                try
                {
                    //For changing database to MultiUser mode if any Restore operation terminated abnormaly 
                    string AlterAgain = "ALTER DATABASE [" + sqlcon.Database + "] SET MULTI_USER";
                    SqlCommand sqlCmd = new SqlCommand(AlterAgain);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    //Catches any exception during Alter DB
                }
            }
            finally
            {
            }
        }
    }
}
