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

namespace Comp._7216Prototype.Limit_Page
{
    public partial class RemoveLimit : Form
    {
        private readonly string CollectionName = "LimitRecord";

        public RemoveLimit()
        {
            InitializeComponent();

        }

        private async void btnRemoveLimit_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                bool success = await dataService.DeleteAsync<LimitRecord>(txtID.Text, CollectionName);
                if (success)
                    MessageBox.Show("Limit Removed");
                else
                    MessageBox.Show("Limit Unable to be Removed");
            }
            else
                MessageBox.Show("Please Enter an ID");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimitHome limitHome = new LimitHome();
            limitHome.Show();
            Hide();
        }
    }
}
