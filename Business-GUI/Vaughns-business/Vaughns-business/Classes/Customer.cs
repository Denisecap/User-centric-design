using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Customer : Person
    {
        private int _orderId;
        public Customer(int id, string firstName, string lastName, string phoneNumber, string email, int orderID)
        : base(id, firstName, lastName, phoneNumber, email)
        {
            this._orderId = orderID;
        }
        public int OrderId { get =>  _orderId; set => _orderId = value; }
    }
}
