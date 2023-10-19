namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmCustomerManagement
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
            lbCusId = new System.Windows.Forms.Label();
            lbCusName = new System.Windows.Forms.Label();
            lbTelephone = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbCusBirthday = new System.Windows.Forms.Label();
            lbCusStatus = new System.Windows.Forms.Label();
            txtCusId = new System.Windows.Forms.TextBox();
            txtCusName = new System.Windows.Forms.TextBox();
            txtCusEmail = new System.Windows.Forms.TextBox();
            txtCusDOB = new System.Windows.Forms.TextBox();
            txtCusStatus = new System.Windows.Forms.TextBox();
            mtbCusTel = new System.Windows.Forms.MaskedTextBox();
            dgvCusList = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtSearchId = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCusList).BeginInit();
            SuspendLayout();
            // 
            // lbCusId
            // 
            lbCusId.AutoSize = true;
            lbCusId.Location = new System.Drawing.Point(30, 45);
            lbCusId.Name = "lbCusId";
            lbCusId.Size = new System.Drawing.Size(91, 20);
            lbCusId.TabIndex = 0;
            lbCusId.Text = "Customer ID";
            // 
            // lbCusName
            // 
            lbCusName.AutoSize = true;
            lbCusName.Location = new System.Drawing.Point(30, 102);
            lbCusName.Name = "lbCusName";
            lbCusName.Size = new System.Drawing.Size(116, 20);
            lbCusName.TabIndex = 1;
            lbCusName.Text = "Customer Name";
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new System.Drawing.Point(30, 159);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new System.Drawing.Size(78, 20);
            lbTelephone.TabIndex = 2;
            lbTelephone.Text = "Telephone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(350, 45);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbCusBirthday
            // 
            lbCusBirthday.AutoSize = true;
            lbCusBirthday.Location = new System.Drawing.Point(350, 102);
            lbCusBirthday.Name = "lbCusBirthday";
            lbCusBirthday.Size = new System.Drawing.Size(131, 20);
            lbCusBirthday.TabIndex = 4;
            lbCusBirthday.Text = "Customer Birthday";
            // 
            // lbCusStatus
            // 
            lbCusStatus.AutoSize = true;
            lbCusStatus.Location = new System.Drawing.Point(350, 159);
            lbCusStatus.Name = "lbCusStatus";
            lbCusStatus.Size = new System.Drawing.Size(116, 20);
            lbCusStatus.TabIndex = 5;
            lbCusStatus.Text = "Customer Status";
            // 
            // txtCusId
            // 
            txtCusId.Location = new System.Drawing.Point(181, 42);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new System.Drawing.Size(163, 27);
            txtCusId.TabIndex = 6;
            // 
            // txtCusName
            // 
            txtCusName.Location = new System.Drawing.Point(181, 99);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new System.Drawing.Size(163, 27);
            txtCusName.TabIndex = 7;
            // 
            // txtCusEmail
            // 
            txtCusEmail.Location = new System.Drawing.Point(515, 42);
            txtCusEmail.Name = "txtCusEmail";
            txtCusEmail.Size = new System.Drawing.Size(247, 27);
            txtCusEmail.TabIndex = 9;
            // 
            // txtCusDOB
            // 
            txtCusDOB.Location = new System.Drawing.Point(515, 99);
            txtCusDOB.Name = "txtCusDOB";
            txtCusDOB.Size = new System.Drawing.Size(247, 27);
            txtCusDOB.TabIndex = 10;
            // 
            // txtCusStatus
            // 
            txtCusStatus.Location = new System.Drawing.Point(515, 156);
            txtCusStatus.Name = "txtCusStatus";
            txtCusStatus.Size = new System.Drawing.Size(247, 27);
            txtCusStatus.TabIndex = 11;
            // 
            // mtbCusTel
            // 
            mtbCusTel.Location = new System.Drawing.Point(181, 156);
            mtbCusTel.Mask = "0000-000-000";
            mtbCusTel.Name = "mtbCusTel";
            mtbCusTel.Size = new System.Drawing.Size(163, 27);
            mtbCusTel.TabIndex = 12;
            // 
            // dgvCusList
            // 
            dgvCusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusList.Location = new System.Drawing.Point(30, 250);
            dgvCusList.Name = "dgvCusList";
            dgvCusList.ReadOnly = true;
            dgvCusList.RowHeadersWidth = 51;
            dgvCusList.RowTemplate.Height = 29;
            dgvCusList.Size = new System.Drawing.Size(732, 188);
            dgvCusList.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(489, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(589, 208);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(181, 208);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search ID";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new System.Drawing.Point(303, 209);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new System.Drawing.Size(163, 27);
            txtSearchId.TabIndex = 17;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(30, 208);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(689, 207);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(73, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Controls.Add(txtSearchId);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(dgvCusList);
            Controls.Add(mtbCusTel);
            Controls.Add(txtCusStatus);
            Controls.Add(txtCusDOB);
            Controls.Add(txtCusEmail);
            Controls.Add(txtCusName);
            Controls.Add(txtCusId);
            Controls.Add(lbCusStatus);
            Controls.Add(lbCusBirthday);
            Controls.Add(lbEmail);
            Controls.Add(lbTelephone);
            Controls.Add(lbCusName);
            Controls.Add(lbCusId);
            Name = "frmCustomerManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCustomerManagement";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCusList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCusId;
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCusBirthday;
        private System.Windows.Forms.Label lbCusStatus;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusDOB;
        private System.Windows.Forms.TextBox txtCusStatus;
        private System.Windows.Forms.MaskedTextBox mtbCusTel;
        private System.Windows.Forms.DataGridView dgvCusList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}