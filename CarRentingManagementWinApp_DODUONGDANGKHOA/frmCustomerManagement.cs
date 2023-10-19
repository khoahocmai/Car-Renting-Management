using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmCustomerManagement : Form
    {
        ICustomerRepository cusRepo = new CustomerRepository();
        BindingSource source;
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        public void LoadCustomer()
        {
            try
            {
                var cusList = cusRepo.GetCustomers();
                BindingSource source = new BindingSource();
                source.DataSource = cusList;

                txtCusId.DataBindings.Clear();
                txtCusName.DataBindings.Clear();
                txtCusEmail.DataBindings.Clear();
                mtbCusTel.DataBindings.Clear();
                txtCusDOB.DataBindings.Clear();
                txtCusStatus.DataBindings.Clear();

                txtCusId.DataBindings.Add("Text", source, "CustomerID");
                txtCusName.DataBindings.Add("Text", source, "CustomerName");
                txtCusEmail.DataBindings.Add("Text", source, "Email");
                mtbCusTel.DataBindings.Add("Text", source, "Telephone");
                txtCusDOB.DataBindings.Add("Text", source, "CustomerBirthday");
                txtCusStatus.DataBindings.Add("Text", source, "CustomerStatus");


                dgvCusList.DataSource = cusList;
                dgvCusList.DataSource = source;
                dgvCusList.Columns["Password"].Visible=false;
                dgvCusList.Columns["RentingTransactions"].Visible=false;

                if (cusList.Count() == 0)
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
                MessageBox.Show(ex.Message, "Error on load list of customer information");
            }
        }
        private void ClearText()
        {
            txtCusId.Text = string.Empty;
            txtCusName.Text = string.Empty;
            txtCusEmail.Text = string.Empty;
            mtbCusTel.Text = string.Empty;
            txtCusDOB.Text = string.Empty;
            txtCusStatus.Text = string.Empty;
        }
        private void EnableText(bool status)
        {
            txtCusId.Enabled = status;
            txtCusName.Enabled = status;
            txtCusEmail.Enabled = status;
            mtbCusTel.Enabled = status;
            txtCusDOB.Enabled = status;
            txtCusStatus.Enabled = status;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Customer Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var cus = new Customer()
                {
                    CustomerId = int.Parse(txtCusId.Text),
                };
                cusRepo.DeleteCus(cus);
                LoadCustomer();
                EnableText(false);
            }
        }
        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            EnableText(false);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var cusID = int.Parse(txtSearchId.Text);
                var cus = cusRepo.GetCustomerById(cusID);

                source = new BindingSource();
                source.DataSource = cus;

                dgvCusList.DataSource = null;
                dgvCusList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search by ID");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomer();
            EnableText(false);
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
