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
    public partial class RequestRecord : Form
    {
        private readonly string CollectionName = "RecordDetails";
        private DataService dataService;
        public RequestRecord()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecord.Clear();
            txtRecord.Focus();
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecord.Text))
            {
                MessageBox.Show($"Record ID is required", "Detected Empty Textbox");
            }
            else
            {
                var record = await dataService.GetRecordByIdAsync<RecordManagement>(CollectionName, txtRecord.Text);
                if (record == null)
                {
                    MessageBox.Show("Cannot find record. Please try another Record ID", "Search Failed");
                }
                else
                {
                    MessageBox.Show("Record has been found", "Search Successful");
                    txtCustomer.Text = record.CustomerID;
                    txtPayment.Text = record.PaymentID;
                    txtTransfer.Text = record.TransferID;
                    txtTransaction.Text = record.TransactionID;
                }
            }
        }
    }
}
