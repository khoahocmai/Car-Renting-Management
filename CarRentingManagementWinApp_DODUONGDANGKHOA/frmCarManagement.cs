using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmCarManagement : Form
    {
        ICarRepository repo = new CarRepository();
        IManufacturerSupplierRepository MSRepo = new ManufacturerSupplierRepository();
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCarInformation();
        }
        // Xử lý nút "Load"

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCarDetail carDetail = new frmCarDetail
            {
                Text = "Add new Car",
                InsertOrUpdate = false,
                CarRepository = repo
            };
            carDetail.ShowDialog();
            LoadCarInformation();

        }
        // Xử lý nút "Add"

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableText(true);
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Enabled = true;
            btnCancel.Visible = true;
        }
        // Xử lý nút "Update"

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Air Conditioner Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var car = new CarInformation()
                {
                    CarId = int.Parse(txtCarId.Text),
                };
                repo.DeleteCar(car);
                LoadCarInformation();
                EnableText(false);
                btnSave.Enabled = false;
            }
        }
        // Xử lý nút "Delete"

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new CarInformation()
                {
                    CarId = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    CarDescription = txtCarDescription.Text,
                    NumberOfDoors = int.Parse(txtNumberOfDoors.Text),
                    SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                    FuelType = txtFuelType.Text,
                    Year = int.Parse(txtYear.Text),
                    ManufacturerId = int.Parse(txtManufacturerId.Text),
                    SupplierId = int.Parse(txtSupplierId.Text),
                    CarStatus = byte.Parse(txtCarStatus.Text),
                    CarRentingPricePerDay = decimal.Parse(txtCarRentingPricePerDay.Text),
                };
                repo.UpdateCar(car);
                MessageBox.Show("Update Car successfully");
                LoadCarInformation();
                EnableText(false);
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Update Car");
            }
        }
        // Xử lí nút "Save" của nút "Update"

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            LoadCarInformation();
            EnableText(false);
        }
        // Xử lí nút "Cancel" của nút "Update"

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text;

                if (rdbID.Checked)
                {
                    var data = repo.GetCarInformationById(int.Parse(searchTerm));
                    source = new BindingSource();
                    source.DataSource = data;

                    dgvCarInformation.DataSource = null;
                    dgvCarInformation.DataSource = source;
                }
                if (rdbName.Checked)
                {
                    var data = repo.GetCarInformationByString(searchTerm);
                    source = new BindingSource();
                    source.DataSource = data;

                    dgvCarInformation.DataSource = null;
                    dgvCarInformation.DataSource = source;
                }
                if (rdbPrice.Checked)
                {
                    var data = repo.GetCarInformationByCarRentingPricePerDay(decimal.Parse(searchTerm));
                    source = new BindingSource();
                    source.DataSource = data;

                    dgvCarInformation.DataSource = null;
                    dgvCarInformation.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search");
            }

        }

        private void btnSearchCarName_Click(object sender, EventArgs e)
        {
            try
            {
                var carName = txtSearch.Text;
                var car = repo.GetCarInformationByString(carName);

                source = new BindingSource();
                source.DataSource = car;

                dgvCarInformation.DataSource = null;
                dgvCarInformation.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search by Name");
            }
        }
        // Xứ lý nút "Search Car Name"

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }
        // Xử lý nút "Back"

        public void LoadCarInformation()
        {
            try
            {
                var aList = repo.GetCarInformation();
                var mList = MSRepo.GetManufacturers();
                var sList = MSRepo.GetSuppliers();

                BindingSource source = new BindingSource();
                BindingSource sourceM = new BindingSource();
                BindingSource sourceS = new BindingSource();
                source.DataSource = aList;
                sourceM.DataSource = mList;
                sourceS.DataSource = sList;

                txtCarId.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtCarDescription.DataBindings.Clear();

                txtNumberOfDoors.DataBindings.Clear();
                txtSeatingCapacity.DataBindings.Clear();
                txtFuelType.DataBindings.Clear();

                txtYear.DataBindings.Clear();
                txtManufacturerId.DataBindings.Clear();
                txtSupplierId.DataBindings.Clear();

                txtCarStatus.DataBindings.Clear();
                txtCarRentingPricePerDay.DataBindings.Clear();

                txtCarId.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtCarDescription.DataBindings.Add("Text", source, "CarDescription");
                txtNumberOfDoors.DataBindings.Add("Text", source, "NumberOfDoors");
                txtSeatingCapacity.DataBindings.Add("Text", source, "SeatingCapacity");
                txtFuelType.DataBindings.Add("Text", source, "FuelType");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtManufacturerId.DataBindings.Add("Text", source, "ManufacturerID");
                txtSupplierId.DataBindings.Add("Text", source, "SupplierID");
                txtCarStatus.DataBindings.Add("Text", source, "CarStatus");
                txtCarRentingPricePerDay.DataBindings.Add("Text", source, "CarRentingPricePerDay");

                dgvCarInformation.DataSource = null;
                dgvCarInformation.DataSource = source;
                dgvManufacturer.DataSource = sourceM;
                dgvSupplier.DataSource = sourceS;

                dgvManufacturer.Columns["CarInformations"].Visible = false;
                dgvSupplier.Columns["CarInformations"].Visible = false;
                dgvCarInformation.Columns["Manufacturer"].Visible = false;
                dgvCarInformation.Columns["Supplier"].Visible = false;
                dgvCarInformation.Columns["RentingDetails"].Visible = false;

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                if (aList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of car information");
            }
        }
        // Load danh sách Car vào DataGridView, bind các TextBox với
        // các thuộc tính dùng Binding Source

        private void ClearText()
        {
            txtCarId.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtCarDescription.Text = string.Empty;
            txtNumberOfDoors.Text = string.Empty;
            txtSeatingCapacity.Text = string.Empty;
            txtFuelType.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtManufacturerId.Text = string.Empty;
            txtSupplierId.Text = string.Empty;
            txtCarStatus.Text = string.Empty;
            txtCarRentingPricePerDay.Text = string.Empty;
        }
        // Làm empty các TextBox, ComboBox chọn về phần tử đầu tiên

        private void EnableText(bool status)
        {
            txtCarId.Enabled = status;
            txtCarName.Enabled = status;
            txtCarDescription.Enabled = status;
            txtNumberOfDoors.Enabled = status;
            txtSeatingCapacity.Enabled = status;
            txtFuelType.Enabled = status;
            txtYear.Enabled = status;
            txtManufacturerId.Enabled = status;
            txtSupplierId.Enabled = status;
            txtCarStatus.Enabled = status;
            txtCarRentingPricePerDay.Enabled = status;
        }
        // Enable/Disable các TextBox tùy tham số truyền vào

        private void frmCustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure to want to exit?",
                "Car Management System", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        //Xử lý sự kiện Form_Closing mở hộp thoại xác nhận

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCarInformation();
            EnableText(false);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
        // Xử lý sự kiện Form_Load

        private void btnUpdatePopup_Click(object sender, EventArgs e)
        {
            frmCarDetail carDetail = new frmCarDetail
            {
                Text = "Update Car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = repo,
            };
            carDetail.ShowDialog();
            LoadCarInformation();
        }
        // Xử lý nút "UpdatePop"     

        private void btnExit_Click(object sender, EventArgs e) => Close();
        // Xử lý nút "Exit"

        private CarInformation GetCarObject()
        {
            CarInformation car = null;
            try
            {
                car = new CarInformation
                {
                    CarId = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    CarDescription = txtCarDescription.Text,
                    NumberOfDoors = int.Parse(txtNumberOfDoors.Text),
                    SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                    FuelType = txtFuelType.Text,
                    Year = int.Parse(txtYear.Text),
                    ManufacturerId = int.Parse(txtManufacturerId.Text),
                    SupplierId = int.Parse(txtSupplierId.Text),
                    CarStatus = byte.Parse(txtCarStatus.Text),
                    CarRentingPricePerDay = decimal.Parse(txtCarRentingPricePerDay.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return car;
        }

    }
}
