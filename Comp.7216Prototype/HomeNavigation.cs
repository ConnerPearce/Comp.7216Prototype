using Comp._7216Prototype.Limit_Page;
using Comp._7216Prototype.Payee_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype
{
    public partial class HomeNavigation : Form
    {
        public HomeNavigation()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            LimitHome limitHome = new LimitHome();
            limitHome.Show();
            Hide();
        }

        private void btnPayee_Click(object sender, EventArgs e)
        {
            PayeeHome payeeHome = new PayeeHome();
            payeeHome.Show();
            Hide();
        }
    }
}
