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
    public partial class UpdateTransInfo : Form
    {
        private readonly string CollectionName = "TransactionDetails";
        public UpdateTransInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Transaction navTrans = new Transaction();
            navTrans.Show();
            this.Hide();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            if (!string.IsNullOrEmpty(txtItemPurchased.Text) && !string.IsNullOrEmpty(txtPaymentAmount.Text) && !string.IsNullOrEmpty(txtPaymentType.Text) && !string.IsNullOrEmpty(txtTransID.Text))
            {
                double temp;
                if (double.TryParse(txtPaymentAmount.Text, out temp))
                {
                    var oldRecord = await dataService.GetRecordByIdAsync<TransactionDetails>(CollectionName, txtTransID.Text);

                    oldRecord.ItemPurchased = txtItemPurchased.Text;
                    oldRecord.PaymentAmount = temp;
                    oldRecord.PaymentType = txtPaymentType.Text;
                    await dataService.UpdateAsync(oldRecord.id, oldRecord, CollectionName);
                }

                MessageBox.Show("Transaction Details Updated");
                txtItemPurchased.Text = "";
                txtPaymentAmount.Text = "";
                txtPaymentType.Text = "";
                txtTransID.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter something");
            }
        }
    }
}
