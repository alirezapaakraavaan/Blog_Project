using System.Collections.Generic;
using _01_BlogQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCommentCountController : ControllerBase
    {
        private readonly IArticleQuery _articleQuery;
        public List<ArticleQueryModel> Articles;

        public ArticleCommentCountController(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        [HttpGet]
        public long CommentsCount()
        {
            Articles = _articleQuery.LatestArticles();
            foreach (var article in Articles)
            {
                return article.Comments.Count;
            }

            return 0;
        }

        [HttpPost]
        public CommentStatus CheckCount(CommentCount command)
        {
            return _articleQuery.CheckCount(command);
        }
    }
}