using MongoDB.Driver;
using PruebaTecnica.Entities;
using PruebaTecnica.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public class ProductRepository : IProductRepository
    {
        internal MongoDBConnection _connection;
        private IMongoCollection<Product> product;
        public ProductRepository(MongoDBConnection connection)
        {
            _connection = connection;
            product = _connection.db.GetCollection<Product>("Product");
        }
        //public async Task Create(Client model)
        //{
        //    await product.InsertOneAsync(model);
        //}

        //public async Task<List<Client>> GetAll(Client model)
        //{
        //    return await client.Find(Builders<Client>.Filter.Empty).ToListAsync();
        //}
    }
}
