using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MyApi.Models;

namespace MyApi.Services
{
    public class MongoServices
    {
        private readonly IMongoCollection<User> _user;

        public MongoServices(IOptions<MongoClientSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _user = database.GetCollection<User>("User");
        }

        public async Task<List<User>> GetUsers()
        {
            return await _user.Find(_ => true).ToListAsync();
        }

        public async Task<User> AddUser(User user)
        {
            await _user.InsertOneAsync(user);
            return user;
        }
    }

    public class MongoClientSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
