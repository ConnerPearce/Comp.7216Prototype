using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.Payee_Page
{
    public partial class PayeeHome : Form
    {
        public PayeeHome()
        {
            InitializeComponent();
        }

        private void btnCreatePayee_Click(object sender, EventArgs e)
        {
            CreatePayee createPayee = new CreatePayee();
            createPayee.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeNavigation homeNavigation = new HomeNavigation();
            homeNavigation.Show();
            Hide();
        }

        private void btnUpdatePayee_Click(object sender, EventArgs e)
        {
            UpdatePayee updatePayee = new UpdatePayee();
            updatePayee.Show();
            Hide();
        }

        private void btnRequestPayee_Click(object sender, EventArgs e)
        {
            RequestPayee requestPayee = new RequestPayee();
            requestPayee.Show();
            Hide();
        }

        private void btnDeletePayee_Click(object sender, EventArgs e)
        {
            DeletePayee deletePayee = new DeletePayee();
            deletePayee.Show();
            Hide();
        }
    }
}
