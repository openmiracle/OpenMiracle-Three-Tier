using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;

namespace OpenMiracle.BLL
{
  public  class ModelNoBll 
    {
      ModelNoInfo infoModelNo = new ModelNoInfo();
      ModelNoSP SpModelNo = new ModelNoSP();
      public List<DataTable> ModelNoOnlyViewAll() 
      {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = SpModelNo.ModelNoOnlyViewAll();
          }
          catch (Exception ex)
          {
              MessageBox.Show("MN1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }
        public bool ModelCheckIfExist(String strModelNo, decimal decModelNoId)
    {
            bool isEdit=false;
        try
        {
            isEdit = SpModelNo.ModelCheckIfExist(strModelNo, decModelNoId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return isEdit;
    }
       public decimal ModelNoAddWithDifferentModelNo(ModelNoInfo modelnoinfo)
    {
        decimal decWork = 0;
           try
        {
           decWork= SpModelNo.ModelNoAddWithDifferentModelNo(modelnoinfo);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           return decWork;
    }
       public bool ModelNoEditParticularFeilds(ModelNoInfo modelnoinfo)
    {
        bool isEdit = false;
        try
        {
            isEdit = SpModelNo.ModelNoEditParticularFeilds(modelnoinfo);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return isEdit;
    }
       public decimal ModelNoCheckReferenceAndDelete(decimal decModelNoId)
    {
        decimal decReturnValue = 0;
        try
        {
            decReturnValue = SpModelNo.ModelNoCheckReferenceAndDelete(decModelNoId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return decReturnValue;
    }
      public void ModelNoDelete(decimal ModelNoId)
    {
        try
        {
            SpModelNo.ModelNoDelete(ModelNoId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
       public ModelNoInfo ModelNoWithNarrationView(decimal decModelNoId)
    {
        ModelNoInfo modelnoinfo = new ModelNoInfo();
        try
        {
            modelnoinfo = SpModelNo.ModelNoWithNarrationView(decModelNoId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return modelnoinfo;
    }

       public List<DataTable> ModelNoViewAll()
    {
        List<DataTable> listObj = new List<DataTable>();
        try
        {
            listObj = SpModelNo.ModelNoViewAll();
        }
        catch (Exception ex)
        {
            MessageBox.Show("MN8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return listObj;
    }
    }
}
