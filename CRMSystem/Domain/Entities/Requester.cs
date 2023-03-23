using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Domain.Entities
{
    public class Requester
    {
        [Key]
        [Required]
        public Guid RequesterId { get; set; }
        public Guid RequestId { get; set;}
        public string? Name { get; set; }
        public string? INN { get; set; }
        public string? KPP { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public string? COntactEmail { get; set; }
        public bool? WebsiteExistence { get; set; }
        public string? Website { get; set; }
        public string? PaymentAccountNumber { get; set; }
        public string? BIK { get; set; }
        public string? BankName{ get; set; }
        public string? CorrespondentBankAccount { get; set; }
        public string? LegalAdress { get; set; }
        public string? ActualAdress { get; set; }
        public bool? HasLicence { get; set; }
        public bool? IsStraregicEnterprise{ get; set; }
        public bool? hasDebtFiles{ get; set; }
        public bool? hasFederalDebt { get; set; }
        public bool? hasSalaryDebt { get; set; }
        public bool? InLicvidationProcess { get; set; }
        public bool? hasCreditProducts { get; set; }
        public int? EmployeesNumber{ get; set; }
    }
}
