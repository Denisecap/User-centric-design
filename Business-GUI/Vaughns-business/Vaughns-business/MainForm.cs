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
    public partial class MainForm : Form
    {
        public List<Customer> customersList = new List<Customer>();
        public MainForm()
        {
            InitializeComponent();

            // reading customers
            string filePath = "..\\..\\Text_files\\customers.txt";
            Utils.ReadFromFile(filePath, customersList);
        }
        private void button_customer_Click(object sender, EventArgs e)
        {
            Form form = new CustomerForm();
            OpenContainerForm(form);
        }

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
