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
    public partial class CreatePayee : Form
    {
        // This is to specify which collection (Table) to insert/update/delete data from
        private readonly string CollectioName = "PayeeDetails";

        public CreatePayee()
        {
            InitializeComponent();
        }

        private async void btnCreatePayee_Click(object sender, EventArgs e)
        {
            // This is used to call methods for the database
            // Its needed
            DataService dataService = new DataService();

            // Checks the text box and if its not empty it will run the code inside
            if (!string.IsNullOrEmpty(txtCreateId.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                // When you insert you need to create a new model of what you need and insert all the items on creation
                // i.e for me since its to do with payee's the model i use is PayeeDetails
                await dataService.InsertAsync(new PayeeDetails()
                {
                    CustomerId = txtCreateId.Text,
                    UserName = txtUsername.Text,
                }, CollectioName); // Collection name is needed every time so that the DataService knows what table to insert data into

                MessageBox.Show("Created"); // Just to show users the action has completed
            }
            else // If the text box is empty it will give an error (ERRORS ARE NEEDED)
                MessageBox.Show("Please enter something");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PayeeHome home = new PayeeHome();
            home.Show();
            Hide();
        }
    }
}