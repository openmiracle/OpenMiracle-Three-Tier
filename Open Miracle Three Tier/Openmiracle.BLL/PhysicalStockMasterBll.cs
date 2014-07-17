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
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    
    public class PhysicalStockMasterBll
    {
        PhysicalStockMasterInfo InfoPhysicalStockMaster = new PhysicalStockMasterInfo();
        PhysicalStockMasterSP SPPhysicalStockMaster = new PhysicalStockMasterSP();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DecBrandId"></param>
        /// <param name="decid"></param>
        /// <returns></returns>
        public DataSet PhysicalStockPrinting(decimal DecBrandId,decimal decid)
        {
            DataSet dsPhysicalStock = new DataSet();
            try
            {
                SPPhysicalStockMaster.PhysicalStockPrinting(DecBrandId, decid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsPhysicalStock;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PhysicalStockDelete(decimal decPhysicalStockMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {            
            try
            {
                SPPhysicalStockMaster.PhysicalStockDelete(decPhysicalStockMasterId, decVoucherTypeId, strVoucherNo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="physicalStockMasterId"></param>
        /// <returns></returns>
        public PhysicalStockMasterInfo PhysicalStockMasterView(decimal physicalStockMasterId)
        {
            PhysicalStockMasterInfo InfoPhysicalStockMaster = new PhysicalStockMasterInfo();
            try
            {
                InfoPhysicalStockMaster = SPPhysicalStockMaster.PhysicalStockMasterView(physicalStockMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoPhysicalStockMaster;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PhysicalStockViewbyMasterId(decimal decPhysicalStockMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPhysicalStockMaster.PhysicalStockViewbyMasterId(decPhysicalStockMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PhysicalStockMasterVoucherMax(decimal decVoucherTypeId)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPPhysicalStockMaster.PhysicalStockMasterVoucherMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InfoPhysicalStockMaster"></param>
        public void PhysicalStockMasterEdit(PhysicalStockMasterInfo InfoPhysicalStockMaster)
        {
            try
            {
                SPPhysicalStockMaster.PhysicalStockMasterEdit(InfoPhysicalStockMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InfoPhysicalStockMaster"></param>
        /// <returns></returns>
        public decimal PhysicalStockMasterAdd(PhysicalStockMasterInfo InfoPhysicalStockMaster)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPPhysicalStockMaster.PhysicalStockMasterAdd(InfoPhysicalStockMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PhysicalStockRegisterGridFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPhysicalStockMaster.PhysicalStockRegisterGridFill(dtDateFrom, dtDateTo, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }

}
