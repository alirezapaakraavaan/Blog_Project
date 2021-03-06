using System.Collections.Generic;
using _0_Framework.Domain;
using BlogManagement.Domain.ArticleAgg;

namespace BlogManagement.Domain.ArticleCategoryAgg
{
    public class ArticleCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Description { get; private set; }
        public int ShowOrder { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string CanonicalAddress { get; private set; }
        public List<Article> Articles { get; private set; }

        public ArticleCategory(string canonicalAddress, string description, string keywords, string metaDescription,
            string name, string picture, string pictureAlt, string pictureTitle, int showOrder, string slug)
        {
            CanonicalAddress = canonicalAddress;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShowOrder = showOrder;
            Slug = slug;
        }

        public void Edit(string canonicalAddress, string description, string keywords, string metaDescription,
            string name, string picture, string pictureAlt, string pictureTitle, int showOrder, string slug)
        {
            CanonicalAddress = canonicalAddress;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Name = name;

            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;

            ShowOrder = showOrder;
            Slug = slug;
        }
    }
}