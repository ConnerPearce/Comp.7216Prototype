using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.Payee_Page
{
    public partial class CreatePayee : Form
    {
        public CreatePayee()
        {
            InitializeComponent();
        }

        private void btnCreatePayee_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PayeeHome home = new PayeeHome();
            home.Show();
            Hide();
        }
    }
}