using BlogAppWeb.Entity;

namespace BlogAppWeb.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void CreateUser(User User);
    }
}
