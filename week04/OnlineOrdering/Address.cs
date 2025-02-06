using System;
class Address
{
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

    public bool IsInUSA()
    {
        // .ToUpper() Converts _country to uppercase to make the comparison case insensitive.
        // == "USA" Checks if the uppercase country name is exactly "USA".
        // return Sends back true if the country is "USA", otherwise false.
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        // return Sends the string back to whoever called the method, allowing flexibility.
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}