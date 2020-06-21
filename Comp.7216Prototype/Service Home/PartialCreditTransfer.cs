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

namespace Comp._7216Prototype.Service_Home
{
    public partial class PartialCreditTransfer : Form
    {
        private DataService dataService = new DataService();
        // Creating a variable to call the user anywhere
        private UserTable user = new UserTable();
        public PartialCreditTransfer()
        {
            InitializeComponent();
            PopulateList();
        }

        private async void PopulateList()
        {
            // Gets the user info from the database
            user = await dataService.GetRecordByIdAsync<UserTable>("UserTable", "5ee40425021fde6dc4b56218");
            if (user != null)
            {
                //Sets the labels if it finds a user
                label3.Text = $"${user.PartialCredit}";
                label4.Text = $"${user.PartialCredit}";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferCredit transferCredit = new TransferCredit();
            transferCredit.Show();
            Hide();
        }

        private void PartialCreditTransfer_Load(object sender, EventArgs e)
        {

        }

        private async void transferpartialcredit_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && comboBox1.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                DataService dataService = new DataService();
                // i is the amount we are transfering
                double i;
                // This checks that the text entered is actually a double/decimal
                if (double.TryParse(textBox1.Text, out i))
                {
                    // Checks if the user has enough credit to make the transfer
                    if (user.PartialCredit >= i)
                    {
                        await dataService.InsertAsync(new TransferDetails()
                {
                    TransferAmount = textBox1.Text,
                    TransferType = "Partial Credit",
                    Payed = true,
                    PayeeID = "5ee40637021fde6dc4b5621d"
                }, "TransferDetails");
                        // subtracts from the total remaining credits of the user
                        user.PartialCredit -= i;
                        await dataService.UpdateAsync(user.id, user, "UserTable");

                        // gets the payee details
                        var payee = await dataService.GetRecordByIdAsync<UserTable>("UserTable", "5ee40637021fde6dc4b5621d");
                        // Adds the amount to the payees credit and updates it
                        payee.PartialCredit += i;
                        await dataService.UpdateAsync(payee.id, payee, "UserTable");
                        string message = "Partial credits has been transfered";
                        string title = "Transfer Partial Credit";
                        MessageBox.Show(message, title);
                    }
                    else
                        MessageBox.Show("Transfer amount cannot be more than current credit");

                }
                else
                    MessageBox.Show("Please enter a valid number");
            }
            else
                MessageBox.Show("Fields can not be empty");
        }
    }
}
