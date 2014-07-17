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
using System.Data;
using System.Data.SqlClient;
using ENTITY;  
//<summary>    
//Summary description for BonusDedutionSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class BonusDedutionSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to BonusDeduction Table
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        public void BonusDedutionAdd(BonusDedutionInfo bonusdedutioninfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDedutionAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.BonusDeductionId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Date;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Month;
                sprmparam = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.BonusAmount;
                sprmparam = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.DeductionAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra2;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in BonusDeduction  Table
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        public void BonusDedutionEdit(BonusDedutionInfo bonusdedutioninfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDedutionEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.BonusDeductionId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Date;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Month;
                sprmparam = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.BonusAmount;
                sprmparam = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.DeductionAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra2;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get all the values from BonusDeduction Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BonusDedutionViewAll()
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BonusDedutionViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listobj;
        }
        /// <summary>
        /// Function to get particular values from BonusDeduction table based on the parameter
        /// </summary>
        /// <param name="bonusDeductionId"></param>
        /// <returns></returns>
        public BonusDedutionInfo BonusDedutionView(decimal bonusDeductionId)
        {
            BonusDedutionInfo bonusdedutioninfo = new BonusDedutionInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDedutionView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
                sprmparam.Value = bonusDeductionId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    bonusdedutioninfo.BonusDeductionId = decimal.Parse(sdrreader[0].ToString());
                    bonusdedutioninfo.EmployeeId = decimal.Parse(sdrreader[1].ToString());
                    bonusdedutioninfo.Date = DateTime.Parse(sdrreader[2].ToString());
                    bonusdedutioninfo.Month = DateTime.Parse(sdrreader[3].ToString());
                    bonusdedutioninfo.BonusAmount = decimal.Parse(sdrreader[4].ToString());
                    bonusdedutioninfo.DeductionAmount = decimal.Parse(sdrreader[5].ToString());
                    bonusdedutioninfo.Narration = sdrreader[6].ToString();
                    bonusdedutioninfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
                    bonusdedutioninfo.Extra1 = sdrreader[8].ToString();
                    bonusdedutioninfo.Extra2 = sdrreader[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return bonusdedutioninfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BonusDeductionId"></param>
        public void BonusDedutionDelete(decimal BonusDeductionId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDedutionDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal);
                sprmparam.Value = BonusDeductionId;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to  get the next id for BonusDeduction table
        /// </summary>
        /// <returns></returns>
        public int BonusDedutionGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDedutionMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return max;
        }
        /// <summary>
        /// Function to get values for search based on parameters
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="dtMonth"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionSearch(String strName, DateTime dtMonth)
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strName;
                sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
                sqlda.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listobj;
        }
        /// <summary>
        /// Function to get particular value based on parameter
        /// </summary>
        /// <param name="decBonusDedutionId"></param>
        /// <returns></returns>
        public List<DataTable> BonusDedutionFill(decimal decBonusDedutionId)
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BonusDedutionView", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("bonusDeductionId", SqlDbType.Decimal).Value = decBonusDedutionId;
                sdaadapter.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listobj;
        }
        /// <summary>
        /// Function to view details for update based on parameter
        /// </summary>
        /// <param name="decBonusDeductionId"></param>
        /// <returns></returns>
        public BonusDedutionInfo BonusDeductionViewForUpdate(decimal decBonusDeductionId)
        {
            BonusDedutionInfo BonusDeductionInfo = new BonusDedutionInfo();
            EmployeeInfo InfoEmployee = new EmployeeInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BonusDeductionViewForUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@bonusDeductionId", SqlDbType.Decimal).Value = decBonusDeductionId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    BonusDeductionInfo.EmployeeId = decimal.Parse(sqldr["employeeId"].ToString());
                    BonusDeductionInfo.Date = DateTime.Parse(sqldr["date"].ToString());
                    BonusDeductionInfo.Month = DateTime.Parse(sqldr["month"].ToString());
                    BonusDeductionInfo.BonusAmount = decimal.Parse(sqldr["bonusAmount"].ToString());
                    BonusDeductionInfo.DeductionAmount = decimal.Parse(sqldr["deductionAmount"].ToString());
                    BonusDeductionInfo.Narration = sqldr["narration"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return BonusDeductionInfo;
        }
        /// <summary>
        /// Function to insert values if not exists and return id
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        /// <returns></returns>
        public bool BonusDeductionAddIfNotExist(BonusDedutionInfo bonusdedutioninfo)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BonusDeductionAddIfNotExist", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Date;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = bonusdedutioninfo.Month;
                sprmparam = sccmd.Parameters.Add("@bonusAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.BonusAmount;
                sprmparam = sccmd.Parameters.Add("@deductionAmount", SqlDbType.Decimal);
                sprmparam.Value = bonusdedutioninfo.DeductionAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = bonusdedutioninfo.Extra2;
                int ina = sccmd.ExecuteNonQuery();
                if (ina > 0)
                {
                    isSave = true;
                }
                else
                {
                    isSave = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isSave;
        }
        /// <summary>
        /// Function to check existence of month and return value
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        /// <returns></returns>
        public bool BonusDeductionMonthCheckExistance(BonusDedutionInfo bonusdedutioninfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BonusDeductionMonthCheckExistance", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@month", SqlDbType.DateTime).Value = bonusdedutioninfo.Month;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    isEdit = true;
                }
                else
                {
                    isEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to get all values based on the parameters for search
        /// </summary>
        /// <param name="strCode"></param>
        /// <param name="strName"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionSearchForPopUp(String strCode, String strName)
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionSearchForPopUp", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strCode;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strName;
                sqlda.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listobj;
        }
        /// <summary>
        /// Function to check reference and delete based on parameters
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public decimal BonusDeductionReferenceDelete(decimal EmployeeId, DateTime month)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BonusDeductionReferenceDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@EmployeeId", SqlDbType.Decimal);
                sprmparam.Value = EmployeeId;
                sprmparam = sqlcmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = month;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to get all the values for Report based on parameters
        /// </summary>
        /// <param name="strFromdate"></param>
        /// <param name="strTodate"></param>
        /// <param name="strSalaryMonth"></param>
        /// <param name="strDesignation"></param>
        /// <param name="strEmployee"></param>
        /// <param name="strBonusOrDeduction"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionReportGridFill(string strFromdate, string strTodate, string strSalaryMonth, string strDesignation, string strEmployee, string strBonusOrDeduction)
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BonusDeductionReportGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("Sl No", typeof(int));
                dtbl.Columns["Sl No"].AutoIncrement = true;
                dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl No"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strFromdate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strTodate;
                sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = strSalaryMonth;
                sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
                sqlda.SelectCommand.Parameters.Add("@employee", SqlDbType.VarChar).Value = strEmployee;
                sqlda.SelectCommand.Parameters.Add("@bonusOrdeduction", SqlDbType.VarChar).Value = strBonusOrDeduction;
                sqlda.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listobj;
        }
    }
}
