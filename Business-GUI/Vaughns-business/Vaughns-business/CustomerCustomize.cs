using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaughns_business.Classes;

namespace Vaughns_business
{
    public partial class CustomerCustomize : Form
    {
        public CustomerCustomize()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string firstName = textBox_firstName.Text;
            string lastName = textBox_lastName.Text;
            string phone = textBox_phone.Text;
            string email = textBox_email.Text; 

            // verifying names
            string[] names = Utils.GetName(firstName, lastName);
            if (names[0] == "" || names[1] == "")
            {
                MessageBox.Show("Please enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox
        }
    }
}
