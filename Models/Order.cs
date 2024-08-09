using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public LineItem lineItem;
        public List<LineItem> Items { get; set; } = new List<LineItem>();

        public Order(int id, List<LineItem> lineItems)
        {
            Id = id;
            Date = DateTime.Now;
            Items = lineItems;
        }

        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            foreach (LineItem item in Items)
            {
                orderPrice = orderPrice + item.CalculateLineItemCost();
            } 
            return orderPrice;
        }
    }
}
