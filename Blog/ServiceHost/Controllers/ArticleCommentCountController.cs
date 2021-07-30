using _01_BlogQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCommentCountController : ControllerBase
    {
        private readonly IArticleQuery _articleQuery;

        public ArticleCommentCountController(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        [HttpPost]
        public CommentStatus CheckCount(CommentCount command)
        {
            return _articleQuery.CheckCount(command);
        }
    }
}