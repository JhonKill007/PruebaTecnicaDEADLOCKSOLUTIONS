using MongoDB.Driver;
using PruebaTecnica.Entities;
using PruebaTecnica.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public class ClientRepository : IClientRepository
    {
        internal MongoDBConnection _connection;
        private IMongoCollection<Client> client;
        public ClientRepository(MongoDBConnection connection)
        {
            _connection = connection;
            client = _connection.db.GetCollection<Client>("Client");
        }
        public async Task Create(Client model)
        {
            await client.InsertOneAsync(model);
        }

        public async Task<List<Client>> GetAll(Client model)
        {
            return await client.Find(Builders<Client>.Filter.Empty).ToListAsync();
        }
    }
}
