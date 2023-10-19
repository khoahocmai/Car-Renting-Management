using BusinessObject;
using Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmRentingSystem : Form
    {
        public string customerId;
        ICarRepository repo = new CarRepository();
        ICustomerRepository cusRepo = new CustomerRepository();
        IRentingRepository renRepo = new RentingRepository();
        BindingSource source = new BindingSource();
        List<CarInformation> list = new List<CarInformation>();
        public frmRentingSystem()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public void LoadCarInformation()
        {
            try
            {
                txtCusId.Text = customerId;
                var aList = repo.GetCarInformation();
                var historyList = renRepo.GetRentingTransactionByCusId(int.Parse(customerId));

                BindingSource source = new BindingSource();
                source.DataSource = aList;

                dgvCarAvailable.DataSource = null;
                dgvCarAvailable.DataSource = source;
                dgvListTransHis.DataSource = historyList;
                dgvListTransHis.Columns["CustomerId"].Visible = false;
                dgvListTransHis.Columns["Customer"].Visible = false;
                dgvListTransHis.Columns["RentingDetails"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of car information");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var timeFrom = DateTime.Parse(dtpFrom.Text);
            var timeTo = DateTime.Parse(dtpTo.Text);
            if (timeFrom > timeTo)
            {
                MessageBox.Show("The day in field 'To' must be after day in field 'From'");
                return;
            }

            var ListCarInfo = repo.GetCarInformation();

            BindingSource source = new BindingSource();
            source.DataSource = ListCarInfo;

            dgvCarAvailable.DataSource = null;
            dgvCarAvailable.DataSource = source;

            var ListRentDetail = renRepo.SearchByDate(timeFrom);

            List<int> ListIdNotAvai = new List<int>();

            foreach (RentingDetail obj in ListRentDetail)
            {
                ListIdNotAvai.Add(obj.CarId);
            }
            List<CarInformation> ListCarAvai = new List<CarInformation>();

            foreach (CarInformation obj in ListCarInfo)
            {
                if (!ListIdNotAvai.Contains(obj.CarId))
                {
                    ListCarAvai.Add(obj);
                }
            }

            dgvCarAvailable.DataSource = ListCarAvai;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCarAvailable.SelectedRows)
            {
                var car = new CarInformation
                {
                    CarId = int.Parse(row.Cells[0].Value.ToString()),
                    CarName = row.Cells[1].Value.ToString(),
                    CarDescription = row.Cells[2].Value.ToString(),
                    NumberOfDoors = int.Parse(row.Cells[3].Value.ToString()),
                    SeatingCapacity = int.Parse(row.Cells[4].Value.ToString()),
                    FuelType = row.Cells[5].Value.ToString(),
                    Year = int.Parse(row.Cells[6].Value.ToString()),
                    ManufacturerId = int.Parse(row.Cells[7].Value.ToString()),
                    SupplierId = int.Parse(row.Cells[8].Value.ToString()),
                    CarStatus = byte.Parse(row.Cells[9].Value.ToString()),
                    CarRentingPricePerDay = decimal.Parse(row.Cells[10].Value.ToString()),
                };
                list.Add(car);
            }

            dgvListCarRenting.DataSource = list;
        }

        private void frmRentManagement_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            LoadCarInformation();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCarInformation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                var timeFrom = DateTime.Parse(dtpFrom.Text);
                var timeTo = DateTime.Parse(dtpTo.Text);
                if (timeFrom > timeTo)
                {
                    MessageBox.Show("The day in field 'To' must be after day in field 'From'");
                    return;
                }
                TimeSpan difference = timeTo - timeFrom;
                int numberOfDays = difference.Days;
                decimal totalPrice = 0;


                foreach (DataGridViewRow row in dgvListCarRenting.Rows)
                {
                    totalPrice = totalPrice + (numberOfDays + 1) * decimal.Parse(row.Cells[10].Value.ToString());
                }
                var renId = renRepo.GetRentingTransactions().Count();

                var rentTrans = new RentingTransaction
                {
                    RentingTransationId = (renId + 1),
                    RentingDate = DateTime.Now,
                    TotalPrice = totalPrice,
                    CustomerId = int.Parse(txtCusId.Text),
                    RentingStatus = 1

                };
                renRepo.SaveRentTrans(rentTrans);

                foreach (DataGridViewRow row in dgvListCarRenting.Rows)
                {
                    var rentDet = new RentingDetail
                    {
                        RentingTransactionId = rentTrans.RentingTransationId,
                        CarId = int.Parse(row.Cells[0].Value.ToString()),
                        StartDate = timeFrom,
                        EndDate = timeTo,
                        Price = decimal.Parse(row.Cells[10].Value.ToString()),
                    };
                    renRepo.SaveRentingDetail(rentDet);
                }
                MessageBox.Show("Renting Car successfully");
                LoadCarInformation();
                dgvListCarRenting.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Renting System");
            }
        }
    }
}
