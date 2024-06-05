
// I modify the Address class to fit program function workflow
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {}

    public bool IsLocationUSA(string country)
    {
        if (country.ToLower() == "usa") return true;
        else return false;
    }

    private void SetStreetAddress()
    {
        Console.Write("Enter street address: ");
        _streetAddress = Console.ReadLine();
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    private void SetCityName()
    {
        Console.Write("Enter city name: ");
        _city = Console.ReadLine();
    }

    public string GetCity()
    {
        return _city;
    }

    private void SetStateOrProvince()
    {
        Console.Write("Enter state/province: ");
        _stateOrProvince = Console.ReadLine();
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    private void SetCountry()
    {
        Console.Write("Enter country name: ");
        _country = Console.ReadLine();
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetAddress()
    {
        SetStreetAddress();
        SetCityName();
        SetStateOrProvince();
        SetCountry();
    }

    public string DisplayAddressInfo()
    {
        
        string addressInfo = $"Street: {GetStreetAddress()}\nCity: {GetCity()}\nState/Province: {GetStateOrProvince()}\nCountry: {GetCountry()}";
        // Console.WriteLine(addressInfo);
        return addressInfo;
    }

}