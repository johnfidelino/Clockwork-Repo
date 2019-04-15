using Clockwork.API.Data;
using Clockwork.API.Models;
using System;
using System.Linq;

namespace Clockwork.API.Repository
{
    public class ClientLogRepository : IClientLogRepository
    {
        private readonly ClockworkContext _context;

        public ClientLogRepository(ClockworkContext context)
        {
            _context = context;
        }

        public ClientLog Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClientLog> GetAll()
        {
            return _context.ClientLogs;
        }

        public ClientLog Add(ClientLog clientLog)
        {
            _context.ClientLogs.Add(clientLog);
            _context.SaveChanges();

            return clientLog;
        }

        public ClientLog Update(ClientLog clientLog)
        {
            ClientLog clientLogToUpdate = _context.ClientLogs.Find(clientLog.Id);

            clientLogToUpdate.PreferredTimestamp = clientLog.PreferredTimestamp;
            _context.SaveChanges();

            return clientLogToUpdate;
        }
    }
}
