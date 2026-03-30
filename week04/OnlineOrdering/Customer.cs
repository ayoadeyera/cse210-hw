public class Customer
{
    private string _name;
    private Address _address; // This is a class inside a class!

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Abstraction in action: The Customer asks the Address "Are you in the USA?"
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters for the Order class to use later
    public string GetName() { return _name; }
    public Address GetAddress() { return _address; }
}