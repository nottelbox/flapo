using System.ComponentModel;

namespace backend.Repository
{
    public class ProductHttpClient
    {
        private static HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://flapotest.blob.core.windows.net"),
        };

        public async Task<List<Product>> GetProducts()
        {
            var res = await httpClient.GetAsync("test/ProductData.json");
            res.EnsureSuccessStatusCode();

            var products = await res.Content.ReadFromJsonAsync<List<Product>>();

            return products ?? throw new ProductsNotDeserialisable();
        }
    }
}
