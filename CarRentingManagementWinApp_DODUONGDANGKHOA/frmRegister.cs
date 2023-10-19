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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmRegister : Form
    {
        public ICustomerRepository cusRepo = new CustomerRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtCusName.Text == "" ||
                    txtPassword.Text == "" || mtbTel.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Register",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var customer = new Customer()
                    {
                        CustomerName = txtCusName.Text,
                        Telephone = mtbTel.Text,
                        Email = txtEmail.Text,
                        CustomerBirthday = DateTime.Parse(dtpDOB.Text),
                        CustomerStatus = 1,
                        Password = txtPassword.Text,
                    };
                    cusRepo.Register(customer);
                    MessageBox.Show("Register successfully", "Register");
                    this.Hide();
                    frmRentingSystem frm = new frmRentingSystem();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Register");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtCusName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
            mtbTel.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
    }
}
