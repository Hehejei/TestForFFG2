using System;
using System.ComponentModel.DataAnnotations;

namespace TestForFFG2.Models
{
    public class Clients
    {
        public Int64 Id { get; set; }

        [MaxLength(200)]
        public string ClientName { get; set; }
    }
}
