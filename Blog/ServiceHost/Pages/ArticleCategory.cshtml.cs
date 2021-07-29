using System.Collections.Generic;
using _01_BlogQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleCategoryModel : PageModel
    {
        private readonly IArticleCategoryQuery _articleCategoryQuery;
        public List<ArticleCategoryQueryModel> ArticleCategory;

        public ArticleCategoryModel(IArticleCategoryQuery articleCategoryQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet()
        {
            ArticleCategory = _articleCategoryQuery.GetArticleCategories();
        }
    }
}