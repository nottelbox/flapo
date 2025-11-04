using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService articleService;

        public ArticleController(ArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticles([FromQuery] string? sortByPrice, [FromQuery] bool filter = false)
        {
            if(sortByPrice is not null && sortByPrice != "asc" && sortByPrice != "desc")
            {
                return BadRequest();
            }

            return Ok((await articleService.GetArticles(sortByPrice, filter))
                .Select(a => new ArticleResponseBody(a)));
            
        }
    }
}
