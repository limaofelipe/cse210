
public class Product
{
    private string _productName;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product()
    {

    }

    public void SetProductName()
    {
        Console.Write("Item name: ");
        _productName = Console.ReadLine();
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductID()
    {
        string idNumber = "";
        Random random = new();
        for (int i = 0; i < 8; i++)
        {
            idNumber += random.Next(9);
        }
        _productID = $"#{idNumber}";
    }

    public string GetProductID()
    {
        SetProductID();
        return _productID;
    }

    public void SetPrice()
    {
        Console.Write("Price of item: $");
        _price = float.Parse(Console.ReadLine());
    }

    public float GetPrice()
    {
        return _price;
    }

    public void SetQuantity()
    {
        Console.Write("Quantity of the item: ");
        _quantity = int.Parse(Console.ReadLine());
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float TotalPrice()
    {
        return _price * _quantity;
    }
}