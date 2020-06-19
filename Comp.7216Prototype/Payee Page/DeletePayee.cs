using Comp._7216Prototype.Database_Files;
using Comp._7216Prototype.Database_Files.Data;
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
    public partial class DeletePayee : Form
    {
        public DeletePayee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PayeeHome home = new PayeeHome();
            home.Show();
            Hide();
        }

        private async void btnDeletePayee_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (!string.IsNullOrEmpty(txtUserId.Text) && !string.IsNullOrEmpty(txtCustomerId.Text))
            {
                bool success = await dataService.DeletePayeeAsync<PayeeDetails>(txtUserId.Text, txtCustomerId.Text);
                if (success)
                    MessageBox.Show("Payee Deleted");
                else
                    MessageBox.Show("Payee unable to be deleted");
            }
            else
                MessageBox.Show("Please Enter a UserID & CustomerID");
        }
    }
}