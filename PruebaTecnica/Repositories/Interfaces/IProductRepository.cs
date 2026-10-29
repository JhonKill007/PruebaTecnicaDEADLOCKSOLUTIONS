using PruebaTecnica.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task Create(Product model);
        Task Update(Product model);
        Task<Product> GetById(string id);
        Task<List<Product>> GetAll();
    }
}
