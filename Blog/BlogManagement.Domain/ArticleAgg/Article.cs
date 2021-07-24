using System;
using _0_Framework.Domain;
using BlogManagement.Domain.ArticleCategoryAgg;

namespace BlogManagement.Domain.ArticleAgg
{
    public class Article : EntityBase
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public DateTime PublishDate { get; private set; }
        public string Slug { get; private set; }
        public string MetaDescription { get; private set; }
        public string Keywords { get; private set; }
        public string CanonicalAddress { get; private set; }
        public long CategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }

        public Article(string canonicalAddress, long categoryId, string description, string keywords,
            string metaDescription, string picture, string pictureAlt, string pictureTitle, DateTime publishDate,
            string shortDescription, string slug, string title)
        {
            CanonicalAddress = canonicalAddress;
            CategoryId = categoryId;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            PublishDate = publishDate;
            ShortDescription = shortDescription;
            Slug = slug;
            Title = title;
        }

        public void Edit(string canonicalAddress, long categoryId, string description, string keywords,
            string metaDescription, string picture, string pictureAlt, string pictureTitle, DateTime publishDate,
            string shortDescription, string slug, string title)
        {
            CanonicalAddress = canonicalAddress;
            CategoryId = categoryId;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;

            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            PublishDate = publishDate;
            ShortDescription = shortDescription;
            Slug = slug;
            Title = title;
        }
    }
}