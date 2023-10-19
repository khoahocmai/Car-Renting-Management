namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmRentingSystem
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
            lbFrom = new System.Windows.Forms.Label();
            lbTo = new System.Windows.Forms.Label();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            btnSearch = new System.Windows.Forms.Button();
            dgvCarAvailable = new System.Windows.Forms.DataGridView();
            dgvListCarRenting = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnRent = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            lbCusId = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            txtCusId = new System.Windows.Forms.TextBox();
            lbCarList = new System.Windows.Forms.Label();
            lbRentCar = new System.Windows.Forms.Label();
            dgvListTransHis = new System.Windows.Forms.DataGridView();
            lbTransHis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarAvailable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListCarRenting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListTransHis).BeginInit();
            SuspendLayout();
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFrom.Location = new System.Drawing.Point(36, 21);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(69, 30);
            lbFrom.TabIndex = 0;
            lbFrom.Text = "From:";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTo.Location = new System.Drawing.Point(378, 21);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(41, 30);
            lbTo.TabIndex = 1;
            lbTo.Text = "To:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(106, 24);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(250, 27);
            dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(425, 24);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(250, 27);
            dtpTo.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(704, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCarAvailable
            // 
            dgvCarAvailable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarAvailable.Location = new System.Drawing.Point(22, 104);
            dgvCarAvailable.Name = "dgvCarAvailable";
            dgvCarAvailable.ReadOnly = true;
            dgvCarAvailable.RowHeadersWidth = 51;
            dgvCarAvailable.RowTemplate.Height = 29;
            dgvCarAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarAvailable.Size = new System.Drawing.Size(869, 188);
            dgvCarAvailable.TabIndex = 5;
            // 
            // dgvListCarRenting
            // 
            dgvListCarRenting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvListCarRenting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCarRenting.Location = new System.Drawing.Point(22, 331);
            dgvListCarRenting.Name = "dgvListCarRenting";
            dgvListCarRenting.ReadOnly = true;
            dgvListCarRenting.RowHeadersWidth = 51;
            dgvListCarRenting.RowTemplate.Height = 29;
            dgvListCarRenting.Size = new System.Drawing.Size(497, 136);
            dgvListCarRenting.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(923, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRent
            // 
            btnRent.Location = new System.Drawing.Point(425, 484);
            btnRent.Name = "btnRent";
            btnRent.Size = new System.Drawing.Size(94, 29);
            btnRent.TabIndex = 9;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(923, 25);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbCusId
            // 
            lbCusId.AutoSize = true;
            lbCusId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCusId.Location = new System.Drawing.Point(22, 480);
            lbCusId.Name = "lbCusId";
            lbCusId.Size = new System.Drawing.Size(134, 30);
            lbCusId.TabIndex = 11;
            lbCusId.Text = "Customer ID";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(738, 484);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(850, 486);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCusId
            // 
            txtCusId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCusId.Location = new System.Drawing.Point(162, 477);
            txtCusId.Name = "txtCusId";
            txtCusId.ReadOnly = true;
            txtCusId.Size = new System.Drawing.Size(69, 36);
            txtCusId.TabIndex = 14;
            // 
            // lbCarList
            // 
            lbCarList.AutoSize = true;
            lbCarList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarList.Location = new System.Drawing.Point(22, 73);
            lbCarList.Name = "lbCarList";
            lbCarList.Size = new System.Drawing.Size(188, 28);
            lbCarList.TabIndex = 15;
            lbCarList.Text = "List Car Infromation ";
            // 
            // lbRentCar
            // 
            lbRentCar.AutoSize = true;
            lbRentCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRentCar.Location = new System.Drawing.Point(22, 300);
            lbRentCar.Name = "lbRentCar";
            lbRentCar.Size = new System.Drawing.Size(147, 28);
            lbRentCar.TabIndex = 16;
            lbRentCar.Text = "List Car Renting";
            // 
            // dgvListTransHis
            // 
            dgvListTransHis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvListTransHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTransHis.Location = new System.Drawing.Point(532, 331);
            dgvListTransHis.Name = "dgvListTransHis";
            dgvListTransHis.ReadOnly = true;
            dgvListTransHis.RowHeadersWidth = 51;
            dgvListTransHis.RowTemplate.Height = 29;
            dgvListTransHis.Size = new System.Drawing.Size(497, 136);
            dgvListTransHis.TabIndex = 17;
            // 
            // lbTransHis
            // 
            lbTransHis.AutoSize = true;
            lbTransHis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTransHis.Location = new System.Drawing.Point(532, 300);
            lbTransHis.Name = "lbTransHis";
            lbTransHis.Size = new System.Drawing.Size(178, 28);
            lbTransHis.TabIndex = 18;
            lbTransHis.Text = "Transaction History";
            // 
            // frmRentingSystem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1059, 530);
            Controls.Add(lbTransHis);
            Controls.Add(dgvListTransHis);
            Controls.Add(lbRentCar);
            Controls.Add(lbCarList);
            Controls.Add(txtCusId);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(lbCusId);
            Controls.Add(btnLoad);
            Controls.Add(btnRent);
            Controls.Add(btnAdd);
            Controls.Add(dgvListCarRenting);
            Controls.Add(dgvCarAvailable);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Name = "frmRentingSystem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRentManagement";
            Load += frmRentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarAvailable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListCarRenting).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListTransHis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCarAvailable;
        private System.Windows.Forms.DataGridView dgvListCarRenting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbCusId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label lbCarList;
        private System.Windows.Forms.Label lbRentCar;
        private System.Windows.Forms.DataGridView dgvListTransHis;
        private System.Windows.Forms.Label lbTransHis;
    }
}