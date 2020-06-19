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
    public partial class UpdatePayee : Form
    {
        private readonly string CollectionName = "PayeeDetails";

        public UpdatePayee()
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

            if (!String.IsNullOrEmpty(txtId.Text) && !String.IsNullOrEmpty(txtCustomerId.Text) && !String.IsNullOrEmpty(txtUsername.Text))
            {
                var payee = await dataService.GetRecordByIdAsync<PayeeDetails>(CollectionName, txtId.Text);
                payee.CustomerId = txtCustomerId.Text;
                payee.UserName = txtUsername.Text;

                bool success = await dataService.UpdateAsync(payee.id, payee, CollectionName);
                if (success)
                    MessageBox.Show("Payee Updated");
                else
                    MessageBox.Show("Payee unable to be updated");
            }
            else
                MessageBox.Show("Please Enter a ID, UserID & Username");
        }
    }
}