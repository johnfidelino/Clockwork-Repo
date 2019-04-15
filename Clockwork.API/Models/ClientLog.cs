using System;
using System.ComponentModel.DataAnnotations;

namespace Clockwork.API.Models
{
    public class ClientLog
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string IPAddress { get; set; }
        public DateTime Timestamp_UTC { get; set; }
        public DateTimeOffset PreferredTimestamp { get; set; }

    }
}
