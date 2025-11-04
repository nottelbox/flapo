using backend.Domain;

namespace backend.Services
{
    public class ArticleFilterService
    {
        public List<Article> FilterArticles(List<Article> articles)
        {
            return articles.Where(a => a.PricePerLiter <= 2).ToList();
        }
    }
}
