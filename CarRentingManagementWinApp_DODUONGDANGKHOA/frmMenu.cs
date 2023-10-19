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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFrmCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarManagement frm = new frmCarManagement();
            frm.ShowDialog();
            this.Close();
        }

        private void btnFrmCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerManagement frm = new frmCustomerManagement();
            frm.ShowDialog();
            this.Close();
        }

        private void btnFrmManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentingManagement frm = new frmRentingManagement();
            frm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
