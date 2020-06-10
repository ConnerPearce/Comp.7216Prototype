using Comp._7216Prototype.Limit_Page;
using Comp._7216Prototype.Payee_Page;
using Comp._7216Prototype.Transaction;
using Comp._7216Prototype.Service_Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comp._7216Prototype.Record_Page;

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

        private void HomeNavigation_Load(object sender, EventArgs e)
        {

        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            TransferHome transferhome = new TransferHome();
            transferhome.Show();
            Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            RecordHomePage recordHome = new RecordHomePage();
            recordHome.Show();
            Hide();
        }
    }
}
