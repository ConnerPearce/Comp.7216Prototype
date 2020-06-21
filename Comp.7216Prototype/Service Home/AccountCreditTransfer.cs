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
    public partial class AccountCreditTransfer : Form
    {
        public AccountCreditTransfer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferCredit transferCredit = new TransferCredit();
            transferCredit.Show();
            Hide();
        }

        private async void transferaccountcredit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && comboBox1.SelectedValue != null && !string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                DataService dataService = new DataService();

                await dataService.InsertAsync(new TransferDetails()
                {
                    TransferAmount = textBox1.Text,
                    TransferType = "Account Credit",
                    Payed = true,
                    PayeeID = "5ee40637021fde6dc4b5621d"
                }, "TransferDetails");

                string message = "Account credits has been transfered";
                string title = "Transfer Account Credit";
                MessageBox.Show(message, title);
            }
            else
                MessageBox.Show("Fields can not be empty");

        }
    }
}
