using Service.Models;

namespace Service
{
    public interface IThreadContentService
    {
        Task CreateAsync(ThreadContent newBook);
        Task<List<ThreadContent>> GetAsync();
        Task<ThreadContent?> GetAsync(string id);
        Task RemoveAsync(string id);
        Task UpdateAsync(string id, ThreadContent updatedBook);
    }
}