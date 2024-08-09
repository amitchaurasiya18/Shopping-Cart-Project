using ShoppingCartProject.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer(1, "Atharv");

        Product product1 = new Product(1, "MacBook Pro 16\"", 249900, 10);
        Product product2 = new Product(2, "Ipad Pro 13\"", 119900, 20);
        Product product3 = new Product(3, "Iphone 15 Pro", 129800, 50);
        Product product4 = new Product(4, "Pencil Pro", 10900, 30);

        LineItem lineItem1 = new LineItem(101, 1, product1);
        LineItem lineItem2 = new LineItem(102, 5, product2);
        LineItem lineItem3 = new LineItem(103, 3, product3);
        LineItem lineItem4 = new LineItem(104, 10, product4);

        Order order1 = new Order(10001, new List<LineItem> { lineItem1, lineItem2 });
        customer.orderList.Add(order1);

        Order order2 = new Order(10002, new List<LineItem> { lineItem1, lineItem3, lineItem4 });
        customer.orderList.Add(order2);

        PrintDetails(customer);
    }

    public static void PrintDetails(Customer customer)
    {
        Console.WriteLine($"Customer ID : {customer.Id} \n" +
            $"Customer Name: {customer.Name}");
        Console.WriteLine();
        Console.WriteLine($"Order Details");

        foreach (var order in customer.orderList)
        {
            Console.WriteLine("_________________________________________________________________________________________________________________________________________");
            Console.WriteLine($"| Order Id: {order.Id,123} |\n| Order Time: {order.Date,121} |");
            //Console.WriteLine();
            Console.WriteLine($"| LineItem Details {"|",118}");
            Console.WriteLine("|-----------|----------------|----------------------|----------|------------|-----------|--------------------------|--------------------|");
            Console.WriteLine("| Line Item |   Product ID   |  Product Name        | Quantity | Unit Price | Discount  | Unit Cost after Discount | Total Lineitem Cost|");
            Console.WriteLine("|-----------|----------------|----------------------|----------|------------|-----------|--------------------------|--------------------|");


            foreach (var item in order.Items)
            {
                Console.WriteLine($"| {item.Id,-9} | {item._product.Id,-14} | {item._product.Name,-20} | {item.Quantity,8} | {item._product.Price,10}" +
                    $" | {item._product.Discount,7}%  | {item._product.CalculateDiscount(),24} | {item.CalculateLineItemCost(),19}|");
            }
            Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"| Total Order Value:                                                                                                 {order.CalculateOrderPrice(),19}|");
            Console.WriteLine("\n\n");
        }
    }
}