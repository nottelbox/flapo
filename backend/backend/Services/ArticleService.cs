using backend.Domain;
using backend.Repository;

namespace backend.Services
{
    public class ArticleService
    {
        private readonly ProductHttpClient productHttpClient;

        public ArticleService(ProductHttpClient productHttpClient)
        {
            this.productHttpClient = productHttpClient;
        }

        public async Task<List<ArticleForDisplay>> GetArticles(string? sortByPrice, bool filter)
        {
            var products = await productHttpClient.GetProducts();
            throw new NotImplementedException();
        }
    }
}
