using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaughns_business.Classes;

namespace Vaughns_business
{
    public partial class CustomerAdd : Form
    {
        // creating an instance of forms
        private MainForm mainFormInstance;
        private CustomerForm customerFormInstance;
        public CustomerAdd(MainForm mainForm, CustomerForm customerForm)
        {
            mainFormInstance = mainForm;
            customerFormInstance = customerForm;
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // getting a unique id
            int customerId = mainFormInstance.GetUniqueId(0);
            
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

            // creating the customer string
            string customerDetails = $"{customerId},{names[0]},{names[1]},{phone},{email}";

            // adding customer to txt file
            using (StreamWriter sw = new StreamWriter("../../Text_files/customers.txt", append: true))
            {
                sw.WriteLine(customerDetails);
            }

            // adding lecturer to lecturersList in Form1
            Customer newLecturer = new Customer(customerId, names[0], names[1], phone, email);
            customerFormInstance.AddCustomer(newLecturer);

            MessageBox.Show("Customer successfully added");
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_phone.Text = "";
            textBox_email.Text = "";
        }
    }
}
