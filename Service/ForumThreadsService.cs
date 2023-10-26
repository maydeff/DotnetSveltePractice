using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Service.Models;
using Shared;

namespace Service;

public class ForumThreadsService : IForumThreadsService
{
    private readonly IMongoCollection<ForumThread> _threadsCollection;

    public ForumThreadsService(
        IOptions<NoSqlSettings> bookStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            bookStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            bookStoreDatabaseSettings.Value.DatabaseName);

        _threadsCollection = mongoDatabase.GetCollection<ForumThread>(
            "Threads");
    }

    public async Task<List<ForumThread>> GetAsync() =>
        await _threadsCollection.Find(_ => true).ToListAsync();

    public async Task<ForumThread?> GetAsync(string id) =>
        await _threadsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(ForumThread newBook) =>
        await _threadsCollection.InsertOneAsync(newBook);

    public async Task UpdateAsync(string id, ForumThread updatedBook) =>
        await _threadsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

    public async Task RemoveAsync(string id) =>
        await _threadsCollection.DeleteOneAsync(x => x.Id == id);
}