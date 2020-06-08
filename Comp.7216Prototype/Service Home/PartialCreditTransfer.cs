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
    public partial class PartialCreditTransfer : Form
    {
        public PartialCreditTransfer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferCredit transferCredit = new TransferCredit();
            transferCredit.Show();
            Hide();
        }

        private void PartialCreditTransfer_Load(object sender, EventArgs e)
        {

        }

        private void transferpartialcredit_Click(object sender, EventArgs e)
        {
            string message = "Partial credits has been transfered";
            string title = "Transfer Partial Credit";
            MessageBox.Show(message, title);
        }
    }
}
