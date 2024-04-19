using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaughns_business
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "user_username" && textBox2_password.Text == "user_password")
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login details");
                ResetForm();
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            textBox_username.Text = "";
            textBox2_password.Text = "";
        }
    }
}
