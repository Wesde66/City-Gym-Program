namespace Membership_Form_Complete_with_code1
{
    partial class membershipExtras
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
            this.cbTrainer = new System.Windows.Forms.CheckBox();
            this.cbDiet = new System.Windows.Forms.CheckBox();
            this.cbVideos = new System.Windows.Forms.CheckBox();
            this.cbAccess = new System.Windows.Forms.CheckBox();
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
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Membership Extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(45, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select all extras you wish to include in the membership";
            // 
            // cbTrainer
            // 
            this.cbTrainer.AutoSize = true;
            this.cbTrainer.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.checkBoxTrainer;
            this.cbTrainer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "checkBoxTrainer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTrainer.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrainer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbTrainer.Location = new System.Drawing.Point(140, 263);
            this.cbTrainer.Name = "cbTrainer";
            this.cbTrainer.Size = new System.Drawing.Size(165, 20);
            this.cbTrainer.TabIndex = 10;
            this.cbTrainer.Text = "Personal trainer ($20)";
            this.cbTrainer.UseVisualStyleBackColor = true;
            // 
            // cbDiet
            // 
            this.cbDiet.AutoSize = true;
            this.cbDiet.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.checkBoxDiet;
            this.cbDiet.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "checkBoxDiet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbDiet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbDiet.Location = new System.Drawing.Point(140, 286);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(159, 20);
            this.cbDiet.TabIndex = 11;
            this.cbDiet.Text = "Diet consultion ($20)";
            this.cbDiet.UseVisualStyleBackColor = true;
            // 
            // cbVideos
            // 
            this.cbVideos.AutoSize = true;
            this.cbVideos.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.checkBoxVideos;
            this.cbVideos.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "checkBoxVideos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbVideos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVideos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbVideos.Location = new System.Drawing.Point(140, 239);
            this.cbVideos.Name = "cbVideos";
            this.cbVideos.Size = new System.Drawing.Size(295, 20);
            this.cbVideos.TabIndex = 9;
            this.cbVideos.Text = "Acess to online fitness videos ($2 per week)";
            this.cbVideos.UseVisualStyleBackColor = true;
            // 
            // cbAccess
            // 
            this.cbAccess.AutoSize = true;
            this.cbAccess.Checked = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.checkBoxAccess;
            this.cbAccess.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "checkBoxAccess", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAccess.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbAccess.Location = new System.Drawing.Point(140, 215);
            this.cbAccess.Name = "cbAccess";
            this.cbAccess.Size = new System.Drawing.Size(260, 20);
            this.cbAccess.TabIndex = 8;
            this.cbAccess.Text = "24/7 Access to the gym ($1 per week)";
            this.cbAccess.UseVisualStyleBackColor = true;
            // 
            // membershipExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.cbTrainer);
            this.Controls.Add(this.cbVideos);
            this.Controls.Add(this.cbAccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "membershipExtras";
            this.Text = "membershipExtras";
            this.Leave += new System.EventHandler(this.membershipExtras_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAccess;
        private System.Windows.Forms.CheckBox cbVideos;
        private System.Windows.Forms.CheckBox cbTrainer;
        private System.Windows.Forms.CheckBox cbDiet;
    }
}