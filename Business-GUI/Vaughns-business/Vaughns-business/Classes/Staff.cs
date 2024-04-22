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
        private EUserRole _userRole;
        public Staff(int id, string firstName, string lastName, string phoneNumber, string email, EPosition position, ESalary salary, EUserRole role)
        : base(id, firstName, lastName, phoneNumber, email)
        {
            this._position = position;
            this._salary = salary;
            this._userRole = role;
        }
        public EPosition Position { get => _position; set => _position = value; }
        public ESalary Salary { get => _salary; set => _salary = value; }
        public EUserRole UserRole { get => _userRole; set => _userRole = value; }
    }
}
