namespace WindowsFormsApp1
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.blood_serviceButton = new System.Windows.Forms.Button();
            this.dBDataSet1 = new WindowsFormsApp1.DBDataSet1();
            this.dBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminGridView = new System.Windows.Forms.DataGridView();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.DBDataSet1TableAdapters.usersTableAdapter();
            this.bloodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodTableAdapter = new WindowsFormsApp1.DBDataSet1TableAdapters.bloodTableAdapter();
            this.bloodservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_servicesTableAdapter = new WindowsFormsApp1.DBDataSet1TableAdapters.blood_servicesTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloodservicesFK1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApp1.DBDataSet1TableAdapters.patientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodservicesFK1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.searchPatientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchPatientButton.Location = new System.Drawing.Point(311, 518);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(610, 35);
            this.searchPatientButton.TabIndex = 8;
            this.searchPatientButton.Text = "Пациенты";
            this.searchPatientButton.UseVisualStyleBackColor = false;
            this.searchPatientButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.usersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersButton.Location = new System.Drawing.Point(311, 568);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(610, 35);
            this.usersButton.TabIndex = 9;
            this.usersButton.Text = "Сотрудники";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // blood_serviceButton
            // 
            this.blood_serviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.blood_serviceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blood_serviceButton.Location = new System.Drawing.Point(311, 618);
            this.blood_serviceButton.Name = "blood_serviceButton";
            this.blood_serviceButton.Size = new System.Drawing.Size(610, 35);
            this.blood_serviceButton.TabIndex = 10;
            this.blood_serviceButton.Text = "Анализы";
            this.blood_serviceButton.UseVisualStyleBackColor = false;
            this.blood_serviceButton.Click += new System.EventHandler(this.blood_serviceButton_Click);
            // 
            // dBDataSet1
            // 
            this.dBDataSet1.DataSetName = "DBDataSet1";
            this.dBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBDataSet1BindingSource
            // 
            this.dBDataSet1BindingSource.DataSource = this.dBDataSet1;
            this.dBDataSet1BindingSource.Position = 0;
            // 
            // adminGridView
            // 
            this.adminGridView.AllowUserToDeleteRows = false;
            this.adminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGridView.Location = new System.Drawing.Point(21, 12);
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.RowHeadersWidth = 51;
            this.adminGridView.RowTemplate.Height = 24;
            this.adminGridView.Size = new System.Drawing.Size(1170, 500);
            this.adminGridView.TabIndex = 11;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "patients";
            this.patientsBindingSource1.DataSource = this.dBDataSet1BindingSource;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dBDataSet1BindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // bloodBindingSource
            // 
            this.bloodBindingSource.DataMember = "blood";
            this.bloodBindingSource.DataSource = this.dBDataSet1BindingSource;
            // 
            // bloodTableAdapter
            // 
            this.bloodTableAdapter.ClearBeforeFill = true;
            // 
            // bloodservicesBindingSource
            // 
            this.bloodservicesBindingSource.DataMember = "blood_services";
            this.bloodservicesBindingSource.DataSource = this.dBDataSet1BindingSource;
            // 
            // blood_servicesTableAdapter
            // 
            this.blood_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.dBDataSet1BindingSource;
            // 
            // bloodservicesFK1BindingSource
            // 
            this.bloodservicesFK1BindingSource.DataMember = "blood_services_FK_1";
            this.bloodservicesFK1BindingSource.DataSource = this.usersBindingSource1;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dBDataSet1BindingSource;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 730);
            this.Controls.Add(this.adminGridView);
            this.Controls.Add(this.blood_serviceButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.searchPatientButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodservicesFK1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button blood_serviceButton;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource;
        private DBDataSet1 dBDataSet1;
        private System.Windows.Forms.DataGridView adminGridView;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource bloodBindingSource;
        private DBDataSet1TableAdapters.bloodTableAdapter bloodTableAdapter;
        private System.Windows.Forms.BindingSource bloodservicesBindingSource;
        private DBDataSet1TableAdapters.blood_servicesTableAdapter blood_servicesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource bloodservicesFK1BindingSource;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DBDataSet1TableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
    }
}