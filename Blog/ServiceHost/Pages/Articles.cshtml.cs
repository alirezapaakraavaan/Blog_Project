using System.Collections.Generic;
using _01_BlogQuery.Contracts.Article;
using _01_BlogQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticlesModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;
        public List<ArticleQueryModel> Articles;
        public ArticleQueryModel Article;
        public List<ArticleCategoryQueryModel> ArticleCategories;
        public ArticleCategoryQueryModel ArticleCategory;

        public ArticlesModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
            Articles = new List<ArticleQueryModel>();
        }

        public void OnGet(string id)
        {
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();
            Articles = _articleQuery.ArticlesBy(id);
        }
    }
}