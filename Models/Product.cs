using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject.Models
{
    public class Product
    {

        public const double DIVISOR = 100;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }


        public Product(int id, string name, double price, double discount)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
        }

        public double CalculateDiscount()
        {
            double discountedPrice = 0;
            discountedPrice = Price * (Discount/DIVISOR);
            return (Price - discountedPrice);
        }
    }
}
