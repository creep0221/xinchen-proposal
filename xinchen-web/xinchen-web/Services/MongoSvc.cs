using MongoDB.Driver;
using System.Linq.Expressions;
using xinchen_web.Models;

namespace xinchen_web.Services
{
    public class MongoSvc
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        public MongoSvc(MongoClient client)
        {
            _client = client;
            _database = GetMongoDataBase();
        }

        private IMongoDatabase GetMongoDataBase()
        {
            return _client.GetDatabase("xinchen");
        }

        public List<T> Get<T>(FilterDefinition<T> filter) =>
        _database.GetCollection<T>(typeof(T).Name).Find<T>(filter).ToList();

        public T Create<T>(T entity)
        {
            _database.GetCollection<T>(typeof(T).Name).InsertOne(entity);
            return entity;
        }

        
        public bool ReplaceOne<T>(FilterDefinition<T> filter, T replacement)
        {
            ReplaceOneResult result = _database.GetCollection<T>(typeof(T).Name).ReplaceOne(filter, replacement);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        public void Remove<T>(FilterDefinition<T> filter) =>
            _database.GetCollection<T>(typeof(T).Name).DeleteOne(filter);


    }
}
