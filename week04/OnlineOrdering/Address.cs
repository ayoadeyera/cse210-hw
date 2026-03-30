using System;

public class Address
{
    // These are private! Nobody can touch them from outside this file.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // This is a "Button" (Abstraction). 
    // The rest of the program doesn't need to know how we check the country.
    public bool IsInUSA()
    {
        // We use .ToLower() to make sure "USA" and "usa" both work.
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    // Returns the full address as a neat block of text
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}