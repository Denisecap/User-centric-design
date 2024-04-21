using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class Order
    {
        private int _id;
        private string _name;
        private double _price;
        public Order(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
