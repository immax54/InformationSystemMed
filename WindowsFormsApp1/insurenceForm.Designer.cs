namespace WindowsFormsApp1
{
    partial class insurenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insurenceForm));
            this.companyLabel = new System.Windows.Forms.Label();
            this.insuranceBox = new System.Windows.Forms.ComboBox();
            this.fromPaymentCalendar = new System.Windows.Forms.MonthCalendar();
            this.toPaymentCalendar = new System.Windows.Forms.MonthCalendar();
            this.periodLabel = new System.Windows.Forms.Label();
            this.btnReportPost = new System.Windows.Forms.Button();
            this.periodToPayBox = new System.Windows.Forms.TextBox();
            this.paimentPeriodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(59, 122);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(138, 18);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Страховая компания";
            // 
            // insuranceBox
            // 
            this.insuranceBox.FormattingEnabled = true;
            this.insuranceBox.Location = new System.Drawing.Point(12, 143);
            this.insuranceBox.Name = "insuranceBox";
            this.insuranceBox.Size = new System.Drawing.Size(244, 26);
            this.insuranceBox.TabIndex = 2;
            // 
            // fromPaymentCalendar
            // 
            this.fromPaymentCalendar.Location = new System.Drawing.Point(315, 98);
            this.fromPaymentCalendar.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.fromPaymentCalendar.Name = "fromPaymentCalendar";
            this.fromPaymentCalendar.TabIndex = 4;
            // 
            // toPaymentCalendar
            // 
            this.toPaymentCalendar.Location = new System.Drawing.Point(576, 98);
            this.toPaymentCalendar.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.toPaymentCalendar.Name = "toPaymentCalendar";
            this.toPaymentCalendar.TabIndex = 5;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(458, 49);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(157, 18);
            this.periodLabel.TabIndex = 6;
            this.periodLabel.Text = "Период оказания услуг";
            // 
            // btnReportPost
            // 
            this.btnReportPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnReportPost.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportPost.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportPost.Location = new System.Drawing.Point(522, 373);
            this.btnReportPost.Name = "btnReportPost";
            this.btnReportPost.Size = new System.Drawing.Size(246, 31);
            this.btnReportPost.TabIndex = 8;
            this.btnReportPost.Text = "&Сформировать отчет";
            this.btnReportPost.UseVisualStyleBackColor = false;
            this.btnReportPost.Click += new System.EventHandler(this.btnReportPost_Click);
            // 
            // periodToPayBox
            // 
            this.periodToPayBox.Location = new System.Drawing.Point(12, 279);
            this.periodToPayBox.Name = "periodToPayBox";
            this.periodToPayBox.Size = new System.Drawing.Size(244, 26);
            this.periodToPayBox.TabIndex = 9;
            // 
            // paimentPeriodLabel
            // 
            this.paimentPeriodLabel.AutoSize = true;
            this.paimentPeriodLabel.Location = new System.Drawing.Point(42, 245);
            this.paimentPeriodLabel.Name = "paimentPeriodLabel";
            this.paimentPeriodLabel.Size = new System.Drawing.Size(181, 18);
            this.paimentPeriodLabel.TabIndex = 10;
            this.paimentPeriodLabel.Text = "Период в днях для оплаты";
            // 
            // insurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.paimentPeriodLabel);
            this.Controls.Add(this.periodToPayBox);
            this.Controls.Add(this.btnReportPost);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.toPaymentCalendar);
            this.Controls.Add(this.fromPaymentCalendar);
            this.Controls.Add(this.insuranceBox);
            this.Controls.Add(this.companyLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insurenceForm";
            this.Text = "Формировать счета";
            this.Load += new System.EventHandler(this.insurenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.ComboBox insuranceBox;
        private System.Windows.Forms.MonthCalendar fromPaymentCalendar;
        private System.Windows.Forms.MonthCalendar toPaymentCalendar;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Button btnReportPost;
        private System.Windows.Forms.TextBox periodToPayBox;
        private System.Windows.Forms.Label paimentPeriodLabel;
    }
}