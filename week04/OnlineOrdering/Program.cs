using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("1515 SE Marshall St", "Boone", "Iowa", "USA");
        Customer c1 = new Customer("Robert Fischer", ad1);
        Product p1 = new Product("Oreos", 940113, 3.98, 2);
        Product p2 = new Product("2% Milk", 640725, 4.48, 1);
        Product p3 = new Product("Bananas", 4011, 0.54, 6);

        List<Product> productList1 = new List<Product>();
        productList1.Add(p1);
        productList1.Add(p2);
        productList1.Add(p3);
        Order order1 = new Order(c1, productList1);

        Address ad2 = new Address("534 S Duff Ave", "Ames", "Iowa", "USA");
        Customer c2 = new Customer("Napoleon Dynamite", ad2);
        Product p4 = new Product("Canned Tuna", 367591, 2.18, 4);
        Product p5 = new Product("Honey Roasted Peanuts 16oz", 124445, 3.48, 3);
        Product p6 = new Product("Mayonnaise", 655723, 2.98, 1);

        List<Product> productList2 = new List<Product>();
        productList2.Add(p4);
        productList2.Add(p5);
        productList2.Add(p6);
        Order order2 = new Order(c2, productList2);

        List<Order> orderList = new List<Order>();
        orderList.Add(order1);
        orderList.Add(order2);

        foreach (Order order in orderList)
        {
            Console.WriteLine("Packing label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total price: ${order.GetTotalPrice()}");
            Console.WriteLine();
        }
    }
}