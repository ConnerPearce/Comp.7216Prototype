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
    public partial class UpdateLimit : Form
    {
        public UpdateLimit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimitHome limitHome = new LimitHome();
            limitHome.Show();
            Hide();
        }

        private async void btnUpdateLimit_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (string.IsNullOrEmpty(txtLimitID.Text) || string.IsNullOrEmpty(txtUpdate.Text))
                MessageBox.Show("Please fill in all fields");
            else
            {
                int i;
                if (int.TryParse(txtUpdate.Text, out i))
                {
                    bool success = await dataService.UpdateAsync(txtLimitID.Text, new LimitRecord()
                    {
                        Limit =i
                }, "LimitRecord");
                }
                else
                    MessageBox.Show("The Limit has to be a int");

            }

        }
    }
}
