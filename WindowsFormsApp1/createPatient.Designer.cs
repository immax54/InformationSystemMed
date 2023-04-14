namespace WindowsFormsApp1
{
    partial class createPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createPatient));
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.birthCalendar = new System.Windows.Forms.MonthCalendar();
            this.passportLabel = new System.Windows.Forms.Label();
            this.passportBox = new System.Windows.Forms.TextBox();
            this.telphoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.cbnumberLabel = new System.Windows.Forms.Label();
            this.cbnumberBox = new System.Windows.Forms.TextBox();
            this.typecbLabel = new System.Windows.Forms.Label();
            this.typecbBox = new System.Windows.Forms.ComboBox();
            this.companyBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.passortnumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passportNumberBox = new System.Windows.Forms.TextBox();
            this.passportNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.Location = new System.Drawing.Point(12, 17);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(97, 18);
            this.fullnameLabel.TabIndex = 7;
            this.fullnameLabel.Text = "Имя пациента";
            // 
            // fullnameBox
            // 
            this.fullnameBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameBox.Location = new System.Drawing.Point(15, 44);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(280, 26);
            this.fullnameBox.TabIndex = 8;
            this.fullnameBox.TextChanged += new System.EventHandler(this.TextChangedLetter);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(438, 17);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(103, 18);
            this.birthLabel.TabIndex = 10;
            this.birthLabel.Text = "Дата рождения";
            // 
            // birthCalendar
            // 
            this.birthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.birthCalendar.Location = new System.Drawing.Point(403, 44);
            this.birthCalendar.Name = "birthCalendar";
            this.birthCalendar.TabIndex = 11;
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportLabel.Location = new System.Drawing.Point(12, 153);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(119, 18);
            this.passportLabel.TabIndex = 12;
            this.passportLabel.Text = "Номер пасспорта";
            // 
            // passportBox
            // 
            this.passportBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportBox.Location = new System.Drawing.Point(15, 185);
            this.passportBox.Name = "passportBox";
            this.passportBox.Size = new System.Drawing.Size(280, 26);
            this.passportBox.TabIndex = 13;
            this.passportBox.UseSystemPasswordChar = true;
            // 
            // telphoneBox
            // 
            this.telphoneBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telphoneBox.Location = new System.Drawing.Point(15, 245);
            this.telphoneBox.MaxLength = 14;
            this.telphoneBox.Name = "telphoneBox";
            this.telphoneBox.Size = new System.Drawing.Size(280, 26);
            this.telphoneBox.TabIndex = 14;
            this.telphoneBox.Text = "+";
            this.telphoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 214);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(65, 18);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(12, 274);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 18);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "E-mail";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(15, 307);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(280, 26);
            this.emailBox.TabIndex = 16;
            // 
            // cbnumberLabel
            // 
            this.cbnumberLabel.AutoSize = true;
            this.cbnumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbnumberLabel.Location = new System.Drawing.Point(12, 344);
            this.cbnumberLabel.Name = "cbnumberLabel";
            this.cbnumberLabel.Size = new System.Drawing.Size(176, 18);
            this.cbnumberLabel.TabIndex = 19;
            this.cbnumberLabel.Text = "Номер страхового полиса";
            // 
            // cbnumberBox
            // 
            this.cbnumberBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbnumberBox.Location = new System.Drawing.Point(15, 377);
            this.cbnumberBox.MaxLength = 8;
            this.cbnumberBox.Name = "cbnumberBox";
            this.cbnumberBox.Size = new System.Drawing.Size(280, 26);
            this.cbnumberBox.TabIndex = 18;
            this.cbnumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // typecbLabel
            // 
            this.typecbLabel.AutoSize = true;
            this.typecbLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typecbLabel.Location = new System.Drawing.Point(12, 406);
            this.typecbLabel.Name = "typecbLabel";
            this.typecbLabel.Size = new System.Drawing.Size(83, 18);
            this.typecbLabel.TabIndex = 21;
            this.typecbLabel.Text = "Тип полиса";
            // 
            // typecbBox
            // 
            this.typecbBox.FormattingEnabled = true;
            this.typecbBox.Location = new System.Drawing.Point(15, 431);
            this.typecbBox.Name = "typecbBox";
            this.typecbBox.Size = new System.Drawing.Size(280, 26);
            this.typecbBox.TabIndex = 22;
            // 
            // companyBox
            // 
            this.companyBox.FormattingEnabled = true;
            this.companyBox.Location = new System.Drawing.Point(15, 488);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(280, 26);
            this.companyBox.TabIndex = 24;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyLabel.Location = new System.Drawing.Point(12, 463);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(203, 18);
            this.companyLabel.TabIndex = 23;
            this.companyLabel.Text = "Название страховой компании";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.createBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.createBtn.Location = new System.Drawing.Point(519, 483);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(163, 31);
            this.createBtn.TabIndex = 26;
            this.createBtn.Text = "&Создать пользователя";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // passortnumLabel
            // 
            this.passortnumLabel.AutoSize = true;
            this.passortnumLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passortnumLabel.Location = new System.Drawing.Point(12, 88);
            this.passortnumLabel.Name = "passortnumLabel";
            this.passortnumLabel.Size = new System.Drawing.Size(114, 18);
            this.passortnumLabel.TabIndex = 27;
            this.passortnumLabel.Text = "Серия пасспорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер пасспорта";
            // 
            // passportNumberBox
            // 
            this.passportNumberBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportNumberBox.Location = new System.Drawing.Point(15, 185);
            this.passportNumberBox.MaxLength = 6;
            this.passportNumberBox.Name = "passportNumberBox";
            this.passportNumberBox.Size = new System.Drawing.Size(280, 26);
            this.passportNumberBox.TabIndex = 13;
            this.passportNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // passportNumBox
            // 
            this.passportNumBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportNumBox.Location = new System.Drawing.Point(15, 115);
            this.passportNumBox.MaxLength = 4;
            this.passportNumBox.Name = "passportNumBox";
            this.passportNumBox.Size = new System.Drawing.Size(280, 26);
            this.passportNumBox.TabIndex = 28;
            this.passportNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // createPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 526);
            this.Controls.Add(this.passportNumBox);
            this.Controls.Add(this.passortnumLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.typecbBox);
            this.Controls.Add(this.typecbLabel);
            this.Controls.Add(this.cbnumberLabel);
            this.Controls.Add(this.cbnumberBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.telphoneBox);
            this.Controls.Add(this.passportNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passportBox);
            this.Controls.Add(this.passportLabel);
            this.Controls.Add(this.birthCalendar);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.fullnameLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createPatient";
            this.Text = "Создать пациента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.createPatient_FormClosed);
            this.Load += new System.EventHandler(this.createPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.MonthCalendar birthCalendar;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.TextBox passportBox;
        private System.Windows.Forms.TextBox telphoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label cbnumberLabel;
        private System.Windows.Forms.TextBox cbnumberBox;
        private System.Windows.Forms.Label typecbLabel;
        private System.Windows.Forms.ComboBox typecbBox;
        private System.Windows.Forms.ComboBox companyBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label passortnumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passportNumberBox;
        private System.Windows.Forms.TextBox passportNumBox;
    }
}