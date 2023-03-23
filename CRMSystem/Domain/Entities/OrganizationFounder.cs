using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRMSystem.Domain.Entities
{
    public class OrganizationFounder
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id{ get; set; }
        public Guid? RequestId{ get; set; }
        public string? Name{ get; set; }
        public string? INN{ get; set; }
        public bool? IsResident{ get; set; }

    }
}
