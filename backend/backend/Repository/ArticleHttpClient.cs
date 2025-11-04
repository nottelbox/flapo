using backend.Domain;
using backend.Repository.Exceptions;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace backend.Repository
{
    public class ArticleHttpClient
    {
        private static HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://flapotest.blob.core.windows.net"),
        };

        public async Task<List<Article>> GetArticles()
        {
            var res = await httpClient.GetAsync("test/ProductData.json");
            res.EnsureSuccessStatusCode();

            var products = await res.Content.ReadFromJsonAsync<List<ProductDto>>();

            if (products is null)
            {
                throw new ProductsNotDeserialisable();
            }

            return products.SelectMany(p => p.Articles, (product, article) => new Article()
            {
                Id = article.Id,
                Name = product.Name,
                ShortDescription = article.ShortDescription,
                Price = article.Price,
                PricePerLiter = ParsePricePerLiter(article.PricePerUnitText),
                Image = article.Image,
            }).ToList();
        }

        private static decimal ParsePricePerLiter(string pricePerUnitText)
        {
            var match = Regex.Match(pricePerUnitText, @"\d+,\d+");

            if (match.Success)
            {
                return decimal.Parse(match.Value, new CultureInfo("de-DE"));
            }
            else
            {
                throw new PricePerUnitTextInvalid();
            }
        }
    }
}
