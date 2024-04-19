using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Staff : Person
    {
        private string _phoneNum;
        private string _staffEmail;
        public Staff(int id, string firstName, string lastName, string phoneNumber, string email)
        : base(id, firstName, lastName)
        {
            this._phoneNum = phoneNumber;
            this._staffEmail = email;
        }
        public string PhoneNumber { get => _phoneNum; set => _phoneNum = value; }
        public string Email { get => _staffEmail; set => _staffEmail = value; }
    }
}
