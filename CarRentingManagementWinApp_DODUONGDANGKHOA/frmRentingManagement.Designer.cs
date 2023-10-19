namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmRentingManagement
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
            dgvRentDetail = new System.Windows.Forms.DataGridView();
            dgvRentTransc = new System.Windows.Forms.DataGridView();
            dgvCarInfor = new System.Windows.Forms.DataGridView();
            lbRentDetail = new System.Windows.Forms.Label();
            lbRentTrasc = new System.Windows.Forms.Label();
            lbCarInfo = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRentDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentTransc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarInfor).BeginInit();
            SuspendLayout();
            // 
            // dgvRentDetail
            // 
            dgvRentDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvRentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentDetail.Location = new System.Drawing.Point(263, 206);
            dgvRentDetail.Name = "dgvRentDetail";
            dgvRentDetail.ReadOnly = true;
            dgvRentDetail.RowHeadersWidth = 51;
            dgvRentDetail.RowTemplate.Height = 29;
            dgvRentDetail.Size = new System.Drawing.Size(534, 188);
            dgvRentDetail.TabIndex = 0;
            // 
            // dgvRentTransc
            // 
            dgvRentTransc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvRentTransc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentTransc.Location = new System.Drawing.Point(263, 12);
            dgvRentTransc.Name = "dgvRentTransc";
            dgvRentTransc.ReadOnly = true;
            dgvRentTransc.RowHeadersWidth = 51;
            dgvRentTransc.RowTemplate.Height = 29;
            dgvRentTransc.Size = new System.Drawing.Size(534, 188);
            dgvRentTransc.TabIndex = 1;
            // 
            // dgvCarInfor
            // 
            dgvCarInfor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarInfor.Location = new System.Drawing.Point(263, 400);
            dgvCarInfor.Name = "dgvCarInfor";
            dgvCarInfor.ReadOnly = true;
            dgvCarInfor.RowHeadersWidth = 51;
            dgvCarInfor.RowTemplate.Height = 29;
            dgvCarInfor.Size = new System.Drawing.Size(534, 188);
            dgvCarInfor.TabIndex = 2;
            // 
            // lbRentDetail
            // 
            lbRentDetail.AutoSize = true;
            lbRentDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRentDetail.Location = new System.Drawing.Point(12, 206);
            lbRentDetail.Name = "lbRentDetail";
            lbRentDetail.Size = new System.Drawing.Size(135, 28);
            lbRentDetail.TabIndex = 3;
            lbRentDetail.Text = "Renting Detail";
            // 
            // lbRentTrasc
            // 
            lbRentTrasc.AutoSize = true;
            lbRentTrasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRentTrasc.Location = new System.Drawing.Point(12, 12);
            lbRentTrasc.Name = "lbRentTrasc";
            lbRentTrasc.Size = new System.Drawing.Size(182, 28);
            lbRentTrasc.TabIndex = 4;
            lbRentTrasc.Text = "Renting Transaction";
            // 
            // lbCarInfo
            // 
            lbCarInfo.AutoSize = true;
            lbCarInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarInfo.Location = new System.Drawing.Point(12, 400);
            lbCarInfo.Name = "lbCarInfo";
            lbCarInfo.Size = new System.Drawing.Size(149, 28);
            lbCarInfo.TabIndex = 5;
            lbCarInfo.Text = "Car Information";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(12, 598);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(112, 598);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmRentingManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 634);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(lbCarInfo);
            Controls.Add(lbRentTrasc);
            Controls.Add(lbRentDetail);
            Controls.Add(dgvCarInfor);
            Controls.Add(dgvRentTransc);
            Controls.Add(dgvRentDetail);
            Name = "frmRentingManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRentingManagement";
            Load += frmRentingManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentTransc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarInfor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentDetail;
        private System.Windows.Forms.DataGridView dgvRentTransc;
        private System.Windows.Forms.DataGridView dgvCarInfor;
        private System.Windows.Forms.Label lbRentDetail;
        private System.Windows.Forms.Label lbRentTrasc;
        private System.Windows.Forms.Label lbCarInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}