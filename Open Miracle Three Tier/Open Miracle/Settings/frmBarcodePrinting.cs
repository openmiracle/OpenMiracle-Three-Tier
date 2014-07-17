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
using System.IO;
using System.Drawing.Imaging;
using System.Collections;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using iTextSharp.text.pdf;
using iTextSharp.text;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmBarcodePrinting : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        ProductCreationBll BllProductCreation = new ProductCreationBll();     
        PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
        List<DataTable> listBarcodePrinting = new List<DataTable>();
        BarcodeSettingsBll BllBarcodeSettings = new BarcodeSettingsBll();
        decimal decTotal = 0;
        int inRowIndex = 0;
        #endregion

        #region Functions
        /// <summary>
        /// Clear Function, the Form will be reset here
        /// </summary>
        public void Clear()
        {
            try
            {
                ProductCodeComboFill(cmbProductCode);
                cmbProductCode.SelectedIndex = 0;
                PurchaseInvoiceComboFillForBarcodePrinting(cmbPurchaseInvoiceNo);
                cmbFormat.SelectedIndex = 0;
                lblTotalCountValue.Text = "0";
                dgvBarcodePrinting.Rows.Clear();
                BarcodePrintingGrideFill();
                serialNoGeneration();
                cmbProductCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no generaion for Grid
        /// </summary>
        public void serialNoGeneration()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvBarcodePrinting.Rows)
                {
                    row.Cells["dgvSNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Count the No of copies to print or generate
        /// </summary>
        public void TotalCountOfCopies()
        {
            try
            {
                decTotal = 0;
                foreach (DataGridViewRow dgvrow in dgvBarcodePrinting.Rows)
                {
                    if (dgvrow.Cells["dgvCopies"].Value != null)
                    {
                        if (dgvrow.Cells["dgvCopies"].Value.ToString() != string.Empty)
                        {
                            decTotal = decTotal + Convert.ToDecimal(dgvrow.Cells["dgvCopies"].Value.ToString());
                            decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                            lblTotalCountValue.Text = decTotal.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Export the Barcodes to PDF format here
        /// </summary>
        public void ExportToPDF()
        {
            iTextSharp.text.Document pdfdoc = new iTextSharp.text.Document();
            try
            {
                DirectoryInfo dir1 = new DirectoryInfo(Application.StartupPath + "\\Barcode");
                if (!Directory.Exists(Application.StartupPath + "\\Barcode"))
                {
                    dir1.Create();
                }
                if (File.Exists(Application.StartupPath + "\\Barcode\\Barcode.pdf"))
                {
                    File.Delete(Application.StartupPath + "\\Barcode\\Barcode.pdf");
                }
                pdfdoc = new Document(PageSize.A4, 12, 1, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(pdfdoc, new FileStream(Application.StartupPath + "\\Barcode\\Barcode.pdf", FileMode.Create));
                PdfPTable tbl = new PdfPTable(5);
                tbl.WidthPercentage = 100;
                tbl.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tbl.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tbl.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfdoc.Open();
                int intotalCount = 0;
                BarcodeSettingsInfo Info = new BarcodeSettingsInfo();
                SettingsBll BllSettings = new SettingsBll();
                Info = BllBarcodeSettings.BarcodeSettingsViewForBarCodePrinting();
                for (int i = 0; i < dgvBarcodePrinting.Rows.Count; i++)
                {
                    if (dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value != null && dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value.ToString() != "")
                    {
                        int inCopies = 0;
                        if (dgvBarcodePrinting.Rows[i].Cells["dgvCopies"].Value != null)
                        {
                            int.TryParse(dgvBarcodePrinting.Rows[i].Cells["dgvCopies"].Value.ToString(), out inCopies); // number of copies of arcode to be printed
                        }
                        for (int j = 0; j < inCopies; j++)
                        {
                            string strProductCode = string.Empty;
                            string strCode = string.Empty;
                            string strCompanyName = string.Empty;
                            if (Info.ShowProductCode)
                            {
                                strCode = dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value.ToString();
              
                                if (Info.ShowProductCode)
                                    strProductCode = strCode;
                            }
                            else
                            {
                                strProductCode = dgvBarcodePrinting.Rows[i].Cells["dgvproductName"].Value.ToString();
                            }
                            if (Info.ShowCompanyName)
                                strCompanyName = Info.CompanyName;
                            string strMRP = string.Empty;
                            if (Info.ShowMRP)
                            {
                                strMRP = new CurrencyBll().CurrencyView(PublicVariables._decCurrencyId).CurrencySymbol + ": " + dgvBarcodePrinting.Rows[i].Cells["dgvMRP"].Value.ToString();
                            }
                            string strSecretPurchaseRateCode = string.Empty;
                            if (Info.ShowPurchaseRate)
                            {
                                string strPurchaseRate = dgvBarcodePrinting.Rows[i].Cells["dgvPurchaseRate"].Value.ToString();
                                if (strPurchaseRate.Contains("."))
                                {
                                    strPurchaseRate = strPurchaseRate.TrimEnd('0');
                                    if (strPurchaseRate[strPurchaseRate.Length - 1] == '.')
                                        strPurchaseRate = strPurchaseRate.Replace(".", "");
                                }
                                for (int k = 0; k < strPurchaseRate.Length; k++)
                                {
                                    switch (strPurchaseRate[k])
                                    {
                                        case '0':
                                            strSecretPurchaseRateCode += Info.Zero;
                                            break;
                                        case '1':
                                            strSecretPurchaseRateCode += Info.One;
                                            break;
                                        case '2':
                                            strSecretPurchaseRateCode += Info.Two;
                                            break;
                                        case '3':
                                            strSecretPurchaseRateCode += Info.Three;
                                            break;
                                        case '4':
                                            strSecretPurchaseRateCode += Info.Four;
                                            break;
                                        case '5':
                                            strSecretPurchaseRateCode += Info.Five;
                                            break;
                                        case '6':
                                            strSecretPurchaseRateCode += Info.Six;
                                            break;
                                        case '7':
                                            strSecretPurchaseRateCode += Info.Seven;
                                            break;
                                        case '8':
                                            strSecretPurchaseRateCode += Info.Eight;
                                            break;
                                        case '9':
                                            strSecretPurchaseRateCode += Info.Nine;
                                            break;
                                        case '.':
                                            strSecretPurchaseRateCode += Info.Point;
                                            break;
                                    }
                                }
                            }
                            PdfContentByte pdfcb = writer.DirectContent;
                            Barcode128 code128 = new Barcode128();
                            code128.Code = strCode;
                            code128.Extended = false;
                            code128.CodeType = iTextSharp.text.pdf.Barcode.CODE128;
                            code128.AltText = strProductCode;
                            code128.BarHeight = 13;
                            code128.Size = 6;
                            code128.Baseline = 8;
                            code128.TextAlignment = Element.ALIGN_CENTER;
                            iTextSharp.text.Image image128 = code128.CreateImageWithBarcode(pdfcb, null, null);
                            Phrase phrase = new Phrase();
                            phrase.Font.Size = 8;
                            phrase.Add(new Chunk(strCompanyName + Environment.NewLine + Environment.NewLine));
                            PdfPCell cell = new PdfPCell(phrase);
                            cell.FixedHeight = 61.69f;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
    
                            phrase.Add(new Chunk(image128, 0, 0));
                            phrase.Add(new Chunk(Environment.NewLine + strMRP));
                            phrase.Add(new Chunk(Environment.NewLine + strSecretPurchaseRateCode));
                            tbl.AddCell(cell);
                            intotalCount++; 
                        }
                    }
                }
                int reminder = intotalCount % 5;
                if (reminder != 0)
                {
                    for (int i = reminder; i < 5; ++i)
                    {
                        tbl.AddCell("");
                    }
                }
                if (tbl.Rows.Count != 0)
                {
                    pdfdoc.Add(tbl);
                    pdfdoc.Close();
                    System.Diagnostics.Process.Start(Application.StartupPath + "\\Barcode\\Barcode.pdf");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("Barcode.pdf' because it is being used by another process."))
                {
                    MessageBox.Show("Close the PDF file and try again", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("BCP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                try
                {
                    pdfdoc.Close();
                }
                catch
                {
                }
            }
        }
        /// <summary>
        /// ExportToThermalPrinter
        /// </summary>
        public void ExportToPDFforThermalPrinter()
        {
            iTextSharp.text.Document pdfdoc = new iTextSharp.text.Document();
            try
            {
                DirectoryInfo dir1 = new DirectoryInfo(Application.StartupPath + "\\Barcode");
                if (!Directory.Exists(Application.StartupPath + "\\Barcode"))
                {
                    dir1.Create();
                }
                if (File.Exists(Application.StartupPath + "\\Barcode\\Barcode.pdf"))
                {
                    File.Delete(Application.StartupPath + "\\Barcode\\Barcode.pdf");
                }
                iTextSharp.text.Rectangle pgSize = new iTextSharp.text.Rectangle(227, 65);
                pdfdoc = new Document(pgSize, 6, 6, 0, 0);
                PdfWriter writer = PdfWriter.GetInstance(pdfdoc, new FileStream(Application.StartupPath + "\\Barcode\\Barcode.pdf", FileMode.Create));
                PdfPTable tbl = new PdfPTable(2);
                float[] fltParentWidth = new float[] { 108f, 108f };
                tbl.TotalWidth = 216;
                tbl.LockedWidth = true;
                tbl.SetWidths(fltParentWidth);
                tbl.DefaultCell.FixedHeight = 57;
                tbl.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tbl.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tbl.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfdoc.Open();
                int intotalCount = 0;
                BarcodeSettingsInfo Info = new BarcodeSettingsInfo();
                SettingsBll BllSettings = new SettingsBll();
                Info = BllBarcodeSettings.BarcodeSettingsViewForBarCodePrinting();
                for (int i = 0; i < dgvBarcodePrinting.Rows.Count; i++) 
                {
                    if (dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value != null && dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value.ToString() != string.Empty)
                    {
                        int inCopies = 0;
                        if (dgvBarcodePrinting.Rows[i].Cells["dgvCopies"].Value != null)
                        {
                            int.TryParse(dgvBarcodePrinting.Rows[i].Cells["dgvCopies"].Value.ToString(), out inCopies); 
                        }
                        for (int j = 0; j < inCopies; j++)
                        {
                            string strCode = dgvBarcodePrinting.Rows[i].Cells["dgvProductCode"].Value.ToString();
                            string strCompanyName = string.Empty;
                            if (Info.ShowCompanyName)
                                strCompanyName = Info.CompanyName;
                            string strProductCode = string.Empty;
                            if (Info.ShowProductCode)
                                strProductCode = strCode;
                            else
                                strProductCode = dgvBarcodePrinting.Rows[i].Cells["dgvproductName"].Value.ToString();

                            string strMRP = string.Empty;
                            if (Info.ShowMRP)
                            {
                                strMRP = new CurrencyBll().CurrencyView(PublicVariables._decCurrencyId).CurrencySymbol + ": " + dgvBarcodePrinting.Rows[i].Cells["dgvMRP"].Value.ToString();
                            }

                            string strSecretPurchaseRateCode = string.Empty;
                            if (Info.ShowPurchaseRate)
                            {
                                string strPurchaseRate = dgvBarcodePrinting.Rows[i].Cells["dgvPurchaseRate"].Value.ToString();
                              
                                if (strPurchaseRate.Contains("."))
                                {
                                    strPurchaseRate = strPurchaseRate.TrimEnd('0');
                                    if (strPurchaseRate[strPurchaseRate.Length - 1] == '.')
                                        strPurchaseRate = strPurchaseRate.Replace(".", "");
                                }
                                for (int k = 0; k < strPurchaseRate.Length; k++)
                                {
                                    switch (strPurchaseRate[k])
                                    {
                                        case '0':
                                            strSecretPurchaseRateCode += Info.Zero;
                                            break;
                                        case '1':
                                            strSecretPurchaseRateCode += Info.One;
                                            break;
                                        case '2':
                                            strSecretPurchaseRateCode += Info.Two;
                                            break;
                                        case '3':
                                            strSecretPurchaseRateCode += Info.Three;
                                            break;
                                        case '4':
                                            strSecretPurchaseRateCode += Info.Four;
                                            break;
                                        case '5':
                                            strSecretPurchaseRateCode += Info.Five;
                                            break;
                                        case '6':
                                            strSecretPurchaseRateCode += Info.Six;
                                            break;
                                        case '7':
                                            strSecretPurchaseRateCode += Info.Seven;
                                            break;
                                        case '8':
                                            strSecretPurchaseRateCode += Info.Eight;
                                            break;
                                        case '9':
                                            strSecretPurchaseRateCode += Info.Nine;
                                            break;
                                        case '.':
                                            strSecretPurchaseRateCode += Info.Point;
                                            break;
                                    }
                                }
                            }
                          
                            PdfContentByte pdfcb = writer.DirectContent;
                            Barcode128 code128 = new Barcode128();
                            code128.Code = strCode;
                            code128.Extended = false;
                            code128.CodeType = iTextSharp.text.pdf.Barcode.CODE128;
                            code128.AltText = strProductCode;
                            code128.BarHeight = 16;
                            code128.Size = 9;
                            code128.Baseline = 9;
                            code128.TextAlignment = Element.ALIGN_CENTER;
                            iTextSharp.text.Image image128 = code128.CreateImageWithBarcode(pdfcb, null, null);
                            Phrase phrase = new Phrase();
 
                            phrase.Add(new Chunk(strCompanyName, new iTextSharp.text.Font(-1, 9, iTextSharp.text.Font.BOLD)));
                            phrase.Add(new Chunk(Environment.NewLine + Environment.NewLine, new iTextSharp.text.Font(-1, 4)));
                            PdfPCell cell = new PdfPCell(phrase);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            phrase.Add(new Chunk(image128, 0, 0));
                            phrase.Add(new Chunk(Environment.NewLine, new iTextSharp.text.Font(-1, 4)));
                            phrase.Add(new Chunk(strMRP, new iTextSharp.text.Font(-1, 8)));
                            phrase.Add(new Chunk(Environment.NewLine + strSecretPurchaseRateCode, new iTextSharp.text.Font(-1, 7)));
                            phrase.Add(new Chunk(Environment.NewLine + Environment.NewLine, new iTextSharp.text.Font(-1, 1.2f)));
                            tbl.AddCell(cell);
                            intotalCount++; 
                        }
                    }
                }
                int reminder = intotalCount % 2;
                if (reminder != 0)
                {
                    for (int i = reminder; i < 2; ++i)
                    {
                        tbl.AddCell("");
                    }
                }
                if (tbl.Rows.Count != 0)
                {
                    pdfdoc.Add(tbl);
                    pdfdoc.Close();
                    System.Diagnostics.Process.Start(Application.StartupPath + "\\Barcode\\Barcode.pdf");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("Barcode.pdf' because it is being used by another process."))
                {
                    MessageBox.Show("Close the PDF file and try again", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("BCP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                try
                {
                    pdfdoc.Close();
                }
                catch
                {
                }
            }
        }
        /// <summary>
        /// Function to fill the Product code CXombobox
        /// </summary>
        /// <param name="cmbProductCode"></param>
        public void ProductCodeComboFill(ComboBox cmbProductCode)
        {
            try
            {
                BllProductCreation.ProductCodeViewAllForBarcodeCodePrinting(cmbProductCode, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for PurchaseInvoice ComboFill  For Barcode Printing
        /// </summary>
        /// <param name="cmbPurchaseInvoice"></param>
        public void PurchaseInvoiceComboFillForBarcodePrinting(ComboBox cmbPurchaseInvoice)
        {
            try
            {
                BllPurchaseInvoice.PurchaseInvoiceNoViewAllForBarcodePrinting(cmbPurchaseInvoice, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for PurchaseInvoice No Combobox Fill function
        /// </summary>
        /// <param name="cmbPurchaseInvoiceNo"></param>
        public void PurchaseInvoiceNoComboFill(ComboBox cmbPurchaseInvoiceNo)
        {
            try
            {
                if (cmbProductCode.SelectedIndex != -1)
                {
                    if (cmbProductCode.SelectedValue.ToString() != "System.Data.DataRowView" && cmbProductCode.Text != "System.Data.DataRowView")
                    {
                        if (cmbBatch.SelectedIndex != -1)
                        {
                            if (cmbBatch.SelectedValue.ToString() != "System.Data.DataRowView" && cmbBatch.Text != "System.Data.DataRowView")
                            {
                                BllPurchaseInvoice.PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting(Convert.ToDecimal(cmbProductCode.SelectedValue.ToString()), Convert.ToDecimal(cmbBatch.SelectedValue.ToString()), cmbPurchaseInvoiceNo, true);
                            }
                        }
                        else
                        {
                            cmbPurchaseInvoiceNo.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    cmbPurchaseInvoiceNo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Barcode Printing GrideFill
        /// </summary>
        public void BarcodePrintingGrideFill()
        {
            BatchBll BllBatch = new BatchBll();
            try
            {
                if (cmbProductCode.SelectedIndex != -1)
                {
                    if (cmbProductCode.SelectedValue.ToString() != "System.Data.DataRowView" && cmbProductCode.Text != "System.Data.DataRowView")
                    {
                        if (cmbBatch.SelectedIndex != -1)
                        {
                            if (cmbBatch.SelectedValue.ToString() != "System.Data.DataRowView" && cmbBatch.Text != "System.Data.DataRowView")
                            {
                                if (cmbPurchaseInvoiceNo.SelectedIndex != -1)
                                {
                                    if (cmbPurchaseInvoiceNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbPurchaseInvoiceNo.Text != "System.Data.DataRowView")
                                    {
                                        dgvBarcodePrinting.Rows.Clear();
                                        listBarcodePrinting = BllBatch.BarcodePrintingGrideFill(Convert.ToDecimal(cmbProductCode.SelectedValue.ToString()), Convert.ToDecimal(cmbBatch.SelectedValue.ToString()), Convert.ToDecimal(cmbPurchaseInvoiceNo.SelectedValue.ToString()));
                                        foreach (DataRow item in listBarcodePrinting[0].Rows)
                                        {
                                            dgvBarcodePrinting.Rows.Add();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvProductCode"].Value = item["productCode"].ToString();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvProductName"].Value = item["productName"].ToString();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvBatch"].Value = item["batchNo"].ToString();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvBarcode"].Value = item["barcode"].ToString();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvCurrentStock"].Value = item["CurrentStock"].ToString();
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvMRP"].Value = Math.Round(Convert.ToDecimal(item["mrp"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvCopies"].Value = 0;
                                            dgvBarcodePrinting.Rows[dgvBarcodePrinting.Rows.Count - 1].Cells["dgvPurchaseRate"].Value = item["purchaseRate"].ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for BatchComboFill
        /// </summary>
        /// <param name="cmbBatch"></param>
        public void BatchComboFill(ComboBox cmbBatch)
        {
            BatchBll BllBatch = new BatchBll();
            try
            {
                if (cmbProductCode.SelectedIndex != -1)
                {
                    if (cmbProductCode.SelectedValue.ToString() != "System.Data.DataRowView" && cmbProductCode.Text != "System.Data.DataRowView")
                    {
                        cmbBatch.Enabled = true;
                        BllBatch.BatchViewAllByProductCodeForBarcodePrinting(Convert.ToDecimal(cmbProductCode.SelectedValue.ToString()), cmbBatch, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Create an Instance for frmBarcodePrinting
        /// </summary>
        public frmBarcodePrinting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when Form Load call the clear function to clear the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBarcodePrinting_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// button ExportToPdf Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBarcodePrinting.Rows.Count > 0)
                {
                    if (decTotal != 0)
                    {
                        if (cmbFormat.Text == "A4")
                        {
                            if (dgvBarcodePrinting.Rows[inRowIndex].Cells["dgvCopies"].Value != null)
                            {
                                ExportToPDF();
                            }
                        }
                        else
                        {
                            ExportToPDFforThermalPrinter();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter number of copies to Print", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("NO Data To Print", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageClose)
                {
                    Messages.CloseMessage(this);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBarcodePrinting.Rows.Clear();
                BarcodePrintingGrideFill();
                serialNoGeneration();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        /// <summary>
        /// ProductCode Combobox index changed to make batch combo Enable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductCode_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                BatchComboFill(cmbBatch);
                if (cmbProductCode.SelectedIndex == 0)
                {
                    cmbBatch.Enabled = false;
                }
                else
                {
                    cmbBatch.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        ///  Grid cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBarcodePrinting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    inRowIndex = dgvBarcodePrinting.CurrentRow.Index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid CellValueChanged for Get count or no of copies to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBarcodePrinting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (dgvBarcodePrinting.Columns[e.ColumnIndex].Name == "dgvCopies")
                    {
                        if (!dgvBarcodePrinting.Rows[e.RowIndex].Cells["dgvCopies"].ReadOnly && dgvBarcodePrinting.Rows[e.RowIndex].Cells["dgvCopies"].Value != null && dgvBarcodePrinting.Rows[e.RowIndex].Cells["dgvCopies"].Value.ToString() != "")
                        {
                            TotalCountOfCopies();
                        }
                        else
                        {
                            dgvBarcodePrinting.Rows[e.RowIndex].Cells["dgvCopies"].Value = 0;
                            TotalCountOfCopies();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To commit each and every changes in cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBarcodePrinting_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBarcodePrinting.IsCurrentCellDirty)
                {
                    dgvBarcodePrinting.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Call the Key press event for handling each cells in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBarcodePrinting_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                TextBoxControl.KeyPress += new KeyPressEventHandler(TextBoxControl_KeyPress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// No Validation in No Of Copies Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TextBoxControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvBarcodePrinting.CurrentCell != null)
                {
                    if (dgvBarcodePrinting.Columns[dgvBarcodePrinting.CurrentCell.ColumnIndex].Name == "dgvCopies")
                    {
                        Common.NumberOnly(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation

        /// <summary>
        /// Form Key Down For Quick Access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBarcodePrinting_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnClear.Enabled)
                    {
                        btnClear.Focus();
                    }
                    else if (dgvBarcodePrinting.Enabled)
                    {
                        dgvBarcodePrinting.Focus();
                    }
                    else if (cmbFormat.Enabled)
                    {
                        cmbFormat.Focus();
                    }
                    else if (btnExportToPdf.Enabled)
                    {
                        btnExportToPdf.Focus();
                    }
                    else if (btnClose.Enabled)
                    {
                        btnClose.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvBarcodePrinting.Enabled)
                    {
                        dgvBarcodePrinting.Focus();
                    }
                    else if (cmbFormat.Enabled)
                    {
                        cmbFormat.Focus();
                    }
                    else if (btnExportToPdf.Enabled)
                    {
                        btnExportToPdf.Focus();
                    }
                    else if (btnClose.Enabled)
                    {
                        btnClose.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBarcodePrinting_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvBarcodePrinting.Rows.Count > 1)
                    {
                        if (dgvBarcodePrinting.CurrentCell != dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvCopies"].Index, dgvBarcodePrinting.CurrentRow.Index])
                        {
                            e.Handled = true;
                            SendKeys.Send("{TAB}");
                        }
                        else
                        {
                            if (dgvBarcodePrinting.CurrentRow.Index + 1 != dgvBarcodePrinting.Rows.Count)
                            {
                                dgvBarcodePrinting.CurrentCell = dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvSNo"].Index, dgvBarcodePrinting.CurrentRow.Index];
                            }
                            else
                            {
                                cmbFormat.Focus();
                                dgvBarcodePrinting.ClearSelection();
                                e.Handled = true;
                            }
                        }
                    }
                    else
                    {
                        if (dgvBarcodePrinting.CurrentCell != dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvCopies"].Index, dgvBarcodePrinting.CurrentRow.Index])
                        {
                            e.Handled = true;
                            SendKeys.Send("{TAB}");
                        }
                        else
                        {
                            cmbFormat.Focus();
                            dgvBarcodePrinting.ClearSelection();
                            e.Handled = true;
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvBarcodePrinting.CurrentCell == dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvSNo"].Index, 0])
                    {
                        if (cmbPurchaseInvoiceNo.Enabled)
                        {
                            cmbPurchaseInvoiceNo.Focus();
                        }
                        else if (cmbBatch.Enabled)
                        {
                            cmbBatch.Focus();
                        }
                        else if (cmbProductCode.Enabled)
                        {
                            cmbProductCode.Focus();
                        }
                    }
                    else
                    {
                        if (dgvBarcodePrinting.CurrentRow.Index > 0)
                        {
                            if (dgvBarcodePrinting.CurrentCell != dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvSNo"].Index, dgvBarcodePrinting.CurrentRow.Index])
                            {
                                dgvBarcodePrinting.CurrentCell = dgvBarcodePrinting[dgvBarcodePrinting.CurrentCell.ColumnIndex - 1, dgvBarcodePrinting.CurrentRow.Index];
                            }
                            else
                            {
                                dgvBarcodePrinting.CurrentCell = dgvBarcodePrinting[dgvBarcodePrinting.Columns["dgvSNo"].Index, dgvBarcodePrinting.CurrentRow.Index - 1];
                            }
                        }
                        else
                        {
                            dgvBarcodePrinting.CurrentCell = dgvBarcodePrinting[dgvBarcodePrinting.CurrentCell.ColumnIndex - 1, dgvBarcodePrinting.CurrentRow.Index];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFormat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvBarcodePrinting.Enabled)
                    {
                        dgvBarcodePrinting.Focus();
                    }
                    else if (cmbPurchaseInvoiceNo.Enabled)
                    {
                        cmbPurchaseInvoiceNo.Focus();
                    }
                    else if (cmbBatch.Enabled)
                    {
                        cmbBatch.Focus();
                    }
                    else if (cmbProductCode.Enabled)
                    {
                        cmbProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbBatch.Enabled)
                    {
                        cmbBatch.Focus();
                    }
                    else if (cmbPurchaseInvoiceNo.Enabled)
                    {
                        cmbPurchaseInvoiceNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPurchaseInvoiceNo.Enabled)
                    {
                        cmbPurchaseInvoiceNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbProductCode.Enabled)
                    {
                        cmbProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter Key And BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPurchaseInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbBatch.Enabled)
                    {
                        cmbBatch.Focus();
                    }
                    else if (cmbProductCode.Enabled)
                    {
                        cmbProductCode.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvBarcodePrinting.Enabled)
                    {
                        dgvBarcodePrinting.Focus();
                    }
                    else if (cmbFormat.Enabled)
                    {
                        cmbFormat.Focus();
                    }
                    else if (btnExportToPdf.Enabled)
                    {
                        btnExportToPdf.Focus();
                    }
                    else if (btnClose.Enabled)
                    {
                        btnClose.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
  
        #endregion
    }
}
