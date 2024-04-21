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
        public CustomerForm(List<Customer> customers, List<Order> orders)
        {
            InitializeComponent();

            // adding data to local list
            customerList = customers;
            ordersList = orders;

            // display customers
            DisplayCustomers();
        }
        private void DisplayCustomers()
        {

        }
    }
}
