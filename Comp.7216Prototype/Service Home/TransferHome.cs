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
    public partial class TransferHome : Form
    {
        public TransferHome()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            TransferService transferservice = new TransferService();
            transferservice.Show();
            Hide();
        }

        private void TransferHome_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            HomeNavigation homeNavigation = new HomeNavigation();
            homeNavigation.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransferCredit transferCredit = new TransferCredit();
            transferCredit.Show();
            Hide();
        }

        private void transferservice_Click(object sender, EventArgs e)
        {
            TransferService transferservice = new TransferService();
            transferservice.Show();
            Hide();
        }
    }
}
