namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    partial class frmCarManagement
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
            txtCarStatus = new System.Windows.Forms.TextBox();
            txtSupplierId = new System.Windows.Forms.TextBox();
            txtFuelType = new System.Windows.Forms.TextBox();
            txtSeatingCapacity = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtCarId = new System.Windows.Forms.TextBox();
            lbCarStatus = new System.Windows.Forms.Label();
            lbSupplierId = new System.Windows.Forms.Label();
            lbFuelType = new System.Windows.Forms.Label();
            lbSeatingCapacity = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbCarId = new System.Windows.Forms.Label();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            txtCarRentingPricePerDay = new System.Windows.Forms.TextBox();
            txtManufacturerId = new System.Windows.Forms.TextBox();
            txtYear = new System.Windows.Forms.TextBox();
            txtNumberOfDoors = new System.Windows.Forms.TextBox();
            txtCarDescription = new System.Windows.Forms.TextBox();
            lbManufacturerId = new System.Windows.Forms.Label();
            lbNumberOfDoors = new System.Windows.Forms.Label();
            lbCarRentingPricePerDay = new System.Windows.Forms.Label();
            lbYear = new System.Windows.Forms.Label();
            lbCarDescription = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            dgvCarInformation = new System.Windows.Forms.DataGridView();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnUpdatePopup = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            dgvManufacturer = new System.Windows.Forms.DataGridView();
            dgvSupplier = new System.Windows.Forms.DataGridView();
            lbCarList = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbSupplier = new System.Windows.Forms.Label();
            rdbID = new System.Windows.Forms.RadioButton();
            rdbName = new System.Windows.Forms.RadioButton();
            rdbPrice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvCarInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // txtCarStatus
            // 
            txtCarStatus.Location = new System.Drawing.Point(465, 260);
            txtCarStatus.Name = "txtCarStatus";
            txtCarStatus.Size = new System.Drawing.Size(170, 27);
            txtCarStatus.TabIndex = 33;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new System.Drawing.Point(465, 214);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new System.Drawing.Size(170, 27);
            txtSupplierId.TabIndex = 32;
            // 
            // txtFuelType
            // 
            txtFuelType.AcceptsReturn = true;
            txtFuelType.Location = new System.Drawing.Point(465, 53);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new System.Drawing.Size(170, 27);
            txtFuelType.TabIndex = 31;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.Location = new System.Drawing.Point(151, 260);
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new System.Drawing.Size(170, 27);
            txtSeatingCapacity.TabIndex = 30;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(151, 108);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(170, 27);
            txtCarName.TabIndex = 29;
            // 
            // txtCarId
            // 
            txtCarId.Location = new System.Drawing.Point(151, 53);
            txtCarId.Name = "txtCarId";
            txtCarId.ReadOnly = true;
            txtCarId.Size = new System.Drawing.Size(170, 27);
            txtCarId.TabIndex = 28;
            // 
            // lbCarStatus
            // 
            lbCarStatus.AutoSize = true;
            lbCarStatus.Location = new System.Drawing.Point(349, 263);
            lbCarStatus.Name = "lbCarStatus";
            lbCarStatus.Size = new System.Drawing.Size(75, 20);
            lbCarStatus.TabIndex = 27;
            lbCarStatus.Text = "Car Status";
            // 
            // lbSupplierId
            // 
            lbSupplierId.AutoSize = true;
            lbSupplierId.Location = new System.Drawing.Point(349, 217);
            lbSupplierId.Name = "lbSupplierId";
            lbSupplierId.Size = new System.Drawing.Size(83, 20);
            lbSupplierId.TabIndex = 26;
            lbSupplierId.Text = "Supplier ID";
            // 
            // lbFuelType
            // 
            lbFuelType.AutoSize = true;
            lbFuelType.Location = new System.Drawing.Point(348, 56);
            lbFuelType.Name = "lbFuelType";
            lbFuelType.Size = new System.Drawing.Size(71, 20);
            lbFuelType.TabIndex = 25;
            lbFuelType.Text = "Fuel Type";
            // 
            // lbSeatingCapacity
            // 
            lbSeatingCapacity.AutoSize = true;
            lbSeatingCapacity.Location = new System.Drawing.Point(24, 263);
            lbSeatingCapacity.Name = "lbSeatingCapacity";
            lbSeatingCapacity.Size = new System.Drawing.Size(120, 20);
            lbSeatingCapacity.TabIndex = 24;
            lbSeatingCapacity.Text = "Seating Capacity";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(24, 111);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 23;
            lbCarName.Text = "Car Name";
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new System.Drawing.Point(24, 56);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new System.Drawing.Size(50, 20);
            lbCarId.TabIndex = 22;
            lbCarId.Text = "Car ID";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(24, 475);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 50;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(136, 477);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(140, 27);
            txtSearch.TabIndex = 48;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(504, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(250, 371);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(136, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(24, 371);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 44;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtCarRentingPricePerDay
            // 
            txtCarRentingPricePerDay.Location = new System.Drawing.Point(216, 318);
            txtCarRentingPricePerDay.Name = "txtCarRentingPricePerDay";
            txtCarRentingPricePerDay.Size = new System.Drawing.Size(170, 27);
            txtCarRentingPricePerDay.TabIndex = 43;
            // 
            // txtManufacturerId
            // 
            txtManufacturerId.Location = new System.Drawing.Point(465, 163);
            txtManufacturerId.Name = "txtManufacturerId";
            txtManufacturerId.Size = new System.Drawing.Size(170, 27);
            txtManufacturerId.TabIndex = 42;
            // 
            // txtYear
            // 
            txtYear.Location = new System.Drawing.Point(465, 108);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(170, 27);
            txtYear.TabIndex = 41;
            // 
            // txtNumberOfDoors
            // 
            txtNumberOfDoors.Location = new System.Drawing.Point(151, 214);
            txtNumberOfDoors.Name = "txtNumberOfDoors";
            txtNumberOfDoors.Size = new System.Drawing.Size(170, 27);
            txtNumberOfDoors.TabIndex = 40;
            // 
            // txtCarDescription
            // 
            txtCarDescription.Location = new System.Drawing.Point(151, 163);
            txtCarDescription.Name = "txtCarDescription";
            txtCarDescription.Size = new System.Drawing.Size(170, 27);
            txtCarDescription.TabIndex = 39;
            // 
            // lbManufacturerId
            // 
            lbManufacturerId.AutoSize = true;
            lbManufacturerId.Location = new System.Drawing.Point(348, 166);
            lbManufacturerId.Name = "lbManufacturerId";
            lbManufacturerId.Size = new System.Drawing.Size(116, 20);
            lbManufacturerId.TabIndex = 38;
            lbManufacturerId.Text = "Manufacturer ID";
            // 
            // lbNumberOfDoors
            // 
            lbNumberOfDoors.AutoSize = true;
            lbNumberOfDoors.Location = new System.Drawing.Point(24, 217);
            lbNumberOfDoors.Name = "lbNumberOfDoors";
            lbNumberOfDoors.Size = new System.Drawing.Size(127, 20);
            lbNumberOfDoors.TabIndex = 37;
            lbNumberOfDoors.Text = "Number Of Doors";
            // 
            // lbCarRentingPricePerDay
            // 
            lbCarRentingPricePerDay.AutoSize = true;
            lbCarRentingPricePerDay.Location = new System.Drawing.Point(24, 321);
            lbCarRentingPricePerDay.Name = "lbCarRentingPricePerDay";
            lbCarRentingPricePerDay.Size = new System.Drawing.Size(176, 20);
            lbCarRentingPricePerDay.TabIndex = 36;
            lbCarRentingPricePerDay.Text = "Car Renting Price Per Day";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new System.Drawing.Point(349, 111);
            lbYear.Name = "lbYear";
            lbYear.Size = new System.Drawing.Size(37, 20);
            lbYear.TabIndex = 35;
            lbYear.Text = "Year";
            // 
            // lbCarDescription
            // 
            lbCarDescription.AutoSize = true;
            lbCarDescription.Location = new System.Drawing.Point(24, 166);
            lbCarDescription.Name = "lbCarDescription";
            lbCarDescription.Size = new System.Drawing.Size(111, 20);
            lbCarDescription.TabIndex = 34;
            lbCarDescription.Text = "Car Description";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(24, 608);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 52;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvCarInformation
            // 
            dgvCarInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarInformation.Location = new System.Drawing.Point(668, 395);
            dgvCarInformation.Name = "dgvCarInformation";
            dgvCarInformation.ReadOnly = true;
            dgvCarInformation.RowHeadersWidth = 51;
            dgvCarInformation.RowTemplate.Height = 29;
            dgvCarInformation.Size = new System.Drawing.Size(796, 242);
            dgvCarInformation.TabIndex = 53;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(350, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(350, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdatePopup
            // 
            btnUpdatePopup.Location = new System.Drawing.Point(250, 406);
            btnUpdatePopup.Name = "btnUpdatePopup";
            btnUpdatePopup.Size = new System.Drawing.Size(94, 29);
            btnUpdatePopup.TabIndex = 56;
            btnUpdatePopup.Text = "UpdatePop";
            btnUpdatePopup.UseVisualStyleBackColor = true;
            btnUpdatePopup.Click += btnUpdatePopup_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(124, 608);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 57;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvManufacturer
            // 
            dgvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturer.Location = new System.Drawing.Point(668, 92);
            dgvManufacturer.Name = "dgvManufacturer";
            dgvManufacturer.ReadOnly = true;
            dgvManufacturer.RowHeadersWidth = 51;
            dgvManufacturer.RowTemplate.Height = 29;
            dgvManufacturer.Size = new System.Drawing.Size(390, 234);
            dgvManufacturer.TabIndex = 58;
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new System.Drawing.Point(1074, 92);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.RowTemplate.Height = 29;
            dgvSupplier.Size = new System.Drawing.Size(390, 234);
            dgvSupplier.TabIndex = 59;
            // 
            // lbCarList
            // 
            lbCarList.AutoSize = true;
            lbCarList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarList.Location = new System.Drawing.Point(991, 357);
            lbCarList.Name = "lbCarList";
            lbCarList.Size = new System.Drawing.Size(264, 35);
            lbCarList.TabIndex = 60;
            lbCarList.Text = "List of Car Information";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbManufacturer.Location = new System.Drawing.Point(752, 44);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(238, 35);
            lbManufacturer.TabIndex = 61;
            lbManufacturer.Text = "List of Manufacturer";
            // 
            // lbSupplier
            // 
            lbSupplier.AutoSize = true;
            lbSupplier.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSupplier.Location = new System.Drawing.Point(1190, 44);
            lbSupplier.Name = "lbSupplier";
            lbSupplier.Size = new System.Drawing.Size(180, 35);
            lbSupplier.TabIndex = 62;
            lbSupplier.Text = "List of Supplier";
            // 
            // rdbID
            // 
            rdbID.AutoSize = true;
            rdbID.Checked = true;
            rdbID.Location = new System.Drawing.Point(293, 480);
            rdbID.Name = "rdbID";
            rdbID.Size = new System.Drawing.Size(93, 24);
            rdbID.TabIndex = 63;
            rdbID.TabStop = true;
            rdbID.Text = "Search ID";
            rdbID.UseVisualStyleBackColor = true;
            // 
            // rdbName
            // 
            rdbName.AutoSize = true;
            rdbName.Location = new System.Drawing.Point(293, 510);
            rdbName.Name = "rdbName";
            rdbName.Size = new System.Drawing.Size(118, 24);
            rdbName.TabIndex = 64;
            rdbName.Text = "Search Name";
            rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbPrice
            // 
            rdbPrice.AutoSize = true;
            rdbPrice.Location = new System.Drawing.Point(293, 540);
            rdbPrice.Name = "rdbPrice";
            rdbPrice.Size = new System.Drawing.Size(110, 24);
            rdbPrice.TabIndex = 65;
            rdbPrice.Text = "Search Price";
            rdbPrice.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1490, 660);
            Controls.Add(rdbPrice);
            Controls.Add(rdbName);
            Controls.Add(rdbID);
            Controls.Add(lbSupplier);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarList);
            Controls.Add(dgvSupplier);
            Controls.Add(dgvManufacturer);
            Controls.Add(btnExit);
            Controls.Add(btnUpdatePopup);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvCarInformation);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(txtCarRentingPricePerDay);
            Controls.Add(txtManufacturerId);
            Controls.Add(txtYear);
            Controls.Add(txtNumberOfDoors);
            Controls.Add(txtCarDescription);
            Controls.Add(lbManufacturerId);
            Controls.Add(lbNumberOfDoors);
            Controls.Add(lbCarRentingPricePerDay);
            Controls.Add(lbYear);
            Controls.Add(lbCarDescription);
            Controls.Add(txtCarStatus);
            Controls.Add(txtSupplierId);
            Controls.Add(txtFuelType);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtCarName);
            Controls.Add(txtCarId);
            Controls.Add(lbCarStatus);
            Controls.Add(lbSupplierId);
            Controls.Add(lbFuelType);
            Controls.Add(lbSeatingCapacity);
            Controls.Add(lbCarName);
            Controls.Add(lbCarId);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCustomerManagement";
            FormClosing += frmCustomerManagement_FormClosing;
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCarStatus;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtSeatingCapacity;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label lbCarStatus;
        private System.Windows.Forms.Label lbSupplierId;
        private System.Windows.Forms.Label lbFuelType;
        private System.Windows.Forms.Label lbSeatingCapacity;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbCarId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtCarRentingPricePerDay;
        private System.Windows.Forms.TextBox txtManufacturerId;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumberOfDoors;
        private System.Windows.Forms.TextBox txtCarDescription;
        private System.Windows.Forms.Label lbManufacturerId;
        private System.Windows.Forms.Label lbNumberOfDoors;
        private System.Windows.Forms.Label lbCarRentingPricePerDay;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbCarDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCarInformation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdatePopup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvManufacturer;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label lbCarList;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbPrice;
    }
}