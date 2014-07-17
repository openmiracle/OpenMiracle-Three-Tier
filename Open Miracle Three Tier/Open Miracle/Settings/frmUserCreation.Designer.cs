namespace Open_Miracle
{
    partial class frmUserCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCreation));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRetype = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.lblSearchUserName = new System.Windows.Forms.Label();
            this.cmbSearchRole = new System.Windows.Forms.ComboBox();
            this.lblSearchRole = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUserCreation = new System.Windows.Forms.DataGridView();
            this.dgvtxtSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserNameValidator = new System.Windows.Forms.Label();
            this.lblPasswordValidator = new System.Windows.Forms.Label();
            this.lblRoleVlidator = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.lblRetypeValidator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCreation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(686, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(594, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(503, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(412, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(535, 108);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.Color.White;
            this.lblNarration.Location = new System.Drawing.Point(429, 108);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 1206;
            this.lblNarration.Text = "Narration";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(33, 64);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1205;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(33, 39);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 1203;
            this.lblUserName.Text = "User Name";
            // 
            // lblRetype
            // 
            this.lblRetype.AutoSize = true;
            this.lblRetype.ForeColor = System.Drawing.Color.White;
            this.lblRetype.Location = new System.Drawing.Point(429, 64);
            this.lblRetype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRetype.Name = "lblRetype";
            this.lblRetype.Size = new System.Drawing.Size(93, 13);
            this.lblRetype.TabIndex = 1215;
            this.lblRetype.Text = "Re-type Password";
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(535, 35);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 21);
            this.cmbRole.TabIndex = 2;
            this.cmbRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRole_KeyDown);
            this.cmbRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRole_KeyPress);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(429, 39);
            this.lblRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 1213;
            this.lblRole.Text = "Role";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 35);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 60);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(535, 60);
            this.txtRetype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(200, 20);
            this.txtRetype.TabIndex = 4;
            this.txtRetype.UseSystemPasswordChar = true;
            this.txtRetype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRetype_KeyDown);
            this.txtRetype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetype_KeyPress);
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(139, 236);
            this.txtSearchUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchUserName.TabIndex = 1220;
            this.txtSearchUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchUserName_KeyDown);
            // 
            // lblSearchUserName
            // 
            this.lblSearchUserName.AutoSize = true;
            this.lblSearchUserName.ForeColor = System.Drawing.Color.White;
            this.lblSearchUserName.Location = new System.Drawing.Point(33, 240);
            this.lblSearchUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSearchUserName.Name = "lblSearchUserName";
            this.lblSearchUserName.Size = new System.Drawing.Size(60, 13);
            this.lblSearchUserName.TabIndex = 1219;
            this.lblSearchUserName.Text = "User Name";
            // 
            // cmbSearchRole
            // 
            this.cmbSearchRole.Location = new System.Drawing.Point(566, 236);
            this.cmbSearchRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSearchRole.Name = "cmbSearchRole";
            this.cmbSearchRole.Size = new System.Drawing.Size(200, 21);
            this.cmbSearchRole.TabIndex = 1221;
            this.cmbSearchRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchRole_KeyDown);
            this.cmbSearchRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSearchRole_KeyPress);
            // 
            // lblSearchRole
            // 
            this.lblSearchRole.AutoSize = true;
            this.lblSearchRole.ForeColor = System.Drawing.Color.White;
            this.lblSearchRole.Location = new System.Drawing.Point(460, 240);
            this.lblSearchRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSearchRole.Name = "lblSearchRole";
            this.lblSearchRole.Size = new System.Drawing.Size(29, 13);
            this.lblSearchRole.TabIndex = 1222;
            this.lblSearchRole.Text = "Role";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearchClear.FlatAppearance.BorderSize = 0;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(657, 263);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(85, 27);
            this.btnSearchClear.TabIndex = 1224;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(566, 263);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 1223;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvUserCreation
            // 
            this.dgvUserCreation.AllowUserToAddRows = false;
            this.dgvUserCreation.AllowUserToResizeColumns = false;
            this.dgvUserCreation.AllowUserToResizeRows = false;
            this.dgvUserCreation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserCreation.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserCreation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserCreation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserCreation.ColumnHeadersHeight = 35;
            this.dgvUserCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserCreation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSLNo,
            this.dgvtxtRoleId,
            this.dgvtxtUserId,
            this.dgvtxtUserName,
            this.dgvtxtRole});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserCreation.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserCreation.EnableHeadersVisualStyles = false;
            this.dgvUserCreation.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUserCreation.Location = new System.Drawing.Point(36, 296);
            this.dgvUserCreation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvUserCreation.Name = "dgvUserCreation";
            this.dgvUserCreation.ReadOnly = true;
            this.dgvUserCreation.RowHeadersVisible = false;
            this.dgvUserCreation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserCreation.Size = new System.Drawing.Size(730, 278);
            this.dgvUserCreation.TabIndex = 1225;
            this.dgvUserCreation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserCreation_CellDoubleClick);
            this.dgvUserCreation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUserCreation_KeyDown);
            this.dgvUserCreation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvUserCreation_KeyUp);
            // 
            // dgvtxtSLNo
            // 
            this.dgvtxtSLNo.DataPropertyName = "SL.No";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtSLNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSLNo.HeaderText = "Sl No";
            this.dgvtxtSLNo.Name = "dgvtxtSLNo";
            this.dgvtxtSLNo.ReadOnly = true;
            this.dgvtxtSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRoleId
            // 
            this.dgvtxtRoleId.DataPropertyName = "roleId";
            this.dgvtxtRoleId.HeaderText = "RoleId";
            this.dgvtxtRoleId.Name = "dgvtxtRoleId";
            this.dgvtxtRoleId.ReadOnly = true;
            this.dgvtxtRoleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRoleId.Visible = false;
            // 
            // dgvtxtUserId
            // 
            this.dgvtxtUserId.DataPropertyName = "userId";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtUserId.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtUserId.HeaderText = "UserId";
            this.dgvtxtUserId.Name = "dgvtxtUserId";
            this.dgvtxtUserId.ReadOnly = true;
            this.dgvtxtUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUserId.Visible = false;
            // 
            // dgvtxtUserName
            // 
            this.dgvtxtUserName.DataPropertyName = "userName";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtUserName.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtUserName.HeaderText = "User Name";
            this.dgvtxtUserName.Name = "dgvtxtUserName";
            this.dgvtxtUserName.ReadOnly = true;
            this.dgvtxtUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRole
            // 
            this.dgvtxtRole.DataPropertyName = "role";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtRole.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtRole.HeaderText = "Role";
            this.dgvtxtRole.Name = "dgvtxtRole";
            this.dgvtxtRole.ReadOnly = true;
            this.dgvtxtRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblUserNameValidator
            // 
            this.lblUserNameValidator.AutoSize = true;
            this.lblUserNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameValidator.Location = new System.Drawing.Point(347, 39);
            this.lblUserNameValidator.Name = "lblUserNameValidator";
            this.lblUserNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblUserNameValidator.TabIndex = 1226;
            this.lblUserNameValidator.Text = "*";
            // 
            // lblPasswordValidator
            // 
            this.lblPasswordValidator.AutoSize = true;
            this.lblPasswordValidator.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidator.Location = new System.Drawing.Point(347, 64);
            this.lblPasswordValidator.Name = "lblPasswordValidator";
            this.lblPasswordValidator.Size = new System.Drawing.Size(11, 13);
            this.lblPasswordValidator.TabIndex = 1227;
            this.lblPasswordValidator.Text = "*";
            // 
            // lblRoleVlidator
            // 
            this.lblRoleVlidator.AutoSize = true;
            this.lblRoleVlidator.ForeColor = System.Drawing.Color.Red;
            this.lblRoleVlidator.Location = new System.Drawing.Point(737, 39);
            this.lblRoleVlidator.Name = "lblRoleVlidator";
            this.lblRoleVlidator.Size = new System.Drawing.Size(11, 13);
            this.lblRoleVlidator.TabIndex = 1228;
            this.lblRoleVlidator.Text = "*";
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.ForeColor = System.Drawing.Color.White;
            this.cbxActive.Location = new System.Drawing.Point(535, 86);
            this.cbxActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(56, 17);
            this.cbxActive.TabIndex = 1229;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = true;
            this.cbxActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxActive_KeyDown);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnRoleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoleAdd.FlatAppearance.BorderSize = 0;
            this.btnRoleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdd.Location = new System.Drawing.Point(746, 35);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(20, 20);
            this.btnRoleAdd.TabIndex = 1231;
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // lblRetypeValidator
            // 
            this.lblRetypeValidator.AutoSize = true;
            this.lblRetypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblRetypeValidator.Location = new System.Drawing.Point(737, 67);
            this.lblRetypeValidator.Name = "lblRetypeValidator";
            this.lblRetypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblRetypeValidator.TabIndex = 1232;
            this.lblRetypeValidator.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 191);
            this.groupBox1.TabIndex = 1233;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Creation";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 377);
            this.groupBox2.TabIndex = 1234;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // frmUserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblRetypeValidator);
            this.Controls.Add(this.btnRoleAdd);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.lblRoleVlidator);
            this.Controls.Add(this.lblPasswordValidator);
            this.Controls.Add(this.lblUserNameValidator);
            this.Controls.Add(this.dgvUserCreation);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchRole);
            this.Controls.Add(this.lblSearchRole);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.lblSearchUserName);
            this.Controls.Add(this.txtRetype);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblRetype);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmUserCreation";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Creation";
            this.Activated += new System.EventHandler(this.frmUserCreation_Activated);
            this.Load += new System.EventHandler(this.frmUserCreation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserCreation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCreation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRetype;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Label lblSearchUserName;
        private System.Windows.Forms.ComboBox cmbSearchRole;
        private System.Windows.Forms.Label lblSearchRole;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvUserCreation;
        private System.Windows.Forms.Label lblUserNameValidator;
        private System.Windows.Forms.Label lblPasswordValidator;
        private System.Windows.Forms.Label lblRoleVlidator;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.Label lblRetypeValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}