using Service.Models;

namespace Service
{
    public interface IForumThreadService
    {
        Task<IReadOnlyList<ForumThread>> GetAll();
    }
}
