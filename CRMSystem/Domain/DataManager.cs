using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRMSystem.Domain.Repositories.Interfaces;
namespace CRMSystem.Domain
{
    public class DataManager
    {
        public IRequestRepository Requests { get; set; }
        public DataManager(IRequestRepository requestsRepository)
        {
            Requests= requestsRepository;

        }

    }
}
