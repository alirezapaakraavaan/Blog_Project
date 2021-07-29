using System.Collections.Generic;
using _01_BlogQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        private readonly IArticleQuery _articleQuery;
        public List<ArticleQueryModel> Article;

        public SearchModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            Article = _articleQuery.Search(value);
        }
    }
}