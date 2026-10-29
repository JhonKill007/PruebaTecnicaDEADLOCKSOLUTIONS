using PruebaTecnica.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Task Create(Client model);
        Task<List<Client>> GetAll();
    }
}
