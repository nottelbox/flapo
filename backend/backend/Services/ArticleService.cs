using backend.Domain;
using backend.Repository;

namespace backend.Services
{
    public class ArticleService
    {
        private readonly ArticleHttpClient productHttpClient;

        public ArticleService(ArticleHttpClient productHttpClient)
        {
            this.productHttpClient = productHttpClient;
        }

        public async Task<List<Article>> GetArticles(string? sortByPrice, bool filter)
        {
            var products = await productHttpClient.GetArticles();
            throw new NotImplementedException();
        }
    }
}
