using Comp._7216Prototype.CreateLimit;
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
    public partial class LimitHome : Form
    {
        public LimitHome()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HomeNavigation homeNavigation = new HomeNavigation();
            homeNavigation.Show();
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateLimit updateLimit = new UpdateLimit();
            updateLimit.Show();
            Hide();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            Limit create = new Limit();
            create.Show();
            Hide();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            RemoveLimit remove = new RemoveLimit();
            remove.Show();
            Hide();
        }
    }
}
