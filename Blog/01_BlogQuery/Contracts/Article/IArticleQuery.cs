using System.Collections.Generic;

namespace _01_BlogQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> LatestArticles();
        List<ArticleQueryModel> ArticlesBy(string slug);
        List<ArticleQueryModel> Search(string value);
    }
}