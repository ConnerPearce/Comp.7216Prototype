using Comp._7216Prototype.Database_Files;
using Comp._7216Prototype.Database_Files.Data;
using Comp._7216Prototype.Limit_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.CreateLimit
{
    public partial class Limit : Form
    {
        // This is to specify which collection (Table) to insert/update/delete data from
        private readonly string CollectionName = "LimitRecord";

        public Limit()
        {
            InitializeComponent();
        }

        // Create Limit
        private async void btnCreateLimit_Click(object sender, EventArgs e)
        {
            // This is used to call methods for the database
            // Its needed
            DataService dataService = new DataService();

            // Checks the text box and if its not empty it will run the code inside
            if (!string.IsNullOrEmpty(txtLimit.Text))
            {
                // TryParse trys to convert something to an int, it will return true or false on if it succedded
                // int temp is used to store the result of the conversion (Needed so you dont have to convert again after the tryparse)
                int temp;
                if (int.TryParse(txtLimit.Text,out temp))
                {
                    // When you insert you need to create a new model of what you need and insert all the items on creation
                    // i.e for me since its to do with Limits the model i use is LimitRecord
                    await dataService.InsertAsync(new LimitRecord() 
                    { 
                        Limit = temp, 
                        DateCreated = DateTime.Now // Datetime.Now gets the current date, everytime you need DateCreated this is what you will need to use
                    }, CollectionName); // Collection name is needed every time so that the DataService knows what table to insert data into

                    MessageBox.Show("Added"); // Just to show users the action has completed
                }
                else// If the text box is not an int it will give an error (ERRORS ARE NEEDED)
                    MessageBox.Show("Please enter a valid int");
            }
            else // If the text box is empty it will give an error (ERRORS ARE NEEDED)
                MessageBox.Show("Please enter something");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimitHome home = new LimitHome();
            home.Show();
            Hide();
        }
    }
}