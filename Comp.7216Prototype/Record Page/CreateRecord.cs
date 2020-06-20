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

namespace Comp._7216Prototype.Record_Page
{
    public partial class CreateRecord : Form
    {
        private readonly string CollectionName = "RecordDetails";
        private DataService dataService;//initialises the dataservice class to enable access to the database
        public CreateRecord()
        {
            InitializeComponent();
            dataService = new DataService(); //assigns the class on run time
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RecordHomePage recordHome = new RecordHomePage();
            recordHome.Show();
            Hide();
        }

        private void picClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            txtCustomer.Focus();
        }

        private void picClearPayment_Click(object sender, EventArgs e)
        {
            txtPayment.Clear();
            txtPayment.Focus();
        }

        private void picClearTransfer_Click(object sender, EventArgs e)
        {
            txtTransfer.Clear();
            txtTransfer.Focus();
        }

        private void picClearTransaction_Click(object sender, EventArgs e)
        {
            txtTransaction.Clear();
            txtTransaction.Focus();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllTextboxes();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            //this is accessing record management class
            RecordManagement recordModel = new RecordManagement();
            //this will call the the validation method to check if any of the textboes are null or empty
            var outcome = CheckTextBoxes(txtCustomer.Text, txtPayment.Text, txtTransfer.Text, txtTransaction.Text);

            if (outcome != "success")//if the result does not return a success string....
            {
                MessageBox.Show($"{outcome} textbox is required", "Detected Empty Textboxes");//display a message to the admin that there is a textbox is null/empty
            }
            else//otherwise
            {
                await dataService.InsertAsync(new RecordManagement()//call the data services class, assign each textbox text to the model class 
                                                                    //and send it to the database
                {
                    CustomerID = txtCustomer.Text,
                    PaymentID = txtPayment.Text,
                    TransferID = txtTransfer.Text,
                    TransactionID = txtTransaction.Text
                }, CollectionName);

                MessageBox.Show("Record has been saved to the database", "Insert Successful");//display a message to the admin that the record has been successfully sent 
                
                ClearAllTextboxes();//call the clear all textboxes method
            }
        }

        private string CheckTextBoxes(string customer, string payment, string transfer, string transaction)//validate all textboxes in Creat a Record page
        {
            if (string.IsNullOrEmpty(customer))
            {
                return "Customer";
            }
            else if (string.IsNullOrEmpty(payment))
            {
                return "Payment";
            }
            else if (string.IsNullOrEmpty(transfer))
            {
                return "Transfer";
            }
            else if (string.IsNullOrEmpty(transaction))
            {
                return "Transaction";
            }
            else
                return "success";
        }

        private void ClearAllTextboxes()//this method clears all textboxes and focuses the cursor to the CustomerID Page
        {
            txtCustomer.Clear();
            txtPayment.Clear();
            txtTransfer.Clear();
            txtTransaction.Clear();

            txtCustomer.Focus();
        }
    }
}
