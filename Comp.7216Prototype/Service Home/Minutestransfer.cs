﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp._7216Prototype.Service_Home
{
    public partial class Minutestransfer : Form
    {
        public Minutestransfer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Minutestransfer_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferService transferService = new TransferService();
            transferService.Show();
            Hide();
        }

        private void transferminutes_Click(object sender, EventArgs e)
        {
            string message = "Minutes has been transfered";
            string title = "Transfer Minutes";
            MessageBox.Show(message, title);
        }
    }
}
