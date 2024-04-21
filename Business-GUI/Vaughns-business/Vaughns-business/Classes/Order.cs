using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Order
    {
        private int _orderId;
        private int _customerId;
        private string _name;
        private double _price;
        public Order(int orderid, int custId, string name, double price)
        {
            _orderId = orderid;
            _customerId = custId;
            _name = name;
            _price = price;
        }
        public int OrderId { get => _orderId; set => _orderId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
