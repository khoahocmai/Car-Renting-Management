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

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmCarDetail : Form
    {
        public ICarRepository CarRepository = new CarRepository();
        IManufacturerSupplierRepository MSRepo = new ManufacturerSupplierRepository();
        public bool InsertOrUpdate { get; set; } // False: Insert, True: Update
        public CarInformation CarInfo { get; set; }
        public frmCarDetail()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    txtCarName.Text.Equals("") || txtCarDescription.Text.Equals("") ||
                    txtNumberOfDoors.Text.Equals("") || txtSeatingCapacity.Text.Equals("") ||
                    txtFuelType.Text.Equals("") || txtYear.Text.Equals("") ||
                    txtManufacturerId.Text.Equals("") || txtSupplierId.Text.Equals("") ||
                    txtCarStatus.Text.Equals("") || txtCarRentingPricePerDay.Text.Equals("")
                    )
                {
                    MessageBox.Show("All fields are required!", "FU Car Renting Management System",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var car = new CarInformation()
                    {
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
                    if (InsertOrUpdate == false) // Insert
                    {
                        CarRepository.InsertCar(car);
                    }
                    else
                    {
                        car.CarId = CarInfo.CarId;
                        CarRepository.UpdateCar(car);
                    }
                    MessageBox.Show(InsertOrUpdate == false ? "Add a new car successfully" : "Update a car successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Create Car");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmCarDetail_Load(object sender, EventArgs e)
        {
            var mList = MSRepo.GetManufacturers();
            var sList = MSRepo.GetSuppliers();

            BindingSource sourceM = new BindingSource();
            BindingSource sourceS = new BindingSource();
            sourceM.DataSource = mList;
            sourceS.DataSource = sList;

            if (InsertOrUpdate == true) // Update
            {
                btnAdd.Text = "Update";
                txtCarName.Text = CarInfo.CarName;
                txtCarDescription.Text = CarInfo.CarDescription;
                txtNumberOfDoors.Text = CarInfo.NumberOfDoors.ToString();
                txtSeatingCapacity.Text = CarInfo.SeatingCapacity.ToString();
                txtFuelType.Text = CarInfo.FuelType;
                txtYear.Text = CarInfo.Year.ToString();
                txtManufacturerId.Text = CarInfo.ManufacturerId.ToString();
                txtSupplierId.Text = CarInfo.SupplierId.ToString();
                txtCarStatus.Text = CarInfo.CarStatus.ToString();
                txtCarRentingPricePerDay.Text = CarInfo.CarRentingPricePerDay.ToString();
            }

            dgvManufacturer.DataSource = sourceM;
            dgvSupplier.DataSource = sourceS;
        }
    }
}
