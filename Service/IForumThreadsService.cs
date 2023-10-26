using Service.Models;

namespace Service
{
    public interface IForumThreadsService
    {
        Task CreateAsync(ForumThread newBook);
        Task<List<ForumThread>> GetAsync();
        Task<ForumThread?> GetAsync(string id);
        Task RemoveAsync(string id);
        Task UpdateAsync(string id, ForumThread updatedBook);
    }
}