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
    public partial class CustomerForm : Form
    {
        private List<Customer> customerList;
        private List<Order> ordersList;

        // creating an instance of MainForm
        private MainForm mainFormInstance;
        public CustomerForm(MainForm mainForm, List<Customer> customers, List<Order> orders)
        {
            InitializeComponent();

            // adding MainForm instance to this form
            mainFormInstance = mainForm;

            // adding data to local list
            customerList = customers;
            ordersList = orders;

            // display customers
            DisplayCustomers();
        }
        private void DisplayCustomers()
        {
            dataGridView1.DataSource = customerList.Select(customer => new
            {
                CustomerID = customer.Id,
                FullName = $"{customer.FirstName} {customer.LastName}",
                Phone = customer.PhoneNumber,
                Email = customer.Email
            }).ToList();
        }

        // adding persons to list
        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
            DisplayCustomers(); // updates the datagridview when new data is added
        }
        // editing persons to list
        public void EditCustomer(Customer customer)
        {
            int index = customerList.FindIndex(c => c.Id == customer.Id);
            customerList[index] = customer;
            DisplayCustomers();
        }
        // form to add customer
        private void button_add_customer_Click(object sender, EventArgs e)
        {
            Form form = new CustomerAdd(mainFormInstance, this);
            OpenContainerForm(form);
        }
        // form to edit customer
        private void button_edit_customer_Click(object sender, EventArgs e)
        {
            Form form = new CustomerEdit(mainFormInstance, this, customerList);
            OpenContainerForm(form);
        }
        // form to delete customer
        private Form activeForm = null;
        private void OpenContainerForm(Form containerForm)
        {
            activeForm?.Close(); // closes current form
            activeForm = containerForm;
            containerForm.TopLevel = false;
            containerForm.FormBorderStyle = FormBorderStyle.None;
            containerForm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(containerForm);
            panel_container.Tag = containerForm;
            containerForm.BringToFront();
            containerForm.Show();
        }
    }
}