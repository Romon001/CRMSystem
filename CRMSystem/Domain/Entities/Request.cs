using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Domain.Entities
{
    public class Request
    {
        [Key]
        [Required] 
        public Guid RequestId { get; set; }
        public int UserId { get; set; }
        public int RequestTypeId { get; set; }

    }
}
