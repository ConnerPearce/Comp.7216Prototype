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
    public partial class RequestPayee : Form
    {
        private readonly string CollectionName = "PayeeDetails";

        public RequestPayee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PayeeHome home = new PayeeHome();
            home.Show();
            Hide();
        }

        private async void btnRequestPayee_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                var payee = await dataService.GetRecordByIdAsync<PayeeDetails>(CollectionName, txtId.Text);

                if (payee != default)
                {
                    txtUserId.Text = payee.UserId;
                    txtUsername.Text = payee.UserName;
                    txtCustomerId.Text = payee.CustomerId;
                }
                else
                    MessageBox.Show("Payee does not exist");
            }
            else
                MessageBox.Show("Please Enter an ID");
        }
    }
}