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
    }
}
