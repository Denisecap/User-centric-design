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
using System.IO;

namespace Vaughns_business
{
    public partial class CustomerRemove : Form
    {
        private List<Customer> customerList;
        private CustomerForm customerFormInstance;
        public CustomerRemove(List<Customer> customer, CustomerForm customerForm)
        {
            customerList = customer;
            customerFormInstance = customerForm;
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List<int> idList = new List<int>();
            foreach (Customer customer in customerList)
            {
                idList.Add(customer.Id);
            }

            // check if user input is an integer and valid id
            if (int.TryParse(textBox_customer_id.Text, out int id) && idList.Contains(id))
            {
                int index = customerList.FindIndex(c => c.Id == id);

                // remove customer from list
                Customer removeCustomer = customerList.FirstOrDefault(customer => customer.Id == id);
                customerFormInstance.RemoveCustomer(removeCustomer);

                // remove customer from txt file
                string[] lines = File.ReadAllLines("../../Text_files/customers.txt");
                string lineToRemove = lines.FirstOrDefault(line => line.StartsWith($"{id},"));

                // create a new list of lines without the line to remove
                List<string> updatedLines = lines.Where(line => line != lineToRemove).ToList();

                // write the updated data back to the file
                File.WriteAllLines("../../Text_files/customers.txt", updatedLines.ToArray());

                MessageBox.Show("Customer successfully removed");
                ClearInputFields();
                return;
            }
            else
            {
                MessageBox.Show("Please enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            textBox_customer_id.Text = "";
        }
    }
}
