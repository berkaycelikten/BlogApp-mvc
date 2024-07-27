using BlogAppWeb.Entity;

namespace BlogAppWeb.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }
        void CreateTag(Tag tag);
    }
}