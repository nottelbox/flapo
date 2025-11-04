using backend.Domain;
using backend.Repository;

namespace backend.Services
{
    public class ArticleService
    {
        private readonly ArticleHttpClient productHttpClient;
        private readonly ArticleFilterService articleFilterService;
        private readonly ArticleSortingService articleSortingService;

        public ArticleService(
            ArticleHttpClient productHttpClient,
            ArticleFilterService articleFilterService,
            ArticleSortingService articleSortingService)
        {
            this.productHttpClient = productHttpClient;
            this.articleFilterService = articleFilterService;
            this.articleSortingService = articleSortingService;
        }

        public async Task<List<Article>> GetArticles(string? sortByPrice, bool filter)
        {
            var articles = await productHttpClient.GetArticles();
            if (filter)
            {
                articles = articleFilterService.FilterArticles(articles);
            }
            
            if (sortByPrice == "asc")
            {
                articles = articleSortingService.SortAscending(articles);
            }

            if (sortByPrice == "desc")
            {
                articles = articleSortingService.SortAscending(articles);
            }
            
            return articles;
        }
    }
}
