using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;

namespace OpenMiracle.BLL
{
  public class BackUpRestoreBll
    {
        public void TakeBackUp()
        {
            BackupRestore BackUpRestoreDalObj = new BackupRestore();
            try
            {
                BackUpRestoreDalObj.TakeBackUp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ReStoreDB()
        {
            BackupRestore BackUpRestoreDalObj = new BackupRestore();
            try
            {
                BackUpRestoreDalObj.ReStoreDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
