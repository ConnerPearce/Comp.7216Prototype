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
        public UpdateRecord()
        {
            InitializeComponent();
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
            txtRecord.Clear();
            txtCustomer.Clear();
            txtPayment.Clear();
            txtTransfer.Clear();
            txtTransaction.Clear();

            txtRecord.Focus();
        }
    }
}
