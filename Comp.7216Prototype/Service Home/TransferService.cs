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
    public partial class TransferService : Form
    {
        public TransferService()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferHome transfer = new TransferHome();
            transfer.Show();
            Hide();
        }

        private void transferdata_Click(object sender, EventArgs e)
        {
            DataTransfer transferdata = new DataTransfer();
            transferdata.Show();
            Hide();
        }

        private void transferminutes_Click(object sender, EventArgs e)
        {
            Minutestransfer minutestransfer = new Minutestransfer();
            minutestransfer.Show();
            Hide();
        }

        private void transfertexts_Click(object sender, EventArgs e)
        {
            TextsTransfer textstransfer = new TextsTransfer();
            textstransfer.Show();
            Hide();
        }
    }
}
