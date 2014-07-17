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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Open_Miracle
{
    public partial class frmLoading : Form
    {
        #region Function
        public frmLoading()
        {
            InitializeComponent();
        }
        public void ShowFromSendMail()
        {
            label1.Text = "Sending...";
            ShowDialog();
        }
        #endregion
        #region Events
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTableName.Text = frmCopyData.strTable;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Loading:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
