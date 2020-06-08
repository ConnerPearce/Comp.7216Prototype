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

        private void lblTransactionID_Click(object sender, EventArgs e)
        {

        }

        private void txtTransID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaymentType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentType_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtItemPurchased_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItemPurchased_Click(object sender, EventArgs e)
        {

        }

        private void txtDateCreated_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateCreated_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
