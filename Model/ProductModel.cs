namespace DynamicTechShop.Model;

public class ProductModel
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; } // Exempelvis: Smartphone, Laptop, Headphones
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public double Price { get; set; }

    public DateTime OrderedTime { get; set; }


}
