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
    public partial class AccountCreditTransfer : Form
    {
        public AccountCreditTransfer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            TransferCredit transferCredit = new TransferCredit();
            transferCredit.Show();
            Hide();
        }

        private void transferaccountcredit_Click(object sender, EventArgs e)
        {
            string message = "Account credits has been transfered";
            string title = "Transfer Account Credit";
            MessageBox.Show(message, title);
        }
    }
}