namespace CrmMVC.Domain.Model
{
    public class ProductDiameter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();
    }
}