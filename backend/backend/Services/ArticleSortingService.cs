using backend.Domain;

namespace backend.Services
{
    public class ArticleSortingService
    {

        public List<Article> SortAscending(List<Article> articles) =>
            articles.OrderBy(a => a.Price).ToList();

        public List<Article> SortDescending(List<Article> articles) =>
            articles.OrderByDescending(a => a.Price).ToList();
    }
}
