using backend.Domain;
using backend.Repository;

namespace backend.Services
{
    public class ArticleService
    {
        private readonly ArticleHttpClient productHttpClient;
        private readonly ArticleFilterService articleFilterService;

        public ArticleService(
            ArticleHttpClient productHttpClient,
            ArticleFilterService articleFilterService)
        {
            this.productHttpClient = productHttpClient;
            this.articleFilterService = articleFilterService;
        }

        public async Task<List<Article>> GetArticles(string? sortByPrice, bool filter)
        {
            var articles = await productHttpClient.GetArticles();
            if (filter)
            {
                articles = articleFilterService.FilterArticles(articles);
            }
            throw new NotImplementedException();
        }
    }
}
