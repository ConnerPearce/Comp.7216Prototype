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
    public partial class TextsTransfer : Form
    {
        public TextsTransfer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferService transferService = new TransferService();
            transferService.Show();
            Hide();
        }

        private void transfertexts_Click(object sender, EventArgs e)
        {
            string message = "Texts has been transfered";
            string title = "Transfer Texts";
            MessageBox.Show(message, title);
        }
    }
}
