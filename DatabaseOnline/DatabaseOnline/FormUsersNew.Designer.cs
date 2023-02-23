
namespace DatabaseOnline
{
    partial class FormUsersNew
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
            this.Type = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxUType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMeliCode = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(26, 54);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(78, 32);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(450, 792);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(189, 81);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(645, 792);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(189, 81);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxUType
            // 
            this.comboBoxUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUType.FormattingEnabled = true;
            this.comboBoxUType.Location = new System.Drawing.Point(210, 51);
            this.comboBoxUType.Name = "comboBoxUType";
            this.comboBoxUType.Size = new System.Drawing.Size(462, 39);
            this.comboBoxUType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "MeliCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "UserName";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 116);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(462, 38);
            this.textBoxFirstName.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 181);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(462, 38);
            this.textBoxLastName.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(210, 376);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(462, 38);
            this.textBoxEmail.TabIndex = 17;
            // 
            // textBoxMeliCode
            // 
            this.textBoxMeliCode.Location = new System.Drawing.Point(210, 311);
            this.textBoxMeliCode.Name = "textBoxMeliCode";
            this.textBoxMeliCode.Size = new System.Drawing.Size(462, 38);
            this.textBoxMeliCode.TabIndex = 16;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(210, 506);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(462, 38);
            this.textBoxUserName.TabIndex = 19;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(210, 441);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(462, 38);
            this.textBoxMobile.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(210, 636);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(462, 133);
            this.textBoxAddress.TabIndex = 21;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(210, 571);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(462, 38);
            this.textBoxPass.TabIndex = 20;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(223, 249);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(114, 36);
            this.radioButtonMale.TabIndex = 22;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(366, 246);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(147, 36);
            this.radioButtonFemale.TabIndex = 23;
            this.radioButtonFemale.Text = "FeMale";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(691, 574);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(212, 197);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 24;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // FormUsersNew
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1015, 899);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMeliCode);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.Type);
            this.Name = "FormUsersNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxMeliCode;
        public System.Windows.Forms.TextBox textBoxUserName;
        public System.Windows.Forms.TextBox textBoxMobile;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxPass;
        public System.Windows.Forms.RadioButton radioButtonMale;
        public System.Windows.Forms.RadioButton radioButtonFemale;
        public System.Windows.Forms.PictureBox pictureBoxImage;
        public System.Windows.Forms.ComboBox comboBoxUType;
    }
}