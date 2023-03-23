using CRMSystem.Domain.Entities;
using CRMSystem.Domain.Repositories.Interfaces;
using CRMSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMSystem.Domain.Repositories.EntityFramework
{
    public class EFRequestRepository : IRequestRepository
    {
        private readonly AppDbContext _context;
        public EFRequestRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Request> GetTextFields()
        {
            return _context.Requests;
        }

        public Request GetTextFieldById(Guid id)
        {
            return _context.Requests.FirstOrDefault(x => x.RequestId == id);
        }

        public Request GetTextFieldByCode(string code)
        {
            return _context.Requests.FirstOrDefault(x => "x" == "1");
        }

        public void CreateNewRequest(AllRequestInfo reqInfo)
        {
            reqInfo.request.RequestId = Guid.NewGuid();
            reqInfo.requestInformation.RequestId = reqInfo.request.RequestId;
            reqInfo.requester.RequestId = reqInfo.request.RequestId;
            _context.Requests.Add(reqInfo.request);
            _context.RequestInformation.Add(reqInfo.requestInformation);
            _context.Requesters.Add(reqInfo.requester);

            _context.SaveChanges();
        }

        public void SaveChanges(AllRequestInfo changes)
        {
            var reqInfo = GetRequestInfoById(changes.request.RequestId);

            reqInfo.requestInformation.RequestCode = changes.requestInformation.RequestCode;
            reqInfo.requestInformation.PurchaseNumber = changes.requestInformation.PurchaseNumber;
            reqInfo.requestInformation.AmountOfMoney = changes.requestInformation.AmountOfMoney;
            reqInfo.requester.INN= changes.requester.INN;
            reqInfo.requester.ContactPhone = changes.requester.ContactPhone;
            reqInfo.requester.Name = changes.requester.Name;
            reqInfo.requester.COntactEmail = changes.requester.COntactEmail;
            

            _context.SaveChanges();
        }
        public void DeleteTextField(Guid id)
        {
            _context.Requests.Remove(new Request() { RequestId = id });
            _context.SaveChanges();
        }
        public List<AllRequestInfo> GetAllRequests() 
        {
            List<AllRequestInfo> requestListInfo = new List<AllRequestInfo>();
            var requests = _context.Requests.ToList();
            foreach(var req in requests)
            {
                requestListInfo.Add( GetRequestInfoById(req.RequestId));
            }

            return requestListInfo;

        }
        public AllRequestInfo GetRequestInfoById(Guid Id)
        {
            AllRequestInfo reqInfo = new AllRequestInfo();
            reqInfo.request = _context.Requests.Where(x => x.RequestId == Id).FirstOrDefault();
            reqInfo.requester = _context.Requesters.Where(x => x.RequestId == Id).FirstOrDefault();
            reqInfo.requestInformation = _context.RequestInformation.Where(x => x.RequestId == Id).FirstOrDefault();
            reqInfo.beneficiary = _context.Beneficiaries.Where(x => x.RequestId == Id).FirstOrDefault();
            reqInfo.executiveDepartment= _context.ExecutiveDepartments.Where(x => x.RequestId == Id).FirstOrDefault();
            reqInfo.organizationFounder= _context.OrganizationFounders.Where(x => x.RequestId == Id).FirstOrDefault();
            //reqInfo.requestType= context.RequestTypes.Where(x => x.RequestTypeId== reqInfo.request.RequestTypeId).FirstOrDefault();
            return reqInfo;
        }
        public void SaveStatus( RequestState data)
        {
            var info = _context.RequestInformation.Where(p => p.RequestId.ToString() == data.RequestId).FirstOrDefault();
            info.Status = data.Status;
            _context.SaveChanges();
        }
        public void SaveMessage(string userId, string message, string reqiestId)
        {
            ChatMessage message1 = new ChatMessage();
            message1.RequestId = new Guid(reqiestId);
            message1.Value = message;
            message1.UserId = message1.RequestId;
            message1.SendingTime = DateTime.Now;
            bool hasChanges = _context.ChangeTracker.HasChanges();

            _context.ChatMessages.Add(message1);
            _context.SaveChanges();
        }
    }
}
