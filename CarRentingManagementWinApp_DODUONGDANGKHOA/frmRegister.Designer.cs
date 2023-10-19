namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmRegister
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
            lbCusName = new System.Windows.Forms.Label();
            lbTel = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbDOB = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtCusName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            dtpDOB = new System.Windows.Forms.DateTimePicker();
            btnRegister = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            mtbTel = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // lbCusName
            // 
            lbCusName.AutoSize = true;
            lbCusName.Location = new System.Drawing.Point(48, 126);
            lbCusName.Name = "lbCusName";
            lbCusName.Size = new System.Drawing.Size(116, 20);
            lbCusName.TabIndex = 0;
            lbCusName.Text = "Customer Name";
            // 
            // lbTel
            // 
            lbTel.AutoSize = true;
            lbTel.Location = new System.Drawing.Point(345, 130);
            lbTel.Name = "lbTel";
            lbTel.Size = new System.Drawing.Size(78, 20);
            lbTel.TabIndex = 1;
            lbTel.Text = "Telephone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(48, 60);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Location = new System.Drawing.Point(345, 60);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new System.Drawing.Size(131, 20);
            lbDOB.TabIndex = 3;
            lbDOB.Text = "Customer Birthday";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(48, 185);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // txtCusName
            // 
            txtCusName.Location = new System.Drawing.Point(172, 123);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new System.Drawing.Size(157, 27);
            txtCusName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(172, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(157, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(172, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(157, 27);
            txtPassword.TabIndex = 11;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new System.Drawing.Point(498, 55);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new System.Drawing.Size(250, 27);
            dtpDOB.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(172, 261);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(94, 29);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(329, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(498, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mtbTel
            // 
            mtbTel.Location = new System.Drawing.Point(498, 127);
            mtbTel.Mask = "0000-000-000";
            mtbTel.Name = "mtbTel";
            mtbTel.Size = new System.Drawing.Size(157, 27);
            mtbTel.TabIndex = 16;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 328);
            Controls.Add(mtbTel);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(dtpDOB);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtCusName);
            Controls.Add(lbPassword);
            Controls.Add(lbDOB);
            Controls.Add(lbEmail);
            Controls.Add(lbTel);
            Controls.Add(lbCusName);
            Name = "frmRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mtbTel;
    }
}