namespace CrmMVC.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int CatalogueNumber { get; set; }
        public string Name { get; set; }
        public ProductUnit Unit { get; set; }
        public int UnitId { get; set; }
        public double WeightPerUnitInKg { get; set; }
        public ProductDiameter Diameter { get; set; }
        public int DiameterId { get; set; }
        public bool IsPipe { get; set; }
        public bool IsOfferItem { get; set; }
        public List<ProductInProject>? ProductsInProjects { get; set; }
    }
}