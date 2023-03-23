using CRMSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Models
{
    public class AllRequestInfo
    {
        public AllRequestInfo()
        {
            request = new Request();
        }
        public Request request { get; set; }
        public RequestType requestType { get; set; }
        public RequestInformation requestInformation { get; set; }
        public Requester requester { get; set; }
        public Beneficiary beneficiary{ get; set; }
        public ExecutiveDepartment executiveDepartment{ get; set; }
        public OrganizationFounder organizationFounder{ get; set; }
        

    }
}
