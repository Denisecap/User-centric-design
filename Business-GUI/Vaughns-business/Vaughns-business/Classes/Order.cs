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
        private string _orderedAt;

        public Order(int orderId, int customerId, string name, double price, string orderedAt)
        {
            _orderId = orderId;
            _customerId = customerId;
            _name = name;
            _price = price;
            _orderedAt = orderedAt;
        }

        public int OrderId { get => _orderId; set => _orderId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public string CreatedAt { get => _orderedAt; set => _orderedAt = value; }
    }

}
