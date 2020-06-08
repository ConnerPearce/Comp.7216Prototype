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
    public partial class DataTransfer : Form
    {
        public DataTransfer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferService transferService = new TransferService();
            transferService.Show();
            Hide();
        }

        private void DataTransfer_Load(object sender, EventArgs e)
        {

        }

        private void transferdata_Click(object sender, EventArgs e)
        {
            string message = "Data has been transfered";
            string title = "Transfer Data";
            MessageBox.Show(message, title);
        }
    }
}
