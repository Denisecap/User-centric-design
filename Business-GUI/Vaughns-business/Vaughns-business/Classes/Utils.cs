using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Vaughns_business.LoginForm;
using System.Text.RegularExpressions;

namespace Vaughns_business.Classes
{
    public class Utils
    {
        // reading in customer details
        public static void ReadFromFile(string filePath, List<Customer> customers)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] customerDetails = line.Split(',');

                int id = int.Parse(customerDetails[0]);
                string firstName = customerDetails[1];
                string lastName = customerDetails[2];
                string phoneNum = customerDetails[3];
                string email = customerDetails[4];

                Customer customer = new Customer(id, firstName, lastName, phoneNum, email);
                customers.Add(customer);
            }
        }

        // reading in staff details
        public static void ReadFromFile(string filePath, List<Staff> staffs)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] staffDetails = line.Split(',');

                int id = int.Parse(staffDetails[0]);
                string firstName = staffDetails[1];
                string lastName = staffDetails[2];
                string phoneNum = staffDetails[3];
                string email = staffDetails[4];
                EPosition position = (EPosition)int.Parse(staffDetails[5]);
                ESalary salary = (ESalary)int.Parse(staffDetails[6]);
                EUserRole userRole = (EUserRole)int.Parse(staffDetails[7]); // provides different access based on role, view Enums class for details

                Staff staff = new Staff(id, firstName, lastName, phoneNum, email, position, salary, userRole);
                staffs.Add(staff);
            }
        }
        // reading in order details
        public static void ReadFromFile(string filePath, List<Order> orders)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] orderDetails = line.Split(',');

                int orderId = int.Parse(orderDetails[0]);
                int customerId = int.Parse(orderDetails[1]);
                string orderName = orderDetails[2];
                double orderPrice = int.Parse(orderDetails[3]);
                string dateTime = orderDetails[4];

                Order order = new Order(orderId, customerId, orderName, orderPrice, dateTime);
                orders.Add(order);
            }
        }

        // reading in staff logins, can be changed to enhance security
        public static void ReadFromFile(string filePath, List<StaffLogin> staffLogins)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] staffLoginDetails = line.Split(',');

                int userId = int.Parse(staffLoginDetails[0]);
                string userName = staffLoginDetails[1];
                string userPass = staffLoginDetails[2];

                StaffLogin staff = new StaffLogin(userId, userName, userPass);
                staffLogins.Add(staff);
            }
        }

        // verify name
        public static string[] GetName(string firstName, string lastName)
        {
            string[] names = new string[2];
            string checkLetters = @"^[a-zA-Z ]+$"; // check if name does not has number and special char
            Regex regex = new Regex(checkLetters);
            if (!string.IsNullOrWhiteSpace(firstName) && regex.IsMatch(firstName) && !string.IsNullOrWhiteSpace(lastName) && regex.IsMatch(lastName))
            {
                names[0] = firstName;
                names[1] = lastName;
            }
            else
            {
                names[0] = "";
                names[1] = "";
            }
            return names;
        }
    }
}
