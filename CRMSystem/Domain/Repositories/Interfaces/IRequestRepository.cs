using CRMSystem.Domain.Entities;
using CRMSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Domain.Repositories.Interfaces
{
    public interface IRequestRepository
    {
        IQueryable<Request> GetTextFields();
        Request GetTextFieldById(Guid id);
        Request GetTextFieldByCode(string code);
        void CreateNewRequest(AllRequestInfo reqInfo);
        void DeleteTextField(Guid id);
        public List<AllRequestInfo> GetAllRequests();
        public AllRequestInfo GetRequestInfoById(Guid id);
        public void SaveChanges(AllRequestInfo reqInfo);
        public void SaveStatus(RequestState data);
        public void SaveMessage(string userId, string message, string reqiestId);
    }
}
