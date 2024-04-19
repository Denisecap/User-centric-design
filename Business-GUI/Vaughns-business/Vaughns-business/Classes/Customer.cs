using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Customer : Person
    {
        private string _order;
        public Customer(int id, string firstName, string lastName, string phoneNumber, string email, string order)
        : base(id, firstName, lastName, phoneNumber, email)
        {
            this._order = order;
        }
        public string Order { get =>  _order; set => _order = value; }
    }
}
