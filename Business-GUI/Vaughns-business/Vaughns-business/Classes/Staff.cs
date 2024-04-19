using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Staff : Person
    {
        private EPosition _position;
        private ESalary _salary;
        public Staff(int id, string firstName, string lastName, string phoneNumber, string email, EPosition position, ESalary salary)
        : base(id, firstName, lastName, phoneNumber, email)
        {
            this._position = position;
            this._salary = salary;
        }
        public EPosition Position { get => _position; set => _position = value; }
        public ESalary Salary { get => _salary; set => _salary = value; }
    }
}
