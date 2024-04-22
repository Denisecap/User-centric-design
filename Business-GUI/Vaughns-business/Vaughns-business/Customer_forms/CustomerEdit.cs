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
    public partial class CustomerEdit : Form
    {
        // creating an instance of forms
        private MainForm mainFormInstance;
        private CustomerForm customerFormInstance;
        private List<Customer> customersList;
        public CustomerEdit(MainForm mainForm, CustomerForm customerForm, List<Customer> customers)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
            customerFormInstance = customerForm;
            customersList = customers;
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(textBox_customer_id.Text);
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

            // find the customer in the list
            Customer customerToUpdate = customersList.FirstOrDefault(c => c.Id == customerId);
            if (customerToUpdate != null)
            {
                // update customer details
                customerToUpdate.FirstName = firstName;
                customerToUpdate.LastName = lastName;
                customerToUpdate.PhoneNumber = phone;
                customerToUpdate.Email = email;

                // save the updated data back to the file
                string filePath = "..\\..\\Text_files\\customers.txt";
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Customer customer in customersList)
                    {
                        sw.WriteLine($"{customer.Id},{customer.FirstName},{customer.LastName},{customer.PhoneNumber},{customer.Email}");
                    }
                }

                // updating datagridview with new details
                customerFormInstance.EditCustomer(customerToUpdate);

                MessageBox.Show("Customer data updated successfully.");
                ClearInputFields();
            }
        }
        private void textBox_customer_id_TextChanged(object sender, EventArgs e)
        {
            // resets the texboxes every change
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_phone.Text = "";
            textBox_email.Text = "";

            // check if the text has actually changed
            if (textBox_customer_id.Text != "")
            {
                string custId = textBox_customer_id.Text;
                if (int.TryParse(custId, out int id))
                {
                    foreach (Customer customer in customersList)
                    {
                        //displaying customer details in textboxes
                        if (customer.Id == id)
                        {
                            textBox_firstName.Text = customer.FirstName;
                            textBox_lastName.Text = customer.LastName;
                            textBox_phone.Text = customer.PhoneNumber;
                            textBox_email.Text = customer.Email;
                        }
                    }
                }
                else
                {
                    ClearInputFields();
                    MessageBox.Show("Invalid ID");
                }
            }
            else
            {
                ClearInputFields();
            }
        }
        private void ClearInputFields()
        {
            textBox_customer_id.Text = "";
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_phone.Text = "";
            textBox_email.Text = "";
        }
    }
}
