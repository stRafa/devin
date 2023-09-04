using DevIn.Business.Models;

namespace DevIn.Business.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByCategory(Guid id);
        Task<IEnumerable<Post>> GetPostsByTag(Guid id);
    }
}
