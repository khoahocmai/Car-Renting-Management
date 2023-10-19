namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmMenu
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
            btnFrmCar = new System.Windows.Forms.Button();
            btnFrmCustomer = new System.Windows.Forms.Button();
            btnFrmManagement = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnFrmCar
            // 
            btnFrmCar.Location = new System.Drawing.Point(44, 112);
            btnFrmCar.Name = "btnFrmCar";
            btnFrmCar.Size = new System.Drawing.Size(227, 51);
            btnFrmCar.TabIndex = 0;
            btnFrmCar.Text = "Car Management";
            btnFrmCar.UseVisualStyleBackColor = true;
            btnFrmCar.Click += btnFrmCar_Click;
            // 
            // btnFrmCustomer
            // 
            btnFrmCustomer.Location = new System.Drawing.Point(296, 112);
            btnFrmCustomer.Name = "btnFrmCustomer";
            btnFrmCustomer.Size = new System.Drawing.Size(227, 51);
            btnFrmCustomer.TabIndex = 1;
            btnFrmCustomer.Text = "Customer Management";
            btnFrmCustomer.UseVisualStyleBackColor = true;
            btnFrmCustomer.Click += btnFrmCustomer_Click;
            // 
            // btnFrmManagement
            // 
            btnFrmManagement.Location = new System.Drawing.Point(550, 112);
            btnFrmManagement.Name = "btnFrmManagement";
            btnFrmManagement.Size = new System.Drawing.Size(227, 51);
            btnFrmManagement.TabIndex = 2;
            btnFrmManagement.Text = "Renting Management";
            btnFrmManagement.UseVisualStyleBackColor = true;
            btnFrmManagement.Click += btnFrmManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(249, 215);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(429, 215);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(846, 305);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnFrmManagement);
            Controls.Add(btnFrmCustomer);
            Controls.Add(btnFrmCar);
            Name = "frmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnFrmCar;
        private System.Windows.Forms.Button btnFrmCustomer;
        private System.Windows.Forms.Button btnFrmManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}