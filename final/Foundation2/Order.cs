using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCostPlusShipping()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = _customer.isInUSA() ? 5.00 : 35.00;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing List:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} : {product.GetProductID()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;
    }
}