namespace WindowsFormsApp1
{
    partial class getMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getMaterial));
            this.codeLabel = new System.Windows.Forms.Label();
            this.btnGetMaterial = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patientBox = new System.Windows.Forms.ComboBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.serviceBox = new System.Windows.Forms.ComboBox();
            this.showPatients = new System.Windows.Forms.Button();
            this.serviceBoxlist = new System.Windows.Forms.CheckedListBox();
            this.downloadPdfBtn = new System.Windows.Forms.Button();
            this.serviceListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeLabel.Location = new System.Drawing.Point(83, 37);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(135, 18);
            this.codeLabel.TabIndex = 6;
            this.codeLabel.Text = "Ввод кода пробирки";
            // 
            // btnGetMaterial
            // 
            this.btnGetMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnGetMaterial.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetMaterial.ForeColor = System.Drawing.Color.Transparent;
            this.btnGetMaterial.Location = new System.Drawing.Point(358, 78);
            this.btnGetMaterial.Name = "btnGetMaterial";
            this.btnGetMaterial.Size = new System.Drawing.Size(147, 31);
            this.btnGetMaterial.TabIndex = 7;
            this.btnGetMaterial.Text = "&Сканировать код";
            this.btnGetMaterial.UseVisualStyleBackColor = false;
            this.btnGetMaterial.Click += new System.EventHandler(this.btnGetMaterial_Click);
            // 
            // codeBox
            // 
            this.codeBox.AccessibleDescription = "";
            this.codeBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.codeBox.Location = new System.Drawing.Point(12, 78);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(280, 26);
            this.codeBox.TabIndex = 8;
            this.codeBox.Tag = "";
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeBox_KeyDown);
            this.codeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(101, 151);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 18);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Имя пациента";
            this.nameLabel.Visible = false;
            // 
            // patientBox
            // 
            this.patientBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.patientBox.FormattingEnabled = true;
            this.patientBox.Location = new System.Drawing.Point(15, 187);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(280, 26);
            this.patientBox.TabIndex = 12;
            this.patientBox.Visible = false;
            this.patientBox.SelectedIndexChanged += new System.EventHandler(this.patientBox_SelectedIndexChanged);
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLabel.Location = new System.Drawing.Point(74, 254);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(171, 18);
            this.serviceLabel.TabIndex = 14;
            this.serviceLabel.Text = "Услуга для исследования";
            this.serviceLabel.Visible = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.createButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.ForeColor = System.Drawing.Color.Transparent;
            this.createButton.Location = new System.Drawing.Point(581, 407);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(182, 31);
            this.createButton.TabIndex = 16;
            this.createButton.Text = "&Создать пациента";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.completeButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeButton.ForeColor = System.Drawing.Color.Transparent;
            this.completeButton.Location = new System.Drawing.Point(77, 370);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(168, 31);
            this.completeButton.TabIndex = 18;
            this.completeButton.Text = "&Оформить заказ";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Visible = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // serviceBox
            // 
            this.serviceBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Location = new System.Drawing.Point(15, 291);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(280, 26);
            this.serviceBox.TabIndex = 19;
            this.serviceBox.Visible = false;
            // 
            // showPatients
            // 
            this.showPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.showPatients.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPatients.ForeColor = System.Drawing.Color.Transparent;
            this.showPatients.Location = new System.Drawing.Point(581, 348);
            this.showPatients.Name = "showPatients";
            this.showPatients.Size = new System.Drawing.Size(182, 31);
            this.showPatients.TabIndex = 20;
            this.showPatients.Text = "&Просмотр пациентов";
            this.showPatients.UseVisualStyleBackColor = false;
            this.showPatients.Visible = false;
            this.showPatients.Click += new System.EventHandler(this.showPatients_Click);
            // 
            // serviceBoxlist
            // 
            this.serviceBoxlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.serviceBoxlist.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceBoxlist.FormattingEnabled = true;
            this.serviceBoxlist.Location = new System.Drawing.Point(557, 158);
            this.serviceBoxlist.Name = "serviceBoxlist";
            this.serviceBoxlist.Size = new System.Drawing.Size(211, 82);
            this.serviceBoxlist.TabIndex = 34;
            this.serviceBoxlist.Visible = false;
            // 
            // downloadPdfBtn
            // 
            this.downloadPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.downloadPdfBtn.Enabled = false;
            this.downloadPdfBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadPdfBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.downloadPdfBtn.Location = new System.Drawing.Point(543, 287);
            this.downloadPdfBtn.Name = "downloadPdfBtn";
            this.downloadPdfBtn.Size = new System.Drawing.Size(245, 31);
            this.downloadPdfBtn.TabIndex = 33;
            this.downloadPdfBtn.Text = "&Выгрузить PDF отчет и записать";
            this.downloadPdfBtn.UseVisualStyleBackColor = false;
            this.downloadPdfBtn.Visible = false;
            this.downloadPdfBtn.Click += new System.EventHandler(this.downloadPdfBtn_Click);
            // 
            // serviceListLabel
            // 
            this.serviceListLabel.AutoSize = true;
            this.serviceListLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceListLabel.Location = new System.Drawing.Point(596, 122);
            this.serviceListLabel.Name = "serviceListLabel";
            this.serviceListLabel.Size = new System.Drawing.Size(123, 18);
            this.serviceListLabel.TabIndex = 35;
            this.serviceListLabel.Text = "Рассчитать услуги";
            this.serviceListLabel.Visible = false;
            // 
            // getMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceListLabel);
            this.Controls.Add(this.serviceBoxlist);
            this.Controls.Add(this.downloadPdfBtn);
            this.Controls.Add(this.showPatients);
            this.Controls.Add(this.serviceBox);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.btnGetMaterial);
            this.Controls.Add(this.codeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getMaterial";
            this.Text = "Прием биоматериала";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.getMaterial_FormClosed);
            this.Load += new System.EventHandler(this.getMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button btnGetMaterial;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox patientBox;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.ComboBox serviceBox;
        private System.Windows.Forms.Button showPatients;
        private System.Windows.Forms.CheckedListBox serviceBoxlist;
        private System.Windows.Forms.Button downloadPdfBtn;
        private System.Windows.Forms.Label serviceListLabel;
    }
}