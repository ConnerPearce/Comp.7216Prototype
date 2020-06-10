using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.Record_Page
{
    public partial class RecordHomePage : Form
    {
        public RecordHomePage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeNavigation home = new HomeNavigation();
            home.Show();
            Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateRecord createHome = new CreateRecord();
            createHome.Show();
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord updateHome = new UpdateRecord();
            updateHome.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord deleteHome = new DeleteRecord();
            deleteHome.Show();
            Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestRecord requestHome = new RequestRecord();
            requestHome.Show();
            Hide();
        }
    }
}
