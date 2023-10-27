using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Service.Models;
using Shared;

namespace Service;

public class ThreadContentService : IThreadContentService
{
    private readonly IMongoCollection<ThreadContent> _threadsCollection;
    private readonly IMongoClient _mongoClient;

    public ThreadContentService(
        IOptions<NoSqlSettings> bookStoreDatabaseSettings, IMongoClient mongoClient)
    {
        _mongoClient = mongoClient;

        var mongoDatabase = _mongoClient.GetDatabase(
            bookStoreDatabaseSettings.Value.DatabaseName);

        _threadsCollection = mongoDatabase.GetCollection<ThreadContent>(
            "Threads");
    }

    public async Task<List<ThreadContent>> GetAsync() =>
        await _threadsCollection.Find(_ => true).ToListAsync();

    public async Task<ThreadContent?> GetAsync(string id) =>
        await _threadsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(ThreadContent newThreadContent) =>
        await _threadsCollection.InsertOneAsync(newThreadContent);

    public async Task UpdateAsync(string id, ThreadContent updatedThreadContent) =>
        await _threadsCollection.ReplaceOneAsync(x => x.Id == id, updatedThreadContent);

    public async Task RemoveAsync(string id) =>
        await _threadsCollection.DeleteOneAsync(x => x.Id == id);
}