using CRMSystem.Domain;
using CRMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CRMSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public DataManager _dataManager { get; set; }
        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(_dataManager.Requests.GetAllRequests());
        }
        public IActionResult CreateRequest()
        {
            AllRequestInfo info = new AllRequestInfo();
            return View(info);
        }

        [HttpPost]
        public IActionResult Create(AllRequestInfo reqInfo)
        {
            _dataManager.Requests.CreateNewRequest(reqInfo);
            return RedirectToAction("Index");
        }
        public IActionResult bid(Guid id)
        {
            AllRequestInfo info = _dataManager.Requests.GetRequestInfoById(id);
            return View(info);
        }        
        public IActionResult SaveChanges(AllRequestInfo requestInfo)
        {
            var str = "bid//" + requestInfo.request.RequestId;
            _dataManager.Requests.SaveChanges(requestInfo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void SaveStatus([FromBody] RequestState data)
        {

            //TODO: добавить result
            _dataManager.Requests.SaveStatus(data);
            
        }


    }
}
