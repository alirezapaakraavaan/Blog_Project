using System.Collections.Generic;
using _01_BlogQuery.Contracts.Article;

namespace _01_BlogQuery.Contracts.ArticleCategory
{
    public class ArticleCategoryQueryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string PublishDate { get; set; }
        public long ArticleCount { get; set; }
        public List<ArticleQueryModel> Articles { get; set; }
    }
}