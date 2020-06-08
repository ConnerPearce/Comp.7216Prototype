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
    public partial class TransferCredit : Form
    {
        public TransferCredit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemainningCreditTransfer remainningCreditTransfer = new RemainningCreditTransfer();
            remainningCreditTransfer.Show();
            Hide();
        }

        private void TransferCredit_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferHome transferhome = new TransferHome();
            transferhome.Show();
            Hide();
        }

        private void transferaccountcredit_Click(object sender, EventArgs e)
        {
            AccountCreditTransfer accountCreditTransfer = new AccountCreditTransfer();
            accountCreditTransfer.Show();
            Hide();

        }

        private void transferpartialcredit_Click(object sender, EventArgs e)
        {
            PartialCreditTransfer partialCreditTransfer = new PartialCreditTransfer();
            partialCreditTransfer.Show();
            Hide();
        }
    }
}
