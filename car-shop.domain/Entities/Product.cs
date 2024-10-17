namespace car_shop.domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}