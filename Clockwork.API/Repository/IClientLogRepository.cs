using Clockwork.API.Models;
using System.Linq;

namespace Clockwork.API.Repository
{
    public interface IClientLogRepository
    {
        ClientLog Get(int id);
        IQueryable<ClientLog> GetAll();
        ClientLog Add(ClientLog clientLog);
        ClientLog Update(ClientLog clientLog);
    }
}
