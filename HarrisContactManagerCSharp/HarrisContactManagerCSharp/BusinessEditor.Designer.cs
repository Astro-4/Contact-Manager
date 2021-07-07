
namespace HarrisContactManagerCSharp
{
    partial class BusinessEditor
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
            this.dGVBusinessRecords = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbComp = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBusinessRecords
            // 
            this.dGVBusinessRecords.AllowUserToResizeColumns = false;
            this.dGVBusinessRecords.AllowUserToResizeRows = false;
            this.dGVBusinessRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBusinessRecords.Location = new System.Drawing.Point(12, 193);
            this.dGVBusinessRecords.Name = "dGVBusinessRecords";
            this.dGVBusinessRecords.RowHeadersWidth = 51;
            this.dGVBusinessRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBusinessRecords.Size = new System.Drawing.Size(1018, 462);
            this.dGVBusinessRecords.TabIndex = 0;
            this.dGVBusinessRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBusinessRecords_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(948, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(948, 78);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(948, 33);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(810, 33);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(111, 23);
            this.btnUpdateSelected.TabIndex = 4;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Location = new System.Drawing.Point(810, 78);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(111, 23);
            this.btnSaveSelected.TabIndex = 5;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(810, 123);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // tbTel
            // 
            this.tbTel.Enabled = false;
            this.tbTel.Location = new System.Drawing.Point(298, 78);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(298, 123);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 8;
            // 
            // tbAddr
            // 
            this.tbAddr.Enabled = false;
            this.tbAddr.Location = new System.Drawing.Point(493, 32);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(100, 20);
            this.tbAddr.TabIndex = 9;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(493, 78);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 10;
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(86, 78);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 20);
            this.tbLname.TabIndex = 11;
            // 
            // tbComp
            // 
            this.tbComp.Enabled = false;
            this.tbComp.Location = new System.Drawing.Point(86, 123);
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(100, 20);
            this.tbComp.TabIndex = 12;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(493, 122);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbPostcode.TabIndex = 13;
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(298, 32);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 20);
            this.tbPosition.TabIndex = 14;
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(86, 32);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(100, 20);
            this.tbFname.TabIndex = 18;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(13, 33);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(67, 15);
            this.lblFname.TabIndex = 19;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(13, 83);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(67, 15);
            this.lblLname.TabIndex = 20;
            this.lblLname.Text = "Last Name";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(21, 126);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(59, 15);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Company";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(219, 33);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(51, 15);
            this.lblPosition.TabIndex = 22;
            this.lblPosition.Text = "Position";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(204, 83);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(88, 15);
            this.lblTel.TabIndex = 23;
            this.lblTel.Text = "Telephone No.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(219, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(423, 35);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(51, 15);
            this.lblAddr.TabIndex = 25;
            this.lblAddr.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(423, 83);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 15);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(423, 126);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(63, 15);
            this.lblPostcode.TabIndex = 27;
            this.lblPostcode.Text = "Post Code";
            // 
            // BusinessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 667);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbComp);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddr);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dGVBusinessRecords);
            this.Name = "BusinessEditor";
            this.Text = "BusinessEditor";
            this.Load += new System.EventHandler(this.BusinessEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBusinessRecords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbComp;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostcode;
    }
}