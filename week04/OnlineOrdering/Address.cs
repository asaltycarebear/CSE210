class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }
    public void SetState(string value)
    {
        _state = value;
    }

    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string value)
    {
        _country = value;

    }
    public bool IsInUSA() //added a way to say many different ways to input USA
    {
        string country = _country.Trim().ToUpper();

        string[] usaVariations =
        {
            "USA",
            "U.S.A.",
            "UNITED STATES",
            "UNITED STATES OF AMERICA",
            "US",
            "U.S."
        };

        return usaVariations.Contains(country);
    }

        public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}