using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRMSystem.Domain.Entities
{
    public class ChatMessage
    {
        public Guid RequestId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SendingTime { get; set; }
        public string Value { get; set; }

    }
}
