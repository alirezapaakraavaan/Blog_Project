using System.Collections.Generic;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Administration.Pages.Blog.Articles
{
    [Authorize(Roles = Roles.Administrator)]
    public class IndexModel : PageModel
    {
        public ArticleSearchModel SearchModel;
        public List<ArticleViewModel> Articles;
        public SelectList ArticleCategories;

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleCategoryApplication articleCategoryApplication,
            IArticleApplication articleApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet(ArticleSearchModel searchModel)
        {
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticleCategories(),
                "Id", "Name");
            Articles = _articleApplication.Search(searchModel);
        }
    }
}