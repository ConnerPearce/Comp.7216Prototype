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
    public partial class DeleteTransInfo : Form
    {
        private readonly string CollectionName = "TransactionDetails";
        public DeleteTransInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Transaction navTrans = new Transaction();
            navTrans.Show();
            this.Hide();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (string.IsNullOrEmpty(txtTransID.Text))
            {
                bool success = await dataService.DeleteAsync<TransactionDetails>(txtTransID.Text, CollectionName);
                if (success)
                    MessageBox.Show("Transaction Deleted");
                else
                    MessageBox.Show("Transaction Unable to be Deleted");
            }
            else
                MessageBox.Show("Please Enter an ID");
        }
    }
}
