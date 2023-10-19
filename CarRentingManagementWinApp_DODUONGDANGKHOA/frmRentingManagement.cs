using Repositories;
using System;
using System.Collections;
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
    public partial class frmRentingManagement : Form
    {
        ICarRepository repo = new CarRepository();
        IRentingRepository renRepo = new RentingRepository();
        public frmRentingManagement()
        {
            InitializeComponent();
        }

        private void frmRentingManagement_Load(object sender, EventArgs e)
        {
            var carList = repo.GetCarInformation();
            var renDelList = renRepo.GetRentingDetails();
            var renTransList = renRepo.GetRentingTransactions();

            BindingSource source = new BindingSource();
            BindingSource sourceD = new BindingSource();
            BindingSource sourceT = new BindingSource();
            source.DataSource = carList;
            sourceD.DataSource = renDelList;
            sourceT.DataSource = renTransList;

            dgvRentDetail.DataSource = sourceD;
            dgvRentTransc.DataSource = sourceT;
            dgvCarInfor.DataSource = source;

            dgvRentDetail.Columns["Car"].Visible = false;
            dgvRentDetail.Columns["RentingTransaction"].Visible = false;
            dgvRentTransc.Columns["RentingDetails"].Visible = false;
            dgvCarInfor.Columns["Manufacturer"].Visible = false;
            dgvCarInfor.Columns["Supplier"].Visible = false;
            dgvCarInfor.Columns["RentingDetails"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
