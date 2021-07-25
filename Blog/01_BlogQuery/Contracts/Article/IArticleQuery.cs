using System.Collections.Generic;

namespace _01_BlogQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> LatestArticles();
    }
}