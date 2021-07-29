using System.Collections.Generic;
using _01_BlogQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleModel : PageModel
    {
        public ArticleQueryModel Article;
        public List<ArticleQueryModel> LatestArticles;
        private readonly IArticleQuery _articleQuery;

        public ArticleModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string id)
        {
            Article = _articleQuery.GetArticleDetails(id);
            LatestArticles = _articleQuery.LatestArticles();
        }
    }
}