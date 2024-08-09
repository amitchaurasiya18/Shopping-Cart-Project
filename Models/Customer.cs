using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> orderList = new List<Order>();

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
