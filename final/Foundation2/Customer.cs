public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isInUSA()
    {
        return _address.isUsAddress();
    }

    public string GetName()
    {
        return _name;
    }
}