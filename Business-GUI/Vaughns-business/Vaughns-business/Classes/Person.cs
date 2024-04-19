using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vaughns_business.Classes
{
    public class Person
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected string _phoneNum;
        protected string _custEmail;
        public Person(int id, string firstName, string lastName, string phoneNumber, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this._phoneNum = phoneNumber;
            this._custEmail = email;
        }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => _phoneNum; set => _phoneNum = value; }
        public string Email { get => _custEmail; set => _custEmail = value; }
    }
}
