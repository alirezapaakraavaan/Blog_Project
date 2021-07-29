using System.Collections.Generic;

namespace _01_BlogQuery.Contracts.ArticleCategory
{
    public interface IArticleCategoryQuery
    {
        List<ArticleCategoryQueryModel> GetArticleCategories();
        ArticleCategoryQueryModel GetArticleCategory(string slug);
    }
}