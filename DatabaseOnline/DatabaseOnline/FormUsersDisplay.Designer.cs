﻿
namespace DatabaseOnline
{
    partial class FormUsersDisplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UT_ID_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UT_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2299, 81);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(123, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1063, 38);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 821);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2299, 100);
            this.panel2.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(18, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(189, 81);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(213, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(189, 81);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(408, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(189, 81);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.UT_ID_FK,
            this.UT_Name,
            this.U_FirstName,
            this.U_LastName,
            this.U_Gender,
            this.U_Image});
            this.dataGridView1.DataSource = this.bindingSourceData;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(2299, 740);
            this.dataGridView1.TabIndex = 2;
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            this.U_ID.HeaderText = "ID";
            this.U_ID.MinimumWidth = 12;
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.Width = 250;
            // 
            // UT_ID_FK
            // 
            this.UT_ID_FK.DataPropertyName = "UT_ID_FK";
            this.UT_ID_FK.HeaderText = "UT_ID_FK";
            this.UT_ID_FK.MinimumWidth = 12;
            this.UT_ID_FK.Name = "UT_ID_FK";
            this.UT_ID_FK.ReadOnly = true;
            this.UT_ID_FK.Visible = false;
            this.UT_ID_FK.Width = 250;
            // 
            // UT_Name
            // 
            this.UT_Name.DataPropertyName = "UT_Name";
            this.UT_Name.HeaderText = "TypeName";
            this.UT_Name.MinimumWidth = 12;
            this.UT_Name.Name = "UT_Name";
            this.UT_Name.ReadOnly = true;
            this.UT_Name.Width = 150;
            // 
            // U_FirstName
            // 
            this.U_FirstName.DataPropertyName = "U_FirstName";
            this.U_FirstName.HeaderText = "FirstName";
            this.U_FirstName.MinimumWidth = 12;
            this.U_FirstName.Name = "U_FirstName";
            this.U_FirstName.ReadOnly = true;
            this.U_FirstName.Width = 200;
            // 
            // U_LastName
            // 
            this.U_LastName.DataPropertyName = "U_LastName";
            this.U_LastName.HeaderText = "LastName";
            this.U_LastName.MinimumWidth = 12;
            this.U_LastName.Name = "U_LastName";
            this.U_LastName.ReadOnly = true;
            this.U_LastName.Width = 200;
            // 
            // U_Gender
            // 
            this.U_Gender.DataPropertyName = "U_GenderText";
            this.U_Gender.HeaderText = "Gender";
            this.U_Gender.MinimumWidth = 12;
            this.U_Gender.Name = "U_Gender";
            this.U_Gender.ReadOnly = true;
            this.U_Gender.Width = 80;
            // 
            // U_Image
            // 
            this.U_Image.DataPropertyName = "U_Image";
            this.U_Image.HeaderText = "Image";
            this.U_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.U_Image.MinimumWidth = 12;
            this.U_Image.Name = "U_Image";
            this.U_Image.ReadOnly = true;
            this.U_Image.Width = 150;
            // 
            // FormUsersDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2299, 921);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsersDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserTypesDisplay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UT_ID_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn UT_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Gender;
        private System.Windows.Forms.DataGridViewImageColumn U_Image;
    }
}