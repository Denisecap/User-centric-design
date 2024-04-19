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
        private EPosition _position;
        private ESalary _salary;
        public Staff(int id, string firstName, string lastName, string phoneNumber, string email, EPosition position, ESalary salary)
        : base(id, firstName, lastName)
        {
            this._phoneNum = phoneNumber;
            this._staffEmail = email;
            this._position = position;
            this._salary = salary;
        }
        public string PhoneNumber { get => _phoneNum; set => _phoneNum = value; }
        public string Email { get => _staffEmail; set => _staffEmail = value; }
        public EPosition Position { get => _position; set => _position = value; }
        public ESalary Salary { get => _salary; set => _salary = value; }
    }
}
