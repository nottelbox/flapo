using backend.Domain;

namespace backend.Controllers
{
    public class ArticleResponseBody
    {
        public ArticleResponseBody(Article article)
        {
            Id = article.Id;
            Name = article.Name;
            ShortDescription = article.ShortDescription;
            Price = article.Price;
            Image = article.Image;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }
    }
}
