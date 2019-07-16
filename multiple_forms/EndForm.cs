using System;
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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

       

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void EndForm_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
