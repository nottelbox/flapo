namespace backend.Repository
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ArticleDto> Articles { get; set; }
    }
}
