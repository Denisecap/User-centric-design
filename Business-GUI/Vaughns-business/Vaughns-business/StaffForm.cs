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
    public partial class StaffForm : Form
    {
        private List<Staff> staffList;

        // creating an instance of MainForm
        private MainForm mainFormInstance;
        public StaffForm(MainForm mainForm, List<Staff> staffs)
        {
            InitializeComponent();

            // adding MainForm instance to this form
            mainFormInstance = mainForm;

            // adding data to local list
            staffList = staffs;

            // display staff
            DisplayStaff();
        }
        private void DisplayStaff()
        {
            dataGridView1.DataSource = staffList.Select(staff => new
            {
                StaffID = staff.Id,
                FullName = $"{staff.FirstName} {staff.LastName}",
                Phone = staff.PhoneNumber,
                Email = staff.Email,
                Position = staff.Position.ToString(),
                Salary = $"{(double)staff.Salary:c}",
            }).ToList();
        }
        // adding persons to list
        public void AddStaff(Staff staff)
        {
            staffList.Add(staff);

            // adds new list to main form customers list
            mainFormInstance.UpdateStaffList(staffList);

            // updates the datagridview when new data is added
            DisplayStaff();
        }
        // editing persons to list
        public void EditStaff(Staff staff)
        {
            int index = staffList.FindIndex(s => s.Id == staff.Id);
            staffList[index] = staff;
            mainFormInstance.UpdateStaffList(staffList);
            DisplayStaff();
        }
        // removing persons from list
        public void RemoveStaff(Staff staff)
        {
            staffList.Remove(staff);
            mainFormInstance.UpdateStaffList(staffList);
            DisplayStaff();
        }

        // form to add staff
        private void button_add_staff_Click(object sender, EventArgs e)
        {

        }
        // form to edit staff
        private void button_edit_staff_Click(object sender, EventArgs e)
        {

        }
        // form to remove staff
        private void button_delete_staff_Click(object sender, EventArgs e)
        {

        }

        // opens form inside panel_container
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
