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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmCompanyCreation : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        byte[] logo = null;
        int inNarrationCount = 0;
        frmCurrencyDetails frmCurrencyObj;
        bool isEditMode = false;
        string strPath;
        bool isExternalDrive = false;
        frmLoading f1 = null;
        decimal decCurrencyIdForStatus = 0;
        #endregion
        #region Function
        /// <summary>
        /// creates instance of frmcompanyCreation class
        /// </summary>
        public frmCompanyCreation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function for Save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                CompanyInfo infoCompany = new CompanyInfo();
                CompanyCreationBll BllCompanyCreation = new CompanyCreationBll();
                CompanyPathInfo infoCompanyPath = new CompanyPathInfo();
                CompanyPathBll BllCompanyPath = new CompanyPathBll();
                UserInfo infoUser = new UserInfo();
                UserBll bllUser = new UserBll();
                ExchangeRateInfo infoExchangeRate = new ExchangeRateInfo();
                //ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                infoCompany.CompanyName = txtCompanyName.Text.Trim();
                infoCompany.MailingName = txtMailingName.Text.Trim();
                infoCompany.Address = txtAddress.Text.Trim();
                infoCompany.Phone = txtPhoneNo.Text.Trim();
                infoCompany.Mobile = txtMobile.Text.Trim();
                infoCompany.EmailId = txtEmail.Text.Trim();
                infoCompany.Web = txtWeb.Text.Trim();
                infoCompany.Country = txtCountry.Text.Trim();
                infoCompany.State = txtState.Text.Trim();
                infoCompany.Pin = txtPincode.Text.Trim();
                infoCompany.CurrencyId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                decCurrencyIdForStatus = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoCompany.FinancialYearFrom = Convert.ToDateTime(txtFinancialYearFrom.Text.Trim().ToString());
                infoCompany.BooksBeginingFrom = Convert.ToDateTime(txtBooksBegining.Text.Trim().ToString());
                infoCompany.Tin = txtTinNo.Text.Trim();
                infoCompany.Cst = txtCstNo.Text.Trim();
                infoCompany.Pan = txtPanNo.Text.Trim();
                infoCompany.CurrentDate = DateTime.Now;
                infoCompany.Logo = logo;
                infoCompany.Extra1 = string.Empty;
                infoCompany.Extra2 = string.Empty;
                infoCompanyPath.CompanyName = txtCompanyName.Text.Trim();
                infoCompanyPath.IsDefault = cbxSetAsDefault.Checked;
                infoCompanyPath.Extra1 = string.Empty;
                infoCompanyPath.Extra2 = string.Empty;
                infoUser.UserName = txtAdminUserName.Text.Trim();
                infoUser.Password = txtPassword.Text.Trim();
                infoUser.Active = true;
                infoUser.Extra1 = string.Empty;
                infoUser.Extra2 = string.Empty;
                infoUser.Narration = string.Empty;
                infoUser.RoleId = 1;
                if (BllCompanyCreation.CompanyCheckExistence(txtCompanyName.Text.Trim().ToString(), 0) == false)
                {
                    decimal decCompanyId = BllCompanyCreation.CompanyAddParticularFeilds(infoCompany);
                    PublicVariables._decCurrentCompanyId = decCompanyId;
                    infoCompanyPath.CompanyPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                    BllCompanyPath.CompanyPathAdd(infoCompanyPath);
                    if (formMDI.demoProject || CreateCompany())
                    {
                        if (!formMDI.demoProject)
                        {
                            infoCompanyPath.CompanyPath = strPath;
                        }
                        else
                        {
                            infoCompanyPath.CompanyPath = Application.StartupPath + "\\Data";
                            PublicVariables._decCurrentCompanyId = 0;
                        }
                        CompanyInfo infoNewCompany = new CompanyInfo();
                        CompanyPathInfo infoNewCompanyPath = new CompanyPathInfo();
                        UserInfo infoNewUser = new UserInfo();
                        UserBll bllNewUser = new UserBll();
                        ExchangeRateInfo infoNewExchangeRate = new ExchangeRateInfo();
                        ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                        CompanyPathBll BllNewCompanyPath = new CompanyPathBll();
                        infoNewCompany = infoCompany;
                        infoNewCompanyPath = infoCompanyPath;
                        infoNewUser = infoUser;
                        decCompanyId = BllCompanyCreation.CompanyAddParticularFeilds(infoNewCompany);
                        bllNewUser.UserAdd(infoNewUser);
                        BllNewCompanyPath.CompanyPathAdd(infoNewCompanyPath);
                        Messages.SavedMessage();
                        formMDI.MDIObj.MenuStripEnabling();
                        //  To set default currencyId.............//
                        infoNewExchangeRate.CurrencyId = infoNewCompany.CurrencyId;
                        infoNewExchangeRate.Rate = 1;
                        infoNewExchangeRate.Narration = string.Empty;
                        infoNewExchangeRate.Extra1 = string.Empty;
                        infoNewExchangeRate.Extra2 = string.Empty;
                        infoNewExchangeRate.ExtraDate = System.DateTime.Now;
                        infoNewExchangeRate.Date = System.DateTime.Now;
                        BllExchangeRate.ExchangeRateAdd(infoNewExchangeRate);
                        CurrencyBll BllCurrency = new CurrencyBll();
                        BllCurrency.DefaultCurrencySet(decCurrencyIdForStatus);
                        AfterCompanyCreation();
                        Clear();
                        this.Close();
                    }
                    else
                    {
                        Messages.InformationMessage("Company creation failed");
                    }
                }
                else
                {
                    Messages.InformationMessage("Companyname already exist");
                    txtCompanyName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                CompanyInfo infoCompany = new CompanyInfo();
                CompanyCreationBll BllCompanyCreation = new CompanyCreationBll();
                CompanyPathInfo infoCompanyPath = new CompanyPathInfo();
                CompanyPathBll BllCompanyPath = new CompanyPathBll();
                UserInfo infoUser = new UserInfo();
                UserBll bllUser = new UserBll();
                infoCompany.CompanyName = txtCompanyName.Text.Trim();
                infoCompany.MailingName = txtMailingName.Text.Trim();
                infoCompany.Address = txtAddress.Text.Trim();
                infoCompany.Phone = txtPhoneNo.Text.Trim();
                infoCompany.Mobile = txtMobile.Text.Trim();
                infoCompany.EmailId = txtEmail.Text.Trim();
                infoCompany.Web = txtWeb.Text.Trim();
                infoCompany.Country = txtCountry.Text.Trim();
                infoCompany.State = txtState.Text.Trim();
                infoCompany.Pin = txtPincode.Text.Trim();
                infoCompany.CurrencyId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoCompany.FinancialYearFrom = Convert.ToDateTime(txtFinancialYearFrom.Text.Trim().ToString());
                infoCompany.BooksBeginingFrom = Convert.ToDateTime(txtBooksBegining.Text.Trim().ToString());
                infoCompany.Tin = txtTinNo.Text.Trim();
                infoCompany.Cst = txtCstNo.Text.Trim();
                infoCompany.Pan = txtPanNo.Text.Trim();
                infoCompany.CurrentDate = DateTime.Now;
                infoCompany.Logo = logo;
                infoCompany.Extra1 = string.Empty;
                infoCompany.Extra2 = string.Empty;
                infoCompanyPath.CompanyName = txtCompanyName.Text.Trim();
                infoCompanyPath.IsDefault = cbxSetAsDefault.Checked;
                strPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                infoCompanyPath.CompanyPath = strPath;
                infoCompanyPath.Extra1 = string.Empty;
                infoCompanyPath.Extra2 = string.Empty;
                infoCompanyPath.ExtraDate = DateTime.Now;
                infoCompanyPath.CompanyId = 1;
                infoCompany.CompanyId = 1;
                BllCompanyCreation.CompanyEdit(infoCompany);
                BllCompanyPath.CompanyPathEdit(infoCompanyPath);
                Messages.UpdatedMessage();
                //  To set default currencyId...........In exchangeRate..//
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                ExchangeRateInfo infoExchangeRate = new ExchangeRateInfo();
                infoExchangeRate.ExchangeRateId = 1;
                infoExchangeRate.Date = PublicVariables._dtCurrentDate;
                infoExchangeRate.CurrencyId = infoCompany.CurrencyId;
                infoExchangeRate.ExtraDate = PublicVariables._dtCurrentDate;
                infoExchangeRate.Narration = string.Empty;
                infoExchangeRate.Rate = 1;
                infoExchangeRate.Extra1 = string.Empty;
                infoExchangeRate.Extra2 = string.Empty;
                BllExchangeRate.ExchangeRateEdit(infoExchangeRate);
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                FinancialYearBll BllFinancialYear = new FinancialYearBll();
                decimal decIdentity;
                infoFinancialYear.FromDate = PublicVariables._dtFromDate;
                infoFinancialYear.ToDate = PublicVariables._dtToDate;
                infoFinancialYear.ExtraDate = DateTime.Now;
                infoFinancialYear.Extra1 = string.Empty;
                infoFinancialYear.Extra2 = string.Empty;
                bool isExist = BllFinancialYear.FinancialYearExistenceCheck(PublicVariables._dtFromDate, PublicVariables._dtToDate);
                if (!isExist)
                {
                    decIdentity = BllFinancialYear.FinancialYearAddWithReturnIdentity(infoFinancialYear);
                }
                //===========Add companyDetails in ExternalDb =====================//
                decimal decCompanyIdForTemp = PublicVariables._decCurrentCompanyId;
                PublicVariables._decCurrentCompanyId = 0;
                CompanyCreationBll bllExCompanyCreation = new CompanyCreationBll();
                CompanyPathBll bllExCompanyPath = new CompanyPathBll();
                CompanyInfo infoExCompany = new CompanyInfo();
                CompanyPathInfo infoExCompanyPath = new CompanyPathInfo();
                infoExCompany = infoCompany;
                infoExCompanyPath = infoCompanyPath;
                infoExCompany.CompanyId = decCompanyIdForTemp;
                infoExCompanyPath.CompanyId = decCompanyIdForTemp;
                bllExCompanyCreation.CompanyEdit(infoExCompany);
                bllExCompanyPath.CompanyPathEdit(infoExCompanyPath);
                PublicVariables._decCurrentCompanyId = decCompanyIdForTemp;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtCompanyName.Text.Trim() == String.Empty)
                {
                    Messages.InformationMessage("Enter companyname");
                    txtCompanyName.Focus();
                }
                else if (cmbCurrency.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select currency");
                    cmbCurrency.Focus();
                }
                else if (txtAdminUserName.Text.Trim() == String.Empty)
                {
                    Messages.InformationMessage("Enter username");
                    txtAdminUserName.Focus();
                }
                else if (txtPassword.Text.Trim() == String.Empty)
                {
                    Messages.InformationMessage("Enter password");
                    txtPassword.Focus();
                }
                else if (txtRetypePassword.Text.Trim() == String.Empty)
                {
                    Messages.InformationMessage("Enter retypepassword");
                    txtRetypePassword.Focus();
                }
                else if (txtPassword.Text != txtRetypePassword.Text)
                {
                    Messages.InformationMessage("Password doesn't match");
                    txtRetypePassword.Focus();
                }
                else
                {
                    if (this.Text == "Company Creation")
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                SaveFunction();
                            }
                        }
                        else
                        {
                            SaveFunction();
                        }
                    }
                    else
                    {
                        if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                EditFunction();
                            }
                        }
                        else
                        {
                            EditFunction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the Image
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        byte[] ReadFile(String strPath)
        {
            byte[] data = null;
            try
            {
                FileInfo fInfo = new FileInfo(strPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(strPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                data = br.ReadBytes((int)numBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return data;
        }
        /// <summary>
        /// Function to fill the default image
        /// </summary>
        public void GetDefaultImage()
        {
            try
            {
                String strImagepath = Application.StartupPath + "\\images.jpg";
                logo = ReadFile(strImagepath);
                MemoryStream ms = new MemoryStream(logo);
                Image newimage = Image.FromStream(ms);
                pbxLogo.Image = newimage;
                pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllCurrency.CurrencyViewAllForCombo();
                cmbCurrency.DataSource = listObj[0];
                cmbCurrency.ValueMember = "currencyId";
                cmbCurrency.DisplayMember = "currencyName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                if (!isEditMode)
                {
                   
                    this.Text = "Company Creation";
                    txtAddress.Clear();
                    txtAdminUserName.Clear();
                    txtCompanyName.Clear();
                    txtCountry.Clear();
                    txtCstNo.Clear();
                    txtEmail.Clear();
                    txtMailingName.Clear();
                    txtMobile.Clear();
                    txtPanNo.Clear();
                    txtPassword.Clear();
                    txtPhoneNo.Clear();
                    txtPincode.Clear();
                    txtRetypePassword.Clear();
                    txtState.Clear();
                    txtTinNo.Clear();
                    txtWeb.Clear();
                    btnDelete.Enabled = false;
                    cmbCurrency.SelectedIndex = -1;
                     txtFinancialYearFrom.Text = System.DateTime.Now.ToString("dd-MMM-yyyy");
                    txtBooksBegining.Text = System.DateTime.Now.ToString("dd-MMM-yyyy");
                    cbxSetAsDefault.Checked = false;
                    GetDefaultImage();
                }
                else
                {
                    CompanyViewForEdit();
                }
                txtCompanyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls for Update
        /// </summary>
        public void CompanyViewForEdit()
        {
            try
            {
                isEditMode = true;
                this.Text = "Edit Company";
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                gbxDetails.Visible = false;
                txtAdminUserName.ReadOnly = true;
                txtAdminUserName.BackColor = Color.White;
                cmbCurrency.Enabled = false;
                CompanyCreationBll BllCompanyCreation = new CompanyCreationBll();
                CompanyInfo infoCompany = new CompanyInfo();
                decimal decCompanyId = 1;
                infoCompany = BllCompanyCreation.CompanyView(PublicVariables._decCurrentCompanyId);
                txtCompanyName.Text = infoCompany.CompanyName;
                txtMailingName.Text = infoCompany.MailingName;
                txtAddress.Text = infoCompany.Address;
                txtPhoneNo.Text = infoCompany.Phone;
                txtMobile.Text = infoCompany.Mobile;
                txtEmail.Text = infoCompany.EmailId;
                txtWeb.Text = infoCompany.Web;
                txtCountry.Text = infoCompany.Country;
                txtState.Text = infoCompany.State;
                txtPincode.Text = infoCompany.Pin;
                cmbCurrency.SelectedValue = infoCompany.CurrencyId;
                txtFinancialYearFrom.Text = infoCompany.FinancialYearFrom.ToString("dd-MMM-yyyy");
                dtpFinancialYearFrom.Text = infoCompany.FinancialYearFrom.ToString();
                txtBooksBegining.Text = infoCompany.BooksBeginingFrom.ToString("dd-MMM-yyyy");
                dtpBooksBegining.Text = infoCompany.BooksBeginingFrom.ToString();
                txtTinNo.Text = infoCompany.Tin;
                txtCstNo.Text = infoCompany.Cst;
                txtPanNo.Text = infoCompany.Pan;
                logo = (byte[])infoCompany.Logo;
                MemoryStream ms = new MemoryStream(logo);
                Image newimage = Image.FromStream(ms);
                pbxLogo.Image = newimage;
                pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                CompanyPathInfo infoCompanyPath = new CompanyPathInfo();
                CompanyPathBll BllComapnyPath = new CompanyPathBll();
                infoCompanyPath = BllComapnyPath.CompanyPathView(1);
                if (infoCompanyPath.IsDefault == true)
                {
                    cbxSetAsDefault.Checked = true;
                }
                else
                {
                    cbxSetAsDefault.Checked = false;
                }
                UserBll bllUser = new UserBll();
                UserInfo infoUser = new UserInfo();
                decimal decuserId = PublicVariables._decCurrentUserId;
                infoUser = bllUser.UserView(decuserId);
                txtAdminUserName.Text = infoUser.UserName;
                txtPassword.Text = infoUser.Password;
                txtRetypePassword.Text = infoUser.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmCurrencyDetails form to select and view Currencies
        /// </summary>
        /// <param name="frmCurrencyDetails"></param>
        /// <param name="decId"></param>
        public void CallFromCurrenCyDetails(frmCurrencyDetails frmCurrencyDetails, decimal decId) //PopUp
        {
            try
            {
                base.Show();
                this.frmCurrencyObj = frmCurrencyDetails;
                cmbCurrency.SelectedValue = decId;
                cmbCurrency.Focus();
                frmCurrencyObj.Close();
                frmCurrencyObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Create database for new company
        /// </summary>
        /// <returns></returns>
        public bool CreateCompany()
        {
            try
            {
                backgroundWorker1.RunWorkerAsync();
                f1 = new frmLoading();
                f1.ShowDialog();              
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }  
        /// <summary>
        /// Function to load the form while calling from formMdi
        /// </summary>
        public void CallFromFormMdi()
        {
            try
            {
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
        /// <summary>
        /// Function to do after company creation
        /// </summary>
        public void AfterCompanyCreation()
        {
            try
            {
                PublicVariables._decCurrentUserId = 1;
                formMDI.MDIObj.CallFromLogin();
                formMDI.MDIObj.ShowQuickLaunchMenu();
                frmNewFinancialYear frmNewFinancialYearObj = new frmNewFinancialYear();
                frmNewFinancialYearObj.MdiParent = formMDI.MDIObj;
                frmNewFinancialYearObj.CallFromCompanyCreation(this);
                CompanyInfo infoCompany = new CompanyInfo();
                CompanyCreationBll BllCompanyCreation = new CompanyCreationBll();
                infoCompany = BllCompanyCreation.CompanyView(1);
                PublicVariables._decCurrencyId = infoCompany.CurrencyId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// Function to delete a company
       /// </summary>
        public void DeleteFunction()
        {
            try
            {
                decimal decCompanyIdForTemp = PublicVariables._decCurrentCompanyId;
                CompanyCreationBll BllCompanyCreation = new CompanyCreationBll();
                PublicVariables._decCurrentCompanyId = 0;
                CompanyCreationBll bllExCompanyCreation = new CompanyCreationBll();
                CompanyPathBll bllExCompanyPath = new CompanyPathBll();
                bllExCompanyCreation.CompanyDelete(decCompanyIdForTemp);
                bllExCompanyPath.CompanyPathDelete(decCompanyIdForTemp);
                Messages.DeletedMessage();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCompanyCreation_Load(object sender, EventArgs e)
        {
            try
            {
                CurrencyComboFill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On close button click
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
                MessageBox.Show("CR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For browsing company logo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdCompany = new OpenFileDialog();
            ofdCompany.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            ofdCompany.FileName = string.Empty;
            if (DialogResult.OK == ofdCompany.ShowDialog())
            {
                if (ofdCompany.FileName != string.Empty)
                {
                    try
                    {
                        logo = ReadFile(ofdCompany.FileName);
                        MemoryStream ms = new MemoryStream(logo);
                        Image newimage = Image.FromStream(ms);
                        pbxLogo.Image = newimage;
                        pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// On clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                GetDefaultImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.Text == "Company Creation")
                {
                    SaveOrEdit();
                }
                else
                {
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                    {
                        SaveOrEdit();
                    }
                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// setting txtFinancialYearFrom textbox while changing dtpFinancialYearFrom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFinancialYearFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtFinancialYearFrom.Text = this.dtpFinancialYearFrom.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtFinancialyearFrom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFinancialyearFrom_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtFinancialYearFrom);
                if (!isInvalid)
                {
                    txtFinancialYearFrom.Text = System.DateTime.Now.ToString("dd-MMM-yyyy");
                }
                string date = txtFinancialYearFrom.Text;
                dtpFinancialYearFrom.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpBooksBegining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpBooksBegining_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtBooksBegining.Text = this.dtpBooksBegining.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtBooksBegining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBooksBegining_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtBooksBegining);
                if (!isInvalid)
                {
                    txtBooksBegining.Text = System.DateTime.Now.ToString("dd-MMM-yyyy");
                }
                string date = txtBooksBegining.Text;
                dtpBooksBegining.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On entering txtAddress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtAddress.Text = txtAddress.Text.Trim();
                if (txtAddress.Text == string.Empty)
                {
                    txtAddress.SelectionStart = 0;
                    txtAddress.Focus();
                }
                else
                {
                    txtAddress.SelectionStart = txtAddress.Text.Length;
                    txtAddress.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On textChanged of txtBooksBegining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBooksBegining_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBooksBegining.Text.Trim() == string.Empty)
                {
                    txtBooksBegining_Leave(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  On textChanged of txtFinancialYearFrom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFinancialYearFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// creates company 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                strPath = string.Empty;
                if (formMDI.DBConnectionType != "Single-User")
                {
                    isExternalDrive = false;
                    string strServer = File.ReadAllText(Application.StartupPath + "\\sys.txt");
                    if (File.Exists(strServer + "\\" + Application.StartupPath + "\\file.txt"))
                    {
                        strPath = File.ReadAllText(strServer + "\\" + Application.StartupPath + "\\file.txt");
                        if (strPath != null && strPath != string.Empty)
                        {
                            strPath = strServer + "\\" + strPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                            isExternalDrive = true;
                        }
                    }
                    if (!isExternalDrive)
                    {
                        if (formMDI.isEstimateDB && formMDI.strEstimateCompanyPath != string.Empty)
                        {
                            strPath = formMDI.strEstimateCompanyPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                        }
                        else
                        {
                            strPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                        }
                    }
                }
                DirectoryInfo infoDirectory = new DirectoryInfo(strPath);
                if (!infoDirectory.Exists)
                {
                    infoDirectory.Create();
                }
                //Copying empty database to new created directory
                string strSourcePath = Application.StartupPath + "\\Data\\" + "COMP";
                string strTargetPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                File.Copy(strSourcePath + "\\DBOpenMiracle.mdf", strTargetPath + "\\DBOpenMiracle.mdf");
                File.Copy(strSourcePath + "\\DBOpenMiracle_log.ldf", strTargetPath + "\\DBOpenMiracle_log.ldf");
                strPath = Application.StartupPath + "\\Data\\" + PublicVariables._decCurrentCompanyId;
                FileInfo SourceMDFinfo = new FileInfo(strPath + "\\DBOpenMiracle.mdf");
                FileInfo SourceLDFinfo = new FileInfo(strPath + "\\DBOpenMiracle_log.ldf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On completion of background worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                f1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction();
                        }
                    }
                    else
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// For shortcut keys
        /// Esc for form close
        /// ctrl+s for Save
        /// ctrl+d for delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCompanyCreation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    
                    btnDelete_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of txtCompanyName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMailingName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// enterkey and backspace navigation of txtMailingName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMailingName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAddress.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMailingName.Text == string.Empty || txtMailingName.SelectionStart == 0)
                    {
                        txtCompanyName.Focus();
                        txtCompanyName.SelectionStart = 0;
                        txtCompanyName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtAddress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        txtPhoneNo.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtAddress.Text == string.Empty || txtAddress.SelectionStart == 0)
                    {
                        txtMailingName.Focus();
                        txtMailingName.SelectionLength = 0;
                        txtMailingName.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtPhoneNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmail.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPhoneNo.Text == string.Empty || txtPhoneNo.SelectionStart == 0)
                    {
                        txtAddress.Focus();
                        txtAddress.SelectionStart = 0;
                        txtAddress.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtEmail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobile.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmail.Text == string.Empty || txtEmail.SelectionStart == 0)
                    {
                        txtPhoneNo.Focus();
                        txtPhoneNo.SelectionStart = 0;
                        txtPhoneNo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtMobile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtWeb.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMobile.Text == string.Empty || txtMobile.SelectionStart == 0)
                    {
                        txtEmail.Focus();
                        txtEmail.SelectionStart = 0;
                        txtEmail.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtWeb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWeb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCountry.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtWeb.Text == string.Empty || txtWeb.SelectionStart == 0)
                    {
                        txtMobile.Focus();
                        txtMobile.SelectionStart = 0;
                        txtMobile.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtCountry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtState.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCountry.Text == string.Empty || txtCountry.SelectionStart == 0)
                    {
                        txtWeb.Focus();
                        txtWeb.SelectionStart = 0;
                        txtWeb.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtState
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtState_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPincode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtState.Text == string.Empty || txtState.SelectionStart == 0)
                    {
                        txtCountry.Focus();
                        txtCountry.SelectionStart = 0;
                        txtCountry.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtPincode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPincode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCurrency.Enabled == false)
                    {
                        txtFinancialYearFrom.Focus();
                    }
                    else
                    {
                        cmbCurrency.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPincode.Text == string.Empty || txtPincode.SelectionStart == 0)
                    {
                        txtState.Focus();
                        txtState.SelectionStart = 0;
                        txtState.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCurrency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFinancialYearFrom.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCurrency.Text == string.Empty || cmbCurrency.SelectionStart == 0)
                    {
                        txtPincode.Focus();
                        txtPincode.SelectionStart = 0;
                        txtPincode.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //POP UP
                {
                    frmCurrencyObj = new frmCurrencyDetails();
                    frmCurrencyObj.MdiParent = formMDI.MDIObj;
                    if (cmbCurrency.SelectedIndex >= 0)
                    {
                        frmCurrencyObj.CallFromCmpany(this, Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select currency");
                        cmbCurrency.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtTinNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTinNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPanNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTinNo.Text == string.Empty || txtTinNo.SelectionStart == 0)
                    {
                        txtBooksBegining.Focus();
                        txtBooksBegining.SelectionStart = 0;
                        txtBooksBegining.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtPanNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPanNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCstNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPanNo.Text == string.Empty || txtPanNo.SelectionStart == 0)
                    {
                        txtTinNo.Focus();
                        txtTinNo.SelectionStart = 0;
                        txtTinNo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtCstNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCstNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtAdminUserName.Visible == true)
                    {
                        txtAdminUserName.Focus();
                    }
                    else
                    {
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCstNo.Text == string.Empty || txtCstNo.SelectionStart == 0)
                    {
                        txtPanNo.Focus();
                        txtPanNo.SelectionStart = 0;
                        txtPanNo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtAdminUserName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdminUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtAdminUserName.Text == string.Empty || txtAdminUserName.SelectionStart == 0)
                    {
                        txtCstNo.Focus();
                        txtCstNo.SelectionStart = 0;
                        txtCstNo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRetypePassword.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPassword.Text == string.Empty || txtPassword.SelectionStart == 0)
                    {
                        txtAdminUserName.Focus();
                        txtAdminUserName.SelectionStart = 0;
                        txtAdminUserName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtRetypePassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRetypePassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRetypePassword.Text == string.Empty || txtRetypePassword.SelectionStart == 0)
                    {
                        txtPassword.Focus();
                        txtPassword.SelectionStart = 0;
                        txtPassword.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRetypePassword.Visible == true)
                    {
                        txtRetypePassword.Focus();
                        txtRetypePassword.SelectionLength = 0;
                        txtRetypePassword.SelectionStart = 0;
                    }
                    else
                    {
                        txtCstNo.Focus();
                        txtCstNo.SelectionLength = 0;
                        txtCstNo.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtFinancialyearFrom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFinancialyearFrom_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBooksBegining.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtFinancialYearFrom.Text == string.Empty || txtFinancialYearFrom.SelectionStart == 0)
                    {
                        if (cmbCurrency.Enabled == false)
                        {
                            txtPincode.Focus();
                            txtPincode.SelectionStart = 0;
                            txtPincode.SelectionLength = 0;
                        }
                        else
                        {
                            cmbCurrency.Focus();
                            cmbCurrency.SelectionStart = 0;
                            cmbCurrency.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtBooksBegining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBooksBegining_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtTinNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBooksBegining.Text == string.Empty || txtBooksBegining.SelectionStart == 0)
                    {
                        txtFinancialYearFrom.Focus();
                        txtFinancialYearFrom.SelectionStart = 0;
                        txtFinancialYearFrom.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnReset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnDelete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnClose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnDelete.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        
    }
}
