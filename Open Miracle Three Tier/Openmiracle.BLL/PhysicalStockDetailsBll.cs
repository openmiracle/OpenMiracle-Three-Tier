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
    public class PhysicalStockDetailsBll
    {
        PhysicalStockDetailsSP SPPhysicalStockDetails = new PhysicalStockDetailsSP();
         /// <summary>
         /// 
         /// </summary>
         /// <param name="decMasterId"></param>
        public void PhysicalStockDetailsDeleteWhenUpdate(decimal decMasterId)
        {
            try
            {
                SPPhysicalStockDetails.PhysicalStockDetailsDeleteWhenUpdate(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InfoPhysicalStockDetails"></param>
        public void PhysicalStockDetailsAdd(PhysicalStockDetailsInfo InfoPhysicalStockDetails)
        {
            try
            {
                SPPhysicalStockDetails.PhysicalStockDetailsAdd(InfoPhysicalStockDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
