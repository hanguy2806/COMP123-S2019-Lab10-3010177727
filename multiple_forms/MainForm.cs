﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.end.Show();
        }
    }
}
