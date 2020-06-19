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

namespace Comp._7216Prototype.Transaction
{
    public partial class CreateTransInfo : Form
    {
        private readonly string CollectionName = "TransactionDetails";

        public CreateTransInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Transaction navTrans = new Transaction();
            navTrans.Show();
            this.Hide();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // This is used to call methods for the database
            // Its needed
            DataService dataService = new DataService();

            //Check the textboxes, if its not empty then it will run the code inside
            if (!string.IsNullOrEmpty(txtItemPurchased.Text) && !string.IsNullOrEmpty(txtPaymentAmount.Text) && !string.IsNullOrEmpty(txtPaymentType.Text))
            {
                double temp;
                if (double.TryParse(txtPaymentAmount.Text, out temp))
                {
                    await dataService.InsertAsync(new TransactionDetails()
                    {
                        CustomerID = "5ee40425021fde6dc4b56218",
                        DateCreated = DateTime.Now,
                        ItemPurchased = txtItemPurchased.Text,
                        PaymentAmount = temp,
                        PaymentType = txtPaymentType.Text
                    }, CollectionName); ;

                    MessageBox.Show("Added");
                    txtItemPurchased.Text = "";
                    txtPaymentAmount.Text = "";
                    txtPaymentType.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a valid double");
                }
            }
            else
            {
                MessageBox.Show("Please enter something");
            }
        }
    }
}
