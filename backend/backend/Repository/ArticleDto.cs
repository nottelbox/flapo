namespace backend.Repository
{
    public class ArticleDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string ShortDescription { get; set; }

        public string PricePerUnitText { get; set; }

        public string Image {  get; set; }
    }
}
