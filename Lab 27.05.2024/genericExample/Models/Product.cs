using genericExample.Models;

public class Product : IEntity
{
    private static int _id;
    public Product()
    {
        Id = _id;
        _id++;
    }
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string catagoryId { get; set; }
    public double UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}

