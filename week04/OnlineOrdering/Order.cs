using System.Runtime.CompilerServices;

public class Order
{
  private Customer _customer;
  private List<Product> _productList;

  public Order(Customer customer)
  {
    _customer = customer;
    _productList = new List<Product>();
  }

  public void AddProduct(Product product)
  {
    _productList.Add(product);
  }

  public Double GetTotalCost()
  {
    double totalCost = 0;
    foreach (Product product in _productList)
    {
      totalCost += product.GetCost();
    }
    if(_customer.IsUSA())
    {
      totalCost += 5;
    }
    else
    { 
      totalCost += 35; // international shipping fee
    }
    // round
    totalCost = Math.Round(totalCost, 2);
    return totalCost;
  }

  public string GetPackingLabel()
  {
    string packingLabel = "Packing Label:\n";
    foreach (Product product in _productList)
    {
      packingLabel += product.GetName() + " (ID: " + product.GetProductId() + ") x " + product.GetQuantity() + "\n";
    }
    return packingLabel;
  }

  public string GetShippingLabel()
  {
    string shippingLabel = "Shipping Label:\n";
    // Assume we have a Customer class with GetName and GetAddress methods
    shippingLabel += _customer.GetName() + "\n";
    shippingLabel += _customer.GetAddress().GetFullAddress() + "\n";
    return shippingLabel;
  }
}