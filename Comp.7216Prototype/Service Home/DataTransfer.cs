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
    public partial class DataTransfer : Form
    {
        private DataService dataService = new DataService();
        // Creating a variable to call the user anywhere
        private UserTable user = new UserTable();

        public DataTransfer()
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
                label4.Text = $"${user.Data}";
                label5.Text = $"${user.Data}";
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferService transferService = new TransferService();
            transferService.Show();
            Hide();
        }

        private void DataTransfer_Load(object sender, EventArgs e)
        {

        }

        private async void transferdata_Click(object sender, EventArgs e)
        {
            // i is the amount we are transfering
            double i;
            // This checks that the text entered is actually a double/decimal
            if (double.TryParse(textBox1.Text, out i))
            {
                // Checks if the user has enough credit to make the transfer
                if (user.Data >= i)
                {

                    if (!string.IsNullOrWhiteSpace(textBox1.Text) && comboBox1.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
                    {
                        DataService dataService = new DataService();

                        await dataService.InsertAsync(new TransferDetails()
                        {
                            TransferAmount = textBox1.Text,
                            TransferType = "Data Transfer",
                            Payed = true,
                            PayeeID = "5ee40637021fde6dc4b5621d"
                        }, "TransferDetails");
                        // subtracts from the total remaining credits of the user
                        user.Data -= i;
                        await dataService.UpdateAsync(user.id, user, "UserTable");

                        // gets the payee details
                        var payee = await dataService.GetRecordByIdAsync<UserTable>("UserTable", "5ee40637021fde6dc4b5621d");
                        // Adds the amount to the payees credit and updates it
                        payee.Data += i;
                        await dataService.UpdateAsync(payee.id, payee, "UserTable");

                        string message = "Data has been transfered";
                        string title = "Transfer Data";
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
