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

        }

        private void textBox_customer_id_TextChanged(object sender, EventArgs e)
        {
            string custId = textBox_customer_id.Text;

            foreach(Customer customer in customersList)
            {

            }
        }
    }
}
