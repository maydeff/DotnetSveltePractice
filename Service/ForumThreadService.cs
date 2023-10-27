using Dapper;
using Service.Models;
using System.Data;

namespace Service
{
    public class ForumThreadService : IForumThreadService
    {
        private readonly IDbConnection _dbConnection;

        public ForumThreadService(IDbConnection connection)
        {
            _dbConnection = connection;
        }

        public async Task<IReadOnlyList<ForumThread>> GetAll()
        {
            using (_dbConnection)
            {
                string query = "SELECT *, my_document_key as DocumentKey FROM threads";

                var dbResult = await _dbConnection.QueryAsync<ForumThread>(query);
                return dbResult.ToList();
            }
        }
    }
}
