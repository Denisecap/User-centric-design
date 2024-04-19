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
    public partial class LoginForm : Form
    {
        public struct StaffLogin
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        private List<StaffLogin> staffLogins = new List<StaffLogin>();
        public LoginForm()
        {
            InitializeComponent();

            // reading staff login
            string filePath = "..\\..\\Text_files\\staff_login.txt";
            ReadFromFile(filePath);
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            // storing user inputs in strings
            string enteredUsername = textBox_username.Text;
            string enteredPassword = textBox2_password.Text;

            foreach (StaffLogin login in staffLogins)
            {
                if (login.UserName == enteredUsername && login.Password == enteredPassword)
                {
                    new MainForm().Show();
                    this.Hide();
                    return; // exits the method after successful login
                }
            }
            // show error message if no matching details
            MessageBox.Show("Incorrect login details");
            ResetForm();
        }

        // reading in staff logins, can be changed to enhance security
        public void ReadFromFile(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] staffDetails = line.Split(',');

                int userId = int.Parse(staffDetails[0]);
                string userName = staffDetails[1];
                string userPass = staffDetails[2];

                StaffLogin staff = new StaffLogin { UserID = userId, UserName = userName, Password = userPass };
                staffLogins.Add(staff);
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            textBox_username.Text = "";
            textBox2_password.Text = "";
        }
    }
}
