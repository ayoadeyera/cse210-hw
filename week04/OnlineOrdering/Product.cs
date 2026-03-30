public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // The Product does its own math. 
    // This is Encapsulation. The math stays inside the "Price Tag."
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    // Getters so the "Label Maker" can see the info
    public string GetName() { return _name; }
    public string GetProductId() { return _productId; }
}