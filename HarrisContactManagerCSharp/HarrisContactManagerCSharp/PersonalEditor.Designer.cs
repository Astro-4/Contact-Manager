
namespace HarrisContactManagerCSharp
{
    partial class PersonalEditor
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
            this.dGVPersonalRecords = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDepart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPersonalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPersonalRecords
            // 
            this.dGVPersonalRecords.AllowUserToResizeColumns = false;
            this.dGVPersonalRecords.AllowUserToResizeRows = false;
            this.dGVPersonalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPersonalRecords.Location = new System.Drawing.Point(50, 216);
            this.dGVPersonalRecords.Name = "dGVPersonalRecords";
            this.dGVPersonalRecords.ReadOnly = true;
            this.dGVPersonalRecords.RowHeadersWidth = 51;
            this.dGVPersonalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPersonalRecords.Size = new System.Drawing.Size(1033, 459);
            this.dGVPersonalRecords.TabIndex = 0;
            this.dGVPersonalRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPersonalRecords_CellClick);
            
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(994, 31);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(843, 31);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateSelected.TabIndex = 2;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(994, 103);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Location = new System.Drawing.Point(843, 103);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(122, 23);
            this.btnSaveSelected.TabIndex = 4;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(994, 165);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(843, 165);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(71, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(71, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(71, 130);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(72, 15);
            this.lblDepart.TabIndex = 9;
            this.lblDepart.Text = "Department";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(403, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(403, 87);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(51, 15);
            this.lblAddr.TabIndex = 11;
            this.lblAddr.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(403, 130);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 15);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(71, 184);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(114, 15);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telephone Number";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(400, 184);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(63, 15);
            this.lblPostCode.TabIndex = 14;
            this.lblPostCode.Text = "Post Code";
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(191, 36);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(176, 20);
            this.tbFname.TabIndex = 15;
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(191, 87);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(176, 20);
            this.tbLname.TabIndex = 16;
            // 
            // tbTel
            // 
            this.tbTel.Enabled = false;
            this.tbTel.Location = new System.Drawing.Point(191, 184);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(176, 20);
            this.tbTel.TabIndex = 18;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(479, 130);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(177, 20);
            this.tbCity.TabIndex = 19;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(479, 184);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(177, 20);
            this.tbPostcode.TabIndex = 20;
            // 
            // tbAddr
            // 
            this.tbAddr.Enabled = false;
            this.tbAddr.Location = new System.Drawing.Point(479, 87);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(177, 20);
            this.tbAddr.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(479, 36);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // tbDepart
            // 
            this.tbDepart.Enabled = false;
            this.tbDepart.Location = new System.Drawing.Point(191, 130);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(176, 20);
            this.tbDepart.TabIndex = 23;
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 715);
            this.Controls.Add(this.tbDepart);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAddr);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dGVPersonalRecords);
            this.Name = "PersonalEditor";
            this.Text = "PersonalEditor";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPersonalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPersonalRecords;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDepart;
    }
}