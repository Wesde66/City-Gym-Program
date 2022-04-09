namespace Membership_Form_Complete_with_code1
{
    partial class paymentMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDirectDebitYes = new System.Windows.Forms.RadioButton();
            this.rbDirectDebitNo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbMonthlyPayment = new System.Windows.Forms.RadioButton();
            this.rbWeeklyPayment = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direct debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "For direct debits you will receive a 1% discount on the base membership";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDirectDebitYes);
            this.panel1.Controls.Add(this.rbDirectDebitNo);
            this.panel1.Location = new System.Drawing.Point(183, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 51);
            this.panel1.TabIndex = 6;
            // 
            // rbDirectDebitYes
            // 
            this.rbDirectDebitYes.AutoSize = true;
            this.rbDirectDebitYes.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbDirectDebitYes;
            this.rbDirectDebitYes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbDirectDebitYes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbDirectDebitYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbDirectDebitYes.Location = new System.Drawing.Point(4, 27);
            this.rbDirectDebitYes.Name = "rbDirectDebitYes";
            this.rbDirectDebitYes.Size = new System.Drawing.Size(43, 17);
            this.rbDirectDebitYes.TabIndex = 1;
            this.rbDirectDebitYes.TabStop = true;
            this.rbDirectDebitYes.Text = "Yes";
            this.rbDirectDebitYes.UseVisualStyleBackColor = true;
            // 
            // rbDirectDebitNo
            // 
            this.rbDirectDebitNo.AutoSize = true;
            this.rbDirectDebitNo.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbDirectDebitNo;
            this.rbDirectDebitNo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbDirectDebitNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbDirectDebitNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbDirectDebitNo.Location = new System.Drawing.Point(4, 4);
            this.rbDirectDebitNo.Name = "rbDirectDebitNo";
            this.rbDirectDebitNo.Size = new System.Drawing.Size(39, 17);
            this.rbDirectDebitNo.TabIndex = 0;
            this.rbDirectDebitNo.TabStop = true;
            this.rbDirectDebitNo.Text = "No";
            this.rbDirectDebitNo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMonthlyPayment);
            this.panel2.Controls.Add(this.rbWeeklyPayment);
            this.panel2.Location = new System.Drawing.Point(183, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 51);
            this.panel2.TabIndex = 7;
            // 
            // rbMonthlyPayment
            // 
            this.rbMonthlyPayment.AutoSize = true;
            this.rbMonthlyPayment.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbMonthlyPayment;
            this.rbMonthlyPayment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbMonthlyPayment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbMonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMonthlyPayment.Location = new System.Drawing.Point(4, 27);
            this.rbMonthlyPayment.Name = "rbMonthlyPayment";
            this.rbMonthlyPayment.Size = new System.Drawing.Size(62, 17);
            this.rbMonthlyPayment.TabIndex = 1;
            this.rbMonthlyPayment.TabStop = true;
            this.rbMonthlyPayment.Text = "Monthly";
            this.rbMonthlyPayment.UseVisualStyleBackColor = true;
            // 
            // rbWeeklyPayment
            // 
            this.rbWeeklyPayment.AutoSize = true;
            this.rbWeeklyPayment.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbWeeklyPayment;
            this.rbWeeklyPayment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbWeeklyPayment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbWeeklyPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbWeeklyPayment.Location = new System.Drawing.Point(4, 4);
            this.rbWeeklyPayment.Name = "rbWeeklyPayment";
            this.rbWeeklyPayment.Size = new System.Drawing.Size(110, 17);
            this.rbWeeklyPayment.TabIndex = 0;
            this.rbWeeklyPayment.TabStop = true;
            this.rbWeeklyPayment.Text = "Weekly Payments";
            this.rbWeeklyPayment.UseVisualStyleBackColor = true;
            // 
            // paymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentMethod";
            this.Text = "paymentMethod";
            this.Leave += new System.EventHandler(this.paymentMethod_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDirectDebitYes;
        private System.Windows.Forms.RadioButton rbDirectDebitNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMonthlyPayment;
        private System.Windows.Forms.RadioButton rbWeeklyPayment;
    }
}