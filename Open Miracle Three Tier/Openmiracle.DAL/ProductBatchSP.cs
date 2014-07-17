using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
//<summary>    
//Summary description for ProductBatchSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ProductBatchSP : DBConnection
    {
        public void ProductBatchAdd(ProductBatchInfo productbatchinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productbatchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = productbatchinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.PartNo;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Barcode;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = productbatchinfo.ExtraDate;
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
        public void ProductBatchEdit(ProductBatchInfo productbatchinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
                sprmparam.Value = productbatchinfo.ProductBatchId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productbatchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = productbatchinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.PartNo;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Barcode;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productbatchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = productbatchinfo.ExtraDate;
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
        public DataTable ProductBatchViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductBatchViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        public ProductBatchInfo ProductBatchView(decimal productBatchId)
        {
            ProductBatchInfo productbatchinfo = new ProductBatchInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
                sprmparam.Value = productBatchId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    productbatchinfo.ProductBatchId = decimal.Parse(sdrreader[0].ToString());
                    productbatchinfo.ProductId = decimal.Parse(sdrreader[1].ToString());
                    productbatchinfo.BatchId = decimal.Parse(sdrreader[2].ToString());
                    productbatchinfo.PartNo = sdrreader[3].ToString();
                    productbatchinfo.Barcode = sdrreader[4].ToString();
                    productbatchinfo.Extra1 = sdrreader[5].ToString();
                    productbatchinfo.Extra2 = sdrreader[6].ToString();
                    productbatchinfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
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
            return productbatchinfo;
        }
        public void ProductBatchDelete(decimal ProductBatchId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productBatchId", SqlDbType.Decimal);
                sprmparam.Value = ProductBatchId;
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
        public int ProductBatchGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchMax", sqlcon);
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
        public string ProductBatchBarcodeViewByBatchId(decimal decBathId)
        {
            string barCode = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchBarcodeViewByBatchId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBathId;
                barCode = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return barCode;
        }
    }
}
