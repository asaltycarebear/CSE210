class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string value)
    {
        _productId = value;
    }

    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double value)
    {
        _price = value;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int value)
    {
        _quantity = value;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
