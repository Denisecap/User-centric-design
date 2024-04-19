using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Customer : Person
    {
        private string _phoneNum;
        private string _custEmail;

        public Customer(int id, string firstName, string lastName, string phoneNumber, string email)
        : base(id, firstName, lastName)
        {
            this._phoneNum = phoneNumber;
            this._custEmail = email;
        }
        public string PhoneNumber { get => _phoneNum; set => _phoneNum = value; }
        public string Email { get => _custEmail; set => _custEmail = value; }
    }
}
