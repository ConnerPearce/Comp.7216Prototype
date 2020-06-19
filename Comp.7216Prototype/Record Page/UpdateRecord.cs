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
    public partial class UpdateRecord : Form
    {
        private readonly string CollectionName = "RecordDetails";
        private DataService dataService;
        public UpdateRecord()
        {
            InitializeComponent();
            dataService = new DataService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RecordHomePage recordHome = new RecordHomePage();
            recordHome.Show();
            Hide();
        }

        private void picClearRecord_Click(object sender, EventArgs e)
        {
            txtRecord.Clear();
            txtRecord.Focus();
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
            RecordManagement record = new RecordManagement();
            string outcome = CheckTextBoxes(txtRecord.Text, txtCustomer.Text, txtPayment.Text, txtTransfer.Text, txtTransaction.Text);
            if (outcome != "success")
            {
                SendErrorMessage(outcome);
            }
            else
            {
                record.id = txtRecord.Text;
                record.CustomerID = txtCustomer.Text;
                record.PaymentID = txtPayment.Text;
                record.TransferID = txtTransfer.Text;
                record.TransactionID = txtTransaction.Text;

                bool result = await dataService.UpdateAsync(txtRecord.Text, record, CollectionName);

                if (!result)
                    SendUpdateFailed();
                else
                    SendUpdateSuccess();

                ClearAllTextboxes();
            }
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecord.Text))
            {
                SendErrorMessage("Record");
            }
            else
            {

                var result = await dataService.GetRecordByIdAsync<RecordManagement>(CollectionName, txtRecord.Text);

            }
            
        }



        //METHODS
        private void SendUpdateFailed()
        {
            string message = "Unable to Update please check if your Record ID is correct";
            string caption = "Update FAILED";

            MessageBox.Show(message, caption);
        }
        
        private void SendUpdateSuccess()
        {
            string message = "Update has been made";
            string caption = "Update Successful";

            MessageBox.Show(message, caption);
        }

        private void SendErrorMessage(string outcome)
        {
            string message = $"{outcome} textbox is required";
            string caption = "Detected Empty Textboxes";

            MessageBox.Show(message, caption);//display a message to the admin that there is a textbox is null/empty
        }

        private string CheckTextBoxes(string record, string customer, string payment, string transfer, string transaction)//validate all textboxes in Creat a Record page
        {
            if (string.IsNullOrEmpty(record))
            {
                return "Record";
            }
            else if (string.IsNullOrEmpty(customer))
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
            txtRecord.Clear();
            txtCustomer.Clear();
            txtPayment.Clear();
            txtTransfer.Clear();
            txtTransaction.Clear();

            txtCustomer.Focus();
        }

        
    }
}
