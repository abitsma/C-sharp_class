public class Product
{
    private string _productName;
    private string _productID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, int ppu, int quantity)
    {
        _productName = name;
        _productID = id;
        _pricePerUnit = ppu;
        _quantity = quantity;
    }

    public int ProductCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}