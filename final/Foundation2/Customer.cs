
public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer()
    {

    }

    public bool IsCustomerInUSA()
    {
        return _customerAddress.IsLocationUSA(_customerAddress.GetCountry());
    }

    public void SetCustomerName()
    {
        Console.Write("What is your name?: ");
        _customerName = Console.ReadLine();
        Console.WriteLine("");
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerAddress(string address, string city, string stateProvince, string country)
    {
        _customerAddress = new(address: address, city: city, stateProvince: stateProvince, country: country);
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}