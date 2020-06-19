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

namespace Comp._7216Prototype.Record_Page
{
    public partial class DeleteRecord : Form
    {
        private readonly string CollectionName = "RecordDetails";
        private DataService dataService;
        public DeleteRecord()
        {
            InitializeComponent();
            dataService = new DataService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RecordHomePage recordHome = new RecordHomePage();
            recordHome.Show();
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecord.Clear();
            txtRecord.Focus();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecord.Text))
            {
                MessageBox.Show($"Record ID is required", "Empty Textbox");
                txtRecord.Focus();
            }
            else
            {
                bool outcome = await dataService.DeleteAsync<RecordManagement>(txtRecord.Text, CollectionName);
                if (!outcome)
                {
                    MessageBox.Show($"Record does not exist or cannot be found, try another Record ID", "Record Non-existent");
                }
                else
                {
                    MessageBox.Show($"Record has been deleted. Have a wonderful day", "Record Deleted");
                }
            }
        }
    }
}
