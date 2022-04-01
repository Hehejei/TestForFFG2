using System;
using System.ComponentModel.DataAnnotations;

namespace TestForFFG2.Models
{
    public class ClientContacts
    {
        public Int64 Id { get; set; }

        public Int64 ClientId { get; set; }

        [MaxLength(255)]
        public string ContactType { get; set; }

        [MaxLength(255)]
        public string ContactValue { get; set; }

    }
}
