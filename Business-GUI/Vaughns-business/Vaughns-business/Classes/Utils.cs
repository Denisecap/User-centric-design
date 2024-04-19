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

                Customer customer = new Customer(id, firstName, lastName, phoneNum, email);
                customers.Add(customer);
            }
        }
    }
}
