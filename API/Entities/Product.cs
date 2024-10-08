namespace API.Entities
{
    public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    public string Description { get; set; } = string.Empty;
    public string PictureUrl { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
public decimal Price { get; set; } 
   public int QuantityInStock {get; set;}

    public Product() { }
}
}