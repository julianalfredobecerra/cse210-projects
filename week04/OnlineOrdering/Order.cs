using System;
class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        // Creates a variable total and initializes it to 0.
        // This will hold the sum of all product costs.
        double total = 0;
        // foreach (var product in _products) Loops through each Product in the _products list
        foreach (var product in _products)
        {
            // product.GetTotalCost() Calls the GetTotalCost() method on each product
            // total += product.GetTotalCost(); Adds the product’s total cost to total
            total += product.GetTotalCost();
        }
        // _customer.IsInUSA() Calls the IsInUSA() method on the customer’s address.
        // ? 5 : 35 If the customer is in the USA, add $5 to total.
        // If the customer is outside the USA, add $35 instead.
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        // string label = "Packing Label:\n"; Creates a variable label and initializes it with "Packing Label:\n".
        // This serves as the header of the label.
        string label = "Packing Label:\n";
        // Loops through each Product in the _products list.
        foreach (var product in _products)
        {
            // product.GetPackingLabel() Calls the GetPackingLabel() method of each Product.
            // Adds the product’s label to label (with a "- " prefix).
            label += " - " + product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}