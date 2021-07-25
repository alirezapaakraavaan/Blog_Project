using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.EFCore.Repository
{
    public class ArticleRepository : RepositoryBase<long, Article>, IArticleRepository
    {
        private readonly BlogContext _context;

        public ArticleRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public EditArticle GetDetails(long id)
        {
            return _context.Articles.Select(x => new EditArticle
            {
                Id = x.Id,
                Description = x.Description,
                PictureAlt = x.PictureAlt,
                Slug = x.Slug,
                MetaDescription = x.MetaDescription,
                Keywords = x.Keywords,
                CanonicalAddress = x.CanonicalAddress,
                CategoryId = x.CategoryId,
                PictureTitle = x.PictureTitle,
                PublishDate = x.PictureAlt,
                ShortDescription = x.ShortDescription,
                Title = x.Title
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            var query = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                ShortDescription = x.ShortDescription,
                Title = x.Title,
                Picture = x.Picture,
                Category = x.ArticleCategory.Name,
                PublishDate = x.PublishDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
                query = query.Where(x => x.Title.Contains(searchModel.Title));

            if (searchModel.CategoryId > 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public Article GetWithCategory(long id)
        {
            return _context.Articles.Include(x => x.ArticleCategory).FirstOrDefault(x => x.Id == id);
        }
    }
}