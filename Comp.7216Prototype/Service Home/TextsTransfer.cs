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

        private async void transfertexts_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                DataService dataService = new DataService();

                await dataService.InsertAsync(new TransferDetails()
                {
                    TransferAmount = textBox1.Text,
                    TransferType = "Minutes Transfer",
                    Payed = true,
                    PayeeID = "5ee40637021fde6dc4b5621d"
                }, "TransferDetails");

                string message = "Texts has been transfered";
                string title = "Transfer Texts";
                MessageBox.Show(message, title);
            }
            else
                MessageBox.Show("Fields can not be empty");
        }
    }
}
