using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingManagementWinApp_DODUONGDANGKHOA
{
    public partial class frmLogin : Form
    {
        ICustomerRepository cusRepo = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtTK = txtUsername.Text;
            string txtMK = txtPassword.Text;
            IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
            string emAD = config["AdminAccount:Email"];
            string psAD = config["AdminAccount:Password"];
            if (txtTK == "" || txtMK == "")
            {
                MessageBox.Show("Missing field!");
            }
            else
            {
                if (txtTK == emAD && txtMK == psAD)
                {
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    var tmp = cusRepo.CheckLogin(txtTK, txtMK);
                    if (tmp != null)
                    {
                        this.Hide();
                        frmRentingSystem frm = new frmRentingSystem();
                        frm.customerId = tmp.CustomerId.ToString();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You have no pemission to do this function!",
                            "Air Conditioner Management");
                    }
                }

            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            this.Close();
        }
    }
}
