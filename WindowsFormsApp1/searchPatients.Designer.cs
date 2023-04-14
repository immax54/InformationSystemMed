namespace WindowsFormsApp1
{
    partial class searchPatients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchPatients));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialsecnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdatetimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.insuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new WindowsFormsApp1.DBDataSet();
            this.patientsTableAdapter = new WindowsFormsApp1.DBDataSetTableAdapters.patientsTableAdapter();
            this.fullnameSearchBox = new System.Windows.Forms.TextBox();
            this.einSearchBox = new System.Windows.Forms.TextBox();
            this.passport_nSearchBox = new System.Windows.Forms.TextBox();
            this.guidSearchBox = new System.Windows.Forms.TextBox();
            this.passport_sSearchBox = new System.Windows.Forms.TextBox();
            this.socialNumberSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.einLabel = new System.Windows.Forms.Label();
            this.guidLabel = new System.Windows.Forms.Label();
            this.passport_nLabel = new System.Windows.Forms.Label();
            this.social_numberLabel = new System.Windows.Forms.Label();
            this.passport_sLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.pwdDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn,
            this.socialsecnumberDataGridViewTextBoxColumn,
            this.einDataGridViewTextBoxColumn,
            this.socialtypeDataGridViewTextBoxColumn,
            this.passportsDataGridViewTextBoxColumn,
            this.passportnDataGridViewTextBoxColumn,
            this.birthdatetimestampDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.ipadressDataGridViewTextBoxColumn,
            this.uaDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.insuranceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // pwdDataGridViewTextBoxColumn
            // 
            this.pwdDataGridViewTextBoxColumn.DataPropertyName = "pwd";
            this.pwdDataGridViewTextBoxColumn.HeaderText = "pwd";
            this.pwdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pwdDataGridViewTextBoxColumn.Name = "pwdDataGridViewTextBoxColumn";
            this.pwdDataGridViewTextBoxColumn.Width = 125;
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "guid";
            this.guidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.Width = 125;
            // 
            // socialsecnumberDataGridViewTextBoxColumn
            // 
            this.socialsecnumberDataGridViewTextBoxColumn.DataPropertyName = "social_sec_number";
            this.socialsecnumberDataGridViewTextBoxColumn.HeaderText = "social_sec_number";
            this.socialsecnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socialsecnumberDataGridViewTextBoxColumn.Name = "socialsecnumberDataGridViewTextBoxColumn";
            this.socialsecnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // einDataGridViewTextBoxColumn
            // 
            this.einDataGridViewTextBoxColumn.DataPropertyName = "ein";
            this.einDataGridViewTextBoxColumn.HeaderText = "ein";
            this.einDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.einDataGridViewTextBoxColumn.Name = "einDataGridViewTextBoxColumn";
            this.einDataGridViewTextBoxColumn.Width = 125;
            // 
            // socialtypeDataGridViewTextBoxColumn
            // 
            this.socialtypeDataGridViewTextBoxColumn.DataPropertyName = "social_type";
            this.socialtypeDataGridViewTextBoxColumn.HeaderText = "social_type";
            this.socialtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socialtypeDataGridViewTextBoxColumn.Name = "socialtypeDataGridViewTextBoxColumn";
            this.socialtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportsDataGridViewTextBoxColumn
            // 
            this.passportsDataGridViewTextBoxColumn.DataPropertyName = "passport_s";
            this.passportsDataGridViewTextBoxColumn.HeaderText = "passport_s";
            this.passportsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportsDataGridViewTextBoxColumn.Name = "passportsDataGridViewTextBoxColumn";
            this.passportsDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportnDataGridViewTextBoxColumn
            // 
            this.passportnDataGridViewTextBoxColumn.DataPropertyName = "passport_n";
            this.passportnDataGridViewTextBoxColumn.HeaderText = "passport_n";
            this.passportnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportnDataGridViewTextBoxColumn.Name = "passportnDataGridViewTextBoxColumn";
            this.passportnDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdatetimestampDataGridViewTextBoxColumn
            // 
            this.birthdatetimestampDataGridViewTextBoxColumn.DataPropertyName = "birthdate_timestamp";
            this.birthdatetimestampDataGridViewTextBoxColumn.HeaderText = "birthdate_timestamp";
            this.birthdatetimestampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdatetimestampDataGridViewTextBoxColumn.Name = "birthdatetimestampDataGridViewTextBoxColumn";
            this.birthdatetimestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // ipadressDataGridViewTextBoxColumn
            // 
            this.ipadressDataGridViewTextBoxColumn.DataPropertyName = "ipadress";
            this.ipadressDataGridViewTextBoxColumn.HeaderText = "ipadress";
            this.ipadressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ipadressDataGridViewTextBoxColumn.Name = "ipadressDataGridViewTextBoxColumn";
            this.ipadressDataGridViewTextBoxColumn.Width = 125;
            // 
            // uaDataGridViewTextBoxColumn
            // 
            this.uaDataGridViewTextBoxColumn.DataPropertyName = "ua";
            this.uaDataGridViewTextBoxColumn.HeaderText = "ua";
            this.uaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uaDataGridViewTextBoxColumn.Name = "uaDataGridViewTextBoxColumn";
            this.uaDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            this.insuranceDataGridViewTextBoxColumn.DataPropertyName = "insurance";
            this.insuranceDataGridViewTextBoxColumn.HeaderText = "insurance";
            this.insuranceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            this.insuranceDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // fullnameSearchBox
            // 
            this.fullnameSearchBox.Location = new System.Drawing.Point(27, 433);
            this.fullnameSearchBox.Name = "fullnameSearchBox";
            this.fullnameSearchBox.Size = new System.Drawing.Size(230, 26);
            this.fullnameSearchBox.TabIndex = 1;
            // 
            // einSearchBox
            // 
            this.einSearchBox.Location = new System.Drawing.Point(27, 510);
            this.einSearchBox.Name = "einSearchBox";
            this.einSearchBox.Size = new System.Drawing.Size(230, 26);
            this.einSearchBox.TabIndex = 2;
            // 
            // passport_nSearchBox
            // 
            this.passport_nSearchBox.Location = new System.Drawing.Point(326, 510);
            this.passport_nSearchBox.Name = "passport_nSearchBox";
            this.passport_nSearchBox.Size = new System.Drawing.Size(230, 26);
            this.passport_nSearchBox.TabIndex = 4;
            // 
            // guidSearchBox
            // 
            this.guidSearchBox.Location = new System.Drawing.Point(326, 433);
            this.guidSearchBox.Name = "guidSearchBox";
            this.guidSearchBox.Size = new System.Drawing.Size(230, 26);
            this.guidSearchBox.TabIndex = 3;
            // 
            // passport_sSearchBox
            // 
            this.passport_sSearchBox.Location = new System.Drawing.Point(602, 510);
            this.passport_sSearchBox.Name = "passport_sSearchBox";
            this.passport_sSearchBox.Size = new System.Drawing.Size(230, 26);
            this.passport_sSearchBox.TabIndex = 6;
            // 
            // socialNumberSearchBox
            // 
            this.socialNumberSearchBox.Location = new System.Drawing.Point(602, 433);
            this.socialNumberSearchBox.Name = "socialNumberSearchBox";
            this.socialNumberSearchBox.Size = new System.Drawing.Size(230, 26);
            this.socialNumberSearchBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(956, 467);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(237, 35);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(33, 399);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(97, 18);
            this.fullnameLabel.TabIndex = 8;
            this.fullnameLabel.Text = "Имя пациента";
            // 
            // einLabel
            // 
            this.einLabel.AutoSize = true;
            this.einLabel.Location = new System.Drawing.Point(33, 475);
            this.einLabel.Name = "einLabel";
            this.einLabel.Size = new System.Drawing.Size(32, 18);
            this.einLabel.TabIndex = 9;
            this.einLabel.Text = "E-in";
            // 
            // guidLabel
            // 
            this.guidLabel.AutoSize = true;
            this.guidLabel.Location = new System.Drawing.Point(323, 399);
            this.guidLabel.Name = "guidLabel";
            this.guidLabel.Size = new System.Drawing.Size(43, 18);
            this.guidLabel.TabIndex = 10;
            this.guidLabel.Text = "GUID";
            // 
            // passport_nLabel
            // 
            this.passport_nLabel.AutoSize = true;
            this.passport_nLabel.Location = new System.Drawing.Point(599, 475);
            this.passport_nLabel.Name = "passport_nLabel";
            this.passport_nLabel.Size = new System.Drawing.Size(183, 18);
            this.passport_nLabel.TabIndex = 11;
            this.passport_nLabel.Text = "Серийный номер пасспорта";
            // 
            // social_numberLabel
            // 
            this.social_numberLabel.AutoSize = true;
            this.social_numberLabel.Location = new System.Drawing.Point(599, 399);
            this.social_numberLabel.Name = "social_numberLabel";
            this.social_numberLabel.Size = new System.Drawing.Size(51, 18);
            this.social_numberLabel.TabIndex = 12;
            this.social_numberLabel.Text = "Полис";
            // 
            // passport_sLabel
            // 
            this.passport_sLabel.AutoSize = true;
            this.passport_sLabel.Location = new System.Drawing.Point(323, 475);
            this.passport_sLabel.Name = "passport_sLabel";
            this.passport_sLabel.Size = new System.Drawing.Size(119, 18);
            this.passport_sLabel.TabIndex = 13;
            this.passport_sLabel.Text = "Номер пасспорта";
            // 
            // searchPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 559);
            this.Controls.Add(this.passport_sLabel);
            this.Controls.Add(this.social_numberLabel);
            this.Controls.Add(this.passport_nLabel);
            this.Controls.Add(this.guidLabel);
            this.Controls.Add(this.einLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.passport_sSearchBox);
            this.Controls.Add(this.socialNumberSearchBox);
            this.Controls.Add(this.passport_nSearchBox);
            this.Controls.Add(this.guidSearchBox);
            this.Controls.Add(this.einSearchBox);
            this.Controls.Add(this.fullnameSearchBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchPatients";
            this.Text = "Поиск пациета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.searchPatients_FormClosed);
            this.Load += new System.EventHandler(this.searchPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DBDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TextBox fullnameSearchBox;
        private System.Windows.Forms.TextBox einSearchBox;
        private System.Windows.Forms.TextBox passport_nSearchBox;
        private System.Windows.Forms.TextBox guidSearchBox;
        private System.Windows.Forms.TextBox passport_sSearchBox;
        private System.Windows.Forms.TextBox socialNumberSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialsecnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdatetimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label einLabel;
        private System.Windows.Forms.Label guidLabel;
        private System.Windows.Forms.Label passport_nLabel;
        private System.Windows.Forms.Label social_numberLabel;
        private System.Windows.Forms.Label passport_sLabel;
    }
}