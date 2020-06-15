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
        public CreateRecord()
        {
            InitializeComponent();
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
            txtCustomer.Clear();
            txtPayment.Clear();
            txtTransfer.Clear();
            txtTransaction.Clear();

            txtCustomer.Focus();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            RecordManagement recordModel = new RecordManagement();
            var result = CheckTextBoxes(txtCustomer.Text, txtPayment.Text, txtTransfer.Text, txtTransaction.Text);

            if (result != "Success")
            {
                SendErrorMessage(result);
            }
        }

        private void SendErrorMessage(string outcome)
        {
            string message = $"{outcome} textbox is required";
            string caption = "Detected Empty Textboxes";

            MessageBox.Show(message, caption);

        }

        private string CheckTextBoxes(string customer, string payment, string transfer, string transaction)
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
    }
}
