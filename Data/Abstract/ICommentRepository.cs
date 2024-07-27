using BlogAppWeb.Entity;

namespace BlogAppWeb.Data.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }
        void CreateComment(Comment comment);
    }
}