using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Domain.Entities
{
    public class RequestInformation
    {
        [Key]
        public Guid RequestId { get; set; }
        public string RequestCode { get; set; }
        public string Status { get; set; }
        public double? AmountOfMoney { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? EndDate { get; set; }
        public string PurchaseNumber { get; set; }
        public double? StartMaxPrice { get; set; }
        public bool? IsPrepayment { get; set; }
        public DateTime? SigningContractDate { get; set; }
        public string ContractObject { get; set; }
        public string EntityOfRussia{ get; set; }
        public string RegionOfWork { get; set; }


        
    }
}
