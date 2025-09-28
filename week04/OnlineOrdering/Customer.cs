class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }

    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}