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
    public class UnitConvertionBll
    {
        UnitConvertionSP spUnitConvertion = new UnitConvertionSP();
        public List<DataTable> UnitConversionIdAndConRateViewallByProductId(string strProductId)
        { 
         
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spUnitConvertion.UnitConversionIdAndConRateViewallByProductId( strProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public decimal UnitConversionRateByUnitConversionId(decimal decConversionId)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spUnitConvertion.UnitConversionRateByUnitConversionId( decConversionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public List<DataTable> DGVUnitConvertionRateByUnitId(decimal decUnitId, string productName)
        {
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spUnitConvertion.DGVUnitConvertionRateByUnitId( decUnitId,  productName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public decimal UnitconversionIdViewByUnitIdAndProductId(decimal unitId, decimal productId)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spUnitConvertion.UnitconversionIdViewByUnitIdAndProductId(unitId, productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public decimal MulUnitDeleteForUpdation(decimal decProductId)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spUnitConvertion.MulUnitDeleteForUpdation(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public UnitConvertionInfo UnitViewAllByProductId(decimal dcProductid)
        {
            UnitConvertionInfo infUnitConvertion = new UnitConvertionInfo();
            try
            {
                infUnitConvertion = spUnitConvertion.UnitViewAllByProductId(dcProductid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infUnitConvertion;
        }
        public void UnitConvertionAdd(UnitConvertionInfo unitconvertioninfo)
        {
            
            try
            {
                spUnitConvertion.UnitConvertionAdd(unitconvertioninfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> UnitConverstionTableForEdit(decimal decProductId)
        {
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spUnitConvertion.UnitConverstionTableForEdit(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public void UnitConverstionEditWhenProductUpdating(UnitConvertionInfo unitConvertionInfo)
        {
            try
            {
                spUnitConvertion.UnitConverstionEditWhenProductUpdating(unitConvertionInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UnitConvertionEdit(UnitConvertionInfo unitconvertioninfo)
        {
            try
            {
                spUnitConvertion.UnitConvertionEdit(unitconvertioninfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> UnitsOfPerticularProduct(decimal decProductId)
        {
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spUnitConvertion.UnitsOfPerticularProduct(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public decimal MulUnitRemoveRows(decimal decUnitConvetionId)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spUnitConvertion.MulUnitRemoveRows(decUnitConvetionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
       
    }

    }

