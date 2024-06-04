
using System.Dynamic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stateProvince, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateOrProvince = stateProvince;
        _country = country;
    }

    public bool IsLocationUSA(string country)
    {
        if (country.ToLower() == "usa") return true;
        else return false;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string DisplayAddressInfo()
    {
        
        string addressInfo = $"Street: {GetStreetAddress()}\nCity: {GetCity()}\nState/Province: {GetStateOrProvince()}\nCountry: {GetCountry()}";
        // Console.WriteLine(addressInfo);
        return addressInfo;
    }

}