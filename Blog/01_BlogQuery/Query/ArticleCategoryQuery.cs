using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_BlogQuery.Contracts.Article;
using _01_BlogQuery.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_BlogQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _context;

        public ArticleCategoryQuery(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategoryQueryModel> GetArticleCategories()
        {
            return _context.ArticleCategories
                .Include(x => x.Articles)
                .Where(x => x.CreationDate <= DateTime.Now)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Id = x.Id,
                    PublishDate = x.CreationDate.ToFarsi(),
                    Description = x.Description,
                    Name = x.Name,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    ArticleCount = x.Articles.Count
                }).ToList();
        }

        public ArticleCategoryQueryModel GetArticleCategory(string slug)
        {
            return _context.ArticleCategories
                .Select(x => new ArticleCategoryQueryModel
                {
                    Slug = x.Slug,
                    Name = x.Name,
                    Description = x.Description,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Articles = MapArticles(x.Articles)
                }).FirstOrDefault(x => x.Slug == slug);
        }

        private static List<ArticleQueryModel> MapArticles(IEnumerable<Article> articles)
        {
            return articles.Select(x => new ArticleQueryModel
            {
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                PublishDate = x.PublishDate.ToFarsi()
            }).ToList();
        }
    }
}