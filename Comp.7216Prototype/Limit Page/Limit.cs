﻿using Comp._7216Prototype.Limit_Page;
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
        public Limit()
        {
            InitializeComponent();
        }

        private void btnCreateLimit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimitHome home = new LimitHome();
            home.Show();
            Hide();
        }
    }
}