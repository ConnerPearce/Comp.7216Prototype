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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void btnCreateTransInfo_Click(object sender, EventArgs e)
        {
            CreateTransInfo navCTI = new CreateTransInfo();
            navCTI.Show();
            this.Hide();
        }

        private void btnRequestTransInfo_Click(object sender, EventArgs e)
        {
            RequestTransInfo navRTI = new RequestTransInfo();
            navRTI.Show();
            this.Hide();
        }

        private void btnUpdateTransactionInfo_Click(object sender, EventArgs e)
        {
            UpdateTransInfo navUTI = new UpdateTransInfo();
            navUTI.Show();
            this.Hide();
        }

        private void btnDeleteTransInfo_Click(object sender, EventArgs e)
        {
            DeleteTransInfo navDTI = new DeleteTransInfo();
            navDTI.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeleteTransInfo navDTI = new DeleteTransInfo();
            navDTI.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HomeNavigation navHome = new HomeNavigation();
            navHome.Show();
            this.Hide();
        }
    }
}
