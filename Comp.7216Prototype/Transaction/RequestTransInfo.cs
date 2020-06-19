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
    public partial class RequestTransInfo : Form
    {
        private readonly string CollectionName = "TransactionDetails";
        public RequestTransInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Transaction navTrans = new Transaction();
            navTrans.Show();
            this.Hide();
        } 
        
        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            if (!string.IsNullOrEmpty(txtTransID.Text))
            {
                var oldRecord = await dataService.GetRecordByIdAsync<TransactionDetails>(CollectionName, txtTransID.Text);

                txtCustomerID.Text = oldRecord.CustomerID;
                txtDateCreated.Text = oldRecord.DateCreated.ToString();
                txtItemPurchased.Text = oldRecord.ItemPurchased;
                txtPaymentAmount.Text = oldRecord.PaymentAmount.ToString();
                txtPaymentType.Text = oldRecord.PaymentType;
            }
            else
            {
                MessageBox.Show("Please enter something");
            }
        }
    }
}
