namespace ProductOperation.Models
{
    public class Product_Detail
    {
        List<Product> products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
        public string Image { get; set; }
    }
}
