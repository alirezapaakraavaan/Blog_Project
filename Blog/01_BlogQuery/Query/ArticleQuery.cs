using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_BlogQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_BlogQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article = _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Slug = x.Slug,
                    PublishDate = x.PublishDate.ToFarsi(),
                    CanonicalAddress = x.CanonicalAddress,
                    CategoryName = x.ArticleCategory.Name,
                    CategorySlug = x.ArticleCategory.Slug,
                    Description = x.Description,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    ShortDescription = x.ShortDescription,
                    Title = x.Title
                }).FirstOrDefault(x => x.Slug == slug);

            if (!string.IsNullOrWhiteSpace(article.Keywords))
                article.KeywordList = article.Keywords.Split(",").ToList();

            return article;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Title = x.Title
                }).ToList();
        }

        public List<ArticleQueryModel> ArticlesBy(string slug)
        {
            return _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now && x.CategoryId == x.ArticleCategory.Id)
                .Select(x => new ArticleQueryModel
                {
                    Slug = x.Slug,
                    Picture = x.Picture,
                    CategoryId = x.ArticleCategory.Id,
                    CategoryName = x.ArticleCategory.Name,
                    CategorySlug = x.ArticleCategory.Slug,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Title = x.Title
                }).Where(x => x.CategorySlug == slug).ToList();
        }

        public List<ArticleQueryModel> Search(string value)
        {
            var query = _context.Articles.Select(x => new ArticleQueryModel
            {
                Title = x.Title,
                Description = x.Description,
                ShortDescription = x.ShortDescription,
                PublishDate = x.PublishDate.ToFarsi(),
                CategoryName = x.ArticleCategory.Name,
                Slug = x.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x =>
                    x.Title.Contains(value)
                    || x.ShortDescription.Contains(value)
                    || x.CategoryName.Contains(value));

            return query.ToList();
        }
    }
}