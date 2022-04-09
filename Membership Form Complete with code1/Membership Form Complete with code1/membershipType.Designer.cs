namespace Membership_Form_Complete_with_code1
{
    partial class membershipType
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPremiumMembership = new System.Windows.Forms.RadioButton();
            this.rbRegularMembership = new System.Windows.Forms.RadioButton();
            this.rbBasicMembership = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb2YearMembership = new System.Windows.Forms.RadioButton();
            this.rb1YearMembership = new System.Windows.Forms.RadioButton();
            this.rb3MonthMembership = new System.Windows.Forms.RadioButton();
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
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Membership Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select what kind of membership";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select membership length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(27, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign up for a 12 month membership and get a $2 per week discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(27, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sign up for a 24 month membership and get a $5 per week discount";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPremiumMembership);
            this.panel1.Controls.Add(this.rbRegularMembership);
            this.panel1.Controls.Add(this.rbBasicMembership);
            this.panel1.Location = new System.Drawing.Point(277, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 94);
            this.panel1.TabIndex = 14;
            // 
            // rbPremiumMembership
            // 
            this.rbPremiumMembership.AutoSize = true;
            this.rbPremiumMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbPremiumMembership;
            this.rbPremiumMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbPremiumMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbPremiumMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremiumMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPremiumMembership.Location = new System.Drawing.Point(11, 56);
            this.rbPremiumMembership.Name = "rbPremiumMembership";
            this.rbPremiumMembership.Size = new System.Drawing.Size(260, 20);
            this.rbPremiumMembership.TabIndex = 2;
            this.rbPremiumMembership.TabStop = true;
            this.rbPremiumMembership.Text = "Premium Membership ($20 per week)";
            this.rbPremiumMembership.UseVisualStyleBackColor = true;
            // 
            // rbRegularMembership
            // 
            this.rbRegularMembership.AutoSize = true;
            this.rbRegularMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbRegularMembership;
            this.rbRegularMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbRegularMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbRegularMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegularMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbRegularMembership.Location = new System.Drawing.Point(11, 30);
            this.rbRegularMembership.Name = "rbRegularMembership";
            this.rbRegularMembership.Size = new System.Drawing.Size(249, 20);
            this.rbRegularMembership.TabIndex = 1;
            this.rbRegularMembership.TabStop = true;
            this.rbRegularMembership.Text = "Regular Membership ($15 per week)";
            this.rbRegularMembership.UseVisualStyleBackColor = true;
            // 
            // rbBasicMembership
            // 
            this.rbBasicMembership.AutoSize = true;
            this.rbBasicMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rbBasicMembership;
            this.rbBasicMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rbBasicMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbBasicMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBasicMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbBasicMembership.Location = new System.Drawing.Point(11, 4);
            this.rbBasicMembership.Name = "rbBasicMembership";
            this.rbBasicMembership.Size = new System.Drawing.Size(234, 20);
            this.rbBasicMembership.TabIndex = 0;
            this.rbBasicMembership.TabStop = true;
            this.rbBasicMembership.Text = "Basic Membership ($10 per week)";
            this.rbBasicMembership.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb2YearMembership);
            this.panel2.Controls.Add(this.rb1YearMembership);
            this.panel2.Controls.Add(this.rb3MonthMembership);
            this.panel2.Location = new System.Drawing.Point(277, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 94);
            this.panel2.TabIndex = 15;
            // 
            // rb2YearMembership
            // 
            this.rb2YearMembership.AutoSize = true;
            this.rb2YearMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rb2YearMembership;
            this.rb2YearMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rb2YearMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb2YearMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2YearMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb2YearMembership.Location = new System.Drawing.Point(12, 56);
            this.rb2YearMembership.Name = "rb2YearMembership";
            this.rb2YearMembership.Size = new System.Drawing.Size(147, 20);
            this.rb2YearMembership.TabIndex = 2;
            this.rb2YearMembership.TabStop = true;
            this.rb2YearMembership.Text = "2 Year Membership";
            this.rb2YearMembership.UseVisualStyleBackColor = true;
            // 
            // rb1YearMembership
            // 
            this.rb1YearMembership.AutoSize = true;
            this.rb1YearMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rb1YearMembership;
            this.rb1YearMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rb1YearMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb1YearMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1YearMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb1YearMembership.Location = new System.Drawing.Point(12, 30);
            this.rb1YearMembership.Name = "rb1YearMembership";
            this.rb1YearMembership.Size = new System.Drawing.Size(146, 20);
            this.rb1YearMembership.TabIndex = 1;
            this.rb1YearMembership.TabStop = true;
            this.rb1YearMembership.Text = "1 Year Membership";
            this.rb1YearMembership.UseVisualStyleBackColor = true;
            // 
            // rb3MonthMembership
            // 
            this.rb3MonthMembership.AutoSize = true;
            this.rb3MonthMembership.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.rb3MonthMembership;
            this.rb3MonthMembership.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "rb3MonthMembership", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb3MonthMembership.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3MonthMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb3MonthMembership.Location = new System.Drawing.Point(11, 4);
            this.rb3MonthMembership.Name = "rb3MonthMembership";
            this.rb3MonthMembership.Size = new System.Drawing.Size(158, 20);
            this.rb3MonthMembership.TabIndex = 0;
            this.rb3MonthMembership.TabStop = true;
            this.rb3MonthMembership.Text = "3 Month membership";
            this.rb3MonthMembership.UseVisualStyleBackColor = true;
            // 
            // membershipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(582, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "membershipType";
            this.Text = "membershipType";
            this.Leave += new System.EventHandler(this.membershipType_Leave);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPremiumMembership;
        private System.Windows.Forms.RadioButton rbRegularMembership;
        private System.Windows.Forms.RadioButton rbBasicMembership;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb2YearMembership;
        private System.Windows.Forms.RadioButton rb1YearMembership;
        private System.Windows.Forms.RadioButton rb3MonthMembership;
    }
}