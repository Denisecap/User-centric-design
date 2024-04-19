using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                string order = customerDetails[5];

                Customer customer = new Customer(id, firstName, lastName, phoneNum, email, order);
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
                EPosition position = (EPosition)int.Parse(staffDetails[3]);
                ESalary salary = (ESalary)int.Parse(staffDetails[4]);
                EUserRole userRole = (EUserRole)int.Parse(staffDetails[5]); // provides different access based on role, view Enums class for details

                Staff staff = new Staff(id, firstName, lastName, phoneNum, email, position, salary, userRole);
                staffs.Add(staff);
            }
        }
    }
}
