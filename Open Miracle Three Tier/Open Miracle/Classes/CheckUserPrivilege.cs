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
namespace Open_Miracle
{
    class CheckUserPrivilege : DBConnection
    {
        /// <summary>
        /// Function to check the privilege
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="formName"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static bool PrivilegeCheck(decimal userId, string formName, string action)
        {
            bool isPrivilege = false;
            PrivilegeSP spPrivilege = new PrivilegeSP();
            if (spPrivilege.PrivilegeCheck(userId, formName, action))
            {
                isPrivilege = true;
            }
            else
            {
                isPrivilege = false;
            }
            return isPrivilege;
        }
    }
}
