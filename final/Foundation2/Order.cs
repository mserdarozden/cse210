public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost = totalCost + product.calculateTotalCost();
        }
        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else 
        {
            totalCost += 35;
        }

        double roundedTotalCost = (double)Math.Round(totalCost, 2);
        return roundedTotalCost;
    }

    public List<string> GetPackingLabel()
    {
        List<string> packingLabel = new List<string>();

        foreach (Product product in _products)
        {
            packingLabel.Add($"Name: {product.GetName()} Id: {product.GetId()}");
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Name: {_customer.GetName()} \n\nAdress: \n{_customer.getAdress()}";

        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    
}