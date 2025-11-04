namespace backend.Domain
{
    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerLiter { get; set; }

        public string Image {  get; set; }
    }
}
