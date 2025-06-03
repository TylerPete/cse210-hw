public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        return totalPrice + GetShippingCost();
    }

    private int GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string theLabel = "";

        foreach (Product product in _products)
        {
            theLabel += $"{product.GetProductName()} - ID: {product.GetProductID()}\r\n";
        }

        return theLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\r\n{_customer.GetCustomerAddress()}";
    }
}