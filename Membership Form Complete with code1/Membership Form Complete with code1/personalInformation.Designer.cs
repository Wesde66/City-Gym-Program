namespace Membership_Form_Complete_with_code1
{
    partial class personalInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbStreetAdd = new System.Windows.Forms.TextBox();
            this.tbSuburb = new System.Windows.Forms.TextBox();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(38, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(38, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(38, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(39, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Post code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(38, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // tbMobile
            // 
            this.tbMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbMobile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMobile.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMobile.Location = new System.Drawing.Point(135, 272);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(337, 15);
            this.tbMobile.TabIndex = 9;
            this.tbMobile.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbMobile;
            this.tbMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMobile_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbEmail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEmail.Location = new System.Drawing.Point(135, 308);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(337, 15);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbEmail;
            // 
            // tbStreetAdd
            // 
            this.tbStreetAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbStreetAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStreetAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbStreetAdd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbStreetAdd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreetAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbStreetAdd.Location = new System.Drawing.Point(135, 349);
            this.tbStreetAdd.Name = "tbStreetAdd";
            this.tbStreetAdd.Size = new System.Drawing.Size(337, 15);
            this.tbStreetAdd.TabIndex = 11;
            this.tbStreetAdd.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbStreetAdd;
            this.tbStreetAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreetAdd_KeyPress);
            // 
            // tbSuburb
            // 
            this.tbSuburb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbSuburb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSuburb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbSuburb", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbSuburb.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuburb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSuburb.Location = new System.Drawing.Point(135, 387);
            this.tbSuburb.Name = "tbSuburb";
            this.tbSuburb.Size = new System.Drawing.Size(337, 15);
            this.tbSuburb.TabIndex = 12;
            this.tbSuburb.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbSuburb;
            this.tbSuburb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSuburb_KeyPress);
            // 
            // tbTown
            // 
            this.tbTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbTown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTown.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTown.Location = new System.Drawing.Point(135, 429);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(337, 15);
            this.tbTown.TabIndex = 13;
            this.tbTown.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbTown;
            this.tbTown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTown_KeyPress);
            // 
            // tbPostCode
            // 
            this.tbPostCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbPostCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPostCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbPostCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPostCode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPostCode.Location = new System.Drawing.Point(135, 483);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(104, 15);
            this.tbPostCode.TabIndex = 14;
            this.tbPostCode.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbPostCode;
            this.tbPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostCode_KeyPress);
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbSurname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbSurname.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSurname.Location = new System.Drawing.Point(135, 237);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(337, 15);
            this.tbSurname.TabIndex = 8;
            this.tbSurname.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbSurname;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Membership_Form_Complete_with_code1.Properties.Settings.Default, "tbFirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFirstName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFirstName.Location = new System.Drawing.Point(135, 196);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(337, 15);
            this.tbFirstName.TabIndex = 7;
            this.tbFirstName.Text = global::Membership_Form_Complete_with_code1.Properties.Settings.Default.tbFirstName;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // personalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(686, 580);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.tbSuburb);
            this.Controls.Add(this.tbStreetAdd);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personalInformation";
            this.Leave += new System.EventHandler(this.personalInformation_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbStreetAdd;
        private System.Windows.Forms.TextBox tbSuburb;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox tbFirstName;
    }
}