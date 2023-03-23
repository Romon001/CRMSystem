using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRMSystem.Domain.Entities
{
    public class ExecutiveDepartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid? RequestId { get; set; }
        public string? LastName{ get; set; }
        public string? FirstName{ get; set; }
        public string? MiddleName{ get; set; }
        public string? Gender{ get; set; }
        public string? Position{ get; set; }
        public double? PercentShare{ get; set; }
        public string? INN{ get; set; }
        public string? SNILS{ get; set; }
        public bool? IsPublicOfficialPerson { get; set; }
        public bool? IsPublicOfficialPersonRelative { get; set; }
        public DateTime? BirthDate{ get; set; }
        public string? BirthPlace{ get; set; }
        public string? Nationality{ get; set; }
        public string? PassportSeries{ get; set; }
        public string? PassportNumber{ get; set; }
        public DateTime? ExtraditionPassportDate{ get; set; }
        public string? DepartmentCode { get; set; }
        public string? WhoGivesPassport { get; set; }
        public string? RegistrationAdress { get; set; }


    }
}
