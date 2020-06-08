using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.Limit_Page
{
    public partial class RemoveLimit : Form
    {
        public RemoveLimit()
        {
            InitializeComponent();

        }

        private void btnRemoveLimit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimitHome limitHome = new LimitHome();
            limitHome.Show();
            Hide();
        }
    }
}
