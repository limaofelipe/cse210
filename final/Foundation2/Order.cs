
public class Order
{
    private List<Product> _products = new();
    private List<Customer> _customers = new();
    private int _inUSA = 5;
    private int _otherCountry = 35;
    private int _shippingCost;
    private float _totalPrice;

    public Order()
    {

    }

    public void GetShippinglabel()
    {
        foreach (Customer customer in _customers)
        {
            Address theAddress = customer.GetAddress();
            Console.WriteLine("\n📦 Shipping label:");
            Console.WriteLine($"{theAddress.DisplayAddressInfo()}");
            _shippingCost = customer.IsCustomerInUSA() ? _inUSA : _otherCountry;
        }
    }

    public int GetShippingCost()
    {
        return _shippingCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("\n📦 Packing label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Item name: {product.GetProductName()} - Item ID: {product.GetProductID()}");
        }
    }

    public float CalculateTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.TotalPrice();
        }

        return _totalPrice + GetShippingCost();
    }

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddProduct(Product item)
    {
        _products.Add(item);
    }

    public void DisplayShippingInfo()
    {
        GetPackingLabel();
        GetShippinglabel();
        Console.WriteLine($"\nYour total cost is ${CalculateTotalCost()}\n");
    }
}