using Clockwork.API.Models;
using Clockwork.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Clockwork.API.Controllers
{
    public class ClientLogController : ControllerBase
    {
        private readonly IClientLogRepository _clientLogRepository;

        public ClientLogController(IClientLogRepository clientLogRepository)
        {
            _clientLogRepository = clientLogRepository;
        }

        [Route("api/[controller]/time")]
        public IActionResult GetClientLog()
        {
            var newClientLog = new ClientLog
            {
                Timestamp = DateTime.Now,
                Timestamp_UTC = DateTime.UtcNow,
                IPAddress = this.HttpContext.Connection.RemoteIpAddress.ToString()
            };

            var result = _clientLogRepository.Add(newClientLog);

            Console.WriteLine("A new client log record has been saved.");

            return Ok(new
            {
                id = result.Id,
                ipAddress = result.IPAddress,
                timestamp = result.Timestamp.ToString(),
                timestamp_UTC = result.Timestamp_UTC.ToString(),
                preferredTimestamp = result.PreferredTimestamp == default(DateTimeOffset) ? string.Empty : result.PreferredTimestamp.ToString()
            });
        }

        [Route("api/[controller]/list")]
        public IActionResult GetClientLogs()
        {
            var clientLogs = _clientLogRepository.GetAll();

            if(!clientLogs.Any())
            {
                return NoContent();
            }

            return Ok(clientLogs.Select(x => new
            {
                id = x.Id,
                ipAddress = x.IPAddress,
                timestamp = x.Timestamp.ToString(),
                timestamp_UTC = x.Timestamp_UTC.ToString(),
                preferredTimestamp = x.PreferredTimestamp == default(DateTimeOffset) ? string.Empty : x.PreferredTimestamp.ToString()
            }));
        }

        [HttpPost]
        [Route("api/[controller]/timezone")]
        public IActionResult SetPreferredTimezone(string timezoneId, ClientLog clientLog)
        {
            clientLog.PreferredTimestamp = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(clientLog.Timestamp, timezoneId);

            var result = _clientLogRepository.Update(clientLog);

            return Ok(new
            {
                id = result.Id,
                ipAddress = result.IPAddress,
                timestamp = result.Timestamp.ToString(),
                timestamp_UTC = result.Timestamp_UTC.ToString(),
                preferredTimestamp = result.PreferredTimestamp  == default(DateTimeOffset) ? string.Empty : result.PreferredTimestamp.ToString()
            });
        }
    }
}
